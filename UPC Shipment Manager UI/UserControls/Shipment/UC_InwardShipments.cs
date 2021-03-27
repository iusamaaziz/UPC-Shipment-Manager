using System;
using System.Windows.Forms;

namespace UPC_Shipment_Manager_UI.UserControls.ShipmentManager
{
	public partial class UC_InwardShipments : UserControl
	{
		UC_SingleInward si;
		UC_BulkInward bi;
		public UC_InwardShipments()
		{
			InitializeComponent();
			si = new UC_SingleInward();
			bi = new UC_BulkInward();
		}

		private void ActivateControls(UserControl uc)
		{
			Canva.Controls.Clear();
			uc.Dock = DockStyle.Fill;
			Canva.Controls.Add(uc);
		}

		private void SingleShipments_Click(object sender, EventArgs e)
		{
			(this.Parent.Parent as UC_ShipmentManager).NavTitle.Text = "UPC Shipment Manager → Inwards → Single Shipment";
			ActivateControls(si);
		}

		private void UC_InwardShipments_Load(object sender, EventArgs e)
		{
			SingleShipments_Click(SingleShipments, e);
		}

		private void GodownStock_Click(object sender, EventArgs e)
		{
			(this.Parent.Parent as UC_ShipmentManager).NavTitle.Text = "UPC Shipment Manager → Inwards → Bulk Shipment";
			ActivateControls(bi);
		}
	}
}
