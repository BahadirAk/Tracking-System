using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackingSystem.Dal.Abstract;
using TrackingSystem.Entities;

namespace TrackingSystem.Dal.Concrete
{
	public class EfPersonDal : IPersonDal
	{
		private TrackingSystemContext _context;
		public EfPersonDal(TrackingSystemContext context)
		{
			_context = context;
		}
		public List<PersonEntity> GetAll()
		{
			var result = _context.People.ToList();
			return result;
		}
		public PersonEntity GetPersonByUsernameAndPassword(string username, string password)
		{
			return _context.People.FirstOrDefault(x => x.Username == username && x.Password == password);
		}

		public string GetNameById(int id)
		{
			return _context.People.Find(id).Name + " " + _context.People.Find(id).Surname;
		}
		public List<PersonEntity> GetByTeam(string team)
		{
			return _context.People.Where(x => x.Team == team).ToList();
		}
	}
}
