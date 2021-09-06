using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackingSystem.Services;

namespace TrackingSystem.Forms
{
	public partial class MenuForm : Form
	{
		private MenuService _menuService;
		public MenuForm(MenuService menuService)
		{
			_menuService = menuService;
			InitializeComponent();
			stockTrackingSystemPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
			workTrackingSystemPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
		}

		private void MenuForm_Load(object sender, EventArgs e)
		{

		}

		private void stockTrackingSystemPictureBox_Click(object sender, EventArgs e)
		{
			_menuService.GoToStockForm();
			this.Hide();
		}

		private void workTrackingSystemPictureBox_Click(object sender, EventArgs e)
		{
			_menuService.GoToWorkForm();
			this.Hide();
		}
	}
}
