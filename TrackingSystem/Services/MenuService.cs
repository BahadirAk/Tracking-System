using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackingSystem.Forms;

namespace TrackingSystem.Services
{
	public class MenuService
	{
		private StockForm _stockForm;
		private WorkForm _workForm;
		public MenuService(StockForm stockForm, WorkForm workForm)
		{
			_workForm = workForm;
			_stockForm = stockForm;
		}

		public void GoToStockForm()
		{
			_stockForm.Show();
		}

		public void GoToWorkForm()
		{
			_workForm.Show();
		}
	}
}
