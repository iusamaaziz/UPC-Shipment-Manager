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
	public partial class UC_SearchTrackingId : UserControl
	{
		public UC_SearchTrackingId()
		{
			InitializeComponent();
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			GeneralManager.ExportDataGrid(dg);
		}

		private async void UC_SearchTrackingId_Load(object sender, EventArgs e)
		{
			ItemName.AutoCompleteCustomSource = await ShipmentLibrary.GetTrackingIdsAsync();
		}

		private async void ItemName_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter && ItemName.TextLength > 0)
			{
				inwardSingleShipmentBindingSource.DataSource = await ShipmentLibrary.GetShipmentsByTrackingAsync(ItemName.Text);
			}
		}

		private void ItemName_Click(object sender, EventArgs e)
		{
			(sender as TextBox).Clear();
		}
	}
}
