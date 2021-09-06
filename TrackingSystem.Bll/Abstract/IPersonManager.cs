using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackingSystem.Entities;

namespace TrackingSystem.Bll.Abstract
{
	public interface IPersonManager
	{
		List<PersonEntity> GetAll();
		PersonEntity GetPersonByUsernameAndPassword(string username, string password);
		string GetNameById(int id);
		List<PersonEntity> GetByTeam(string team);
	}
}
