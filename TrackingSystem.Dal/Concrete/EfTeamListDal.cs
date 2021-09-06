using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackingSystem.Dal.Abstract;
using TrackingSystem.Entities;

namespace TrackingSystem.Dal.Concrete
{
	public class EfTeamListDal : ITeamListDal
	{
		private TrackingSystemContext _context;
		public EfTeamListDal(TrackingSystemContext context)
		{
			_context = context;
		}
		public List<TeamListEntity> GetTeamList()
		{
			return _context.TeamList.ToList();
		}
	}
}
