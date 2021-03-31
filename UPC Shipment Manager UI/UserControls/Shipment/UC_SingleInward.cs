using System;
using System.Text;
using System.Windows.Forms;

using UPC.Library.LoginModels;
using UPC.Library.Models;
using UPC.UIManager;
using UPC.UIManager.InventoryManager;

using UPC_Shipment_Manager_UI.Forms;

namespace UPC_Shipment_Manager_UI.UserControls
{
	public partial class UC_SingleInward : UserControl
	{
		public UC_SingleInward()
		{
			InitializeComponent();
			if (Login.Role == "Operator")
			{
				ShipmentDate.Enabled = false;
				ShipmentDate.Value = DateTime.Now;
			}
		}

		private bool IsValid
		{
			get
			{
				return (TrackingId.TextLength > 0 && ItemName.TextLength > 0 && CourierName.Text.Length > 0 && ItemCondition.Text.Length > 0);
			}
		}

		private void Clear()
		{
			ShipmentDate.Value = DateTime.Now;
			ItemName.Clear();
			Remarks.Clear();
			ItemCondition.SelectedIndex = -1;
			ItemCondition.Text = "";
			CourierName.SelectedIndex = -1;
			CourierName.Text = "";
			TrackingId.Clear();
			Register.Enabled = false;
			CourierName.Focus();
		}

		private void Tb_TextChanged(object sender, EventArgs e)
		{
			if (IsValid) Register.Enabled = true;
			else Register.Enabled = false;
		}

		private async void UC_SingleInward_Load(object sender, EventArgs e)
		{
			CourierName.Items.Clear();
			CourierName.Items.AddRange(await ShipmentLibrary.GetCourierNamesAsync());
			inwardSingleShipmentBindingSource.DataSource = await ShipmentLibrary.GetInwardShipmentsAsync();
			dg.ClearSelection();
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			GeneralManager.ExportDataGrid(dg);
		}

		private async void Register_Click(object sender, EventArgs e)
		{
			try
			{
				InwardSingleShipment si = new InwardSingleShipment() { CourierName = CourierName.Text, Date = ShipmentDate.Value, ItemCondition = ItemCondition.Text, ItemName = ItemName.Text, Remarks = Remarks.Text, TrackingId = TrackingId.Text, ShipmentType = "Inward", CustomerName = "N/A", PaymentType = "N/A", Amount = "N/A" };
				ShipmentLibrary.InsertInwardSingleShipment(si);
				Notification.Show("Shipment registered", Notification.Type.Success);
				Clear();
				inwardSingleShipmentBindingSource.DataSource = await ShipmentLibrary.GetInwardShipmentsAsync();
				dg.ClearSelection();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Failed to register shipment due to:\nException Type:{ex.GetType()}\nMessage:{ex.Message}", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private async void NewGodown_Click(object sender, EventArgs e)
		{
			using (FormNewCourierName f = new FormNewCourierName())
			{
				if (f.ShowDialog() == DialogResult.OK)
				{
					CourierName.Items.Clear();
					CourierName.Items.AddRange(await ShipmentLibrary.GetCourierNamesAsync());
				}
			}
		}
	}
}
