using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Microsoft.VisualBasic.FileIO;
using Microsoft.Win32;
using net.glympz.ProfileManagerSTMR;
using net.glympz.ProfileManagerSTMR.Business;
using net.glympz.ProfileManagerSTMR.Properties;
using SharpCompress.Readers;

namespace spintires_mudrunner_profile_manager
{
	public partial class frmMainWindow : Form
	{
		public frmMainWindow()
		{
			InitializeComponent();
			this.Icon = Resources.ProfileManagerIcon;
			this.settingsDialog = new frmSettings();
			this.workingDialog = new frmWorkingDialog();
			this.installModDialog = new frmInstallMod();
			this.modDetailDialog = new frmModDetails();
			this.bgwSwitchProfile.DoWork += bgwSwitchProfile_DoWork;
			this.bgwSwitchProfile.RunWorkerCompleted += bgwSwitchProfile_RunWorkerCompleted;

			this.lvMods.Columns[1].Width = 90;
			this.lvMods.Columns[2].Width = 90;
			this.lvMods.Columns[3].Width = 60;
			this.lvMods.Columns[4].Width = 60;
		}

		private const string ACTIVE_PROFILE_INDICATOR = "•";

		private ApplicationSettings appSettings;
		private frmSettings settingsDialog;
		private frmWorkingDialog workingDialog;
		private frmInstallMod installModDialog;
		private frmModDetails modDetailDialog;
		private List<Profile> profiles;
		private List<Mod> mods;
		private int activeProfileIndex = -1;

		#region ListView Cursor Fix
		public const uint LVM_SETHOTCURSOR = 4158;

