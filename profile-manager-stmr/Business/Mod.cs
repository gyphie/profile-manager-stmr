using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net.glympz.ProfileManagerSTMR.Business
{
	public class Mod
	{
		public string Name { get; set; } = string.Empty;
		public string Path { get; set; } = string.Empty;

		internal static List<Mod> LoadModList(string modPath)
		{
			return new List<Mod>
			{
				new Mod { Name = "Place 1", Path = "isoplacian1/"},
				new Mod { Name = "Place 2", Path = "isoplacian2/"},
				new Mod { Name = "Place 3", Path = "isoplacian3/"},
				new Mod { Name = "Place 4", Path = "isoplacian4/"},
				new Mod { Name = "Place 5", Path = "isoplacian5/"},
				new Mod { Name = "Place 6", Path = "isoplacian6/"},
			};
		}
	}
}
