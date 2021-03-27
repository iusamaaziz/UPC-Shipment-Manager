using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPC.Library.Models;

using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

using UPCData.Library;

namespace UPC.UIManager
{
	public class ShipmentLibrary
	{
		public static void InsertInwardSingleShipment(InwardSingleShipment si)
		{
			List<SqlParameter> parameters = new List<SqlParameter>()
			{
				new SqlParameter("@date     ", si.Date),
				new SqlParameter("@tracking ", si.TrackingId),
				new SqlParameter("@courier  ", si.CourierName),
				new SqlParameter("@item     ", si.ItemName),
				new SqlParameter("@condition", si.ItemCondition),
				new SqlParameter("@remarks  ", si.Remarks),
				new SqlParameter("@type     ", si.ShipmentType),
				new SqlParameter("@customer ", si.CustomerName)
			};
			Access.ExecuteProcedure("[dbo].[InsertShipment]", parameters.ToArray());
		}

		public static void InsertCourierName(string name)
		{
			List<SqlParameter> parameters = new List<SqlParameter>()
			{
				new SqlParameter("@name", name)
			};
			Access.ExecuteProcedure("[dbo].[InsertCourierName]", parameters.ToArray());
		}

		public static async Task<InwardSingleShipment[]> GetInwardShipmentsAsync()
		{
			return await Access.GetInwardSingleShipmentsAsync("SELECT * FROM [dbo].[GetInwardShipments]()");
		}

		public static async Task<InwardSingleShipment[]> GetOutwardShipmentsAsync()
		{
			return await Access.GetInwardSingleShipmentsAsync("SELECT * FROM [dbo].[GetOutwardShipments]()");
		}

		public static async Task<string[]> GetCourierNamesAsync()
		{
			return await Access.GetStringArrayAsync("SELECT * FROM [dbo].[GetCourierNames]()");
		}

		public static async Task<bool> IsCourierNameExistsAsync(string godown)
		{
			SqlParameter[] parameters = { new SqlParameter("@name", godown) };
			return await Access.GetBooleanAsync("SELECT [dbo].[IsCourierNameExists](@name)", parameters);
		}
	}
}
