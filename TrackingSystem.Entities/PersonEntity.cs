using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingSystem.Entities
{
	[Table("Person")]
	public class PersonEntity
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string Name { get; set; }
		[Required]
		public string Surname { get; set; }
		[Required]
		public string Username { get; set; }
		[Required]
		public string Password { get; set; }
		public string Team { get; set; }

		public List<WorkEntity> Works { get; set; }
		public int TeamListEntityId { get; set; }
		public virtual TeamListEntity TeamListEntity { get; set; }
	}
}
