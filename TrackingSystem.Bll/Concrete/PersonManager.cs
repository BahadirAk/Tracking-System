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

		public PersonEntity GetById(int id)
		{
			return _personDal.GetById(id);
		}

		public string GetNameById(int id)
		{
			return _personDal.GetNameById(id);
		}
		public List<PersonEntity> GetByTeamId(int id)
		{
			return _personDal.GetByTeamId(id);
		}
	}
}
