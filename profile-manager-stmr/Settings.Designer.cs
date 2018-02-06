namespace net.glympz.ProfileManagerSTMR
{
	partial class frmSettings
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.lblSteamFolder = new System.Windows.Forms.Label();
			this.txtSteamFolder = new System.Windows.Forms.TextBox();
			this.btnSteamFolderPicker = new System.Windows.Forms.Button();
			this.txtGameFolder = new System.Windows.Forms.TextBox();
			this.lblGameFolder = new System.Windows.Forms.Label();
			this.btnGameFolderPicker = new System.Windows.Forms.Button();
			this.txtAppDataFolder = new System.Windows.Forms.TextBox();
			this.lblAppDataFolder = new System.Windows.Forms.Label();
			this.btnAppDataFolderPicker = new System.Windows.Forms.Button();
			this.txtModsFolder = new System.Windows.Forms.TextBox();
			this.lblModsFolder = new System.Windows.Forms.Label();
			this.btnModsFolderPicker = new System.Windows.Forms.Button();
			this.btnOpenFolderSteam = new System.Windows.Forms.Button();
			this.btnOpenFolderGame = new System.Windows.Forms.Button();
			this.btnOpenFolderAppData = new System.Windows.Forms.Button();
			this.btnOpenFolderMods = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.BackColor = System.Drawing.SystemColors.ControlLight;
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.FlatAppearance.BorderSize = 0;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnCancel.Location = new System.Drawing.Point(554, 209);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(82, 40);
			this.btnCancel.TabIndex = 10;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSave.BackColor = System.Drawing.SystemColors.ControlLight;
			this.btnSave.FlatAppearance.BorderSize = 0;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnSave.Location = new System.Drawing.Point(470, 209);
			this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(77, 40);
			this.btnSave.TabIndex = 9;
			this.btnSave.Text = "&Save";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// lblSteamFolder
			// 
			this.lblSteamFolder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSteamFolder.Location = new System.Drawing.Point(13, 11);
			this.lblSteamFolder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblSteamFolder.Name = "lblSteamFolder";
			this.lblSteamFolder.Size = new System.Drawing.Size(185, 22);
			this.lblSteamFolder.TabIndex = 12;
			this.lblSteamFolder.Text = "Steam";
			this.lblSteamFolder.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// txtSteamFolder
			// 
			this.txtSteamFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtSteamFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtSteamFolder.Location = new System.Drawing.Point(206, 9);
			this.txtSteamFolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtSteamFolder.Name = "txtSteamFolder";
			this.txtSteamFolder.Size = new System.Drawing.Size(372, 29);
			this.txtSteamFolder.TabIndex = 11;
			// 
			// btnSteamFolderPicker
			// 
			this.btnSteamFolderPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSteamFolderPicker.BackgroundImage = global::net.glympz.ProfileManagerSTMR.Properties.Resources.Folder_16x;
			this.btnSteamFolderPicker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnSteamFolderPicker.FlatAppearance.BorderSize = 0;
			this.btnSteamFolderPicker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSteamFolderPicker.Location = new System.Drawing.Point(585, 10);
			this.btnSteamFolderPicker.Name = "btnSteamFolderPicker";
			this.btnSteamFolderPicker.Size = new System.Drawing.Size(28, 28);
			this.btnSteamFolderPicker.TabIndex = 14;
			this.btnSteamFolderPicker.UseMnemonic = false;
			this.btnSteamFolderPicker.UseVisualStyleBackColor = true;
			// 
			// txtGameFolder
			// 
			this.txtGameFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtGameFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtGameFolder.Location = new System.Drawing.Point(206, 49);
			this.txtGameFolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtGameFolder.Name = "txtGameFolder";
			this.txtGameFolder.Size = new System.Drawing.Size(372, 29);
			this.txtGameFolder.TabIndex = 11;
			// 
			// lblGameFolder
			// 
			this.lblGameFolder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblGameFolder.Location = new System.Drawing.Point(13, 51);
			this.lblGameFolder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblGameFolder.Name = "lblGameFolder";
			this.lblGameFolder.Size = new System.Drawing.Size(185, 22);
			this.lblGameFolder.TabIndex = 12;
			this.lblGameFolder.Text = "Spintires: MudRunner";
			this.lblGameFolder.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// btnGameFolderPicker
			// 
			this.btnGameFolderPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnGameFolderPicker.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGameFolderPicker.BackgroundImage")));
			this.btnGameFolderPicker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnGameFolderPicker.FlatAppearance.BorderSize = 0;
			this.btnGameFolderPicker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGameFolderPicker.Location = new System.Drawing.Point(585, 50);
			this.btnGameFolderPicker.Name = "btnGameFolderPicker";
			this.btnGameFolderPicker.Size = new System.Drawing.Size(28, 28);
			this.btnGameFolderPicker.TabIndex = 14;
			this.btnGameFolderPicker.UseMnemonic = false;
			this.btnGameFolderPicker.UseVisualStyleBackColor = true;
			// 
			// txtAppDataFolder
			// 
			this.txtAppDataFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtAppDataFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtAppDataFolder.Location = new System.Drawing.Point(206, 89);
			this.txtAppDataFolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtAppDataFolder.Name = "txtAppDataFolder";
			this.txtAppDataFolder.Size = new System.Drawing.Size(372, 29);
			this.txtAppDataFolder.TabIndex = 11;
			// 
			// lblAppDataFolder
			// 
			this.lblAppDataFolder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAppDataFolder.Location = new System.Drawing.Point(13, 91);
			this.lblAppDataFolder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblAppDataFolder.Name = "lblAppDataFolder";
			this.lblAppDataFolder.Size = new System.Drawing.Size(185, 22);
			this.lblAppDataFolder.TabIndex = 12;
			this.lblAppDataFolder.Text = "ST:MR AppData";
			this.lblAppDataFolder.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// btnAppDataFolderPicker
			// 
			this.btnAppDataFolderPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAppDataFolderPicker.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAppDataFolderPicker.BackgroundImage")));
			this.btnAppDataFolderPicker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnAppDataFolderPicker.FlatAppearance.BorderSize = 0;
			this.btnAppDataFolderPicker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAppDataFolderPicker.Location = new System.Drawing.Point(585, 90);
			this.btnAppDataFolderPicker.Name = "btnAppDataFolderPicker";
			this.btnAppDataFolderPicker.Size = new System.Drawing.Size(28, 28);
			this.btnAppDataFolderPicker.TabIndex = 14;
			this.btnAppDataFolderPicker.UseMnemonic = false;
			this.btnAppDataFolderPicker.UseVisualStyleBackColor = true;
			// 
			// txtModsFolder
			// 
			this.txtModsFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtModsFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtModsFolder.Location = new System.Drawing.Point(206, 131);
			this.txtModsFolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtModsFolder.Name = "txtModsFolder";
			this.txtModsFolder.Size = new System.Drawing.Size(372, 29);
			this.txtModsFolder.TabIndex = 11;
			// 
			// lblModsFolder
			// 
			this.lblModsFolder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblModsFolder.Location = new System.Drawing.Point(13, 133);
			this.lblModsFolder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblModsFolder.Name = "lblModsFolder";
			this.lblModsFolder.Size = new System.Drawing.Size(185, 22);
			this.lblModsFolder.TabIndex = 12;
			this.lblModsFolder.Text = "Mods";
			this.lblModsFolder.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// btnModsFolderPicker
			// 
			this.btnModsFolderPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnModsFolderPicker.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModsFolderPicker.BackgroundImage")));
			this.btnModsFolderPicker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnModsFolderPicker.FlatAppearance.BorderSize = 0;
			this.btnModsFolderPicker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnModsFolderPicker.Location = new System.Drawing.Point(585, 132);
			this.btnModsFolderPicker.Name = "btnModsFolderPicker";
			this.btnModsFolderPicker.Size = new System.Drawing.Size(28, 28);
			this.btnModsFolderPicker.TabIndex = 14;
			this.btnModsFolderPicker.UseMnemonic = false;
			this.btnModsFolderPicker.UseVisualStyleBackColor = true;
			// 
			// btnOpenFolderSteam
			// 
			this.btnOpenFolderSteam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOpenFolderSteam.BackgroundImage = global::net.glympz.ProfileManagerSTMR.Properties.Resources.LinkedFolderOpen_16x;
			this.btnOpenFolderSteam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnOpenFolderSteam.FlatAppearance.BorderSize = 0;
			this.btnOpenFolderSteam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOpenFolderSteam.Location = new System.Drawing.Point(619, 10);
			this.btnOpenFolderSteam.Name = "btnOpenFolderSteam";
			this.btnOpenFolderSteam.Size = new System.Drawing.Size(28, 28);
			this.btnOpenFolderSteam.TabIndex = 15;
			this.btnOpenFolderSteam.UseMnemonic = false;
			this.btnOpenFolderSteam.UseVisualStyleBackColor = true;
			this.btnOpenFolderSteam.Click += new System.EventHandler(this.btnOpenFolderX_Click);
			// 
			// btnOpenFolderGame
			// 
			this.btnOpenFolderGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOpenFolderGame.BackgroundImage = global::net.glympz.ProfileManagerSTMR.Properties.Resources.LinkedFolderOpen_16x;
			this.btnOpenFolderGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnOpenFolderGame.FlatAppearance.BorderSize = 0;
			this.btnOpenFolderGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOpenFolderGame.Location = new System.Drawing.Point(619, 50);
			this.btnOpenFolderGame.Name = "btnOpenFolderGame";
			this.btnOpenFolderGame.Size = new System.Drawing.Size(28, 28);
			this.btnOpenFolderGame.TabIndex = 15;
			this.btnOpenFolderGame.UseMnemonic = false;
			this.btnOpenFolderGame.UseVisualStyleBackColor = true;
			this.btnOpenFolderGame.Click += new System.EventHandler(this.btnOpenFolderX_Click);
			// 
			// btnOpenFolderAppData
			// 
			this.btnOpenFolderAppData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOpenFolderAppData.BackgroundImage = global::net.glympz.ProfileManagerSTMR.Properties.Resources.LinkedFolderOpen_16x;
			this.btnOpenFolderAppData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnOpenFolderAppData.FlatAppearance.BorderSize = 0;
			this.btnOpenFolderAppData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOpenFolderAppData.Location = new System.Drawing.Point(619, 90);
			this.btnOpenFolderAppData.Name = "btnOpenFolderAppData";
			this.btnOpenFolderAppData.Size = new System.Drawing.Size(28, 28);
			this.btnOpenFolderAppData.TabIndex = 15;
			this.btnOpenFolderAppData.UseMnemonic = false;
			this.btnOpenFolderAppData.UseVisualStyleBackColor = true;
			this.btnOpenFolderAppData.Click += new System.EventHandler(this.btnOpenFolderX_Click);
			// 
			// btnOpenFolderMods
			// 
			this.btnOpenFolderMods.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOpenFolderMods.BackgroundImage = global::net.glympz.ProfileManagerSTMR.Properties.Resources.LinkedFolderOpen_16x;
			this.btnOpenFolderMods.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnOpenFolderMods.FlatAppearance.BorderSize = 0;
			this.btnOpenFolderMods.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOpenFolderMods.Location = new System.Drawing.Point(619, 132);
			this.btnOpenFolderMods.Name = "btnOpenFolderMods";
			this.btnOpenFolderMods.Size = new System.Drawing.Size(28, 28);
			this.btnOpenFolderMods.TabIndex = 15;
			this.btnOpenFolderMods.UseMnemonic = false;
			this.btnOpenFolderMods.UseVisualStyleBackColor = true;
			this.btnOpenFolderMods.Click += new System.EventHandler(this.btnOpenFolderX_Click);
			// 
			// frmSettingsDialog
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(648, 261);
			this.Controls.Add(this.btnOpenFolderMods);
			this.Controls.Add(this.btnOpenFolderAppData);
			this.Controls.Add(this.btnOpenFolderGame);
			this.Controls.Add(this.btnOpenFolderSteam);
			this.Controls.Add(this.btnModsFolderPicker);
			this.Controls.Add(this.btnAppDataFolderPicker);
			this.Controls.Add(this.btnGameFolderPicker);
			this.Controls.Add(this.btnSteamFolderPicker);
			this.Controls.Add(this.lblModsFolder);
			this.Controls.Add(this.lblAppDataFolder);
			this.Controls.Add(this.lblGameFolder);
			this.Controls.Add(this.lblSteamFolder);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.txtModsFolder);
			this.Controls.Add(this.txtAppDataFolder);
			this.Controls.Add(this.txtGameFolder);
			this.Controls.Add(this.txtSteamFolder);
			this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(500, 300);
			this.Name = "frmSettingsDialog";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Settings";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Label lblSteamFolder;
		private System.Windows.Forms.TextBox txtSteamFolder;
		private System.Windows.Forms.Button btnSteamFolderPicker;
		private System.Windows.Forms.TextBox txtGameFolder;
		private System.Windows.Forms.Label lblGameFolder;
		private System.Windows.Forms.Button btnGameFolderPicker;
		private System.Windows.Forms.TextBox txtAppDataFolder;
		private System.Windows.Forms.Label lblAppDataFolder;
		private System.Windows.Forms.Button btnAppDataFolderPicker;
		private System.Windows.Forms.TextBox txtModsFolder;
		private System.Windows.Forms.Label lblModsFolder;
		private System.Windows.Forms.Button btnModsFolderPicker;
		private System.Windows.Forms.Button btnOpenFolderSteam;
		private System.Windows.Forms.Button btnOpenFolderGame;
		private System.Windows.Forms.Button btnOpenFolderAppData;
		private System.Windows.Forms.Button btnOpenFolderMods;
	}
}