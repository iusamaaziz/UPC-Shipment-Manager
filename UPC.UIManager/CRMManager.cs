using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using UPC.Library.CRMModels;
using UPC.Library.Models;

using UPCData.Library;

namespace UPC.UIManager
{
	public class CRMManager
	{
		public static void InsertNewCustomerEntry(CustomerEntry si)
		{
			List<SqlParameter> parameters = new List<SqlParameter>()
			{

				new SqlParameter("@name", si.CustomerName),
				new SqlParameter("@phone", si.Phone),
				new SqlParameter("@email", si.Email),
				new SqlParameter("@market", si.MarketPlace),
				new SqlParameter("@order", si.OrderNumber),
				new SqlParameter("@date", si.OrderDate),
				new SqlParameter("@product", si.Product),
				new SqlParameter("@query", si.Query),
				new SqlParameter("@action", si.Action),
				new SqlParameter("@message", si.WhatsappMessage),
				new SqlParameter("@status", si.Status),
				new SqlParameter("@type", si.Type),
			};
			Access.ExecuteProcedure("[dbo].[InsertCustomerEntry]", parameters.ToArray());
		}

		public static void UpdateCustomerEntry(int id, string status)
		{
			List<SqlParameter> parameters = new List<SqlParameter>()
			{
				new SqlParameter("@id", id),
				new SqlParameter("@status", status),
			};
			Access.ExecuteProcedure("[dbo].[UpdateCustomerEntry]", parameters.ToArray());
		}

		public static async Task<CustomerEntry[]> GetCustomerEntriesAsync(string customer)
		{
			List<SqlParameter> parameters = new List<SqlParameter>()
			{

				new SqlParameter("@name", customer)
			};
			return await Access.GetCustomerEntriesAsync("SELECT * FROM [dbo].[GetEntriesByName](@name)", parameters.ToArray());
		}

		public static async Task<AutoCompleteStringCollection> GetCustomerNamesAsync()
		{
			return await Access.GetAutoCompleteStringCollectionAsync("SELECT * FROM [dbo].[GetCustomerNames]()");
		}

	}
}
