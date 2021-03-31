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
using UPC.Library.LoginModels;
using UPC.UIManager;

using UPC_Shipment_Manager_UI.Forms;
using UPC_Shipment_Manager_UI.UserControls.Inventory;

namespace UPC_Shipment_Manager_UI.UserControls.CRM
{
	public partial class UC_NewCustomer : UserControl
	{
		ErrorProvider error = new ErrorProvider();
		public UC_NewCustomer()
		{
			InitializeComponent();
		}

		private bool IsValid
		{
			get
			{
				if (CustomerName.TextLength == 0)
				{
					error.SetError(CustomerName, "Can't be empty"); return false;
				}
				else { error.SetError(CustomerName, ""); }
				if (Phone.TextLength == 0)
				{
					error.SetError(Phone, "Can't be empty"); return false;
				}
				else { error.SetError(Phone, ""); }
				if (Query.TextLength == 0)
				{
					error.SetError(Query, "Can't be empty"); return false;
				}
				else { error.SetError(Query, ""); }
				return true;
			}
		}

		private void Clear()
		{
			foreach (TextBox item in this.Controls.OfType<TextBox>())
			{
				item.Clear();
			}
			foreach (RichTextBox item in this.Controls.OfType<RichTextBox>())
			{
				item.Clear();
			}
			CustomerName.Focus();
		}

		private void Whatsapp_Click(object sender, EventArgs e)
		{
			if (!String.IsNullOrWhiteSpace(Phone.Text))
			{
				Process.Start($"https://wa.me/{Phone.Text}?text={WhatsappMessage.Text}");
			}
		}

		private void OpenEntry_Click(object sender, EventArgs e)
		{
			if (Login.Role == "Operator")
			{
				MessageBox.Show("Operators do not have access to open entries. Please contact administrator for further details.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			if (IsValid)
			{
				try
				{
					CRMManager.InsertNewCustomerEntry(new CustomerEntry()
					{
						CustomerName = CustomerName.Text,
						Phone = Phone.Text,
						Email = Email.Text,
						MarketPlace = "",
						OrderDate = "",
						Action = Action.Text,
						OrderNumber = "",
						Product = "",
						Query = Query.Text,
						Status = "Open",
						Type = "New",
						WhatsappMessage = WhatsappMessage.Text
					});
					Notification.Show("Entry Opened.", Notification.Type.Success);
					Clear();
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Could not open entry due to:\nException type: {ex.GetType()}\nMessage: {ex.Message}", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
		}
	}
}
