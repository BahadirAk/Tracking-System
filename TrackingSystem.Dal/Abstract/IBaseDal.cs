using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingSystem.Dal.Abstract
{
	public interface IBaseDal<T>
	{
		List<T> GetAll();
		T GetById(int id);
		void Add(T entity);
		void Delete(int id);
		void Update(T entity);
	}
}
