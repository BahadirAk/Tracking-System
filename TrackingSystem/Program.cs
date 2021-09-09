using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackingSystem.Bll.Abstract;
using TrackingSystem.Bll.Concrete;
using TrackingSystem.Dal.Abstract;
using TrackingSystem.Dal.Concrete;
using TrackingSystem.Forms;
using TrackingSystem.Services;

namespace TrackingSystem
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			
			var host = CreateHostBuilder(args).Build();
			var form = (Form)host.Services.GetRequiredService(typeof(LoginForm));
			Application.Run(form);
		}

		public static IHostBuilder CreateHostBuilder(string[] args)
		{
			return Host.CreateDefaultBuilder(args).ConfigureLogging(options =>
			{
				options.ClearProviders();
				options.AddDebug();
			}).ConfigureAppConfiguration(config =>
			{
			}).ConfigureServices((hostContext, services) =>
			{
				services.Configure<Test>(hostContext.Configuration.GetSection("TestConfig"));
				services.AddTransient<LoginForm>();
				services.AddTransient<MenuForm>();
				services.AddTransient<StockForm>();
				services.AddTransient<WorkForm>();
				services.AddTransient<LoginService>();
				services.AddTransient<StockService>();
				services.AddTransient<MenuService>();
				services.AddTransient<WorkService>();
				services.AddTransient<PersonService>();
				services.AddTransient<IPersonManager, PersonManager>();
				services.AddTransient<IStockManager, StockManager>();
				services.AddTransient<IWorkManager, WorkManager>();
				services.AddTransient<IWorkListManager, WorkListManager>();
				services.AddTransient<ITeamListManager, TeamListManager>();
				services.AddTransient<IPersonDal, EfPersonDal>();
				services.AddTransient<IStockDal, EfStockDal>();
				services.AddTransient<IWorkDal, EfWorkDal>();
				services.AddTransient<IWorkListDal, EfWorkListDal>();
				services.AddTransient<ITeamListDal, EfTeamListDal>();
				services.AddTransient<TrackingSystemContext>();
				services.AddTransient<AutoCompleteStringCollection>();
			});
		}
	}
}
