using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using UPC.Library.InventoryModels;
using UPC.Library.LoginModels;
using UPC.Library.Models;
using UPC.Library.CRMModels;

namespace UPCData.Library
{
	public static class Access
	{
		public static void ExecuteProcedure(string storedProcedure, SqlParameter[] parameters = null)
		{
			using (SqlConnection cnn = DB.SqlConnection)
			{
				SqlTransaction transaction = cnn.BeginTransaction("ExecuteProcedure");
				SqlCommand cmd = new SqlCommand(storedProcedure, cnn) { Transaction = transaction, CommandType = CommandType.StoredProcedure };
				if (parameters != null)
					cmd.Parameters.AddRange(parameters);
				try
				{
					cmd.ExecuteNonQuery();
					transaction.Commit();
				}
				catch (Exception ex)
				{
					try
					{
						Console.WriteLine($"Commit Exception Type {ex.GetType()}");
						Console.WriteLine($"Commit Exception Message {ex.Message}");
						transaction.Rollback();
					}
					catch (Exception ex1)
					{
						Console.WriteLine($"Rollback Exception Type {ex1.GetType()}");
						Console.WriteLine($"Rollback Exception Message {ex1.Message}");
						throw ex1;
					}
				}
			}
		}

		/// <summary>
		/// Get a boolean value according to executed command
		/// </summary>
		/// <param name="command"></param>
		/// <param name=""></param>
		/// <param name="parameters"></param>
		/// <returns>returns false is result has now rows</returns>
		public static async Task<bool> GetBooleanAsync(string command, SqlParameter[] parameters = null)
		{
			using (SqlConnection cnn = await DB.GetSqlConnectionAsync())
			{
				SqlCommand cmd = new SqlCommand(command, cnn);
				if (parameters != null)
					cmd.Parameters.AddRange(parameters);
				SqlDataReader reader = await cmd.ExecuteReaderAsync();
				if (reader.HasRows)
				{
					while (await reader.ReadAsync())
					{
						return reader.GetBoolean(0);
					}
				}
				else return false;
			}
			return false;
		}

		public static async Task<int> GetIntAsync(string command, SqlParameter[] parameters = null)
		{
			using (SqlConnection cnn = await DB.GetSqlConnectionAsync())
			{
				SqlCommand cmd = new SqlCommand(command, cnn);
				if (parameters != null)
					cmd.Parameters.AddRange(parameters);
				SqlDataReader reader = await cmd.ExecuteReaderAsync();
				if (reader.HasRows)
				{
					while (await reader.ReadAsync())
					{
						return reader.GetInt32(0);
					}
				}
			}
			return -1;
		}

		public static int GetInt(string command, SqlParameter[] parameters = null)
		{
			using (SqlConnection cnn = DB.SqlConnection)
			{
				SqlCommand cmd = new SqlCommand(command, cnn);
				if (parameters != null)
					cmd.Parameters.AddRange(parameters);
				SqlDataReader reader = cmd.ExecuteReader();
				if (reader.HasRows)
				{
					while (reader.Read())
					{
						return reader.GetInt32(0);
					}
				}
			}
			return -1;
		}

		public static async Task<User> GetUserAsync(string command, SqlParameter[] parameters = null)
		{
			using (SqlConnection cnn = await DB.GetSqlConnectionAsync())
			{
				SqlCommand cmd = new SqlCommand(command, cnn);
				if (parameters != null)
					cmd.Parameters.AddRange(parameters);
				SqlDataReader reader = await cmd.ExecuteReaderAsync();
				if (reader.HasRows)
				{
					while (await reader.ReadAsync())
					{
						User user = new User()
						{
							Id = (int)reader["Id"],
							Username = (string)reader["Username"],
							Password = (string)reader["Password"],
							Role = (string)reader["Role"]
						};
						return user;
					}
				}
			}
			return null;
		}

		public static async Task<AutoCompleteStringCollection> GetAutoCompleteStringCollectionAsync(string command, SqlParameter[] parameters = null)
		{
			AutoCompleteStringCollection col = new AutoCompleteStringCollection();
			using (SqlConnection cnn = await DB.GetSqlConnectionAsync())
			{
				SqlCommand cmd = new SqlCommand(command, cnn);
				if (parameters != null)
					cmd.Parameters.AddRange(parameters);
				SqlDataReader reader = await cmd.ExecuteReaderAsync();
				if (reader.HasRows)
				{
					while (await reader.ReadAsync())
					{
						col.Add(reader[0].ToString());
					}
				}
			}
			return col;
		}

