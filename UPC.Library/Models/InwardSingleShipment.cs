using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPC.Library.Models
{
	public class InwardSingleShipment
	{
		public DateTime Date { get; set; }

		[DisplayName("Tracking ID")]
		public string TrackingId { get; set; }
		[DisplayName("Courier name")]
		public string CourierName { get; set; }

		[DisplayName("Item Name")]
		public string ItemName { get; set; }

		[DisplayName("Item Condition")]
		public string ItemCondition { get; set; }

		public string Remarks { get; set; }

		/// <summary>
		/// Inward/Outward
		/// </summary>
		[DisplayName("Shipment Type")]
		public string ShipmentType { get; set; }

	}
}
