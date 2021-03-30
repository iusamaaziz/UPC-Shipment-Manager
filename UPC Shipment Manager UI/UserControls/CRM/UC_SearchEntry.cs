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

namespace UPC_Shipment_Manager_UI.UserControls.CRM
{
	public partial class UC_SearchEntry : UserControl
	{
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
	}
}
