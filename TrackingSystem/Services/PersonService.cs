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

		public PersonEntity GetById(int id)
		{
			return _personManager.GetById(id);
		}

		public string GetNameById(int id)
		{
			return _personManager.GetNameById(id);
		}

		public List<PersonEntity> GetByTeamId(int id)
		{
			return _personManager.GetByTeamId(id);
		}
	}
}
