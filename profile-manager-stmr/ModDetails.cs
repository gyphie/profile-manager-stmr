using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using net.glympz.ProfileManagerSTMR.Business;
using net.glympz.ProfileManagerSTMR.Properties;
using SharpCompress.Readers;
using Syroot.Windows.IO;

namespace net.glympz.ProfileManagerSTMR
{
	public partial class frmModDetails : Form
	{
		private Mod mod;

		public frmModDetails()
		{
			InitializeComponent();
			this.Icon = Resources.ProfileManagerIcon;
		}

		public DialogResult ShowForm(IWin32Window owner, Mod mod, string modPath)
		{
			this.mod = mod;

			this.txtModFilePath.Text = AppLogic.PathCombine(modPath, mod.Path);
			this.txtModName.Text = mod.Name;
			this.cmboModType.SelectedValue = Enums.ModTypeToString(mod.Type);
			this.cmboRating.SelectedValue = Enums.RatingToString(mod.Rating);
			this.dtpInstalledOn.Value = mod.InstallationDate;


			return this.ShowDialog(owner);
		}

		private void frmInstallMod_Load(object sender, EventArgs e)
		{
		}

		private void btnOpenFolder_Click(object sender, EventArgs e)
		{
			var modPath = this.txtModFilePath.Text;
			if (string.IsNullOrEmpty(modPath) || !Directory.Exists(modPath))
			{
				return;
			}

			try
			{
				Process.Start("explorer.exe", modPath);
			}
			catch { }
		}

		private void btnSave_Click(object sender, EventArgs e)
		{

		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Deleting this mod will delete the entire mod folder from disk", "Delete mod") != DialogResult.OK)
			{
				return;
			}

			// Delete the mod folder

			// Report back the main form that there has been a deletion and the mod list needs to be reloaded
		}
	}
}
