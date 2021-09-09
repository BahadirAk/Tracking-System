using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingSystem.Entities
{
	[Table("Teams")]
	public class TeamListEntity
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string Name { get; set; }

		public virtual ICollection<PersonEntity> People { get; set; }
	}
}
