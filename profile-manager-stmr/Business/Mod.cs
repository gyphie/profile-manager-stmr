using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace net.glympz.ProfileManagerSTMR.Business
{
	public class Mod
	{
		private const string MOD_META_DATA_FILENAME = "mod-meta-data.json";

		public string Name { get; set; } = string.Empty;
		public string Path { get; set; } = string.Empty;
		public ModType Type { get; set; } = ModType.Unknown;
		public Rating Rating { get; set; } = Rating.None;
		public DateTime InstallationDate { get; set; } = DateTime.Now;

		public static void DeleteMod(string modPath, Mod mod)
		{

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
							Path = trueModPath,
							Type =  Mod.DetectType(AppLogic.PathCombine(modPath, trueModPath)),
							Rating = Rating.None,
							InstallationDate = DateTime.Now,
						};
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

		private static string FindModPath(DirectoryInfo mainDirectory)
		{
			if (Directory.Exists(AppLogic.PathCombine(mainDirectory.FullName, "levels")) ||
				Directory.Exists(AppLogic.PathCombine(mainDirectory.FullName, "classes")) ||
				Directory.Exists(AppLogic.PathCombine(mainDirectory.FullName, "meshes")) ||
				Directory.Exists(AppLogic.PathCombine(mainDirectory.FullName, "textures")) ||
				Directory.Exists(AppLogic.PathCombine(mainDirectory.FullName, "billboards"))
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

		private static ModType DetectType(string modPath)
		{
			return ModType.Unknown;
		}

		private class SimpleMod
		{
			public string name;
			public string path;
			public int type;
			public int rating;
			public long installationdate;

			public SimpleMod() { }
			public SimpleMod(Mod mod)
			{
				name = mod.Name;
				path = mod.Path;
				type = (int)mod.Type;
				rating = (int)mod.Rating;
				installationdate = mod.InstallationDate.Ticks;
			}

			public Mod ToMod()
			{
				return new Mod
				{
					Name = this.name,
					Path = this.path,
					Type = Enums.IntToModType(this.type),
					Rating = Enums.IntToRating(this.rating),
					InstallationDate = new DateTime(this.installationdate)
				};

			}
		}
	}
}
