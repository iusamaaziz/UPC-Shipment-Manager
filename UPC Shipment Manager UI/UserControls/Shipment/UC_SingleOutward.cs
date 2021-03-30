using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using UPC.Library.LoginModels;
using UPC.Library.Models;
using UPC.UIManager;

using UPC_Shipment_Manager_UI.Forms;

namespace UPC_Shipment_Manager_UI.UserControls.Shipment
{
	public partial class UC_SingleOutward : UserControl
	{
		public UC_SingleOutward()
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
				return (TrackingId.TextLength > 0 && ItemName.TextLength > 0 && CourierName.Text.Length > 0);
			}
		}

		private void Clear()
		{
			ShipmentDate.Value = DateTime.Now;
			ItemName.Clear();
			Remarks.Clear();
			CourierName.SelectedIndex = -1;
			CourierName.Text = "";
			TrackingId.Clear();
			Register.Enabled = false;
			Prepaid.Checked = true;
			CODAmount.ResetText();
			CustomerName.Clear();
			CourierName.Focus();
		}

		private void Tb_TextChanged(object sender, EventArgs e)
		{
			if (IsValid) Register.Enabled = true;
			else Register.Enabled = false;
		}

		private async void UC_SingleOutward_Load(object sender, EventArgs e)
		{
			CourierName.Items.Clear();
			CourierName.Items.AddRange(await ShipmentLibrary.GetCourierNamesAsync());
			inwardSingleShipmentBindingSource.DataSource = await ShipmentLibrary.GetOutwardShipmentsAsync();
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
				InwardSingleShipment si = new InwardSingleShipment() { CourierName = CourierName.Text, Date = ShipmentDate.Value, ItemCondition = "N/A", ItemName = ItemName.Text, Remarks = Remarks.Text, TrackingId = TrackingId.Text, CustomerName = CustomerName.Text, ShipmentType = "Outward", PaymentType = COD.Checked ? "COD" : "Prepaid", Amount = COD.Checked ? CODAmount.Value.ToString() : "N/A" };
				ShipmentLibrary.InsertInwardSingleShipment(si);
				MessageBox.Show("Shipment Registered", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
				Clear();
				inwardSingleShipmentBindingSource.DataSource = await ShipmentLibrary.GetOutwardShipmentsAsync();
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

		private void COD_CheckedChanged(object sender, EventArgs e)
		{
			if (COD.Checked)
			{
				CODLabel.Visible = true;
				CODAmount.Visible = true;
			}
			else
			{
				CODLabel.Visible = false;
				CODAmount.Visible = false;
			}
		}
	}
}
