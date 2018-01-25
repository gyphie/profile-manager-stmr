using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using net.glympz.ProfileManagerSTMR;
using net.glympz.ProfileManagerSTMR.Business;

namespace spintires_mudrunner_profile_manager
{
	public partial class frmMainWindow : Form
	{
		public frmMainWindow()
		{
			InitializeComponent();
			this.settingsDialog = new frmSettingsDialog();
			this.workingDialog = new frmWorkingDialog();
			this.bgwSwitchProfile.DoWork += bgwSwitchProfile_DoWork;
			this.bgwSwitchProfile.RunWorkerCompleted += bgwSwitchProfile_RunWorkerCompleted;
		}

		private ApplicationSettings appSettings;
		private frmSettingsDialog settingsDialog;
		private frmWorkingDialog workingDialog;
		private List<Profile> profiles;
		private List<Mod> mods;
		private int activeProfileIndex = -1;
		private Profile activeProfile { get { return this.profiles[this.activeProfileIndex]; } }

		private int SelectedIndex
		{
			get
			{
				return this.lvProfiles.SelectedIndices[0];
			}
		}

		private void frmMainWindow_Load(object sender, EventArgs e)
		{
			this.appSettings = ApplicationSettings.Default;
		}
		private void frmMainWindow_Shown(object sender, EventArgs e)
		{
			this.GetInitialAppState();

			// Async load settings and mod list
			this.profiles = Profile.LoadProfiles();
			this.lvProfiles.Items.Clear();
			foreach (var profile in this.profiles)
			{
				this.lvProfiles.Items.Add(new ListViewItem(profile.Name));
			}

			if (this.profiles.Count > 0)
			{
				this.lvProfiles.Items[0].Focused = true;
				this.lvProfiles.Items[0].Selected = true;
			}

			// load the mod list
			this.mods = Mod.LoadModList("");

			foreach (var mod in this.mods)
			{
				this.cblMods.Items.Add(mod.Name, false);
			}
		}


		private void GetInitialAppState()
		{
			string messages = "";
			bool showSettingsDialog = AppLogic.GetInitialSettings(this.appSettings, out messages);

			if (showSettingsDialog)
			{
				if (!string.IsNullOrEmpty(messages))
				{
					MessageBox.Show(messages);
				}

				this.settingsDialog.ShowFormDialog(this, this.appSettings);
			}
		}

		private void lvProfiles_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
		{
			this.activeProfileIndex = e.ItemIndex;
			this.txtProfileName.Text = this.activeProfile.Name;
		}

		private void cblMods_ItemCheck(object sender, ItemCheckEventArgs e)
		{

		}

		private void txtProfileName_TextChanged(object sender, EventArgs e)
		{
			this.activeProfile.Name = this.txtProfileName.Text;
			this.lvProfiles.Items[this.activeProfileIndex].Text = this.activeProfile.DisplayName;
		}

		private void btnAddProfile_Click(object sender, EventArgs e)
		{
			var profile = Profile.CreateNewProfile("");
			this.profiles.Add(profile);
			this.lvProfiles.Items.Add(new ListViewItem(profile.DisplayName));
			int newProfileIndex = this.lvProfiles.Items.Count - 1;
			this.lvProfiles.Items[newProfileIndex].Focused = true;
			this.lvProfiles.Items[newProfileIndex].Selected = true;
			this.lvProfiles.Items[newProfileIndex].EnsureVisible();

			this.txtProfileName.Focus();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Delete profile \"\"?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
			{
				return;
			}

			this.profiles.RemoveAt(this.activeProfileIndex);
			this.lvProfiles.Items.RemoveAt(this.activeProfileIndex);

			if (this.activeProfileIndex >= this.profiles.Count) this.activeProfileIndex--;

			this.lvProfiles.Items[this.activeProfileIndex].Focused = true;
			this.lvProfiles.Items[this.activeProfileIndex].Selected = true;
			this.lvProfiles.Items[this.activeProfileIndex].EnsureVisible();
		}

		private void btnLaunch_Click(object sender, EventArgs e)
		{
			this.SwitchProfiles(new WorkerData { Profile = this.activeProfile, LaunchGame = true });
		}
		private void btnSwitch_Click(object sender, EventArgs e)
		{
			this.SwitchProfiles(new WorkerData { Profile = this.activeProfile, LaunchGame = false });
		}

