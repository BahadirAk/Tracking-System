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
			FillThePeopleComboBox();
		}

		private void loginButton_Click(object sender, EventArgs e)
		{
			if(loginPeopleComboBox.SelectedIndex != -1)
			{
				var result = loginPeopleComboBox.SelectedItem as PersonEntity;
				MyCalimTypes.currentUser = _personService.GetById(result.Id);
				_menuForm.Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("Please select the user!!!");
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

		void FillThePeopleComboBox()
		{
			loginPeopleComboBox.DataSource = _personService.GetPeople();
			loginPeopleComboBox.ValueMember = "id";
			loginPeopleComboBox.DisplayMember = "Name";
			loginPeopleComboBox.AutoCompleteMode = AutoCompleteMode.Suggest;
			loginPeopleComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
			loginPeopleComboBox.SelectedIndex = -1;
		}

		private void LoginPeopleComboBoxFormat(object sender, ListControlConvertEventArgs e)
		{
			string name = ((PersonEntity)e.ListItem).Name;
			string surname = ((PersonEntity)e.ListItem).Surname;
			e.Value = name + " " + surname;
		}
	}
}
