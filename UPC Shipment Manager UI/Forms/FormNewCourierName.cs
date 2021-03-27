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
using UPC.UIManager.InventoryManager;

namespace UPC_Shipment_Manager_UI.Forms
{
	public partial class FormNewCourierName : Form
	{
		ErrorProvider error = new ErrorProvider();

		public FormNewCourierName()
		{
			InitializeComponent();
		}

		private void Cancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private async void Register_Click(object sender, EventArgs e)
		{
			if (String.IsNullOrWhiteSpace(Godown.Text))
			{
				error.SetError(Godown, "Courier name can't be empty.");
				return;
			}
			if (await ShipmentLibrary.IsCourierNameExistsAsync(Godown.Text))
			{
				error.SetError(Godown, "Courier name already exists in database.");
				return;
			}
			error.SetError(Godown, "");
			ShipmentLibrary.InsertCourierName(Godown.Text);
			this.DialogResult = DialogResult.OK;
			MessageBox.Show("Courier name was successfully registered.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
