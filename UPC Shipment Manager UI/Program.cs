using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;

using UPC.UIManager.UserManager;

using UPC_Shipment_Manager_UI.Forms;
using UPC_Shipment_Manager_UI.Forms.Login;

namespace UPC_Shipment_Manager_UI
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.ThreadException += Application_ThreadException;
			AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
			try
			{
				if (UserManager.GetUserCount() == 0)
				{
					Application.Run(new FormRegister());
				}
				else Application.Run(new FormLogin());
			}
			catch (Exception ex)
			{
				if (MessageBox.Show($"Could not connect to SQL server due to:\n{ex.Message}\n\nDo you want to open server configuration?", Application.ProductName, MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					using (FormConfiguration frm = new FormConfiguration())
					{
						frm.ShowDialog();
					}
				}

			}
		}

		private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
		{
			MessageBox.Show((e.ExceptionObject as Exception).Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
		{
			MessageBox.Show(e.Exception.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}
}
