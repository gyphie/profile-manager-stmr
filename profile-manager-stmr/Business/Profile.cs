using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace net.glympz.ProfileManagerSTMR.Business
{
	public class Profile
	{
		public static Profile CreateNewProfile(string name = "Default Profile")
		{
			var profile = new Profile()
			{
				Name = name,
				Guid = System.Guid.NewGuid().ToString("D")
			};

			return profile;
		}

		public string DisplayName { get { return String.IsNullOrEmpty(this.Name) ? "(empty)" : this.Name; } }
		public string Name { get; set; } = string.Empty;
		public string Guid { get; set; } = string.Empty;
		public List<Mod> ActivatedMods { get; set; } = new List<Mod>();

		public string ToJson()
		{
			var simpleObject = new
			{
				name = this.Name,
				guid = this.Guid,
				mods = this.ActivatedMods.Select(a => a.Path)
			};

			return JsonConvert.SerializeObject(simpleObject);
		}

		internal static List<Profile> LoadProfiles(string profileManagerPath, List<Mod> availableMods)
		{
			var anonTemplate = new { name = "", guid = "", mods = new List<string>() };
			var profiles = new List<Profile>();

			var profileFolders = Directory.GetDirectories(profileManagerPath);
			foreach (var profileFolder in profileFolders)
			{
				var pObj = JsonConvert.DeserializeAnonymousType(File.ReadAllText(AppLogic.PathCombine(profileFolder, "profile.json")), anonTemplate);
				var profile = new Profile
				{
					Name = pObj.name,
					Guid = pObj.guid,
				};

				foreach (var modPath in pObj.mods)
				{
					var mod = availableMods.FirstOrDefault(a => a.Path == modPath);
					if (mod != null && !profile.ActivatedMods.Contains(mod))
					{
						profile.ActivatedMods.Add(mod);
					}
				}

				profiles.Add(profile);

			}

			return profiles;
		}
	}
}
