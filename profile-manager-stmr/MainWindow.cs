using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
		}

		private frmSettingsDialog settingsDialog;
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
			bool showSettingsDialog = AppLogic.GetInitialSettings(ApplicationSettings.Default, out messages);

			if (showSettingsDialog)
			{
				if (!string.IsNullOrEmpty(messages))
				{
					MessageBox.Show(messages);
				}

				this.settingsDialog.ShowDialog(this);
			}
		}

		private void lvProfiles_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
		{
			this.activeProfileIndex = e.ItemIndex;
			this.txtProfileName.Text = this.activeProfile.Name;
		}

		#region Profile Change Events
		private void cblMods_ItemCheck(object sender, ItemCheckEventArgs e)
		{

		}

		private void txtProfileName_TextChanged(object sender, EventArgs e)
		{
			this.activeProfile.Name = this.txtProfileName.Text;
			this.lvProfiles.Items[this.activeProfileIndex].Text = this.activeProfile.DisplayName;
		}

		#endregion

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
			// Show a working modal dialog

			// Preserve the current profile saves

			// Copy old saves

			// Update Config.xml

			// Launch game
			AppLogic.LaunchGame(675010);
		}

	}
}
