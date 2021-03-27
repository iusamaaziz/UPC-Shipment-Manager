using System;
using System.Windows.Forms;

using UPC.Library.LoginModels;

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
			if (Login.Role == "Operator")
			{
				MessageBox.Show("Operators do not have access to this section. Please contact administrator for further details.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
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
