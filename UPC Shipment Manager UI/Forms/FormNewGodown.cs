using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using UPC.UIManager.InventoryManager;

namespace UPC_Shipment_Manager_UI.Forms
{
	public partial class FormNewGodown : Form
	{
		ErrorProvider error = new ErrorProvider();
		public FormNewGodown()
		{
			InitializeComponent();
		}

		private void Cancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private async void Register_Click(object sender, EventArgs e)
		{
			if (String.IsNullOrWhiteSpace(Godown.Text))
			{
				error.SetError(Godown, "Godown number can't be empty.");
				return;
			}
			if (await InventoryManager.IsGodownExistsAsync(Godown.Text))
			{
				error.SetError(Godown, "Godown number already exists in database.");
				return;
			}
			error.SetError(Godown, "");
			InventoryManager.InsertGodown(Godown.Text);
			this.DialogResult = DialogResult.OK;
			MessageBox.Show("Godown was successfully registered.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
