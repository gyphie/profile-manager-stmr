using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace net.glympz.ProfileManagerSTMR.Business
{
	public class SpinTiresConfig
	{
		public string Path { get; set; } = string.Empty;
		public XmlDocument Config { get; set; } = null;

		public void SaveConfig()
		{

		}
		public void ActivateMod(Mod mod)
		{

		}

		public void DeactivateMod(Mod mod)
		{

		}
	}
}
