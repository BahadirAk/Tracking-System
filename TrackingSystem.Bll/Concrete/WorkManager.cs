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
	public class WorkManager : IWorkManager
	{
		private IWorkDal _workDal;
		public WorkManager(IWorkDal workDal)
		{
			_workDal = workDal;
		}

		public void Add(WorkEntity entity)
		{
			_workDal.Add(entity);
		}

		public void Delete(int id)
		{
			_workDal.Delete(id);
		}

		public List<WorkEntity> GetAll()
		{
			var result = _workDal.GetAll();
			return result;
		}

		public WorkEntity GetById(int id)
		{
			var result = _workDal.GetById(id);
			return result;
		}

		public List<WorkEntity> GetByPerson(string personFullname)
		{
			return _workDal.GetByPerson(personFullname);
		}

		public void Update(WorkEntity entity)
		{
			_workDal.Update(entity);
		}
	}
}
