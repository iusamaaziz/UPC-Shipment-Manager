using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using UPC.UIManager.InventoryManager;

namespace UPC_Shipment_Manager_UI.UserControls.Inventory
{
	public partial class UC_ItemReports : UserControl
	{
		public UC_ItemReports()
		{
			InitializeComponent();
		}

		private void ItemName_Click(object sender, EventArgs e)
		{
			ItemName.Clear();
		}

		private async void UC_ItemReports_Load(object sender, EventArgs e)
		{
			ItemName.AutoCompleteCustomSource = await InventoryManager.GetItemNames();
		}

		private async void ItemName_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter && ItemName.TextLength > 0)
			{
				inventoryItemBindingSource.DataSource = await InventoryManager.GetItemStockAsync(ItemName.Text);
				bindingSource1.DataSource = await InventoryManager.GetItemCheckInsAsync(ItemName.Text);
				bindingSource2.DataSource = await InventoryManager.GetItemCheckOutsAsync(ItemName.Text);
				Current.ClearSelection();
				InventoryIn.ClearSelection();
				InventoryOut.ClearSelection();
			}
		}
	}
}
