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
		private int hoverItemIndex = -1;

		private int SelectedProfileIndex
		{
			get
			{
				return this.lvProfiles.SelectedIndices.Count > 0 ? this.lvProfiles.SelectedIndices[0] : -1;
			}
		}
		private Profile SelectedProfile
		{
			get
			{
				return this.lvProfiles.SelectedIndices.Count > 0 ? this.profiles[this.lvProfiles.SelectedIndices[0]] : null;
			}
		}

		private void frmMainWindow_Load(object sender, EventArgs e)
		{
			this.appSettings = ApplicationSettings.Default;
		}
		private void frmMainWindow_Shown(object sender, EventArgs e)
		{
			this.GetInitialAppState();

			// load the mod list
			this.mods = Mod.LoadModList(this.appSettings.ModFolder);

			this.profiles = Profile.LoadProfiles(AppLogic.PathCombine(this.appSettings.GameAppDataFolder, this.appSettings.ProfilesSubfolderName), this.mods);
			this.lvProfiles.Items.Clear();
			foreach (var profile in this.profiles)
			{
				this.lvProfiles.Items.Add(new ListViewItem(profile.DisplayName));
			}

			this.activeProfileIndex = this.profiles.FindIndex(a => a.Guid == this.ReadCurrentProfileGuid());
			if (this.activeProfileIndex >= 0)
			{
				this.lvProfiles.Items[this.activeProfileIndex].Focused = true;
				this.lvProfiles.Items[this.activeProfileIndex].Selected = true;
			}
			else
			{
				// If there was no active profile we create a new one, save it, and make it the current one
				var profile = Profile.CreateNewProfile();
				this.WriteProfile(profile);
				this.WriteCurrentProfileGuid(profile.Guid);

				this.profiles.Add(profile);
				this.lvProfiles.Items.Add(new ListViewItem(profile.DisplayName));
				this.lvProfiles.Items[this.lvProfiles.Items.Count - 1].Focused = true;
				this.lvProfiles.Items[this.lvProfiles.Items.Count - 1].Selected = true;
			}



			foreach (var mod in this.mods)
			{
				var item = new ListViewItem(mod.Name);
				this.lvMods.Items.Add(item);
			}

			this.lvMods.Columns[0].Width = this.lvMods.ClientSize.Width;

			this.lvMods.ItemChecked += lvMods_ItemChecked; // Manually assign this event handler after we've populated the item list to prevent it triggering unnecessarily.
			this.lvProfiles.SelectedIndexChanged += lvProfiles_SelectedIndexChanged;
			this.lvProfiles_SelectedIndexChanged(lvProfiles, new EventArgs());
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

		private void lvProfiles_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.SelectedProfile != null)
			{
				this.txtProfileName.Text = this.SelectedProfile.Name;
				this.lvMods.ItemChecked -= lvMods_ItemChecked;

				foreach (ListViewItem listItem in this.lvMods.Items)
				{
					listItem.Checked = false;
					if (this.SelectedProfile.ActivatedMods.Any(a => a.Name == listItem.Text))
					{
						listItem.Checked = true;
					}
				}

				this.lvMods.ItemChecked += lvMods_ItemChecked;

				this.panDetail.Enabled = true;
			}
			else
			{
				this.txtProfileName.Text = "";
				this.panDetail.Enabled = false;

			}
		}
		private void lvProfiles_ItemMouseHover(object sender, ListViewItemMouseHoverEventArgs e)
		{
			Console.WriteLine("hover");
			if (this.hoverItemIndex != e.Item.Index)
			{
				this.hoverItemIndex = e.Item.Index;
				this.lvProfiles.Invalidate();
			}
		}

		private void txtProfileName_TextChanged(object sender, EventArgs e)
		{
			if (this.SelectedProfile != null)
			{
				this.SelectedProfile.Name = this.txtProfileName.Text;
				this.lvProfiles.Items[this.SelectedProfileIndex].Text = this.SelectedProfile.DisplayName;

				this.WriteProfile(this.SelectedProfile);
			}
		}

		private void btnAddProfile_Click(object sender, EventArgs e)
		{
			var profile = Profile.CreateNewProfile("");

			this.WriteProfile(profile);

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
			if (this.SelectedProfile == null)
			{
				return;
			}

			if (MessageBox.Show($"Delete \"{this.SelectedProfile.DisplayName}\"?\n\nThis will also delete any saved games in this profile.", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
			{
				return;
			}

			try
			{
				var profilePath = AppLogic.PathCombine(this.appSettings.GameAppDataFolder, this.appSettings.ProfilesSubfolderName, this.SelectedProfile.Guid);
				Directory.Delete(profilePath, recursive: true);

			}
			catch
			{
				MessageBox.Show("The profile files could not be deleted.");
				return;
			}

			try
			{
				if (this.SelectedProfileIndex == this.activeProfileIndex)
				{
					this.DeleteCurrentProfileGuid();
				}
			}
			catch { }


			var currentIndex = this.SelectedProfileIndex;

			this.profiles.RemoveAt(currentIndex);
			this.lvProfiles.Items.RemoveAt(currentIndex);

			if (currentIndex >= this.profiles.Count) currentIndex--;

			// If the last profile was deleted create a new default profile
			if (this.profiles.Count == 0)
			{
				var defaultProfile = Profile.CreateNewProfile();
				this.WriteProfile(defaultProfile);
				this.profiles.Add(defaultProfile);
				this.lvProfiles.Items.Add(new ListViewItem(defaultProfile.DisplayName));
				currentIndex = 0;
			}

			this.lvProfiles.Items[currentIndex].Focused = true;
			this.lvProfiles.Items[currentIndex].Selected = true;
			this.lvProfiles.Items[currentIndex].EnsureVisible();
		}

		private void btnLaunch_Click(object sender, EventArgs e)
		{
			this.SwitchProfiles(new WorkerData { Profile = this.SelectedProfile, LaunchGame = true });
		}
		private void btnSwitch_Click(object sender, EventArgs e)
		{
			this.SwitchProfiles(new WorkerData { Profile = this.SelectedProfile, LaunchGame = false });
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
			var workerData = e.Argument as WorkerData;
			var profile = (e.Argument as WorkerData)?.Profile;

			// Preserve the current profile saves
			string profileManagerPath = AppLogic.PathCombine(this.appSettings.GameAppDataFolder, this.appSettings.ProfilesSubfolderName);
			string currentProfileGuid = this.ReadCurrentProfileGuid();

			Profile currentProfile = this.profiles.FirstOrDefault(a => a.Guid == currentProfileGuid);
			if (currentProfile == null)
			{
				currentProfile = Profile.CreateNewProfile();
				workerData.NewDefaultProfile = currentProfile;
			}

			// Ensure the proper folder exist
			this.WriteProfile(currentProfile);

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

			// Copy New Profile saves to game folder
			string newProfileFolder = AppLogic.PathCombine(profileManagerPath, profile.Guid);
			this.WriteProfile(profile);
			foreach (var filePath in Directory.GetFiles(AppLogic.PathCombine(newProfileFolder, this.appSettings.SaveFolderName)))
			{
				var f = new FileInfo(filePath);
				f.CopyTo(AppLogic.PathCombine(this.appSettings.GameAppDataFolder, this.appSettings.SaveFolderName, f.Name));
			}

			// Update Config.xml


			// Create current profile indicator
			this.WriteCurrentProfileGuid(profile.Guid);

			e.Result = workerData;
		}
		private void bgwSwitchProfile_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			var workerData = e.Result as WorkerData;
			this.workingDialog.Hide();

			if (e.Error != null)
			{

			}

			this.activeProfileIndex = this.profiles.FindIndex(a => a.Guid == workerData.Profile.Guid);

			if (workerData.NewDefaultProfile != null)
			{
				this.profiles.Add(workerData.NewDefaultProfile);
				this.lvProfiles.Items.Add(new ListViewItem(workerData.NewDefaultProfile.DisplayName));
			}

			if (workerData.LaunchGame)
			{
				AppLogic.LaunchGame(AppLogic.PathCombine(appSettings.SteamFolder, appSettings.SteamExecutable), this.appSettings.GameAppID);
			}

		}

		private string ReadCurrentProfileGuid()
		{
			try
			{
				string profileGuidFile = AppLogic.PathCombine(this.appSettings.GameAppDataFolder, "profile-manager-stmr.txt");
				return File.ReadAllText(profileGuidFile);
			}
			catch { }

			return null;
		}
		private void WriteCurrentProfileGuid(string guid)
		{
			try
			{
				string profileGuidFile = AppLogic.PathCombine(this.appSettings.GameAppDataFolder, "profile-manager-stmr.txt");
				File.WriteAllText(profileGuidFile, guid);
			}
			catch { }
		}

		private void DeleteCurrentProfileGuid()
		{
			try
			{
				string profileGuidFile = AppLogic.PathCombine(this.appSettings.GameAppDataFolder, "profile-manager-stmr.txt");
				File.Delete(profileGuidFile);
			}
			catch { }
		}

		private void WriteProfile(Profile profile)
		{
			var profilePath = AppLogic.PathCombine(this.appSettings.GameAppDataFolder, this.appSettings.ProfilesSubfolderName, profile.Guid);
			Directory.CreateDirectory(AppLogic.PathCombine(profilePath, this.appSettings.SaveFolderName));

			File.WriteAllText(AppLogic.PathCombine(profilePath, "profile.json"), profile.ToJson());
		}

		private void CreateXML(Profile profile)
		{

		}

		private void lvProfiles_DrawItem(object sender, DrawListViewItemEventArgs e)
		{
			Brush brush = null;

			if (e.Item.Selected)
			{
				brush = new SolidBrush(SystemColors.Highlight);
			}
			else if (e.ItemIndex == this.activeProfileIndex)
			{
				brush = new SolidBrush(Color.FromArgb(0, 192, 0));
			}
			else if (e.ItemIndex == this.hoverItemIndex)	// Hover
			{
				brush = new SolidBrush(SystemColors.HotTrack);
			}
			else
			{
				brush = new SolidBrush(e.Item.BackColor);
			}

			e.Graphics.FillRectangle(brush, e.Bounds);

			e.DrawText();
		}

		private void frmMainWindow_Resize(object sender, EventArgs e)
		{
			this.lvMods.Columns[0].Width = this.lvMods.ClientSize.Width;
		}

		private void lvMods_ItemChecked(object sender, ItemCheckedEventArgs e)
		{
			if (this.SelectedProfile == null) return;

			if (e.Item.Checked)
			{
				var mod = this.mods.FirstOrDefault(a => a.Name == e.Item.Text);
				if (mod != null && !this.SelectedProfile.ActivatedMods.Contains(mod))
				{
					this.SelectedProfile.ActivatedMods.Add(mod);
				}
			}
			else
			{
				int modIdx;
				do
				{
					modIdx = this.SelectedProfile.ActivatedMods.FindIndex(a => a.Name == e.Item.Text);
					if (modIdx >= 0)
					{
						this.SelectedProfile.ActivatedMods.RemoveAt(modIdx);
					}
				} while (modIdx != -1);
			}

			this.WriteProfile(this.SelectedProfile);
		}
	}
}
