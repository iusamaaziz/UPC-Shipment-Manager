using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using UPC_Shipment_Manager_UI.Forms;

namespace UPC_Shipment_Manager_UI.UserControls
{
	public partial class UC_Outward : UserControl
	{
		public UC_Outward()
		{
			InitializeComponent();
		}

		private void ActivateControl(UserControl c)
		{
			Canva.Controls.Clear();
			c.Dock = DockStyle.Fill;
			Canva.Controls.Add(c);
		}

		private void Single_Clicked(object sender, EventArgs e)
		{
			NavTitle.Text = "Outward Shipments → Single shipment";
		}

		private void Bulk_Clicked(object sender, EventArgs e)
		{
			NavTitle.Text = "Outward Shipments → Bulk shipment";
		}

		private void Back_Click(object sender, EventArgs e)
		{
			(this.ParentForm as Dashboard).ActivateInitials();
		}
	}
}
