using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using UPC.Library.InventoryModels;
using UPC.UIManager;
using UPC.UIManager.InventoryManager;

using UPC_Shipment_Manager_UI.Reporting;

namespace UPC_Shipment_Manager_UI.UserControls.Inventory
{
	public partial class UC_GodownStock : UserControl
	{
		public UC_GodownStock()
		{
			InitializeComponent();
			dg.AutoGenerateColumns = false;
		}

		private async void UC_GodownStock_Load(object sender, EventArgs e)
		{
			Godown.Items.Clear();
			Godown.Items.AddRange(await InventoryManager.GetGodownsAsync());
		}

		private async void Godown_SelectedIndexChanged(object sender, EventArgs e)
		{
			inventoryItemBindingSource.DataSource = await InventoryManager.GetGodownStockAsync(Godown.Text);
		}

		private void Print_Click(object sender, EventArgs e)
		{
			using (FormGodownPrintout frm = new FormGodownPrintout(inventoryItemBindingSource.List.OfType<InventoryItem>().ToArray(), Godown.Text)) frm.ShowDialog();
		}

		private void Export_Click(object sender, EventArgs e)
		{
			GeneralManager.ExportDataGrid(dg);
		}
	}
}
