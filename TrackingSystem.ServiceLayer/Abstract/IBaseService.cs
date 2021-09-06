using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackingSystem.Bll.Abstract;

namespace TrackingSystem.ServiceLayer.Abstract
{
	public interface IBaseService<T> : IBaseManager<T>
	{
	}
}
