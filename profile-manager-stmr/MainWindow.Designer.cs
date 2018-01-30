namespace spintires_mudrunner_profile_manager
{
	partial class frmMainWindow
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lvProfiles = new System.Windows.Forms.ListView();
			this.btnAddProfile = new System.Windows.Forms.Button();
			this.txtProfileName = new System.Windows.Forms.TextBox();
			this.lblProfileName = new System.Windows.Forms.Label();
			this.panDetail = new System.Windows.Forms.Panel();
			this.lvMods = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.lblLine = new System.Windows.Forms.Label();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnSwitch = new System.Windows.Forms.Button();
			this.btnLaunch = new System.Windows.Forms.Button();
			this.lblMods = new System.Windows.Forms.Label();
			this.bgwSwitchProfile = new System.ComponentModel.BackgroundWorker();
			this.btnSettings = new System.Windows.Forms.Button();
			this.btnAddMod = new System.Windows.Forms.Button();
			this.panDetail.SuspendLayout();
			this.SuspendLayout();
			// 
			// lvProfiles
			// 
			this.lvProfiles.Activation = System.Windows.Forms.ItemActivation.OneClick;
			this.lvProfiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.lvProfiles.BackColor = System.Drawing.Color.LightSteelBlue;
			this.lvProfiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lvProfiles.FullRowSelect = true;
			this.lvProfiles.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.lvProfiles.HideSelection = false;
			this.lvProfiles.LabelWrap = false;
			this.lvProfiles.Location = new System.Drawing.Point(0, 0);
			this.lvProfiles.Margin = new System.Windows.Forms.Padding(0);
			this.lvProfiles.MultiSelect = false;
			this.lvProfiles.Name = "lvProfiles";
			this.lvProfiles.OwnerDraw = true;
			this.lvProfiles.ShowGroups = false;
			this.lvProfiles.Size = new System.Drawing.Size(250, 343);
			this.lvProfiles.TabIndex = 0;
			this.lvProfiles.TileSize = new System.Drawing.Size(230, 46);
			this.lvProfiles.UseCompatibleStateImageBehavior = false;
			this.lvProfiles.View = System.Windows.Forms.View.Tile;
			this.lvProfiles.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.lvProfiles_DrawItem);
			// 
			// btnAddProfile
			// 
			this.btnAddProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnAddProfile.BackColor = System.Drawing.Color.LightGray;
			this.btnAddProfile.FlatAppearance.BorderSize = 0;
			this.btnAddProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddProfile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddProfile.Location = new System.Drawing.Point(0, 340);
			this.btnAddProfile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnAddProfile.Name = "btnAddProfile";
			this.btnAddProfile.Size = new System.Drawing.Size(250, 74);
			this.btnAddProfile.TabIndex = 1;
			this.btnAddProfile.Text = "&Add profile";
			this.btnAddProfile.UseVisualStyleBackColor = false;
			this.btnAddProfile.Click += new System.EventHandler(this.btnAddProfile_Click);
			// 
			// txtProfileName
			// 
			this.txtProfileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtProfileName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtProfileName.Location = new System.Drawing.Point(128, 18);
			this.txtProfileName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtProfileName.Name = "txtProfileName";
			this.txtProfileName.Size = new System.Drawing.Size(370, 22);
			this.txtProfileName.TabIndex = 3;
			this.txtProfileName.TextChanged += new System.EventHandler(this.txtProfileName_TextChanged);
			// 
			// lblProfileName
			// 
			this.lblProfileName.AutoSize = true;
			this.lblProfileName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblProfileName.Location = new System.Drawing.Point(12, 18);
			this.lblProfileName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblProfileName.Name = "lblProfileName";
			this.lblProfileName.Size = new System.Drawing.Size(112, 21);
			this.lblProfileName.TabIndex = 4;
			this.lblProfileName.Text = "Profile name:";
			this.lblProfileName.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// panDetail
			// 
			this.panDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panDetail.AutoScroll = true;
			this.panDetail.BackColor = System.Drawing.Color.White;
			this.panDetail.Controls.Add(this.btnAddMod);
			this.panDetail.Controls.Add(this.lvMods);
			this.panDetail.Controls.Add(this.lblLine);
			this.panDetail.Controls.Add(this.btnDelete);
			this.panDetail.Controls.Add(this.btnSwitch);
			this.panDetail.Controls.Add(this.btnLaunch);
			this.panDetail.Controls.Add(this.lblMods);
			this.panDetail.Controls.Add(this.lblProfileName);
			this.panDetail.Controls.Add(this.txtProfileName);
			this.panDetail.Location = new System.Drawing.Point(250, 0);
			this.panDetail.Name = "panDetail";
			this.panDetail.Size = new System.Drawing.Size(534, 414);
			this.panDetail.TabIndex = 5;
			// 
			// lvMods
			// 
			this.lvMods.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lvMods.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lvMods.CheckBoxes = true;
			this.lvMods.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
			this.lvMods.FullRowSelect = true;
			this.lvMods.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.lvMods.LabelWrap = false;
			this.lvMods.Location = new System.Drawing.Point(128, 81);
			this.lvMods.MultiSelect = false;
			this.lvMods.Name = "lvMods";
			this.lvMods.ShowGroups = false;
			this.lvMods.Size = new System.Drawing.Size(370, 253);
			this.lvMods.TabIndex = 10;
			this.lvMods.UseCompatibleStateImageBehavior = false;
			this.lvMods.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Width = 300;
			// 
			// lblLine
			// 
			this.lblLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblLine.Location = new System.Drawing.Point(128, 42);
			this.lblLine.Name = "lblLine";
			this.lblLine.Size = new System.Drawing.Size(370, 2);
			this.lblLine.TabIndex = 9;
			// 
			// btnDelete
			// 
			this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDelete.BackColor = System.Drawing.Color.Firebrick;
			this.btnDelete.FlatAppearance.BorderSize = 0;
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnDelete.Location = new System.Drawing.Point(440, 340);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(82, 74);
			this.btnDelete.TabIndex = 8;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnSwitch
			// 
			this.btnSwitch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSwitch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.btnSwitch.FlatAppearance.BorderSize = 0;
			this.btnSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSwitch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSwitch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnSwitch.Location = new System.Drawing.Point(305, 340);
			this.btnSwitch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnSwitch.Name = "btnSwitch";
			this.btnSwitch.Size = new System.Drawing.Size(136, 74);
			this.btnSwitch.TabIndex = 1;
			this.btnSwitch.Text = "&Switch";
			this.btnSwitch.UseVisualStyleBackColor = false;
			this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
			// 
			// btnLaunch
			// 
			this.btnLaunch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnLaunch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.btnLaunch.FlatAppearance.BorderSize = 0;
			this.btnLaunch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLaunch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLaunch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnLaunch.Location = new System.Drawing.Point(0, 340);
			this.btnLaunch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnLaunch.Name = "btnLaunch";
			this.btnLaunch.Size = new System.Drawing.Size(305, 74);
			this.btnLaunch.TabIndex = 1;
			this.btnLaunch.Text = "Switch && &launch";
			this.btnLaunch.UseVisualStyleBackColor = false;
			this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
			// 
			// lblMods
			// 
			this.lblMods.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMods.Location = new System.Drawing.Point(7, 81);
			this.lblMods.Name = "lblMods";
			this.lblMods.Size = new System.Drawing.Size(93, 21);
			this.lblMods.TabIndex = 7;
			this.lblMods.Text = "Mods:";
			this.lblMods.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// btnSettings
			// 
			this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSettings.BackgroundImage = global::net.glympz.ProfileManagerSTMR.Properties.Resources.cog;
			this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnSettings.FlatAppearance.BorderSize = 0;
			this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSettings.Location = new System.Drawing.Point(756, 12);
			this.btnSettings.Name = "btnSettings";
			this.btnSettings.Size = new System.Drawing.Size(16, 16);
			this.btnSettings.TabIndex = 13;
			this.btnSettings.UseVisualStyleBackColor = true;
			this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
			// 
			// btnAddMod
			// 
			this.btnAddMod.BackgroundImage = global::net.glympz.ProfileManagerSTMR.Properties.Resources.plugin_add;
			this.btnAddMod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnAddMod.FlatAppearance.BorderSize = 0;
			this.btnAddMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddMod.Location = new System.Drawing.Point(106, 83);
			this.btnAddMod.Name = "btnAddMod";
			this.btnAddMod.Size = new System.Drawing.Size(16, 16);
			this.btnAddMod.TabIndex = 14;
			this.btnAddMod.UseVisualStyleBackColor = true;
			this.btnAddMod.Click += new System.EventHandler(this.btnAddMod_Click);
			// 
			// frmMainWindow
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(784, 411);
			this.Controls.Add(this.btnSettings);
			this.Controls.Add(this.panDetail);
			this.Controls.Add(this.btnAddProfile);
			this.Controls.Add(this.lvProfiles);
			this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MinimumSize = new System.Drawing.Size(800, 400);
			this.Name = "frmMainWindow";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.Text = "Profile Manager for Spintires: Mudrunner";
			this.Load += new System.EventHandler(this.frmMainWindow_Load);
			this.Shown += new System.EventHandler(this.frmMainWindow_Shown);
			this.Resize += new System.EventHandler(this.frmMainWindow_Resize);
			this.panDetail.ResumeLayout(false);
			this.panDetail.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView lvProfiles;
		private System.Windows.Forms.Button btnAddProfile;
		private System.Windows.Forms.TextBox txtProfileName;
		private System.Windows.Forms.Label lblProfileName;
		private System.Windows.Forms.Panel panDetail;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Label lblMods;
		private System.Windows.Forms.Button btnLaunch;
		private System.Windows.Forms.Label lblLine;
		private System.Windows.Forms.Button btnSwitch;
		private System.ComponentModel.BackgroundWorker bgwSwitchProfile;
		private System.Windows.Forms.Button btnSettings;
		private System.Windows.Forms.ListView lvMods;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.Button btnAddMod;
	}
}

