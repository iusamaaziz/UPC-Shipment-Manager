using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPC_Shipment_Manager_UI.UserControls.Inventory
{
	public partial class UC_Reports : UserControl
	{
		UC_GodownStock gs;
		public UC_Reports()
		{
			InitializeComponent();
			gs = new UC_GodownStock();
		}

		private void ActivateControl(UserControl uc)
		{
			Canva.Controls.Clear();
			uc.Dock = DockStyle.Fill;
			Canva.Controls.Add(uc);
		}

		private void ItemReports_Click(object sender, EventArgs e)
		{
			//ActivateControl(gs);
			(this.Parent.Parent as UC_InventoryManager).NavTitle.Text = "UPC Inventory Manager → Reports → Item Reports";
		}

		private void GodownStock_Click(object sender, EventArgs e)
		{
			ActivateControl(gs);
			(this.Parent.Parent as UC_InventoryManager).NavTitle.Text = "UPC Inventory Manager → Reports → Godown Stock";
		}
	}
}
