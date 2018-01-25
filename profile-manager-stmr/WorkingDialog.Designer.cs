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
			this.lblWorkingMessage = new System.Windows.Forms.Label();
			this.progressBar = new System.Windows.Forms.ProgressBar();
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
			this.lblWorkingMessage.Size = new System.Drawing.Size(317, 107);
			this.lblWorkingMessage.TabIndex = 0;
			this.lblWorkingMessage.Text = "Switching Profiles...";
			this.lblWorkingMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblWorkingMessage.UseMnemonic = false;
			this.lblWorkingMessage.UseWaitCursor = true;
			// 
			// progressBar
			// 
			this.progressBar.Location = new System.Drawing.Point(12, 119);
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(317, 23);
			this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
			this.progressBar.TabIndex = 1;
			// 
			// frmWorkingDialog
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(337, 157);
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
			this.TopMost = true;
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lblWorkingMessage;
		private System.Windows.Forms.ProgressBar progressBar;
	}
}