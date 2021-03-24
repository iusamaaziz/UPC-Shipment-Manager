using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using UPC.Library.InventoryModels;

using UPCData.Library;

namespace UPC.UIManager.InventoryManager
{
	public class InventoryManager
	{
		public static async Task InsertInventoryIn(InventoryItem item)
		{
			List<SqlParameter> parameters = new List<SqlParameter>();
			parameters.Add(new SqlParameter("", new object())); //TODO CREATE PARAMETERES
			Access.ExecuteProcedure("[dbo].[InsertInventoryIn]");
		}
	}
}
