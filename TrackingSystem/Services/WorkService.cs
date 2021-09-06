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
	public class WorkService
	{
		private IWorkManager _workManager;
		private IServiceProvider _services;
		private IWorkListManager _workListManager;
		private ITeamListManager _teamListManager;
		public WorkService(IWorkManager workManager, IServiceProvider services, IWorkListManager workListManager, ITeamListManager teamListManager)
		{
			_services = services;
			_workManager = workManager;
			_workListManager = workListManager;
			_teamListManager = teamListManager;
		}

		public List<WorkEntity> GetAll()
		{
			var result = _workManager.GetAll();
			return result;
		}

		public void GetBackMenu()
		{
			var a = _services.GetRequiredService<MenuForm>();
			a.Show();
		}

		public List<WorkListEntity> GetWorkList()
		{
			return _workListManager.GetWorkList();
		}

		public void Save(WorkEntity entity)
		{
			if(entity.Id == 0)
			{
				_workManager.Add(entity);
			}
			else
			{
				_workManager.Update(entity);
			}
		}

		public void Delete(int id)
		{
			_workManager.Delete(id);
		}

		public string GetNameById(int id)
		{
			return _workListManager.GetNameById(id);
		}

		public List<WorkEntity> ListByPerson(string personFullname)
		{
			return _workManager.GetByPerson(personFullname);
		}

		public List<TeamListEntity> GetTeamList()
		{
			return _teamListManager.GetTeamList();
		}
	}
}
