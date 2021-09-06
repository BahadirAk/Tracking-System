using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackingSystem.Bll.Abstract;
using TrackingSystem.Dal.Abstract;
using TrackingSystem.Entities;

namespace TrackingSystem.Bll.Concrete
{
	public class TeamListManager : ITeamListManager
	{
		private ITeamListDal _teamListDal;
		public TeamListManager(ITeamListDal teamListDal)
		{
			_teamListDal = teamListDal;
		}
		public List<TeamListEntity> GetTeamList()
		{
			return _teamListDal.GetTeamList();
		}
	}
}
