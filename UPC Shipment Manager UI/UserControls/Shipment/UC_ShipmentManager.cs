using System;
using System.Windows.Forms;

using UPC_Shipment_Manager_UI.Forms;
using UPC_Shipment_Manager_UI.UserControls.Inventory;
using UPC_Shipment_Manager_UI.UserControls.Shipment;

namespace UPC_Shipment_Manager_UI.UserControls.ShipmentManager
{
	public partial class UC_ShipmentManager : UserControl
	{
		public UC_ShipmentManager()
		{
			InitializeComponent();
		}

		private void ActivateControl(UserControl c)
		{
			Canva.Controls.Clear();
			c.Dock = DockStyle.Fill;
			Canva.Controls.Add(c);
		}

		private void Back_Click(object sender, EventArgs e)
		{
			(this.ParentForm as Dashboard).ActivateInitials();
		}

		private void Inward_Click(object sender, EventArgs e)
		{
			NavTitle.Text = "UPC Inventory Manager → Inward Shipments";
			ActivateControl(new UC_InwardShipments());
		}

		private void Outward_Click(object sender, EventArgs e)
		{
			NavTitle.Text = "UPC Inventory Manager → Outward Shipments";
			ActivateControl(new UC_OutwardShipments());
		}

		private void Reports_Click(object sender, EventArgs e)
		{
			NavTitle.Text = "UPC Inventory Manager → Reports";
			ActivateControl(new UC_InventoryIn());
		}
	}
}
