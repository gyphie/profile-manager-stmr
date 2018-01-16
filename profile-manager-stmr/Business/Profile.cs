using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

		internal static List<Profile> LoadProfiles()
		{
			return new List<Profile>
			{
				new Profile { Name="Test 1"},
				new Profile { Name="Test 2"},
				new Profile { Name="Test 3"},
				new Profile { Name="Test 4"},
				new Profile { Name="Test 5"},
				new Profile { Name="Test 6"},
			};
		}
	}
}
