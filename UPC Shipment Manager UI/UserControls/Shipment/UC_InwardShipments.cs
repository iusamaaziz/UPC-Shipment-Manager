using System;
using System.Windows.Forms;

namespace UPC_Shipment_Manager_UI.UserControls.ShipmentManager
{
	public partial class UC_InwardShipments : UserControl
	{
		UC_SingleInward si;
		public UC_InwardShipments()
		{
			InitializeComponent();
			si = new UC_SingleInward();
		}

		private void ActivateControls(UserControl uc)
		{
			Canva.Controls.Clear();
			uc.Dock = DockStyle.Fill;
			Canva.Controls.Add(uc);
		}

		private void SingleShipments_Click(object sender, EventArgs e)
		{
			(this.Parent.Parent as UC_ShipmentManager).NavTitle.Text = "UPC Inventory Manager → Inwards → Single Shipment";
			ActivateControls(si);

		}
	}
}
