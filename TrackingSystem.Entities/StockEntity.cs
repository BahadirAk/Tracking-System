using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingSystem.Entities
{
	[Table("Stock")]
	public class StockEntity
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string Name { get; set; }
		[Required]
		public string Model { get; set; }
		[Required]
		public string SerialNo { get; set; }
		[Required]
		public int Quantity { get; set; }
		public DateTime? DataEntered { get; set; }

		public string EnteredBy { get; set; }
	}
}
