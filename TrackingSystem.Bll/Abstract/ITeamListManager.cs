using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackingSystem.Entities;

namespace TrackingSystem.Bll.Abstract
{
	public interface ITeamListManager
	{
		List<TeamListEntity> GetTeamList();
	}
}
