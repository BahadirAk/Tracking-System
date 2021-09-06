using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackingSystem.Entities;

namespace TrackingSystem.Dal.Abstract
{
	public interface IWorkDal : IBaseDal<WorkEntity>
	{
		List<WorkEntity> GetByPerson(string personFullname);
	}
}
