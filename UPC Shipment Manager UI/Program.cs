﻿using System;
using System.Collections.Generic;
using System.Linq;
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
			if (UserManager.GetUserCount() == 0)
			{
				Application.Run(new FormRegister());
			}
			else Application.Run(new FormLogin());
		}
	}
}
