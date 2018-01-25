using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net.glympz.ProfileManagerSTMR.Business
{
	public class Profile
	{
		public static Profile CreateNewProfile(string name)
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

		public void CreateProfileFolders(string profileManagerPath, string userSaveFolderName)
		{
			var profilePath = AppLogic.PathCombine(profileManagerPath, this.Guid);
			Directory.CreateDirectory(AppLogic.PathCombine(profilePath, userSaveFolderName));
		}

		internal static List<Profile> LoadProfiles()
		{
			return new List<Profile>
			{
				Profile.CreateNewProfile("Test 1"),
				Profile.CreateNewProfile("Test 2"),
				Profile.CreateNewProfile("Test 3"),
				Profile.CreateNewProfile("Test 4"),
				Profile.CreateNewProfile("Test 5"),
				Profile.CreateNewProfile("Test 6"),
			};
		}
	}
}
