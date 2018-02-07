using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace net.glympz.ProfileManagerSTMR.Business
{
	public class Mod
	{
		private const string MOD_META_DATA_FILENAME = "mod-meta-data.json";

		public string Name { get; set; } = string.Empty;
		public string RootPath { get; set; } = string.Empty;
		public string Path { get; set; } = string.Empty;
		public ModType Type { get; set; } = ModType.Unknown;
		public Rating Rating { get; set; } = Rating.None;
		public DateTime InstallationDate { get; set; } = DateTime.Now;
		public bool Multiplayer { get; set; } = false;

		public static bool DeleteMod(string modPath, Mod mod)
		{
			try
			{
				if (string.IsNullOrEmpty(mod.RootPath))
				{
					return false;
				}

				var modFolder = AppLogic.PathCombine(modPath, mod.RootPath);
				if (Directory.Exists(modFolder))
				{
					FileSystem.DeleteDirectory(modFolder, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);

					//Directory.Delete(modFolder, true);
					return true;
				}
			}
			catch { }

			return false;
		}

		public static void WriteMods(string profileManagerPath, List<Mod> mods)
		{
			var simpleMods = mods.Select(a => new SimpleMod(a)).ToList();

			File.WriteAllText(AppLogic.PathCombine(profileManagerPath, MOD_META_DATA_FILENAME), JsonConvert.SerializeObject(simpleMods));
		}

		private static List<Mod> LoadModMetaData(string profileManagerPath)
		{
			var mods = new List<Mod>();

			try
			{
				var modFileName = AppLogic.PathCombine(profileManagerPath, MOD_META_DATA_FILENAME);

				mods = JsonConvert.DeserializeObject<List<SimpleMod>>(File.ReadAllText(modFileName)).Select(a => a.ToMod()).ToList();
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error reading in mod meta data file: " + ex.Message);
			}

			return mods;
		}

		public static List<Mod> LoadModList(string profileMangerPath, string modPath)
		{
			// Load the mod meta data
			var mods = Mod.LoadModMetaData(profileMangerPath);
			var foundMods = new List<Mod>();
			bool foundNewMod = false;

			foreach (var directoryName in Directory.GetDirectories(modPath))
			{
				var directory = new DirectoryInfo(directoryName);

				var trueModPath = FindModPath(directory);	// Find the correct subdirectory where the mod files are stored
				if (trueModPath != null)
				{
					var mod = mods.FirstOrDefault(a => a.Path == trueModPath);
					if (mod == null)
					{
						foundNewMod = true;
						mod = new Mod
						{
							Name = directory.Name,
							RootPath = directory.Name,
							Path = trueModPath,
							Rating = Rating.None,
							InstallationDate = DateTime.Now,
						};

						mod.Type = Mod.DetectType(AppLogic.PathCombine(modPath, trueModPath), out bool multiplayer);
						mod.Multiplayer = multiplayer;
					}
					else
					{
						mod.Name = string.IsNullOrWhiteSpace(mod.Name) ? directory.Name : mod.Name;
						mod.RootPath = directory.Name;
					}

					foundMods.Add(mod);
				}
			}

			if (foundNewMod || foundMods.Count < mods.Count)
			{
				Mod.WriteMods(profileMangerPath, foundMods);
			}

			return foundMods;
		}

		public static string FindModPath(DirectoryInfo mainDirectory)
		{
			if (Directory.Exists(AppLogic.PathCombine(mainDirectory.FullName, "levels")) ||
				Directory.Exists(AppLogic.PathCombine(mainDirectory.FullName, "classes")) ||
				Directory.Exists(AppLogic.PathCombine(mainDirectory.FullName, "meshes")) ||
				Directory.Exists(AppLogic.PathCombine(mainDirectory.FullName, "textures")) ||
				Directory.Exists(AppLogic.PathCombine(mainDirectory.FullName, "billboards")) ||
				Directory.Exists(AppLogic.PathCombine(mainDirectory.FullName, "_m")) ||
				Directory.Exists(AppLogic.PathCombine(mainDirectory.FullName, "_t"))
			)
			{
				return mainDirectory.Name;
			}
			else
			{
				foreach (var childDirectory in mainDirectory.GetDirectories())
				{
					return AppLogic.PathCombine(mainDirectory.Name, FindModPath(childDirectory));
				}
			}

			return null;
		}

		public static ModType DetectType(string modPath, out bool multiplayer)
		{
			multiplayer = false;
			if (Directory.Exists(AppLogic.PathCombine(modPath, "levels")))
			{
				if (Directory.GetDirectories(modPath).Length == 1)
				{
					multiplayer = true;
				}

				return ModType.Map;
			}

			if (Directory.Exists(AppLogic.PathCombine(modPath, "classes", "trucks")) ||
				Directory.Exists(AppLogic.PathCombine(modPath, "classes", "wheels")))
			{
				return ModType.Vehicle;
			}

			return ModType.Other;
		}

		private class SimpleMod
		{
			public string name;
			public string path;
			public int type;
			public int rating;
			public long installationdate;
			public bool multiplayer;

			public SimpleMod() { }
			public SimpleMod(Mod mod)
			{
				name = mod.Name;
				path = mod.Path;
				type = (int)mod.Type;
				rating = (int)mod.Rating;
				installationdate = mod.InstallationDate.Ticks;
				multiplayer = mod.Multiplayer;
			}

			public Mod ToMod()
			{
				return new Mod
				{
					Name = this.name,
					Path = this.path,
					Type = Enums.IntToModType(this.type),
					Rating = Enums.IntToRating(this.rating),
					InstallationDate = new DateTime(this.installationdate),
					Multiplayer = this.multiplayer
				};

			}
		}
	}
}
