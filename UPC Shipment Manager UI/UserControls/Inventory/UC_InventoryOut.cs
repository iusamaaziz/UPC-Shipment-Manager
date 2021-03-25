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
using UPC.UIManager.InventoryManager;

using UPC_Shipment_Manager_UI.Reporting;

namespace UPC_Shipment_Manager_UI.UserControls.Inventory
{
	public partial class UC_InventoryOut : UserControl
	{
		ErrorProvider error = new ErrorProvider();
		public UC_InventoryOut()
		{
			InitializeComponent();
			dg.AutoGenerateColumns = false;
		}

		private async void UC_InventoryOut_Load(object sender, EventArgs e)
		{
			Godown.Items.Clear();
			PLGodown.Items.Clear();
			object[] items = await InventoryManager.GetGodownsAsync();
			Godown.Items.AddRange(items);
			PLGodown.Items.AddRange(items);
			ItemName.AutoCompleteCustomSource = await InventoryManager.GetItemNames();
			PLItemName.AutoCompleteCustomSource = await InventoryManager.GetItemNames();
			dg.DataSource = await InventoryManager.GetLast30InventoryCheckoutsAsync();
		}

		private void ResetSingle()
		{
			Godown.Enabled = false;
			Quantity.Enabled = false;
		}

		private void ResetPicklist()
		{
			PLGodown.Enabled = false;
			PLQuantity.Enabled = false;
		}

		private void ClearForPiclist()
		{
			PLItemName.Clear();
			PLGodown.Text = "";
			PLQuantity.ResetText();
			PLRemarks.Clear();
			PLTransactionDate.Value = DateTime.Now;
		}

		private bool IsValidSingle
		{
			get
			{
				if (ItemName.TextLength == 0)
				{
					error.SetError(ItemName, "Item name can't be empty.");
					return false;
				}
				error.SetError(ItemName, "");
				if (Godown.Text.Length == 0)
				{
					error.SetError(Godown, "Godown can't be empty.");
					return false;
				}
				error.SetError(Godown, "");
				if (Quantity.Value == 0)
				{
					error.SetError(Quantity, "Quantity can't be Zero.");
					return false;
				}
				error.SetError(Quantity, "");
				return true;
			}
		}

		private bool IsValidPicklist
		{
			get
			{
				if (PLItemName.TextLength == 0)
				{
					error.SetError(PLItemName, "Item name can't be empty.");
					return false;
				}
				error.SetError(PLItemName, "");
				if (PLGodown.Text.Length == 0)
				{
					error.SetError(PLGodown, "Godown can't be empty.");
					return false;
				}
				error.SetError(PLGodown, "");
				if (PLQuantity.Value == 0)
				{
					error.SetError(PLQuantity, "Quantity can't be Zero.");
					return false;
				}
				error.SetError(PLQuantity, "");
				return true;
			}
		}

		private async Task FillGodownsAsync()
		{
			Godown.Enabled = true;
			Godown.Items.Clear();
			Godown.Items.AddRange(await InventoryManager.GetGodownsByItemAsync(ItemName.Text));
		}

		private async Task FillPLGodownsAsync()
		{
			PLGodown.Enabled = true;
			PLGodown.Items.Clear();
			PLGodown.Items.AddRange(await InventoryManager.GetGodownsByItemAsync(PLItemName.Text));
		}

		private async Task LimitQuantityAsync()
		{
			Quantity.Maximum = await InventoryManager.GetQuantityByItemAsync(ItemName.Text, Godown.Text);
			Quantity.Enabled = true;
		}

		private async Task LimitPLQuantityAsync()
		{
			PLQuantity.Maximum = await InventoryManager.GetQuantityByItemAsync(PLItemName.Text, PLGodown.Text);
			PLQuantity.Enabled = true;
		}

		private async void ItemName_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter && ItemName.TextLength > 0)
			{
				Godown.Enabled = false;
				Quantity.Enabled = false;
				await FillGodownsAsync();
			}
		}

		private void ItemName_Click(object sender, EventArgs e)
		{
			(sender as TextBox).Clear();
		}

		private async void Checkout_Click(object sender, EventArgs e)
		{
			try
			{
				if (IsValidSingle)
				{
					InventoryItem item = new InventoryItem() { ItemName = ItemName.Text, Godown = Godown.Text, Quantity = Convert.ToInt32(Quantity.Value * -1), Remarks = Remarks.Text, TransactionDate = TransactionDate.Value };

					InventoryManager.InsertInventoryOut(item);
					MessageBox.Show("Checked out"); // UNDONE -- Notification
					ResetSingle();
					dg.DataSource = await InventoryManager.GetLast30InventoryCheckoutsAsync();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Could not check out inventory due to:\nException type: {ex.GetType()}\nMessage: {ex.Message}", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private async void Godown_SelectedIndexChanged(object sender, EventArgs e)
		{
			await LimitQuantityAsync();
		}

		private async void PLItemName_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter && PLItemName.TextLength > 0)
			{
				PLGodown.Enabled = false;
				PLQuantity.Enabled = false;
				await FillPLGodownsAsync();
			}
		}

		private async void PLGodown_SelectedIndexChanged(object sender, EventArgs e)
		{
			await LimitPLQuantityAsync();
		}

		private void AddToPicklist_Click(object sender, EventArgs e)
		{
			try
			{
				if (IsValidPicklist)
				{
					InventoryItem item = new InventoryItem() { ItemName = PLItemName.Text, Godown = PLGodown.Text, Quantity = Convert.ToInt32(PLQuantity.Value * -1), Remarks = PLRemarks.Text, TransactionDate = PLTransactionDate.Value };
					foreach (InventoryItem hell in inventoryItemBindingSource.List)
					{
						if (hell.ItemName == item.ItemName && hell.Godown == item.Godown)
						{
							hell.Quantity = item.Quantity; hell.Remarks = item.Remarks; hell.TransactionDate = item.TransactionDate;
							inventoryItemBindingSource.ResetBindings(false);
							ClearForPiclist();
							ResetPicklist();
							return;
						}
					}
					inventoryItemBindingSource.List.Add(item);
					ClearForPiclist();
					ResetPicklist();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Could not item to Picklist due to:\nException type: {ex.GetType()}\nMessage: {ex.Message}", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void CheckoutPicklist_Click(object sender, EventArgs e)
		{
			if (inventoryItemBindingSource.List.Count == 0)
			{
				MessageBox.Show("Picklist is empty. You can not checkout at the moment.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			try
			{

				foreach (InventoryItem item in inventoryItemBindingSource.List.OfType<InventoryItem>())
				{
					InventoryManager.InsertPicklistItem(item);
					// UNDONE -- Show notification
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Could not check out inventory picklist due to:\nException type: {ex.GetType()}\nMessage: {ex.Message}", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			if (TakePrintout.Checked)
			{
				using (FormPicklistPrintout frm = new FormPicklistPrintout(inventoryItemBindingSource.List.OfType<InventoryItem>().ToArray()))
				{
					frm.ShowDialog();
				}
			}
		}
	}
}
