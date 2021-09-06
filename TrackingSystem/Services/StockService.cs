using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackingSystem.Bll.Abstract;
using TrackingSystem.Entities;
using TrackingSystem.Forms;

namespace TrackingSystem.Services
{
	public class StockService
	{
		private IStockManager _stockManager;
		private IServiceProvider _services;
		public int orderId = 0;
		public StockService(IStockManager stockManager, IServiceProvider services)
		{
			_services = services;
			_stockManager = stockManager;
		}

		public List<StockEntity> GetStocks()
		{
			var result = _stockManager.GetAll();
			return result;
		}

		public void GetBackMenu()
		{
			var a = _services.GetRequiredService<MenuForm>();
			a.Show();
		}

		public void Save(StockEntity entity)
		{
			if(entity.Id == 0)
			{
				_stockManager.Add(entity);
			}
			else
			{
				_stockManager.Update(entity);
			}
		}
		public void Delete(int id)
		{
			_stockManager.Delete(id);
		}

		public void Order(int id, int quantity)
		{
			_stockManager.Order(id, quantity);
		}

		public List<StockEntity> Search(string text)
		{
			var result = _stockManager.GetByFilter(text);
			return result;
		}

		public StockEntity GetStockById(int id)
		{
			return _stockManager.GetById(id);
		}

		public StockEntity GetBySerialNumber(string serilNo)
		{
			return _stockManager.GetBySerialNo(serilNo);
		}
	}
}
