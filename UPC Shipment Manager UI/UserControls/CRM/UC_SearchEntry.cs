using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using UPC.Library.CRMModels;
using UPC.UIManager;

namespace UPC_Shipment_Manager_UI.UserControls.CRM
{
	public partial class UC_SearchEntry : UserControl
	{
		private int selectedId = -1;
		public UC_SearchEntry()
		{
			InitializeComponent();
		}

		private async void CustomerName_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter && CustomerName.TextLength > 0)
			{
				customerEntryBindingSource.DataSource = await CRMManager.GetCustomerEntriesAsync(CustomerName.Text);
			}
		}

		private async void UC_SearchEntry_Load(object sender, EventArgs e)
		{
			CustomerName.AutoCompleteCustomSource = await CRMManager.GetCustomerNamesAsync();
		}

		private void CustomerName_Click(object sender, EventArgs e)
		{
			(sender as TextBox).Clear();
		}

		private void Whatsapp_Click(object sender, EventArgs e)
		{
			if (!String.IsNullOrWhiteSpace(Phone.Text))
			{
				Process.Start($"https://wa.me/{Phone.Text}?text={WhatsappMessage.Text}");
			}
		}

		private void CloseEntry_Click(object sender, EventArgs e)
		{
			try
			{

				CRMManager.UpdateCustomerEntry(selectedId, "Closed");
				MessageBox.Show("The entry was successfully closed.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
				Clear();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Could not open entry due to:\nException type: {ex.GetType()}\nMessage: {ex.Message}", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void Clear()
		{
			foreach (var item in bunifuCards1.Controls.OfType<TextBox>())
			{
				item.Clear();
			}
			Marketplace.Text = "";
			CustomerName.Focus();
		}

		private void Display(CustomerEntry entry)
		{
			Customer.Text = entry.CustomerName;
			Phone.Text = entry.Phone;
			Email.Text = entry.Email;
			Query.Text = entry.Query;
			OrderDate.Text = entry.OrderDate;
			Product.Text = entry.Product;
			Marketplace.Text = entry.MarketPlace;
			OrderNumber.Text = entry.OrderNumber;
			Action.Text = entry.Action;
			WhatsappMessage.Text = entry.WhatsappMessage;
			selectedId = entry.Id;
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			GeneralManager.ExportDataGrid(dg);
		}

		private void dg_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (dg.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != DBNull.Value && !String.IsNullOrEmpty(dg.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()))
			{
				CustomerEntry ent = customerEntryBindingSource.List[e.RowIndex] as CustomerEntry;
				Display(ent);
			}
		}
	}
}
