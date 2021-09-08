using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackingSystem.Entities;
using TrackingSystem.Services;

namespace TrackingSystem.Forms
{
	public partial class LoginForm : Form
	{
		private LoginService _loginService;
		private PersonService _personService;
		private MenuForm _menuForm;
		public LoginForm(LoginService loginService, MenuForm menuForm, PersonService personService)
		{
			_menuForm = menuForm;
			_loginService = loginService;
			_personService = personService;
			InitializeComponent();
			fordOtosanLogoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
		}

		private void LoginForm_Load(object sender, EventArgs e)
		{
			loginUsernameTextBox.ResetText();
			loginPasswordTextBox.ResetText();
		}

		private void loginButton_Click(object sender, EventArgs e)
		{
			if (_loginService.Login(loginUsernameTextBox.Text, loginPasswordTextBox.Text) == true)
			{
				var result = _personService.GetPersonByUsernameAndPassword(loginUsernameTextBox.Text, loginPasswordTextBox.Text);
				MyCalimTypes.currentUser = result;

				_menuForm.Show();
				this.Hide();
			}
		}

		private void LoginUsernameTextBox_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				loginButton_Click(sender, e);
			}
		}

		private void LoginPasswordTextBox_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				loginButton_Click(sender, e);
			}
		}
	}
}
