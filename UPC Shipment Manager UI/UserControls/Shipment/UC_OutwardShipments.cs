using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using UPC_Shipment_Manager_UI.UserControls.ShipmentManager;

namespace UPC_Shipment_Manager_UI.UserControls.Shipment
{
	public partial class UC_OutwardShipments : UserControl
	{
		UC_SingleOutward so;
		UC_BulkOutward bo;
		public UC_OutwardShipments()
		{
			InitializeComponent();
			so = new UC_SingleOutward();
			bo = new UC_BulkOutward();
		}

		private void SingleShipments_Click(object sender, EventArgs e)
		{
			(this.Parent.Parent as UC_ShipmentManager).NavTitle.Text = "UPC Inventory Manager → Outwards → Single Shipment";
			ActivateControls(so);
		}

		private void ActivateControls(UserControl uc)
		{
			Canva.Controls.Clear();
			uc.Dock = DockStyle.Fill;
			Canva.Controls.Add(uc);
		}

		private void UC_OutwardShipments_Load(object sender, EventArgs e)
		{
			SingleShipments_Click(SingleShipments, e);
		}

		private void BulkShipments_Click(object sender, EventArgs e)
		{
			(this.Parent.Parent as UC_ShipmentManager).NavTitle.Text = "UPC Inventory Manager → Outward → Bulk Shipment";
			ActivateControls(bo);
		}
	}
}
