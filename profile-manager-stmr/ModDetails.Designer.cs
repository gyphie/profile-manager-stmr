namespace net.glympz.ProfileManagerSTMR
{
	partial class frmModDetails
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
			this.label2 = new System.Windows.Forms.Label();
			this.txtModName = new System.Windows.Forms.TextBox();
			this.cmboModType = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.cmboRating = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.dtpInstalledOn = new System.Windows.Forms.DateTimePicker();
			this.btnOpenFolder = new System.Windows.Forms.Button();
			this.lblSteamFolder = new System.Windows.Forms.Label();
			this.txtModFilePath = new System.Windows.Forms.TextBox();
			this.btnDelete = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.BackColor = System.Drawing.SystemColors.ControlLight;
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
			this.btnCancel.FlatAppearance.BorderSize = 0;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnCancel.Location = new System.Drawing.Point(498, 194);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(74, 40);
			this.btnCancel.TabIndex = 12;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.UseVisualStyleBackColor = false;
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSave.BackColor = System.Drawing.SystemColors.ControlLight;
			this.btnSave.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
			this.btnSave.FlatAppearance.BorderSize = 0;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnSave.Location = new System.Drawing.Point(408, 194);
			this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(83, 40);
			this.btnSave.TabIndex = 11;
			this.btnSave.Text = "&Save";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(13, 9);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(110, 22);
			this.label2.TabIndex = 20;
			this.label2.Text = "Mod name";
			// 
			// txtModName
			// 
			this.txtModName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtModName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtModName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtModName.Location = new System.Drawing.Point(17, 36);
			this.txtModName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtModName.Name = "txtModName";
			this.txtModName.Size = new System.Drawing.Size(554, 29);
			this.txtModName.TabIndex = 19;
			// 
			// cmboModType
			// 
			this.cmboModType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmboModType.FormattingEnabled = true;
			this.cmboModType.Items.AddRange(new object[] {
            "Autodetect",
            "Map",
            "Vehicle",
            "Other"});
			this.cmboModType.Location = new System.Drawing.Point(17, 156);
			this.cmboModType.Name = "cmboModType";
			this.cmboModType.Size = new System.Drawing.Size(180, 29);
			this.cmboModType.TabIndex = 21;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(13, 131);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(110, 22);
			this.label1.TabIndex = 20;
			this.label1.Text = "Type";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(387, 131);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(110, 22);
			this.label3.TabIndex = 20;
			this.label3.Text = "Rating";
			// 
			// cmboRating
			// 
			this.cmboRating.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cmboRating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmboRating.FormattingEnabled = true;
			this.cmboRating.Items.AddRange(new object[] {
            "Thumbs Up",
            "None",
            "Thumbs Down"});
			this.cmboRating.Location = new System.Drawing.Point(391, 156);
			this.cmboRating.Name = "cmboRating";
			this.cmboRating.Size = new System.Drawing.Size(180, 29);
			this.cmboRating.TabIndex = 21;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(199, 131);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(110, 22);
			this.label4.TabIndex = 20;
			this.label4.Text = "Installed on";
			// 
			// dtpInstalledOn
			// 
			this.dtpInstalledOn.CustomFormat = "MMMM d, yyyy";
			this.dtpInstalledOn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpInstalledOn.Location = new System.Drawing.Point(203, 156);
			this.dtpInstalledOn.Name = "dtpInstalledOn";
			this.dtpInstalledOn.Size = new System.Drawing.Size(182, 29);
			this.dtpInstalledOn.TabIndex = 22;
			// 
			// btnOpenFolder
			// 
			this.btnOpenFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOpenFolder.BackColor = System.Drawing.Color.Transparent;
			this.btnOpenFolder.BackgroundImage = global::net.glympz.ProfileManagerSTMR.Properties.Resources.LinkedFolderOpen_16x;
			this.btnOpenFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnOpenFolder.FlatAppearance.BorderSize = 0;
			this.btnOpenFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOpenFolder.Location = new System.Drawing.Point(543, 98);
			this.btnOpenFolder.Name = "btnOpenFolder";
			this.btnOpenFolder.Size = new System.Drawing.Size(28, 28);
			this.btnOpenFolder.TabIndex = 25;
			this.btnOpenFolder.UseMnemonic = false;
			this.btnOpenFolder.UseVisualStyleBackColor = false;
			this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
			// 
			// lblSteamFolder
			// 
			this.lblSteamFolder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSteamFolder.Location = new System.Drawing.Point(13, 70);
			this.lblSteamFolder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblSteamFolder.Name = "lblSteamFolder";
			this.lblSteamFolder.Size = new System.Drawing.Size(110, 22);
			this.lblSteamFolder.TabIndex = 24;
			this.lblSteamFolder.Text = "Mod folder";
			// 
			// txtModFilePath
			// 
			this.txtModFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtModFilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtModFilePath.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtModFilePath.Location = new System.Drawing.Point(17, 97);
			this.txtModFilePath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtModFilePath.Name = "txtModFilePath";
			this.txtModFilePath.ReadOnly = true;
			this.txtModFilePath.Size = new System.Drawing.Size(519, 29);
			this.txtModFilePath.TabIndex = 23;
			// 
			// btnDelete
			// 
			this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnDelete.BackColor = System.Drawing.SystemColors.ControlLight;
			this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
			this.btnDelete.FlatAppearance.BorderSize = 0;
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnDelete.Location = new System.Drawing.Point(17, 194);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(74, 40);
			this.btnDelete.TabIndex = 12;
			this.btnDelete.Text = "&Delete";
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// frmModDetails
			// 
			this.AcceptButton = this.btnSave;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.White;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(584, 246);
			this.Controls.Add(this.btnOpenFolder);
			this.Controls.Add(this.lblSteamFolder);
			this.Controls.Add(this.txtModFilePath);
			this.Controls.Add(this.dtpInstalledOn);
			this.Controls.Add(this.cmboRating);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.cmboModType);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtModName);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(600, 285);
			this.Name = "frmModDetails";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Mod details";
			this.Load += new System.EventHandler(this.frmInstallMod_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtModName;
		private System.Windows.Forms.ComboBox cmboModType;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cmboRating;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker dtpInstalledOn;
		private System.Windows.Forms.Button btnOpenFolder;
		private System.Windows.Forms.Label lblSteamFolder;
		private System.Windows.Forms.TextBox txtModFilePath;
		private System.Windows.Forms.Button btnDelete;
	}
}