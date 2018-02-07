using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using net.glympz.ProfileManagerSTMR.Business;
using net.glympz.ProfileManagerSTMR.Properties;

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
			this.Tag = null;
			this.DialogResult = DialogResult.None;

			this.mod = mod;

			this.txtModFilePath.Text = AppLogic.PathCombine(modPath, mod.Path);
			this.txtModName.Text = mod.Name;
			this.cmboModType.SelectedItem = Enums.ModTypeToString(mod.Type);
			this.cmboRating.SelectedItem = Enums.RatingToString(mod.Rating);
			this.dtpInstalledOn.Value = mod.InstallationDate;
			this.cbMultiplayer.Checked = mod.Multiplayer;

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
			string modName = this.txtModName.Text;
			ModType modType = Enums.StringToModType(this.cmboModType.SelectedItem as string);
			Rating rating = Enums.StringToRating(this.cmboRating.SelectedItem as string);

			this.mod.Name = modName;
			this.mod.Type = modType;
			this.mod.Rating = rating;
			this.mod.InstallationDate = this.dtpInstalledOn.Value;
			this.mod.Multiplayer = this.cbMultiplayer.Checked;

			this.DialogResult = DialogResult.OK;
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (DialogResult.OK != MessageBox.Show("Uninstalling this mod will delete this mod folder from disk.", "Uninstall mod", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2))
			{
				return;
			}

			this.Tag = "delete";
			this.DialogResult = DialogResult.OK;
		}
	}
}
