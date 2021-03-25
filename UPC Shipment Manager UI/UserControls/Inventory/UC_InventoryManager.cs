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

		public UC_InventoryManager()
		{
			InitializeComponent();
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
			ActivateControl(new UC_InventoryIn());
		}

		private void InventoryOut_Click(object sender, EventArgs e)
		{
			NavTitle.Text = "UPC Inventory Manager → Inventory Out";
			ActivateControl(new UC_InventoryOut());
		}

		private void Reports_Click(object sender, EventArgs e)
		{
			NavTitle.Text = "UPC Inventory Manager → Reports";
			ActivateControl(new UC_Reports());
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
