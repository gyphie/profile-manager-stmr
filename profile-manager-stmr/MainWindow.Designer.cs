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
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btnAddProfile = new System.Windows.Forms.Button();
			this.txtProfileName = new System.Windows.Forms.TextBox();
			this.panDetail = new System.Windows.Forms.Panel();
			this.lvMods = new System.Windows.Forms.ListView();
			this.chModName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chInstallationDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chRating = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chMultiplayer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.lblProfileName = new System.Windows.Forms.Label();
			this.btnAddMod = new System.Windows.Forms.Button();
			this.btnSwitch = new System.Windows.Forms.Button();
			this.btnLaunch = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.bgwSwitchProfile = new System.ComponentModel.BackgroundWorker();
			this.btnSettings = new System.Windows.Forms.Button();
			this.panDetail.SuspendLayout();
			this.SuspendLayout();
			// 
			// lvProfiles
			// 
			this.lvProfiles.Activation = System.Windows.Forms.ItemActivation.OneClick;
			this.lvProfiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.lvProfiles.BackColor = System.Drawing.SystemColors.Window;
			this.lvProfiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lvProfiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
			this.lvProfiles.ForeColor = System.Drawing.SystemColors.WindowText;
			this.lvProfiles.FullRowSelect = true;
			this.lvProfiles.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.lvProfiles.HideSelection = false;
			this.lvProfiles.LabelWrap = false;
			this.lvProfiles.Location = new System.Drawing.Point(0, 0);
			this.lvProfiles.Margin = new System.Windows.Forms.Padding(0);
			this.lvProfiles.MultiSelect = false;
			this.lvProfiles.Name = "lvProfiles";
			this.lvProfiles.ShowGroups = false;
			this.lvProfiles.Size = new System.Drawing.Size(250, 343);
			this.lvProfiles.TabIndex = 0;
			this.lvProfiles.TileSize = new System.Drawing.Size(230, 46);
			this.lvProfiles.UseCompatibleStateImageBehavior = false;
			this.lvProfiles.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Width = 230;
			// 
			// btnAddProfile
			// 
			this.btnAddProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnAddProfile.BackColor = System.Drawing.SystemColors.ControlLight;
			this.btnAddProfile.FlatAppearance.BorderSize = 0;
			this.btnAddProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddProfile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddProfile.Location = new System.Drawing.Point(13, 359);
			this.btnAddProfile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnAddProfile.Name = "btnAddProfile";
			this.btnAddProfile.Size = new System.Drawing.Size(147, 40);
			this.btnAddProfile.TabIndex = 1;
			this.btnAddProfile.Text = "Add &profile";
			this.btnAddProfile.UseVisualStyleBackColor = false;
			this.btnAddProfile.Click += new System.EventHandler(this.btnAddProfile_Click);
			// 
			// txtProfileName
			// 
			this.txtProfileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtProfileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtProfileName.Location = new System.Drawing.Point(14, 41);
			this.txtProfileName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtProfileName.Name = "txtProfileName";
			this.txtProfileName.Size = new System.Drawing.Size(484, 29);
			this.txtProfileName.TabIndex = 3;
			this.txtProfileName.TextChanged += new System.EventHandler(this.txtProfileName_TextChanged);
			// 
			// panDetail
			// 
			this.panDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panDetail.AutoScroll = true;
			this.panDetail.BackColor = System.Drawing.Color.White;
			this.panDetail.Controls.Add(this.lvMods);
			this.panDetail.Controls.Add(this.lblProfileName);
			this.panDetail.Controls.Add(this.txtProfileName);
			this.panDetail.Location = new System.Drawing.Point(250, 0);
			this.panDetail.Name = "panDetail";
			this.panDetail.Size = new System.Drawing.Size(534, 343);
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
            this.chModName,
            this.chInstallationDate,
            this.chType,
            this.chRating,
            this.chMultiplayer});
			this.lvMods.FullRowSelect = true;
			this.lvMods.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lvMods.LabelWrap = false;
			this.lvMods.Location = new System.Drawing.Point(14, 90);
			this.lvMods.MultiSelect = false;
			this.lvMods.Name = "lvMods";
			this.lvMods.ShowGroups = false;
			this.lvMods.Size = new System.Drawing.Size(520, 250);
			this.lvMods.TabIndex = 10;
			this.lvMods.UseCompatibleStateImageBehavior = false;
			this.lvMods.View = System.Windows.Forms.View.Details;
			this.lvMods.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lvMods_ItemCheck);
			this.lvMods.DoubleClick += new System.EventHandler(this.lvMods_DoubleClick);
			this.lvMods.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvMods_MouseDown);
			this.lvMods.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lvMods_MouseUp);
			// 
			// chModName
			// 
			this.chModName.Text = "Mod";
			this.chModName.Width = 278;
			// 
			// chInstallationDate
			// 
			this.chInstallationDate.Text = "Date";
			// 
			// chType
			// 
			this.chType.Text = "Type";
			// 
			// chRating
			// 
			this.chRating.Text = "Rating";
			// 
			// chMultiplayer
			// 
			this.chMultiplayer.Text = "MP";
			// 
			// lblProfileName
			// 
			this.lblProfileName.AutoSize = true;
			this.lblProfileName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblProfileName.Location = new System.Drawing.Point(10, 12);
			this.lblProfileName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblProfileName.Name = "lblProfileName";
			this.lblProfileName.Size = new System.Drawing.Size(98, 21);
			this.lblProfileName.TabIndex = 4;
			this.lblProfileName.Text = "Profile name";
			// 
			// btnAddMod
			// 
			this.btnAddMod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnAddMod.BackColor = System.Drawing.SystemColors.ControlLight;
			this.btnAddMod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnAddMod.FlatAppearance.BorderSize = 0;
			this.btnAddMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddMod.Location = new System.Drawing.Point(334, 359);
			this.btnAddMod.Name = "btnAddMod";
			this.btnAddMod.Size = new System.Drawing.Size(100, 40);
			this.btnAddMod.TabIndex = 14;
			this.btnAddMod.Text = "Add &mod";
			this.btnAddMod.UseVisualStyleBackColor = false;
			this.btnAddMod.Click += new System.EventHandler(this.btnAddMod_Click);
			// 
			// btnSwitch
			// 
			this.btnSwitch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSwitch.BackColor = System.Drawing.SystemColors.ControlLight;
			this.btnSwitch.FlatAppearance.BorderSize = 0;
			this.btnSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSwitch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSwitch.ForeColor = System.Drawing.SystemColors.WindowText;
			this.btnSwitch.Location = new System.Drawing.Point(689, 360);
			this.btnSwitch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnSwitch.Name = "btnSwitch";
			this.btnSwitch.Size = new System.Drawing.Size(82, 39);
			this.btnSwitch.TabIndex = 1;
			this.btnSwitch.Text = "S&witch";
			this.btnSwitch.UseVisualStyleBackColor = false;
			this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
			// 
			// btnLaunch
			// 
			this.btnLaunch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnLaunch.BackColor = System.Drawing.SystemColors.ControlLight;
			this.btnLaunch.FlatAppearance.BorderSize = 0;
			this.btnLaunch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLaunch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLaunch.ForeColor = System.Drawing.SystemColors.WindowText;
			this.btnLaunch.Location = new System.Drawing.Point(540, 360);
			this.btnLaunch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnLaunch.Name = "btnLaunch";
			this.btnLaunch.Size = new System.Drawing.Size(141, 39);
			this.btnLaunch.TabIndex = 1;
			this.btnLaunch.Text = "Switch && &launch";
			this.btnLaunch.UseVisualStyleBackColor = false;
			this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnDelete.BackColor = System.Drawing.SystemColors.ControlLight;
			this.btnDelete.FlatAppearance.BorderSize = 0;
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.ForeColor = System.Drawing.SystemColors.WindowText;
			this.btnDelete.Location = new System.Drawing.Point(167, 359);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(70, 40);
			this.btnDelete.TabIndex = 8;
			this.btnDelete.Text = "&Delete";
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnSettings
			// 
			this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnSettings.BackColor = System.Drawing.SystemColors.ControlLight;
			this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnSettings.FlatAppearance.BorderSize = 0;
			this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSettings.Location = new System.Drawing.Point(251, 359);
			this.btnSettings.Name = "btnSettings";
			this.btnSettings.Size = new System.Drawing.Size(77, 40);
			this.btnSettings.TabIndex = 13;
			this.btnSettings.Text = "&Settings";
			this.btnSettings.UseVisualStyleBackColor = false;
			this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
			// 
			// frmMainWindow
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(784, 411);
			this.Controls.Add(this.btnAddMod);
			this.Controls.Add(this.btnSettings);
			this.Controls.Add(this.panDetail);
			this.Controls.Add(this.btnSwitch);
			this.Controls.Add(this.btnAddProfile);
			this.Controls.Add(this.btnLaunch);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.lvProfiles);
			this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MinimumSize = new System.Drawing.Size(800, 400);
			this.Name = "frmMainWindow";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.Text = "Profile Manager for Spintires: MudRunner";
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
		private System.Windows.Forms.Panel panDetail;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnLaunch;
		private System.Windows.Forms.Button btnSwitch;
		private System.ComponentModel.BackgroundWorker bgwSwitchProfile;
		private System.Windows.Forms.Button btnSettings;
		private System.Windows.Forms.ListView lvMods;
		private System.Windows.Forms.ColumnHeader chModName;
		private System.Windows.Forms.Button btnAddMod;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.Label lblProfileName;
		private System.Windows.Forms.ColumnHeader chType;
		private System.Windows.Forms.ColumnHeader chRating;
		private System.Windows.Forms.ColumnHeader chMultiplayer;
		private System.Windows.Forms.ColumnHeader chInstallationDate;
	}
}

