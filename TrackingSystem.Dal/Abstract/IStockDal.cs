using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackingSystem.Entities;

namespace TrackingSystem.Dal.Abstract
{
	public interface IStockDal : IBaseDal<StockEntity>
	{
		void Order(int id, int quantity);
		StockEntity GetBySerialNo(string serialNo);
		List<StockEntity> GetByFilter(string text);
	}
}