		private void btnSettings_Click(object sender, EventArgs e)
		{
			this.settingsDialog.ShowFormDialog(this, this.appSettings);
		}

		private void SwitchProfiles(WorkerData workerData)
		{
			if (this.bgwSwitchProfile.IsBusy)
			{
				return;
			}

			// Check whether the game is currently running
			if (AppLogic.IsProcessRunning(AppLogic.PathCombine(this.appSettings.GameFolder, this.appSettings.GameExecutable)))
			{
				MessageBox.Show("Spintires: Mudrunner is currently running. Exit the game before switching profiles.", "Spintires: Mudrunner already running", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}

			this.bgwSwitchProfile.RunWorkerAsync(workerData);
			this.workingDialog.ShowWorking();
		}

		private void bgwSwitchProfile_DoWork(object sender, DoWorkEventArgs e)
		{
			var profile = (e.Argument as WorkerData)?.Profile;

			// Preserve the current profile saves
			string profileManagerPath = AppLogic.PathCombine(this.appSettings.GameAppDataFolder, this.appSettings.ProfilesSubfolderName);
			string profileGuidFile = AppLogic.PathCombine(this.appSettings.GameAppDataFolder, "profile-manager-stmr.txt");
			string currentProfileGuid = null;
			try
			{
				currentProfileGuid = File.ReadAllText(profileGuidFile);
			}
			catch { }

			Profile currentProfile = this.profiles.FirstOrDefault(a => a.Guid == currentProfileGuid);
			if (currentProfile == null)
			{
				currentProfile = Profile.CreateNewProfile("Default Profile");
			}

			// Ensure the proper folder exist
			currentProfile.CreateProfileFolders(profileManagerPath, this.appSettings.SaveFolderName);

			// Remove the saves in the profile and copy the current Saves to the current profile
			string currentProfileFolder = AppLogic.PathCombine(profileManagerPath, currentProfile.Guid);
			string deleteFolder = AppLogic.PathCombine(currentProfileFolder, "_delete");
			Directory.CreateDirectory(deleteFolder);
			foreach (var filePath in Directory.GetFiles(AppLogic.PathCombine(currentProfileFolder, this.appSettings.SaveFolderName)))
			{
				var f = new FileInfo(filePath);
				f.MoveTo(AppLogic.PathCombine(deleteFolder, f.Name));
			}

			try
			{
				// Move current saves to the current profile folder
				foreach (var filePath in Directory.GetFiles(AppLogic.PathCombine(this.appSettings.GameAppDataFolder, this.appSettings.SaveFolderName)))
				{
					var f = new FileInfo(filePath);
					f.MoveTo(AppLogic.PathCombine(currentProfileFolder, this.appSettings.SaveFolderName, f.Name));
				}
				
				// Delete the old profile saves
				Directory.Delete(deleteFolder, true);
			}
			catch
			{
				// Try to move the save files back from the temp location
				foreach (var filePath in Directory.GetFiles(deleteFolder))
				{
					var f = new FileInfo(filePath);
					f.MoveTo(AppLogic.PathCombine(currentProfileFolder, "save-games", f.Name));
				}
				Directory.Delete(deleteFolder, true);
			}

			//	Remove current profile indicator
			File.Delete(profileGuidFile);

			// Copy New Profile saves to game folder
			string newProfileFolder = AppLogic.PathCombine(profileManagerPath, profile.Guid);
			profile.CreateProfileFolders(profileManagerPath, this.appSettings.SaveFolderName);
			foreach (var filePath in Directory.GetFiles(AppLogic.PathCombine(newProfileFolder, this.appSettings.SaveFolderName)))
			{
				var f = new FileInfo(filePath);
				f.CopyTo(AppLogic.PathCombine(this.appSettings.GameAppDataFolder, this.appSettings.SaveFolderName, f.Name));
			}

			// Update Config.xml


			// Create current profile indicator
			File.WriteAllText(profileGuidFile, profile.Guid);

			e.Result = e.Argument;
		}
		private void bgwSwitchProfile_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			this.workingDialog.Hide();

			if (e.Error != null)
			{

			}

			var workerData = e.Result as WorkerData;
			if (workerData.LaunchGame)
			{
				AppLogic.LaunchGame(AppLogic.PathCombine(appSettings.SteamFolder, appSettings.SteamExecutable), this.appSettings.GameAppID);
			}

		}
	}
}
