using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net.glympz.ProfileManagerSTMR.Business
{
	public class Mod
	{
		public string Name { get; set; } = string.Empty;
		public string Path { get; set; } = string.Empty;

		public static List<Mod> LoadModList(string modPath)
		{
			var mods = new List<Mod>();
			foreach (var directoryName in Directory.GetDirectories(modPath))
			{
				var directory = new DirectoryInfo(directoryName);

				var trueModPath = FindModPath(directory);	// Find the correct subdirectory where the mod files are stored
				if (trueModPath != null)
				{

					var mod = new Mod
					{
						Name = directory.Name,
						Path = trueModPath
					};

					mods.Add(mod);
				}
			}

			return mods;
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
	}
}
