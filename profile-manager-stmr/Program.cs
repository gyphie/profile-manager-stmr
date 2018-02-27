using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using JR.Utils.GUI.Forms;
using net.glympz.ProfileManagerSTMR.Business;

namespace spintires_mudrunner_profile_manager
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			try
			{
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run(new frmMainWindow());
			}
			catch (Exception ex)
			{
				FlexibleMessageBox.Show(
					text: ex.FormatForMessageBox("There was an unhandled error and the program crashed. There program will exit. Here's some info about the error:"),
					caption: "Program crashed!",
					buttons: MessageBoxButtons.OK,
					icon: MessageBoxIcon.Error
				);
			}
		}
	}
}
