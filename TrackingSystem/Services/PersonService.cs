using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackingSystem.Bll.Abstract;
using TrackingSystem.Entities;

namespace TrackingSystem.Services
{
	public class PersonService
	{
		private IPersonManager _personManager;
		public PersonService(IPersonManager personManager)
		{
			_personManager = personManager;
		}

		public List<PersonEntity> GetPeople()
		{
			var result = _personManager.GetAll();
			return result;
		}

		public PersonEntity GetPersonByUsernameAndPassword(string username, string password)
		{
			return _personManager.GetPersonByUsernameAndPassword(username, password);
		}

		public string GetNameById(int id)
		{
			return _personManager.GetNameById(id);
		}

		public List<PersonEntity> GetByTeam(string team)
		{
			return _personManager.GetByTeam(team);
		}
	}
}
