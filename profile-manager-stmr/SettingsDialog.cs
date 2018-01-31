using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using net.glympz.ProfileManagerSTMR.Business;
using net.glympz.ProfileManagerSTMR.Properties;

namespace net.glympz.ProfileManagerSTMR
{
	public partial class frmSettingsDialog : Form
	{
		private ApplicationSettings appSettings;

		public frmSettingsDialog()
		{
			InitializeComponent();
			this.Icon = Resources.ProfileManagerIcon;
		}

		internal DialogResult ShowFormDialog(IWin32Window owner, ApplicationSettings settings)
		{
			this.appSettings = settings;

			this.txtSteamFolder.Text = this.appSettings.SteamFolder;
			this.txtGameFolder.Text = this.appSettings.GameFolder;
			this.txtAppDataFolder.Text = this.appSettings.GameAppDataFolder;
			this.txtModsFolder.Text = this.appSettings.ModFolder;

			return this.ShowDialog(owner);
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			var steamFolder = this.txtSteamFolder.Text;
			var gameFolder = this.txtGameFolder.Text;
			var gameAppDataFolder = this.txtAppDataFolder.Text;
			var modFolder = this.txtModsFolder.Text;

			if (!Directory.Exists(steamFolder) || !File.Exists(AppLogic.PathCombine(steamFolder, appSettings.SteamExecutable)))
			{
				MessageBox.Show($"{appSettings.SteamExecutable} was not found in the Steam Folder.");
				return;
			}
			if (!Directory.Exists(gameFolder) || !File.Exists(AppLogic.PathCombine(gameFolder, this.appSettings.GameExecutable)))
			{
				MessageBox.Show("The Spintires: Mudrunner folder was not found.");
				return;
			}
			if (!Directory.Exists(gameAppDataFolder))
			{
				MessageBox.Show("The Spintires: Mudrunner AppData folder was not found.");
				return;
			}

			if (!AppLogic.IsSubdirectory(gameFolder, modFolder))
			{
				MessageBox.Show("The Mod Folder must be a sub-folder of the Game Folder.");
				return;
			}

			if (!Directory.Exists(modFolder))
			{
				if (DialogResult.Yes == MessageBox.Show("The Mod Folder does not exist. Would you like to create it?", "Mod Folder", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1))
				{
					try
					{
						Directory.CreateDirectory(modFolder);
					}
					catch
					{
						MessageBox.Show("The Mod Folder could not be created.");
						return;
					}
				}
				else
				{
					return;
				}
			}

			this.appSettings.SteamFolder = steamFolder;
			this.appSettings.GameFolder = gameFolder;
			this.appSettings.GameAppDataFolder = gameAppDataFolder;
			this.appSettings.ModFolder = modFolder;

			this.appSettings.Save();

			this.DialogResult = DialogResult.OK;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			return;
		}
	}
}
