using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackingSystem.Entities;

namespace TrackingSystem.Dal.Abstract
{
	public interface IPersonDal
	{
		List<PersonEntity> GetAll();
		PersonEntity GetById(int id);
		string GetNameById(int id);
		List<PersonEntity> GetByTeamId(int id);
	}
}
