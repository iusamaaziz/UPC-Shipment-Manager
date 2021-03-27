using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using UPC.UIManager;

namespace UPC_Shipment_Manager_UI.UserControls.Shipment
{
	public partial class UC_ShipementReportDateRange : UserControl
	{
		public UC_ShipementReportDateRange()
		{
			InitializeComponent();
		}

		private async void Search_Click(object sender, EventArgs e)
		{
			inwardSingleShipmentBindingSource.DataSource = await ShipmentLibrary.GetShipmentsAsync(From.Value, To.Value);
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			GeneralManager.ExportDataGrid(dg);
		}
	}
}