		public static async Task<string[]> GetStringArrayAsync(string command, SqlParameter[] parameters = null)
		{
			List<string> col = new List<string>();
			using (SqlConnection cnn = await DB.GetSqlConnectionAsync())
			{
				SqlCommand cmd = new SqlCommand(command, cnn);
				if (parameters != null)
					cmd.Parameters.AddRange(parameters);
				SqlDataReader reader = await cmd.ExecuteReaderAsync();
				if (reader.HasRows)
				{
					while (await reader.ReadAsync())
					{
						col.Add(reader[0].ToString());
					}
				}
			}
			return col.ToArray();
		}

		public static async Task<InventoryItem[]> GetInventoryItemsAsync(string command, SqlParameter[] parameters = null)
		{
			List<InventoryItem> col = new List<InventoryItem>();
			using (SqlConnection cnn = await DB.GetSqlConnectionAsync())
			{
				SqlCommand cmd = new SqlCommand(command, cnn);
				if (parameters != null)
					cmd.Parameters.AddRange(parameters);
				SqlDataReader reader = await cmd.ExecuteReaderAsync();
				if (reader.HasRows)
				{
					while (await reader.ReadAsync())
					{
						InventoryItem item = new InventoryItem()
						{
							Id = (int)reader["Id"],
							ItemName = reader["ItemName"].ToString(),
							Godown = reader["Godown"].ToString(),
							Quantity = (int)reader["Quantity"],
							TransactionDate = (DateTime)reader["TransactionDate"],
							Remarks = reader["Remarks"].ToString()
						};
						col.Add(item);
					}
				}
			}
			return col.ToArray();
		}

		public static async Task<InwardSingleShipment[]> GetInwardSingleShipmentsAsync(string command, SqlParameter[] parameters = null)
		{
			List<InwardSingleShipment> col = new List<InwardSingleShipment>();
			using (SqlConnection cnn = await DB.GetSqlConnectionAsync())
			{
				SqlCommand cmd = new SqlCommand(command, cnn);
				if (parameters != null)
					cmd.Parameters.AddRange(parameters);
				SqlDataReader reader = await cmd.ExecuteReaderAsync();
				if (reader.HasRows)
				{
					while (await reader.ReadAsync())
					{
						InwardSingleShipment ship = new InwardSingleShipment()
						{
							Date = (DateTime)reader["ShipmentDate"],
							ItemCondition = (string)reader["ItemCondition"],
							ItemName = (string)reader["ItemName"],
							Remarks = (string)reader["Remarks"],
							TrackingId = (string)reader["TrackingId"],
							CourierName = (string)reader["CourierName"],
							ShipmentType = (string)reader["ShipmentType"],
							CustomerName = (string)reader["CustomerName"]
						};
						col.Add(ship);
					}
				}
			}
			return col.ToArray();
		}

		public static async Task<DataTable> GetDataTableAsync(string command, SqlParameter[] parameters = null)
		{
			DataTable dt = new DataTable();
			using (SqlConnection cnn = await DB.GetSqlConnectionAsync())
			{
				SqlCommand cmd = new SqlCommand(command, cnn);
				if (parameters != null)
					cmd.Parameters.AddRange(parameters);
				SqlDataAdapter adapter = new SqlDataAdapter(cmd);
				adapter.Fill(dt);
			}
			return dt;
		}

		public static async Task<CustomerEntry[]> GetCustomerEntriesAsync(string command, SqlParameter[] parameters = null)
		{
			List<CustomerEntry> col = new List<CustomerEntry>();
			using (SqlConnection cnn = await DB.GetSqlConnectionAsync())
			{
				SqlCommand cmd = new SqlCommand(command, cnn);
				if (parameters != null)
					cmd.Parameters.AddRange(parameters);
				SqlDataReader reader = await cmd.ExecuteReaderAsync();
				if (reader.HasRows)
				{
					while (await reader.ReadAsync())
					{
						CustomerEntry item = new CustomerEntry()
						{
							Id = (int)reader["Id"],
							CustomerName = (string)reader["CustomerName"],
							Phone = (string)reader["Phone"],
							Email = (string)reader["Email"],
							Action = (string)reader["Action"],
							MarketPlace = (string)reader["MarketPlace"],
							OrderDate = (string)reader["OrderDate"],
							OrderNumber = (string)reader["OrderNumber"],
							Product = (string)reader["Product"],
							Query = (string)reader["Query"],
							Status = (string)reader["Status"],
							Type = (string)reader["Type"],
							WhatsappMessage = (string)reader["WhatsappMessage"]
						};
						col.Add(item);
					}
				}
			}
			return col.ToArray();
		}
	}
}
