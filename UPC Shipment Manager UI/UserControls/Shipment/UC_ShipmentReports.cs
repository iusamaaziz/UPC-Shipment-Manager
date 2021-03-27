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
	public partial class UC_ShipmentReports : UserControl
	{
		public UC_ShipmentReports()
		{
			InitializeComponent();
		}

		private void Report_Click(object sender, EventArgs e)
		{
			(this.Parent.Parent as UC_ShipmentManager).NavTitle.Text = "UPC Shipment Manager → Reports → Date Range";
			ActivateControls(new UC_ShipementReportDateRange());
		}

		private void ActivateControls(UserControl uc)
		{
			Canva.Controls.Clear();
			uc.Dock = DockStyle.Fill;
			Canva.Controls.Add(uc);
		}

		private void Search_Click(object sender, EventArgs e)
		{
			(this.Parent.Parent as UC_ShipmentManager).NavTitle.Text = "UPC Shipment Manager → Inwards → Search Tracking Id";
			ActivateControls(new UC_SearchTrackingId());
		}

		private void UC_ShipmentReports_Load(object sender, EventArgs e)
		{
			Search_Click(Search, e);
		}
	}
}
