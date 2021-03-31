using System;
using System.Windows.Forms;

using UPC.Library.InventoryModels;
using UPC.Library.LoginModels;
using UPC.UIManager.InventoryManager;

using UPC_Shipment_Manager_UI.Forms;

namespace UPC_Shipment_Manager_UI.UserControls.Inventory
{
	public partial class UC_ItemReports : UserControl
	{
		private bool IsTime = false;
		public UC_ItemReports()
		{
			InitializeComponent();
			if (Login.Role == "Operator")
			{
				Current.RowHeadersVisible = false;
				Current.ReadOnly = true;
			}
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
				IsTime = true;
			}
		}

		private void Current_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (IsTime)
			{
				InventoryItem item = inventoryItemBindingSource.List[e.RowIndex] as InventoryItem;
				InventoryManager.UpdateInventoryItem(item);
				Notification.Show("Item Updated", Notification.Type.Success);
			}
		}

		private async void Current_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete && e.Shift && Login.Role != "Operator")
			{
				DataGridViewRow row = Current.CurrentRow;
				if (row != null)
				{
					InventoryItem item = inventoryItemBindingSource.List[row.Index] as InventoryItem;
					InventoryManager.DeleteInventoryItem(item);
					MessageBox.Show($"{item.ItemName} was successfully deleted.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
}
