using System;
using System.Windows.Forms;

namespace UPC_Shipment_Manager_UI.UserControls.Inventory
{
	public partial class UC_Reports : UserControl
	{
		UC_GodownStock gs;
		UC_ItemReports ir;
		public UC_Reports()
		{
			InitializeComponent();
			gs = new UC_GodownStock();
			ir = new UC_ItemReports();
		}

		private void ActivateControl(UserControl uc)
		{
			Canva.Controls.Clear();
			uc.Dock = DockStyle.Fill;
			Canva.Controls.Add(uc);
		}

		private void ItemReports_Click(object sender, EventArgs e)
		{
			ActivateControl(ir);
			(this.Parent.Parent as UC_InventoryManager).NavTitle.Text = "UPC Inventory Manager → Reports → Item Reports";
		}

		private void GodownStock_Click(object sender, EventArgs e)
		{
			ActivateControl(gs);
			(this.Parent.Parent as UC_InventoryManager).NavTitle.Text = "UPC Inventory Manager → Reports → Godown Stock";
		}

		private void PastPicklists_Click(object sender, EventArgs e)
		{
			ActivateControl(new UC_PastPicklists());
			(this.Parent.Parent as UC_InventoryManager).NavTitle.Text = "UPC Inventory Manager → Reports → Past Picklists";
		}
	}
}
