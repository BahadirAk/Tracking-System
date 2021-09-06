using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackingSystem.Entities;

namespace TrackingSystem.ServiceLayer.Abstract
{
	public interface IWorkService : IBaseService<WorkEntity>
	{
		List<WorkEntity> GetByTeam();
		List<WorkEntity> GetByPerson();
	}
}