		[DllImport("user32.dll")]
		public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);
		#endregion

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
			SendMessage(this.lvProfiles.Handle, LVM_SETHOTCURSOR, IntPtr.Zero, Cursors.Arrow.Handle);
			this.appSettings = ApplicationSettings.Default;
		}
		private void frmMainWindow_Shown(object sender, EventArgs e)
		{
			this.GetInitialAppState();
			this.LoadAppData();

			this.frmMainWindow_Resize(this, new EventArgs());
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

		private void LoadAppData()
		{
			int previouslySelectedProfileIndex = this.SelectedProfileIndex;

			// Reset the controls and their data
			this.lvMods.ItemChecked -= lvMods_ItemChecked; // Manually assign this event handler after we've populated the item list to prevent it triggering unnecessarily.
			this.lvMods.ItemCheck -= lvMods_ItemCheck;
			this.lvProfiles.SelectedIndexChanged -= lvProfiles_SelectedIndexChanged;

			this.activeProfileIndex = -1;

			this.lvProfiles.Items.Clear();
			this.lvMods.Items.Clear();
			this.profiles = null;
			this.mods = null;

			// load the mod list
			var profilePath = AppLogic.PathCombine(this.appSettings.GameAppDataFolder, this.appSettings.ProfilesSubfolderName);
			this.mods = Mod.LoadModList(profilePath, this.appSettings.ModFolder);
			this.profiles = Profile.LoadProfiles(profilePath, this.mods);

			foreach (var profile in this.profiles)
			{
				this.lvProfiles.Items.Add("").SubItems.Add(profile.DisplayName);
			}

			foreach (var mod in this.mods)
			{
				this.lvMods.Items.Add(mod.Name)
					.SubItems.AddRange(new string[] {
						mod.InstallationDate.ToShortDateString(),
						Enums.ModTypeToString(mod.Type),
						Enums.RatingToEmoji(mod.Rating),
						mod.Multiplayer ? "X" : ""
					});

			}

			string activeProfileGuid = this.ReadCurrentProfileGuid();
			this.activeProfileIndex = this.profiles.FindIndex(a => a.Guid == activeProfileGuid);
			if (this.activeProfileIndex >= 0)
			{
				this.lvProfiles.Items[this.activeProfileIndex].SubItems[0].Text = ACTIVE_PROFILE_INDICATOR;
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
				this.lvProfiles.Items.Add(ACTIVE_PROFILE_INDICATOR).SubItems.Add(profile.DisplayName);
				this.lvProfiles.Items[this.lvProfiles.Items.Count - 1].Focused = true;
				this.lvProfiles.Items[this.lvProfiles.Items.Count - 1].Selected = true;
			}

			// Restore the previous selection
			if (previouslySelectedProfileIndex > -1 && previouslySelectedProfileIndex < this.lvProfiles.Items.Count)
			{
				this.lvProfiles.Items[previouslySelectedProfileIndex].Focused = true;
				this.lvProfiles.Items[previouslySelectedProfileIndex].Selected = true;
			}

			this.lvMods.ItemCheck += lvMods_ItemCheck;
			this.lvMods.ItemChecked += lvMods_ItemChecked; // Manually assign this event handler after we've populated the item list to prevent it triggering unnecessarily.
			this.lvProfiles.SelectedIndexChanged += lvProfiles_SelectedIndexChanged;

			this.lvProfiles_SelectedIndexChanged(lvProfiles, new EventArgs());
		}

		private void lvProfiles_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.lvProfiles.FocusedItem == null) return;    // Detects the "double fire" event where the deselecting items fire an Index Changed event

			this.lvMods.ItemChecked -= lvMods_ItemChecked;
			this.lvMods.ItemCheck -= lvMods_ItemCheck;

			if (this.SelectedProfile != null)
			{
				this.EnableProfileRelatedControls(true);

				this.txtProfileName.Text = this.SelectedProfile.Name;

				foreach (ListViewItem listItem in this.lvMods.Items)
				{
					listItem.Checked = false;
					if (this.SelectedProfile.ActivatedMods.Any(a => a.Name == listItem.Text))
					{
						listItem.Checked = true;
					}
				}
			}
			else
			{
				foreach (ListViewItem listItem in this.lvMods.Items)
				{
					listItem.Checked = false;
				}

				this.txtProfileName.Text = "";
				this.EnableProfileRelatedControls(false);

			}

			this.lvMods.ItemCheck += lvMods_ItemCheck;
			this.lvMods.ItemChecked += lvMods_ItemChecked;
		}

		private void EnableProfileRelatedControls(bool enable)
		{
			this.panDetail.Enabled = enable;
			this.btnDelete.Enabled = enable;
			this.btnSwitch.Enabled = enable;
			this.btnLaunch.Enabled = enable;
		}

		private void txtProfileName_TextChanged(object sender, EventArgs e)
		{
			if (this.SelectedProfile != null)
			{
				this.SelectedProfile.Name = this.txtProfileName.Text;
				this.lvProfiles.Items[this.SelectedProfileIndex].SubItems[1].Text = this.SelectedProfile.DisplayName;

				this.WriteProfile(this.SelectedProfile);
			}
		}

		private void btnAddProfile_Click(object sender, EventArgs e)
		{
			var profile = Profile.CreateNewProfile("");

			this.WriteProfile(profile);

			this.profiles.Add(profile);
			this.lvProfiles.Items.Add("").SubItems.Add(profile.DisplayName);
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
				FileSystem.DeleteDirectory(profilePath, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin, UICancelOption.ThrowException);

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
				this.WriteCurrentProfileGuid(defaultProfile.Guid);
				this.profiles.Add(defaultProfile);
				this.lvProfiles.Items.Add(ACTIVE_PROFILE_INDICATOR).SubItems.Add(defaultProfile.DisplayName);
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
			var result = this.settingsDialog.ShowFormDialog(this, this.appSettings);
			if (result == DialogResult.OK)
			{
				this.LoadAppData();
			}
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
				MessageBox.Show("Spintires: MudRunner is currently running. Exit the game before switching profiles.", "Spintires: MudRunner already running", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}

			this.bgwSwitchProfile.RunWorkerAsync(workerData);
			this.workingDialog.ShowWorking(workerData.LaunchGame ? "Launching Spintires: MudRunner..." : "Switching profiles...");
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
			this.CreateXML(profile);

			// Create current profile indicator
			this.WriteCurrentProfileGuid(profile.Guid);

			e.Result = workerData;
		}
		private void bgwSwitchProfile_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			var workerData = e.Result as WorkerData;
			this.workingDialog.HideWorking(minMillisecondsDisplayed: 2000);

			if (e.Error != null)
			{

			}

			this.activeProfileIndex = this.profiles.FindIndex(a => a.Guid == workerData.Profile.Guid);

			foreach (ListViewItem item in this.lvProfiles.Items)
			{
				item.SubItems[0].Text = "";
			}

			this.lvProfiles.Items[this.activeProfileIndex].SubItems[0].Text = ACTIVE_PROFILE_INDICATOR;

			if (workerData.NewDefaultProfile != null)
			{
				this.profiles.Add(workerData.NewDefaultProfile);
				this.lvProfiles.Items.Add("").SubItems.Add(workerData.NewDefaultProfile.DisplayName);
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

		private void WriteMods(List<Mod> mods)
		{
			Mod.WriteMods(AppLogic.PathCombine(this.appSettings.GameAppDataFolder, this.appSettings.ProfilesSubfolderName), mods);
		}

		private void CreateXML(Profile profile)
		{
			string configFilePath = AppLogic.PathCombine(this.appSettings.GameAppDataFolder, "config.xml");
			var configXMLDocument = new XmlDocument();
			configXMLDocument.Load(configFilePath);

			var root = configXMLDocument.DocumentElement;

			XmlNode mediaZipNode = null;

			// Remove any MediaPath entries (except the defaults)
			var mediaPathNodes = new List<XmlNode>();
			foreach (XmlNode node in root.GetElementsByTagName("MediaPath"))	// Clone the list so the removeChild foreach loop doesn't have issues with modifying the underlying collection
			{
				mediaPathNodes.Add(node);
			}

			foreach (XmlNode mediaPath in mediaPathNodes)
			{
				try
				{
					var path = mediaPath.Attributes["Path"].Value.ToLower();

					if (path == "media.zip")
					{
						mediaZipNode = mediaPath;
					}

					if (path != "media.zip" &&
						path != "texturecache.zip" &&
						path != "meshcache.zip")
					{
						root.RemoveChild(mediaPath);
					}
				}
				catch { }
			}

			// Add MediaPath entries based on the current profile
			foreach (var activatedMod in profile.ActivatedMods)
			{
				XmlNode modNode = configXMLDocument.CreateElement("MediaPath");
				var pathAttribute = configXMLDocument.CreateAttribute("Path", null);
				pathAttribute.Value = AppLogic.PathCombine(this.appSettings.ModSubfolderName, activatedMod.Path);
				modNode.Attributes.Append(pathAttribute);
				if (mediaZipNode != null)
				{
					root.InsertBefore(modNode, mediaZipNode);
				}
				else
				{
					root.AppendChild(modNode);
				}
				
			}

			// Overwrite the config file
			configXMLDocument.Save(configFilePath);
		}
		
		private void frmMainWindow_Resize(object sender, EventArgs e)
		{
			var nameWidth = this.lvMods.Columns[0].Width;
			var otherColumnWidth = -nameWidth;
			foreach (ColumnHeader column in this.lvMods.Columns)
			{
				otherColumnWidth += column.Width;
			}


			this.lvMods.Columns[0].Width = this.lvMods.ClientSize.Width - otherColumnWidth;
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

		private void btnAddMod_Click(object sender, EventArgs e)
		{
			var result = this.installModDialog.ShowForm(this, this.appSettings.ModFolder);
			if (result == DialogResult.OK)
			{
				var mod = this.installModDialog.Tag as Mod;
				if (mod != null)
				{
					this.mods.Add(mod);
					this.WriteMods(this.mods);
				}

				this.LoadAppData();
			}
		}

		private void lvMods_DoubleClick(object sender, EventArgs e)
		{
			int modIdx = lvMods.SelectedIndices.Count > 0 ? lvMods.SelectedIndices[0] : -1;

			if (modIdx < 0) return;

			var mod = this.mods[modIdx];

			var result = this.modDetailDialog.ShowForm(this, mod, this.appSettings.ModFolder);
			if (result == DialogResult.OK)
			{
				if ((this.modDetailDialog.Tag as string) == "delete")
				{
					this.DeleteMod(mod);
				}
				// else the mod object was updated by the form and is ready to be saved

				this.WriteMods(this.mods);

				this.LoadAppData();
			}
		}

		private void DeleteMod(Mod mod)
		{
			if (Mod.DeleteMod(this.appSettings.ModFolder, mod))
			{
				this.mods.Remove(mod);
			}
			else
			{
				MessageBox.Show("The mod could not be deleted.");
			}

		}

		// Technique from https://stackoverflow.com/questions/1406887/only-change-a-listviewitems-checked-state-if-the-checkbox-is-clicked
		private bool inhibitModAutoCheck = false;
		private void lvMods_MouseDown(object sender, MouseEventArgs e)
		{
			this.inhibitModAutoCheck = true;
		}

		private void lvMods_MouseUp(object sender, MouseEventArgs e)
		{
			this.inhibitModAutoCheck = false;
		}

		private void lvMods_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			if (this.inhibitModAutoCheck)
			{
				e.NewValue = e.CurrentValue;
			}
		}

		private void cmsMod_Opening(object sender, CancelEventArgs e)
		{
			if (this.lvMods.SelectedItems.Count == 0)
			{
				e.Cancel = true;
				return;
			}

			this.miModEnabled.Checked = this.lvMods.SelectedItems[0].Checked;
		}

		private void miModEnabled_Click(object sender, EventArgs e)
		{
			if (this.lvMods.SelectedItems.Count > 0)
			{
				this.lvMods.SelectedItems[0].Checked = !this.lvMods.SelectedItems[0].Checked;
			}
		}

		private void miModEdit_Click(object sender, EventArgs e)
		{
			if (this.lvMods.SelectedItems.Count > 0)
			{
				this.lvMods_DoubleClick(this.lvMods.SelectedItems[0], new EventArgs());
			}
		}

		private void cmsProfile_Opening(object sender, CancelEventArgs e)
		{
			if (this.lvProfiles.SelectedItems.Count == 0)
			{
				e.Cancel = true;
				return;
			}

			this.miProfileSwitch.Text = $"Switch to {this.SelectedProfile.Name}";
			this.miProfileSwitchAndLaunch.Text = $"Start game with {this.SelectedProfile.Name}";
			this.miProfileDelete.Text = $"Delete {this.SelectedProfile.Name}";
		}

		private void miProfileSwitchAndLaunch_Click(object sender, EventArgs e)
		{
			if (this.lvProfiles.SelectedItems.Count > 0)
			{
				this.btnLaunch_Click(this.btnLaunch, new EventArgs());
			}
		}

		private void miProfileSwitch_Click(object sender, EventArgs e)
		{
			if (this.lvProfiles.SelectedItems.Count > 0)
			{
				this.btnSwitch_Click(this.btnSwitch, new EventArgs());
			}
		}

		private void miProfileDelete_Click(object sender, EventArgs e)
		{
			if (this.lvProfiles.SelectedItems.Count > 0)
			{
				this.btnDelete_Click(this.btnDelete, new EventArgs());
			}
		}

		private void miModUninstall_Click(object sender, EventArgs e)
		{
			if (this.lvMods.SelectedItems.Count > 0)
			{
				var mod = this.mods[this.lvMods.SelectedIndices[0]];
				if (DialogResult.OK == MessageBox.Show("Uninstalling this mod will delete this mod folder from disk.", $"Uninstall {mod.Name}", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2))
				{
					this.DeleteMod(mod);
				}
			}
		}
	}
}
