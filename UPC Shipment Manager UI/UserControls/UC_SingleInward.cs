using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPC_Shipment_Manager_UI.UserControls
{
	public partial class UC_SingleInward : UserControl
	{
		public UC_SingleInward()
		{
			InitializeComponent();
		}

		private void UC_SingleInward_Load(object sender, EventArgs e)
		{
			Date.Text = DateTime.Now.ToString();
		}
	}
}
