using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackingSystem.Dal.Abstract;
using TrackingSystem.Entities;

namespace TrackingSystem.Dal.Concrete
{
	public class EfWorkDal : IWorkDal
	{
		private TrackingSystemContext _context;
		public EfWorkDal(TrackingSystemContext context)
		{
			_context = context;
		}

		public void Add(WorkEntity entity)
		{
			_context.Works.Add(entity);
			_context.SaveChanges();
		}

		public void Delete(int id)
		{
			_context.Works.Remove(_context.Works.FirstOrDefault(p => p.Id == id));
			_context.SaveChanges();
		}

		public List<WorkEntity> GetAll()
		{
			var result = _context.Works.ToList();
			return result;
		}

		public WorkEntity GetById(int id)
		{
			var result = _context.Works.Find(id);
			return result;
		}

		public List<WorkEntity> GetByPerson(string personFullname)
		{
			return _context.Works.Where(x => x.DoneBy == personFullname).ToList();
		}

		public void Update(WorkEntity entity)
		{
			var result = _context.Works.Find(entity.Id);
			result.Name = entity.Name;
			result.DoneBy = entity.DoneBy;
			result.IsToDo = entity.IsToDo;
			result.IsInProgress = entity.IsInProgress;
			result.IsDone = entity.IsDone;
			result.WorkStartedTime = entity.WorkStartedTime;
			result.WorkEndedTime = entity.WorkEndedTime;
			result.EnteredBy = entity.EnteredBy;
			result.EnteredTime = entity.EnteredTime;
			result.DoneBy = entity.DoneBy;
			result.AssignedBy = entity.AssignedBy;
			result.AssignedPerson = entity.AssignedPerson;
			_context.SaveChanges();
		}
	}
}
