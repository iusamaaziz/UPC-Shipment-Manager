using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FontAwesome.Sharp;

using UPC_Shipment_Manager_UI.Forms;

namespace UPC_Shipment_Manager_UI.UserControls.Inventory
{
	public partial class UC_InventoryManager : UserControl
	{
		private UC_InventoryIn ii;
		private UC_InventoryOut io;
		private UC_Reports rep;

		public UC_InventoryManager()
		{
			InitializeComponent();
			ii = new UC_InventoryIn();
			io = new UC_InventoryOut();
			rep = new UC_Reports();
		}

		private void ActivateControl(UserControl c)
		{
			Canva.Controls.Clear();
			c.Dock = DockStyle.Fill;
			Canva.Controls.Add(c);
		}

		private void InventoryIn_Click(object sender, EventArgs e)
		{
			NavTitle.Text = "UPC Inventory Manager → Inventory In";
			ActivateControl(ii);
		}

		private void InventoryOut_Click(object sender, EventArgs e)
		{
			NavTitle.Text = "UPC Inventory Manager → Inventory Out";
			ActivateControl(io);
		}

		private void Reports_Click(object sender, EventArgs e)
		{
			NavTitle.Text = "UPC Inventory Manager → Reports";
			ActivateControl(rep);
		}

		private void Back_Click(object sender, EventArgs e)
		{
			(this.ParentForm as Dashboard).ActivateInitials();
		}

		private void UC_InventoryManager_Load(object sender, EventArgs e)
		{
			InventoryIn_Click(InventoryIn, e);
		}
	}
}
