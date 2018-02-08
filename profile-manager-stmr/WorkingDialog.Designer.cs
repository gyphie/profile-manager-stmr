namespace net.glympz.ProfileManagerSTMR
{
	partial class frmWorkingDialog
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
			this.lblWorkingMessage = new System.Windows.Forms.Label();
			this.progressBar = new System.Windows.Forms.ProgressBar();
			this.timHide = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// lblWorkingMessage
			// 
			this.lblWorkingMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblWorkingMessage.Font = new System.Drawing.Font("Segoe UI", 18F);
			this.lblWorkingMessage.Location = new System.Drawing.Point(12, 9);
			this.lblWorkingMessage.Name = "lblWorkingMessage";
			this.lblWorkingMessage.Size = new System.Drawing.Size(293, 98);
			this.lblWorkingMessage.TabIndex = 0;
			this.lblWorkingMessage.Text = "Working...";
			this.lblWorkingMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblWorkingMessage.UseMnemonic = false;
			this.lblWorkingMessage.UseWaitCursor = true;
			// 
			// progressBar
			// 
			this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.progressBar.Location = new System.Drawing.Point(12, 110);
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(293, 15);
			this.progressBar.Step = 1;
			this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
			this.progressBar.TabIndex = 1;
			this.progressBar.UseWaitCursor = true;
			// 
			// timHide
			// 
			this.timHide.Tick += new System.EventHandler(this.timHide_Tick);
			// 
			// frmWorkingDialog
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(317, 137);
			this.ControlBox = false;
			this.Controls.Add(this.progressBar);
			this.Controls.Add(this.lblWorkingMessage);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmWorkingDialog";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.UseWaitCursor = true;
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lblWorkingMessage;
		private System.Windows.Forms.ProgressBar progressBar;
		private System.Windows.Forms.Timer timHide;
	}
}