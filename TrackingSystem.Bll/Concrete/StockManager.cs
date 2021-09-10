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
	public class StockManager : IStockManager
	{
		private IStockDal _stockDal;
		public StockManager(IStockDal stockDal)
		{
			_stockDal = stockDal;
		}

		public void Add(StockEntity entity)
		{
			_stockDal.Add(entity);
		}

		public void Delete(int id)
		{
			_stockDal.Delete(id);
		}

		public List<StockEntity> GetAll()
		{
			var result = _stockDal.GetAll();
			return result;
		}

		public StockEntity GetById(int id)
		{
			var result = _stockDal.GetById(id);
			return result;
		}

		public StockEntity GetBySerialNo(string serialNo)
		{
			var result = _stockDal.GetBySerialNo(serialNo);
			return result;
		}

		public List<StockEntity> GetByFilter(string text)
		{
			var result = _stockDal.GetByFilter(text);
			return result;
		}

		public void IncreaseQuantity(int id, int quantity)
		{
			_stockDal.IncreaseQuantity(id, quantity);
		}

		public void DecreaseQuantity(int id, int quantity)
		{
			_stockDal.DecreaseQuantity(id, quantity);
		}

		public void Update(StockEntity entity)
		{
			_stockDal.Update(entity);
		}
	}
}
