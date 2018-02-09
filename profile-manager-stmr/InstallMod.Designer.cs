namespace net.glympz.ProfileManagerSTMR
{
	partial class frmInstallMod
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
			this.components = new System.ComponentModel.Container();
			this.bgwInstaller = new System.ComponentModel.BackgroundWorker();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnInstall = new System.Windows.Forms.Button();
			this.btnModArchivePicker = new System.Windows.Forms.Button();
			this.lblSteamFolder = new System.Windows.Forms.Label();
			this.txtModFilePath = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtModName = new System.Windows.Forms.TextBox();
			this.cmboModType = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.cmboRating = new System.Windows.Forms.ComboBox();
			this.timEnableForm = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// bgwInstaller
			// 
			this.bgwInstaller.WorkerReportsProgress = true;
			this.bgwInstaller.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwInstaller_DoWork);
			this.bgwInstaller.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwInstaller_ProgressChanged);
			this.bgwInstaller.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwInstaller_RunWorkerCompleted);
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
			this.btnCancel.Location = new System.Drawing.Point(498, 254);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(74, 40);
			this.btnCancel.TabIndex = 12;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.UseVisualStyleBackColor = false;
			// 
			// btnInstall
			// 
			this.btnInstall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnInstall.BackColor = System.Drawing.SystemColors.ControlLight;
			this.btnInstall.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
			this.btnInstall.FlatAppearance.BorderSize = 0;
			this.btnInstall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnInstall.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnInstall.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnInstall.Location = new System.Drawing.Point(408, 254);
			this.btnInstall.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnInstall.Name = "btnInstall";
			this.btnInstall.Size = new System.Drawing.Size(83, 40);
			this.btnInstall.TabIndex = 11;
			this.btnInstall.Text = "&Install";
			this.btnInstall.UseVisualStyleBackColor = false;
			this.btnInstall.Click += new System.EventHandler(this.btnInstall_Click);
			// 
			// btnModArchivePicker
			// 
			this.btnModArchivePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnModArchivePicker.BackColor = System.Drawing.Color.Transparent;
			this.btnModArchivePicker.BackgroundImage = global::net.glympz.ProfileManagerSTMR.Properties.Resources.Folder_16x;
			this.btnModArchivePicker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnModArchivePicker.FlatAppearance.BorderSize = 0;
			this.btnModArchivePicker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnModArchivePicker.Location = new System.Drawing.Point(543, 37);
			this.btnModArchivePicker.Name = "btnModArchivePicker";
			this.btnModArchivePicker.Size = new System.Drawing.Size(28, 28);
			this.btnModArchivePicker.TabIndex = 17;
			this.btnModArchivePicker.UseMnemonic = false;
			this.btnModArchivePicker.UseVisualStyleBackColor = false;
			this.btnModArchivePicker.Click += new System.EventHandler(this.btnModArchivePicker_Click);
			// 
			// lblSteamFolder
			// 
			this.lblSteamFolder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSteamFolder.Location = new System.Drawing.Point(13, 9);
			this.lblSteamFolder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblSteamFolder.Name = "lblSteamFolder";
			this.lblSteamFolder.Size = new System.Drawing.Size(110, 22);
			this.lblSteamFolder.TabIndex = 16;
			this.lblSteamFolder.Text = "Mod archive";
			// 
			// txtModFilePath
			// 
			this.txtModFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtModFilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtModFilePath.Cursor = System.Windows.Forms.Cursors.Default;
			this.txtModFilePath.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtModFilePath.Location = new System.Drawing.Point(17, 36);
			this.txtModFilePath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtModFilePath.Name = "txtModFilePath";
			this.txtModFilePath.Size = new System.Drawing.Size(519, 29);
			this.txtModFilePath.TabIndex = 15;
			this.txtModFilePath.Click += new System.EventHandler(this.btnModArchivePicker_Click);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(13, 75);
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
			this.txtModName.Location = new System.Drawing.Point(17, 102);
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
			this.cmboModType.Location = new System.Drawing.Point(17, 171);
			this.cmboModType.Name = "cmboModType";
			this.cmboModType.Size = new System.Drawing.Size(180, 29);
			this.cmboModType.TabIndex = 21;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(13, 146);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(110, 22);
			this.label1.TabIndex = 20;
			this.label1.Text = "Type";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(287, 146);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(110, 22);
			this.label3.TabIndex = 20;
			this.label3.Text = "Rating";
			// 
			// cmboRating
			// 
			this.cmboRating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmboRating.FormattingEnabled = true;
			this.cmboRating.Items.AddRange(new object[] {
            "Thumbs Up",
            "None",
            "Thumbs Down"});
			this.cmboRating.Location = new System.Drawing.Point(291, 171);
			this.cmboRating.Name = "cmboRating";
			this.cmboRating.Size = new System.Drawing.Size(180, 29);
			this.cmboRating.TabIndex = 21;
			// 
			// timEnableForm
			// 
			this.timEnableForm.Tick += new System.EventHandler(this.timEnableForm_Tick);
			// 
			// frmInstallMod
			// 
			this.AcceptButton = this.btnInstall;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.White;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(584, 306);
			this.Controls.Add(this.cmboRating);
			this.Controls.Add(this.cmboModType);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtModName);
			this.Controls.Add(this.btnModArchivePicker);
			this.Controls.Add(this.lblSteamFolder);
			this.Controls.Add(this.txtModFilePath);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnInstall);
			this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(600, 230);
			this.Name = "frmInstallMod";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Install Mod for Spintires: MudRunner";
			this.Load += new System.EventHandler(this.frmInstallMod_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.ComponentModel.BackgroundWorker bgwInstaller;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnInstall;
		private System.Windows.Forms.Button btnModArchivePicker;
		private System.Windows.Forms.Label lblSteamFolder;
		private System.Windows.Forms.TextBox txtModFilePath;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtModName;
		private System.Windows.Forms.ComboBox cmboModType;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cmboRating;
		private System.Windows.Forms.Timer timEnableForm;
	}
}