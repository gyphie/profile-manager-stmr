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
			this.bgwInstaller = new System.ComponentModel.BackgroundWorker();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnInstall = new System.Windows.Forms.Button();
			this.btnSteamFolderPicker = new System.Windows.Forms.Button();
			this.lblSteamFolder = new System.Windows.Forms.Label();
			this.txtModFilePath = new System.Windows.Forms.TextBox();
			this.lblLine = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtModName = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// bgwInstaller
			// 
			this.bgwInstaller.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwInstaller_DoWork);
			this.bgwInstaller.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwInstaller_RunWorkerCompleted);
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.BackColor = System.Drawing.Color.Firebrick;
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
			this.btnCancel.FlatAppearance.BorderSize = 0;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnCancel.Location = new System.Drawing.Point(490, 105);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(82, 74);
			this.btnCancel.TabIndex = 12;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.UseVisualStyleBackColor = false;
			// 
			// btnInstall
			// 
			this.btnInstall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnInstall.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.btnInstall.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
			this.btnInstall.FlatAppearance.BorderSize = 0;
			this.btnInstall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnInstall.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnInstall.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnInstall.Location = new System.Drawing.Point(325, 105);
			this.btnInstall.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnInstall.Name = "btnInstall";
			this.btnInstall.Size = new System.Drawing.Size(165, 74);
			this.btnInstall.TabIndex = 11;
			this.btnInstall.Text = "&Install";
			this.btnInstall.UseVisualStyleBackColor = false;
			this.btnInstall.Click += new System.EventHandler(this.btnInstall_Click);
			// 
			// btnSteamFolderPicker
			// 
			this.btnSteamFolderPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSteamFolderPicker.BackColor = System.Drawing.Color.Transparent;
			this.btnSteamFolderPicker.BackgroundImage = global::net.glympz.ProfileManagerSTMR.Properties.Resources.Folder_16x;
			this.btnSteamFolderPicker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnSteamFolderPicker.FlatAppearance.BorderSize = 0;
			this.btnSteamFolderPicker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSteamFolderPicker.Location = new System.Drawing.Point(533, 7);
			this.btnSteamFolderPicker.Name = "btnSteamFolderPicker";
			this.btnSteamFolderPicker.Size = new System.Drawing.Size(28, 28);
			this.btnSteamFolderPicker.TabIndex = 17;
			this.btnSteamFolderPicker.UseMnemonic = false;
			this.btnSteamFolderPicker.UseVisualStyleBackColor = false;
			this.btnSteamFolderPicker.Click += new System.EventHandler(this.btnSteamFolderPicker_Click);
			// 
			// lblSteamFolder
			// 
			this.lblSteamFolder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSteamFolder.Location = new System.Drawing.Point(13, 9);
			this.lblSteamFolder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblSteamFolder.Name = "lblSteamFolder";
			this.lblSteamFolder.Size = new System.Drawing.Size(204, 22);
			this.lblSteamFolder.TabIndex = 16;
			this.lblSteamFolder.Text = "Mod archive:";
			this.lblSteamFolder.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// txtModFilePath
			// 
			this.txtModFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtModFilePath.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtModFilePath.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtModFilePath.Location = new System.Drawing.Point(225, 9);
			this.txtModFilePath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtModFilePath.Name = "txtModFilePath";
			this.txtModFilePath.Size = new System.Drawing.Size(301, 22);
			this.txtModFilePath.TabIndex = 15;
			// 
			// lblLine
			// 
			this.lblLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblLine.Location = new System.Drawing.Point(225, 33);
			this.lblLine.Name = "lblLine";
			this.lblLine.Size = new System.Drawing.Size(301, 2);
			this.lblLine.TabIndex = 18;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Location = new System.Drawing.Point(225, 74);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(301, 2);
			this.label1.TabIndex = 22;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(13, 49);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(204, 22);
			this.label2.TabIndex = 20;
			this.label2.Text = "Mod name:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// txtModName
			// 
			this.txtModName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtModName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtModName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtModName.Location = new System.Drawing.Point(225, 49);
			this.txtModName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtModName.Name = "txtModName";
			this.txtModName.Size = new System.Drawing.Size(301, 22);
			this.txtModName.TabIndex = 19;
			// 
			// frmInstallMod
			// 
			this.AcceptButton = this.btnInstall;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.White;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(584, 191);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtModName);
			this.Controls.Add(this.lblLine);
			this.Controls.Add(this.btnSteamFolderPicker);
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
			this.Text = "Install Spintires: Mudrunner Mod";
			this.Load += new System.EventHandler(this.frmInstallMod_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.ComponentModel.BackgroundWorker bgwInstaller;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnInstall;
		private System.Windows.Forms.Button btnSteamFolderPicker;
		private System.Windows.Forms.Label lblSteamFolder;
		private System.Windows.Forms.TextBox txtModFilePath;
		private System.Windows.Forms.Label lblLine;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtModName;
	}
}