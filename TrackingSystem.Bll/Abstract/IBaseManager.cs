using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackingSystem.Dal.Abstract;

namespace TrackingSystem.Bll.Abstract
{
	public interface IBaseManager<T> : IBaseDal<T>
	{
		List<T> GetAll();
		T GetById(int id);
		void Add(T entity);
		void Delete(int id);
		void Update(T entity);
	}
}
