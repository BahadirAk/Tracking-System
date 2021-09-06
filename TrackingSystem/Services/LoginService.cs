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
	public class LoginService
	{
		private IPersonManager _personManager;
		public LoginService(IPersonManager personManager)
		{
			_personManager = personManager;
		}
		public bool Login(string username, string password)
		{
			if (username != string.Empty || password != string.Empty)
			{
				var user = _personManager.GetAll().Where(a => a.Username.Equals(username)).FirstOrDefault();
				if (user != null)
				{
					if (user.Password.Equals(password))
					{
						return true;
					}
					else
					{
						MessageBox.Show("Incorrect Password");
						return false;
					}
				}
				else
				{
					MessageBox.Show("Incorrect Username");
					return false;
				}
			}
			else
			{
				MessageBox.Show("Username and Password Required");
				return false;
			}
		}
	}
}
