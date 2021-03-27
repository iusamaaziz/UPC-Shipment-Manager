using System;
using System.Windows.Forms;

using UPC.Library.InventoryModels;
using UPC.Library.LoginModels;
using UPC.UIManager;
using UPC.UIManager.InventoryManager;

using UPC_Shipment_Manager_UI.Forms;

namespace UPC_Shipment_Manager_UI.UserControls.Inventory
{
	public partial class UC_InventoryIn : UserControl
	{
		ErrorProvider error = new ErrorProvider();
		public UC_InventoryIn()
		{
			InitializeComponent();
			if (Login.Role == "Operator")
			{
				TransactionDate.Enabled = false;
				TransactionDate.Value = DateTime.Now;
			}
		}

		private void Clear()
		{
			Godown.SelectedIndex = -1;
			ItemName.Clear();
			Quantity.ResetText();
			Remarks.Clear();
			TransactionDate.Value = DateTime.Now;
		}

		private bool IsValid
		{
			get
			{
				if (ItemName.TextLength == 0)
				{
					error.SetError(ItemName, "Item name can't be empty.");
					return false;
				}
				else error.SetError(ItemName, "");
				if (Godown.Text.Length == 0)
				{
					error.SetError(Godown, "Godown can't be empty.");
					return false;
				}
				else error.SetError(Godown, "");
				return true;
			}
		}

		private void Godown_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private async void UC_InventoryIn_Load(object sender, EventArgs e)
		{
			Godown.Items.Clear();
			Godown.Items.AddRange(await InventoryManager.GetGodownsAsync());
			dg.DataSource = await InventoryManager.GetInventoryDetailsAsync();
			dg.ClearSelection();
		}

		private void Register_Click(object sender, EventArgs e)
		{
			try
			{
				if (IsValid)
				{
					InventoryItem item = new InventoryItem() { ItemName = ItemName.Text, Godown = Godown.Text, Quantity = Convert.ToInt32(Quantity.Value), Remarks = Remarks.Text, TransactionDate = TransactionDate.Value };
					InventoryManager.InsertInventoryIn(item);
					MessageBox.Show("Added"); // UNDONE - Customize notification
					Clear();
					UC_InventoryIn_Load(this, e);
				}
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

		private void Export_Click(object sender, EventArgs e)
		{
			GeneralManager.ExportDataGrid(dg);
		}
	}
}
