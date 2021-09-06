using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingSystem.Entities
{
	[Table("Work")]
	public class WorkEntity
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string Name { get; set; }
		public DateTime? EnteredTime { get; set; }
		public string EnteredBy { get; set; }
		public string AssignedPerson { get; set; }
		public string AssignedBy { get; set; }
		public DateTime? WorkStartedTime { get; set; }
		public DateTime? WorkEndedTime { get; set; }
		public string DoneBy { get; set; }
		public Boolean IsToDo { get; set; }
		public Boolean IsInProgress { get; set; }
		public Boolean IsDone { get; set; }

		public List<PersonEntity> People { get; set; }
	}
}
