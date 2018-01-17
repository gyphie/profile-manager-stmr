namespace net.glympz.ProfileManagerSTMR
{
	partial class frmSettingsDialog
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
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.lblLine = new System.Windows.Forms.Label();
			this.lblSteamFolder = new System.Windows.Forms.Label();
			this.txtSteamFolder = new System.Windows.Forms.TextBox();
			this.btnSteamFolderPicker = new System.Windows.Forms.Button();
			this.txtGameFolder = new System.Windows.Forms.TextBox();
			this.lblGameFolder = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnGameFolderPicker = new System.Windows.Forms.Button();
			this.txtAppDataFolder = new System.Windows.Forms.TextBox();
			this.lblAppDataFolder = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnAppDataFolderPicker = new System.Windows.Forms.Button();
			this.txtModsFolder = new System.Windows.Forms.TextBox();
			this.lblModsFolder = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.btnModsFolderPicker = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.BackColor = System.Drawing.Color.Firebrick;
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.FlatAppearance.BorderSize = 0;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnCancel.Location = new System.Drawing.Point(544, 216);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(82, 74);
			this.btnCancel.TabIndex = 10;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSave.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.btnSave.FlatAppearance.BorderSize = 0;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnSave.Location = new System.Drawing.Point(379, 216);
			this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(165, 74);
			this.btnSave.TabIndex = 9;
			this.btnSave.Text = "&Save";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// lblLine
			// 
			this.lblLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblLine.Location = new System.Drawing.Point(225, 33);
			this.lblLine.Name = "lblLine";
			this.lblLine.Size = new System.Drawing.Size(367, 2);
			this.lblLine.TabIndex = 13;
			// 
			// lblSteamFolder
			// 
			this.lblSteamFolder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSteamFolder.Location = new System.Drawing.Point(13, 9);
			this.lblSteamFolder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblSteamFolder.Name = "lblSteamFolder";
			this.lblSteamFolder.Size = new System.Drawing.Size(204, 22);
			this.lblSteamFolder.TabIndex = 12;
			this.lblSteamFolder.Text = "Steam:";
			this.lblSteamFolder.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// txtSteamFolder
			// 
			this.txtSteamFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtSteamFolder.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtSteamFolder.Location = new System.Drawing.Point(225, 9);
			this.txtSteamFolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtSteamFolder.Name = "txtSteamFolder";
			this.txtSteamFolder.Size = new System.Drawing.Size(367, 22);
			this.txtSteamFolder.TabIndex = 11;
			// 
			// btnSteamFolderPicker
			// 
			this.btnSteamFolderPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSteamFolderPicker.FlatAppearance.BorderSize = 0;
			this.btnSteamFolderPicker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSteamFolderPicker.Location = new System.Drawing.Point(599, 11);
			this.btnSteamFolderPicker.Name = "btnSteamFolderPicker";
			this.btnSteamFolderPicker.Size = new System.Drawing.Size(28, 28);
			this.btnSteamFolderPicker.TabIndex = 14;
			this.btnSteamFolderPicker.Text = "···";
			this.btnSteamFolderPicker.UseMnemonic = false;
			this.btnSteamFolderPicker.UseVisualStyleBackColor = true;
			// 
			// txtGameFolder
			// 
			this.txtGameFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtGameFolder.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtGameFolder.Location = new System.Drawing.Point(225, 49);
			this.txtGameFolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtGameFolder.Name = "txtGameFolder";
			this.txtGameFolder.Size = new System.Drawing.Size(367, 22);
			this.txtGameFolder.TabIndex = 11;
			// 
			// lblGameFolder
			// 
			this.lblGameFolder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblGameFolder.Location = new System.Drawing.Point(13, 49);
			this.lblGameFolder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblGameFolder.Name = "lblGameFolder";
			this.lblGameFolder.Size = new System.Drawing.Size(204, 22);
			this.lblGameFolder.TabIndex = 12;
			this.lblGameFolder.Text = "Spintires: Mudrunner:";
			this.lblGameFolder.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label2.Location = new System.Drawing.Point(225, 73);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(367, 2);
			this.label2.TabIndex = 13;
			// 
			// btnGameFolderPicker
			// 
			this.btnGameFolderPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnGameFolderPicker.FlatAppearance.BorderSize = 0;
			this.btnGameFolderPicker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGameFolderPicker.Location = new System.Drawing.Point(599, 51);
			this.btnGameFolderPicker.Name = "btnGameFolderPicker";
			this.btnGameFolderPicker.Size = new System.Drawing.Size(28, 28);
			this.btnGameFolderPicker.TabIndex = 14;
			this.btnGameFolderPicker.Text = "···";
			this.btnGameFolderPicker.UseMnemonic = false;
			this.btnGameFolderPicker.UseVisualStyleBackColor = true;
			// 
			// txtAppDataFolder
			// 
			this.txtAppDataFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtAppDataFolder.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtAppDataFolder.Location = new System.Drawing.Point(225, 89);
			this.txtAppDataFolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtAppDataFolder.Name = "txtAppDataFolder";
			this.txtAppDataFolder.Size = new System.Drawing.Size(367, 22);
			this.txtAppDataFolder.TabIndex = 11;
			// 
			// lblAppDataFolder
			// 
			this.lblAppDataFolder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAppDataFolder.Location = new System.Drawing.Point(13, 89);
			this.lblAppDataFolder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblAppDataFolder.Name = "lblAppDataFolder";
			this.lblAppDataFolder.Size = new System.Drawing.Size(204, 22);
			this.lblAppDataFolder.TabIndex = 12;
			this.lblAppDataFolder.Text = "ST:MR AppData";
			this.lblAppDataFolder.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label4.Location = new System.Drawing.Point(225, 113);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(367, 2);
			this.label4.TabIndex = 13;
			// 
			// btnAppDataFolderPicker
			// 
			this.btnAppDataFolderPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAppDataFolderPicker.FlatAppearance.BorderSize = 0;
			this.btnAppDataFolderPicker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAppDataFolderPicker.Location = new System.Drawing.Point(599, 91);
			this.btnAppDataFolderPicker.Name = "btnAppDataFolderPicker";
			this.btnAppDataFolderPicker.Size = new System.Drawing.Size(28, 28);
			this.btnAppDataFolderPicker.TabIndex = 14;
			this.btnAppDataFolderPicker.Text = "···";
			this.btnAppDataFolderPicker.UseMnemonic = false;
			this.btnAppDataFolderPicker.UseVisualStyleBackColor = true;
			// 
			// txtModsFolder
			// 
			this.txtModsFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtModsFolder.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtModsFolder.Location = new System.Drawing.Point(225, 131);
			this.txtModsFolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtModsFolder.Name = "txtModsFolder";
			this.txtModsFolder.Size = new System.Drawing.Size(367, 22);
			this.txtModsFolder.TabIndex = 11;
			// 
			// lblModsFolder
			// 
			this.lblModsFolder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblModsFolder.Location = new System.Drawing.Point(13, 131);
			this.lblModsFolder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblModsFolder.Name = "lblModsFolder";
			this.lblModsFolder.Size = new System.Drawing.Size(204, 22);
			this.lblModsFolder.TabIndex = 12;
			this.lblModsFolder.Text = "Mods:";
			this.lblModsFolder.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label6.Location = new System.Drawing.Point(225, 155);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(367, 2);
			this.label6.TabIndex = 13;
			// 
			// btnModsFolderPicker
			// 
			this.btnModsFolderPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnModsFolderPicker.FlatAppearance.BorderSize = 0;
			this.btnModsFolderPicker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnModsFolderPicker.Location = new System.Drawing.Point(599, 133);
			this.btnModsFolderPicker.Name = "btnModsFolderPicker";
			this.btnModsFolderPicker.Size = new System.Drawing.Size(28, 28);
			this.btnModsFolderPicker.TabIndex = 14;
			this.btnModsFolderPicker.Text = "···";
			this.btnModsFolderPicker.UseMnemonic = false;
			this.btnModsFolderPicker.UseVisualStyleBackColor = true;
			// 
			// frmSettingsDialog
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(638, 302);
			this.Controls.Add(this.btnModsFolderPicker);
			this.Controls.Add(this.btnAppDataFolderPicker);
			this.Controls.Add(this.btnGameFolderPicker);
			this.Controls.Add(this.btnSteamFolderPicker);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblLine);
			this.Controls.Add(this.lblModsFolder);
			this.Controls.Add(this.txtModsFolder);
			this.Controls.Add(this.lblAppDataFolder);
			this.Controls.Add(this.txtAppDataFolder);
			this.Controls.Add(this.lblGameFolder);
			this.Controls.Add(this.txtGameFolder);
			this.Controls.Add(this.lblSteamFolder);
			this.Controls.Add(this.txtSteamFolder);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
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
		private System.Windows.Forms.Label lblLine;
		private System.Windows.Forms.Label lblSteamFolder;
		private System.Windows.Forms.TextBox txtSteamFolder;
		private System.Windows.Forms.Button btnSteamFolderPicker;
		private System.Windows.Forms.TextBox txtGameFolder;
		private System.Windows.Forms.Label lblGameFolder;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnGameFolderPicker;
		private System.Windows.Forms.TextBox txtAppDataFolder;
		private System.Windows.Forms.Label lblAppDataFolder;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnAppDataFolderPicker;
		private System.Windows.Forms.TextBox txtModsFolder;
		private System.Windows.Forms.Label lblModsFolder;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnModsFolderPicker;
	}
}