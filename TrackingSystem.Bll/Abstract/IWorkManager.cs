using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackingSystem.Entities;

namespace TrackingSystem.Bll.Abstract
{
	public interface IWorkManager : IBaseManager<WorkEntity>
	{
		List<WorkEntity> GetByPerson(string personFullname);
		WorkEntity GetByName(string workName);
		List<WorkEntity> GetToDoWorksByName(string workName);
	}
}
