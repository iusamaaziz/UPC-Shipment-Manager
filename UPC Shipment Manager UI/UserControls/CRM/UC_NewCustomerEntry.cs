using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPC_Shipment_Manager_UI.UserControls.CRM
{
	public partial class UC_NewCustomerEntry : UserControl
	{
		public UC_NewCustomerEntry()
		{
			InitializeComponent();
		}

		private void ActivateControl(UserControl c)
		{
			Canva.Controls.Clear();
			c.Dock = DockStyle.Fill;
			Canva.Controls.Add(c);
		}

		private void NewCustomer_Click(object sender, EventArgs e)
		{
			(this.Parent.Parent as UC_CRM).NavTitle.Text = "UPC CRM → New Customer Entry → New Customer";
			ActivateControl(new UC_NewCustomer());
		}

		private void ExistingCustomer_Click(object sender, EventArgs e)
		{
			(this.Parent.Parent as UC_CRM).NavTitle.Text = "UPC CRM → New Customer Entry → Existing Customer";
			ActivateControl(new UC_ExistingCustomerEntry());
		}

		private void UC_NewCustomerEntry_Load(object sender, EventArgs e)
		{
			NewCustomer_Click(this, e);
		}
	}
}
