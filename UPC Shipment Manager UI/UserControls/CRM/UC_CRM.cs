using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using UPC_Shipment_Manager_UI.UserControls.Inventory;

namespace UPC_Shipment_Manager_UI.UserControls.CRM
{
	public partial class UC_CRM : UserControl
	{
		public UC_CRM()
		{
			InitializeComponent();
		}

		private void ActivateControl(UserControl c)
		{
			Canva.Controls.Clear();
			c.Dock = DockStyle.Fill;
			Canva.Controls.Add(c);
		}

		private void NewEntry_Click(object sender, EventArgs e)
		{
			NavTitle.Text = "UPC CRM → New Customer Entry";
			ActivateControl(new UC_NewCustomerEntry());
		}

		private void SearchEntry_Click(object sender, EventArgs e)
		{
			NavTitle.Text = "UPC CRM → Search Existing Entry";
			ActivateControl(new UC_SearchEntry());
		}

		private void UC_CRM_Load(object sender, EventArgs e)
		{
			NewEntry_Click(this, e);
		}
	}
}
