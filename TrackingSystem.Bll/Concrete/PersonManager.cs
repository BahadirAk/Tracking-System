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
	public class PersonManager : IPersonManager
	{
		private IPersonDal _personDal;
		public PersonManager(IPersonDal personDal)
		{
			_personDal = personDal;
		}
		public List<PersonEntity> GetAll()
		{
			var result = _personDal.GetAll();
			return result;
		}
		public PersonEntity GetPersonByUsernameAndPassword(string username, string password)
		{
			return _personDal.GetPersonByUsernameAndPassword(username, password);
		}

		public string GetNameById(int id)
		{
			return _personDal.GetNameById(id);
		}
		public List<PersonEntity> GetByTeam(string team)
		{
			return _personDal.GetByTeam(team);
		}
	}
}
