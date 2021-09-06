using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackingSystem.Entities;

namespace TrackingSystem.Bll.Abstract
{
	public interface IStockManager : IBaseManager<StockEntity>
	{
		void Order(int id, int quantity);
		StockEntity GetBySerialNo(string SerialNo);
		List<StockEntity> GetByFilter(string text);
	}
}
