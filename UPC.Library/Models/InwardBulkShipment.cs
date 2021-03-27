using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPC.Library.Models
{
	public class InwardBulkShipment
	{
		public DateTime Date { get; set; }

		[DisplayName("Courier Name")]
		public string CourierName { get; set; }

		[DisplayName("Tracking Id")]
		public string TrackingId { get; set; }

		public string Remarks { get; set; }

	}
}
