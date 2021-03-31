using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

using ExcelDataReader;

using UPC.Library.LoginModels;
using UPC.Library.Models;
using UPC.UIManager;

using UPC_Shipment_Manager_UI.Forms;

namespace UPC_Shipment_Manager_UI.UserControls
{
	public partial class UC_BulkInward : UserControl
	{
		ErrorProvider error = new ErrorProvider();
		List<string> TrackingIds = new List<string>();
		DataTableCollection tableCollection;

		public UC_BulkInward()
		{
			InitializeComponent();
			if (Login.Role == "Operator")
			{
				ShipmentDate.Enabled = false;
				ShipmentDate.Value = DateTime.Now;
			}
		}

		private void Clear()
		{
			ShipmentDate.Value = DateTime.Now;
			Remarks.Clear();
			CourierName.SelectedIndex = -1;
			CourierName.Text = "";
			CourierName.Focus();
			Register.Enabled = false;
		}

		private bool IsValid
		{
			get
			{
				return (CourierName.Text.Length > 0 && TrackingIds.Count > 0);
			}
		}

		private async Task<bool> IsValidTrackingIds()
		{
			foreach (var item in TrackingIds)
			{
				if (await ShipmentLibrary.IsTrackingIdExistsAsync(item))
					return false;
			}
			return true;
		}

		private void Tb_TextChanged(object sender, EventArgs e)
		{
			if (IsValid) Register.Enabled = true;
			else Register.Enabled = false;
		}

		private void pictureBox2_Click(object sender, System.EventArgs e)
		{
			GeneralManager.ExportDataGrid(dg);
		}

		private async void NewGodown_Click(object sender, System.EventArgs e)
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

		private async void UC_BulkInward_Load(object sender, System.EventArgs e)
		{
			CourierName.Items.Clear();
			CourierName.Items.AddRange(await ShipmentLibrary.GetCourierNamesAsync());
			inwardSingleShipmentBindingSource.DataSource = await ShipmentLibrary.GetInwardShipmentsAsync();
			dg.ClearSelection();
		}

		private void ImportTrackingId_Click(object sender, System.EventArgs e)
		{
			using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx|Excel 97-2003 Workbook|*.xls" })
			{
				ofd.Title = "Select a file to upload. (If file doesn't appears, change the file type.)";
				if (ofd.ShowDialog() == DialogResult.OK)
				{
					try
					{
						using (var stream = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read))
						{
							using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
							{
								DataSet result = reader.AsDataSet(new ExcelDataReader.ExcelDataSetConfiguration()
								{
									ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = false }
								});
								tableCollection = result.Tables;
							}
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message, Application.ProductName);
					}
				}
			}

			System.Data.DataTable dt = tableCollection[0];
			if (dt != null)
			{
				TrackingIds.Clear();
				for (int i = 0; i < dt.Rows.Count; i++)
				{
					TrackingIds.Add(dt.Rows[i][0].ToString());
				}
			}
			TrackingIdCount.Text = $"{TrackingIds.Count} tracking ids imported.";
		}

		private async void Register_Click(object sender, EventArgs e)
		{
			if (!(await IsValidTrackingIds()))
			{
				error.SetError(TrackingIdCount, "Some tracking ids already exist in database.");
				return;
			}
			else error.SetError(TrackingIdCount, "");
			try
			{
				foreach (var item in TrackingIds)
				{
					InwardSingleShipment si = new InwardSingleShipment() { CourierName = CourierName.Text, Date = ShipmentDate.Value, ItemCondition = "N/A", ItemName = "N/A", Remarks = Remarks.Text, TrackingId = item, ShipmentType = "Inward", CustomerName = "N/A", Amount = "N/A", PaymentType = "N/A" };
					ShipmentLibrary.InsertInwardSingleShipment(si);
				}
				Notification.Show("Registered", Notification.Type.Success);
				Clear();
				inwardSingleShipmentBindingSource.DataSource = await ShipmentLibrary.GetInwardShipmentsAsync();
				dg.ClearSelection();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Failed to register shipments due to:\nException Type:{ex.GetType()}\nMessage:{ex.Message}", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
