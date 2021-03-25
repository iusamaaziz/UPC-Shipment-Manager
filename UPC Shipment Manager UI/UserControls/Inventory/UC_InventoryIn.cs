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

using UPC_Shipment_Manager_UI.Forms;

namespace UPC_Shipment_Manager_UI.UserControls.Inventory
{
	public partial class UC_InventoryIn : UserControl
	{
		public UC_InventoryIn()
		{
			InitializeComponent();
		}

		private void Clear()
		{
			Godown.SelectedIndex = -1;
			ItemName.Clear();
			Quantity.ResetText();
			Remarks.Clear();
			TransactionDate.Value = DateTime.Now;
		}

		private void Godown_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private async void UC_InventoryIn_Load(object sender, EventArgs e)
		{
			Godown.Items.Clear();
			Godown.Items.AddRange(await InventoryManager.GetGodownsAsync());
			dg.DataSource = await InventoryManager.GetLast30InventoryInTransactionsAsync();
			dg.ClearSelection();
		}

		private void Register_Click(object sender, EventArgs e)
		{
			try
			{
				InventoryItem item = new InventoryItem() { ItemName = ItemName.Text, Godown = Godown.Text, Quantity = Convert.ToInt32(Quantity.Value), Remarks = Remarks.Text, TransactionDate = TransactionDate.Value };
				InventoryManager.InsertInventoryIn(item);
				MessageBox.Show("Added"); // UNDONE - Customize notification
				Clear();
				UC_InventoryIn_Load(this, e);
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Could not register inventory due to:\nException type: {ex.GetType()}\nMessage: {ex.Message}", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private async void NewGodown_Click(object sender, EventArgs e)
		{
			using (FormNewGodown f = new FormNewGodown())
			{
				if (f.ShowDialog() == DialogResult.OK)
				{
					Godown.Items.Clear();
					Godown.Items.AddRange(await InventoryManager.GetGodownsAsync());
				}
			}
		}
	}
}
