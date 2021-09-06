using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackingSystem.Dal.Abstract;
using TrackingSystem.Entities;

namespace TrackingSystem.Dal.Concrete
{
	public class EfWorkListDal : IWorkListDal
	{
		private TrackingSystemContext _context;
		public EfWorkListDal(TrackingSystemContext context)
		{
			_context = context;
		}
		public List<WorkListEntity> GetWorkList()
		{
			return _context.WorkList.ToList();
		}

		public string GetNameById(int id)
		{
			return _context.WorkList.Find(id).Name;
		}
	}
}
