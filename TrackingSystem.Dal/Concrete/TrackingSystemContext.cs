using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackingSystem.Entities;

namespace TrackingSystem.Dal.Concrete
{
	public class TrackingSystemContext : DbContext
	{
		public TrackingSystemContext()
		{
			Database.Connection.ConnectionString = "Server=.;Database=TrackingSystemDb;Trusted_Connection=True";
		}
		public DbSet<PersonEntity> People { get; set; }
		public DbSet<StockEntity> Stocks { get; set; }
		public DbSet<WorkEntity> Works { get; set; }
		public DbSet<WorkListEntity> WorkList { get; set; }
		public DbSet<TeamListEntity> TeamList { get; set; }
	}
}
