using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackingSystem.Dal.Abstract;
using TrackingSystem.Entities;

namespace TrackingSystem.Dal.Concrete
{
	public class EfStockDal : IStockDal
	{
		private TrackingSystemContext _context;
		public EfStockDal(TrackingSystemContext context)
		{
			_context = context;
		}

		public void Add(StockEntity entity)
		{
			_context.Stocks.Add(entity);
			_context.SaveChanges();
		}

		public void Delete(int id)
		{
			_context.Stocks.Remove(_context.Stocks.FirstOrDefault(p => p.Id == id));
			_context.SaveChanges();
		}

		public List<StockEntity> GetAll()
		{
			var result = _context.Stocks.ToList();
			return result;
		}

		public StockEntity GetById(int id)
		{
			var result = _context.Stocks.Find(id);
			return result;
		}

		public StockEntity GetBySerialNo(string serialNo)
		{
			var result = _context.Stocks.FirstOrDefault(x => x.SerialNo == serialNo);
			return result;
		}

		public List<StockEntity> GetByFilter(string text)
		{
			var result = _context.Stocks.Where(x => x.Name == text || x.Model == text || x.SerialNo == text).ToList();
			return result;
		}

		public void Order(int id, int quantity)
		{
			var result = _context.Stocks.Find(id);
			result.Quantity = result.Quantity - quantity;
			_context.SaveChanges();
		}

		public void Update(StockEntity entity)
		{
			var result = _context.Stocks.Find(entity.Id);
			result.Name = entity.Name;
			result.Model = entity.Model;
			result.SerialNo = entity.SerialNo;
			result.Quantity = entity.Quantity;
			result.DataEntered = entity.DataEntered;
			result.EnteredBy = entity.EnteredBy;
			_context.SaveChanges();
		}
	}
}
