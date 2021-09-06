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
	public class WorkListManager : IWorkListManager
	{
		private IWorkListDal _workListDal;
		public WorkListManager(IWorkListDal workListDal)
		{
			_workListDal = workListDal;
		}
		public List<WorkListEntity> GetWorkList()
		{
			return _workListDal.GetWorkList();
		}
		public string GetNameById(int id)
		{
			return _workListDal.GetNameById(id);
		}
	}
}
