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

		public static void InsertInventoryOut(InventoryItem item)
		{
			List<SqlParameter> parameters = new List<SqlParameter>
			{
				new SqlParameter("@name", item.ItemName),
				new SqlParameter("@godown", item.Godown),
				new SqlParameter("@quantity", item.Quantity),
				new SqlParameter("@remarks", item.Remarks),
				new SqlParameter("@date", item.TransactionDate),
				new SqlParameter("@type", "Single")
			};
			Access.ExecuteProcedure("[dbo].[InsertInventoryOut]", parameters.ToArray());
		}

		public static void InsertPicklistItem(InventoryItem item)
		{
			List<SqlParameter> parameters = new List<SqlParameter>
			{
				new SqlParameter("@name", item.ItemName),
				new SqlParameter("@godown", item.Godown),
				new SqlParameter("@quantity", item.Quantity),
				new SqlParameter("@remarks", item.Remarks),
				new SqlParameter("@date", item.TransactionDate),
				new SqlParameter("@type", "Picklist")
			};
			Access.ExecuteProcedure("[dbo].[InsertInventoryOut]", parameters.ToArray());
		}

		public static void InsertGodown(string godown)
		{
			List<SqlParameter> parameters = new List<SqlParameter>
			{
				new SqlParameter("@godown", godown)
			};
			Access.ExecuteProcedure("[dbo].[InsertGodown]", parameters.ToArray());
		}

		public static async Task<int> GetQuantityByItemAsync(string itemName, string godown)
		{
			SqlParameter[] parameters = {
				new SqlParameter("@name", itemName),
				new SqlParameter("@godown", godown)
			};
			return await Access.GetIntAsync("SELECT [dbo].[GetQuantityByItem](@name, @godown)", parameters);
		}

		public static async Task<DataTable> GetInventoryDetailsAsync()
		{
			return await Access.GetDataTableAsync("SELECT * FROM [dbo].[GetLast30InventoryInTransactions]()");
		}

		public static async Task<InventoryItem[]> GetGodownStockAsync(string godown)
		{
			List<SqlParameter> parameters = new List<SqlParameter>
			{
				new SqlParameter("@godown", godown)
			};
			return await Access.GetInventoryItemsAsync("SELECT * FROM [dbo].[GetGodownStock](@godown)", parameters.ToArray());
		}

		public static async Task<InventoryItem[]> GetItemStockAsync(string itemName)
		{
			List<SqlParameter> parameters = new List<SqlParameter>
			{
				new SqlParameter("@name", itemName)
			};
			return await Access.GetInventoryItemsAsync("SELECT * FROM [dbo].[GetItemStock](@name)", parameters.ToArray());
		}

		public static async Task<InventoryItem[]> GetItemCheckInsAsync(string itemName)
		{
			List<SqlParameter> parameters = new List<SqlParameter>
			{
				new SqlParameter("@name", itemName)
			};
			return await Access.GetInventoryItemsAsync("SELECT * FROM [dbo].[GetItemCheckIns](@name)", parameters.ToArray());
		}

		public static async Task<InventoryItem[]> GetItemCheckOutsAsync(string itemName)
		{
			List<SqlParameter> parameters = new List<SqlParameter>
			{
				new SqlParameter("@name", itemName)
			};
			return await Access.GetInventoryItemsAsync("SELECT * FROM [dbo].[GetItemCheckOuts](@name)", parameters.ToArray());
		}

		public static async Task<InventoryItem[]> GetPastPicklistsAsync()
		{
			//List<SqlParameter> parameters = new List<SqlParameter>
			//{
			//	new SqlParameter("@name", itemName)
			//};
			return await Access.GetInventoryItemsAsync("SELECT * FROM [dbo].[GetPastPicklists]()");
		}

		public static async Task<DataTable> GetLast30InventoryCheckoutsAsync()
		{
			return await Access.GetDataTableAsync("SELECT * FROM [dbo].[GetLast30InventoryCheckouts]()");
		}

		public static async Task<string[]> GetGodownsByItemAsync(string itemName)
		{
			SqlParameter[] parameters = { new SqlParameter("@item", itemName) };
			return await Access.GetStringArrayAsync("SELECT * FROM [dbo].[GetGodownsByItem](@item)", parameters);
		}

		public static async Task<string[]> GetGodownsAsync()
		{
			return await Access.GetStringArrayAsync("SELECT * FROM [dbo].[GetGodowns]()");
		}

		public static async Task<bool> IsGodownExistsAsync(string godown)
		{
			SqlParameter[] parameters = { new SqlParameter("@godown", godown) };
			return await Access.GetBooleanAsync("SELECT [dbo].[IsGodownExists](@godown)", parameters);
		}

		public static async Task<AutoCompleteStringCollection> GetItemNames()
		{
			return await Access.GetAutoCompleteStringCollectionAsync("SELECT * FROM [dbo].[GetItemNames]()");
		}
	}
}
