using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using UPC.Library.InventoryModels;

using UPCData.Library;
using System.Windows.Forms;
using System.Data;

namespace UPC.UIManager.InventoryManager
{
	public class InventoryManager
	{
		public static void InsertInventoryIn(InventoryItem item)
		{
			List<SqlParameter> parameters = new List<SqlParameter>
			{
				new SqlParameter("@name", item.ItemName),
				new SqlParameter("@godown", item.Godown),
				new SqlParameter("@quantity", item.Quantity),
				new SqlParameter("@remarks", item.Remarks),
				new SqlParameter("@date", item.TransactionDate),
			};
			Access.ExecuteProcedure("[dbo].[InsertInventoryItem]", parameters.ToArray());
		}

		public static void InsertGodown(string godown)
		{
			List<SqlParameter> parameters = new List<SqlParameter>
			{
				new SqlParameter("@godown", godown)
			};
			Access.ExecuteProcedure("[dbo].[InsertGodown]", parameters.ToArray());
		}

		public static async Task<DataTable> GetLast30InventoryInTransactionsAsync()
		{
			return await Access.GetDataTableAsync("SELECT * FROM [dbo].[GetLast30InventoryInTransactions]()");
		}

		public static async Task<string[]> GetGodownsByItemAsync(string itemName)
		{
			SqlParameter[] parameters = { new SqlParameter("@item", itemName) };
			return await Access.GetStringArrayAsync("SELECT * FROM [dbo].[GetGodownsByItem](@item)", parameters);
		}

		public static async Task<bool> IsGodownExistsAsync(string godown)
		{
			SqlParameter[] parameters = { new SqlParameter("@godown", godown) };
			return await Access.GetBooleanAsync("SELECT [dbo].[IsGodownExists](@godown)", parameters);
		}

		public static async Task<string[]> GetGodownsAsync()
		{
			return await Access.GetStringArrayAsync("SELECT * FROM [dbo].[GetGodowns]()");
		}
	}
}
