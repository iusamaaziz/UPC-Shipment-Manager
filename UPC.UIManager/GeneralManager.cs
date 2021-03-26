using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using UPCData.Library;

using Excel = Microsoft.Office.Interop.Excel;

namespace UPC.UIManager
{
	public class GeneralManager
	{
		public static void ExportDataGrid(DataGridView dataGridView1)
		{
			int rownum = 1;
			// intialize excel application
			var excelApp = new Excel.Application();
			excelApp.Visible = true;
			// creates a workbook
			Excel.Workbook excelbk = excelApp.Workbooks.Add(Type.Missing);
			//Add a Workseet named sheet1 to above workbook
			Excel.Worksheet xlWorkSheet1 = (Excel.Worksheet)excelbk.Worksheets["Sheet1"];

			//Add each column name of datagridview to the first row of Excel,
			//this will be the header text
			for (int colCount = 0; colCount < dataGridView1.Columns.Count; colCount++)
			{
				Excel.Range xlRange = (Excel.Range)xlWorkSheet1.Cells[rownum, colCount + 1];
				xlRange.Value2 = dataGridView1.Columns[colCount].HeaderText;
				xlRange.Font.Bold = true;
			}
			// for each row in the datagridview
			for (int rowCount = 0; rowCount < dataGridView1.Rows.Count; rowCount++)
			{
				//if the row is visible
				if (dataGridView1.Rows[rowCount].Visible == true)
				{
					//increment the row number for excel
					rownum = rownum + 1;
					for (int colCount = 0; colCount < dataGridView1.Columns.Count; colCount++)
					{
						//create a excel range for the rownum and the columncount
						Excel.Range xlRange = (Excel.Range)xlWorkSheet1.Cells[rownum, colCount + 1];
						try
						{
							//add the gridview cell value to the cellrange
							if (dataGridView1.Rows[rowCount].Cells[colCount].Value == null)
								dataGridView1.Rows[rowCount].Cells[colCount].Value = "";
							xlRange.Value2 =
							dataGridView1.Rows[rowCount].Cells[colCount].Value.ToString();
						}
						catch (Exception)
						{
							try
							{
								xlRange.Value2 = "";
							}
							catch (Exception)
							{

							}
						}
					}
				}
			}
		}

		public static async Task ExportDataGridAsync(DataGridView dataGridView1)
		{
			int rownum = 1;
			// intialize excel application
			var excelApp = new Excel.Application();
			excelApp.Visible = true;
			// creates a workbook
			Excel.Workbook excelbk = excelApp.Workbooks.Add(Type.Missing);
			//Add a Workseet named sheet1 to above workbook
			Excel.Worksheet xlWorkSheet1 = (Excel.Worksheet)excelbk.Worksheets["Sheet1"];

			//Add each column name of datagridview to the first row of Excel,
			//this will be the header text
			for (int colCount = 0; colCount < dataGridView1.Columns.Count; colCount++)
			{
				Excel.Range xlRange = (Excel.Range)xlWorkSheet1.Cells[rownum, colCount + 1];
				xlRange.Value2 = dataGridView1.Columns[colCount].HeaderText;
				xlRange.Font.Bold = true;
			}
			// for each row in the datagridview
			for (int rowCount = 0; rowCount < dataGridView1.Rows.Count; rowCount++)
			{
				//if the row is visible
				if (dataGridView1.Rows[rowCount].Visible == true)
				{
					//increment the row number for excel
					rownum = rownum + 1;
					for (int colCount = 0; colCount < dataGridView1.Columns.Count; colCount++)
					{
						//create a excel range for the rownum and the columncount
						Excel.Range xlRange = (Excel.Range)xlWorkSheet1.Cells[rownum, colCount + 1];
						try
						{
							//add the gridview cell value to the cellrange
							if (dataGridView1.Rows[rowCount].Cells[colCount].Value == null)
								dataGridView1.Rows[rowCount].Cells[colCount].Value = "";
							xlRange.Value2 =
							dataGridView1.Rows[rowCount].Cells[colCount].Value.ToString();
						}
						catch (Exception)
						{
							try
							{
								xlRange.Value2 = "";
							}
							catch (Exception)
							{

							}
						}
					}
				}
			}
		}

		public static bool IsConnected
		{
			get
			{
				try
				{
					Access.GetInt("SELECT COUNT(*) FROM [dbo].[Checkouts]");
					return true;
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Could not establish a connection to SQL Server due to:\nException Type:{ex.GetType()}\nMessage:{ex.Message}", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}
			}
		}
	}
}
