using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace UPCData.Library
{
	public static class Access
	{

		public static void ExecuteProcedure(string storedProcedure, SqlParameterCollection parameters)
		{
			using (SqlConnection cnn = DB.SqlConnection)
			{
				SqlTransaction transaction = cnn.BeginTransaction("ExecuteProcedure");
				SqlCommand cmd = new SqlCommand(storedProcedure, cnn) { Transaction = transaction };
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

	}
}
