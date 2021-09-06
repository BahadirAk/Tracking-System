using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackingSystem.Entities;
using TrackingSystem.Services;

namespace TrackingSystem.Forms
{
	public partial class StockForm : Form
	{
		private StockService _stockService;
		public StockForm(StockService stockService)
		{
			_stockService = stockService;
			InitializeComponent();
		}

		private void StockForm_Load(object sender, EventArgs e)
		{
			FillTheList();
		}

		private void menuStockButton_Click(object sender, EventArgs e)
		{
			_stockService.GetBackMenu();
			this.Hide();
		}

		private void exitStockButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			if(stockNameTextBox.Text != String.Empty && stockModelTextBox.Text != String.Empty && stockSerialNoTextbox.Text != String.Empty && stockQuantityTextBox.Text != String.Empty)
			{
				var result = _stockService.GetBySerialNumber(stockSerialNoTextbox.Text);
				if (result != null)
				{
						result.Name = stockNameTextBox.Text;
						result.Model = stockModelTextBox.Text;
						result.SerialNo = stockSerialNoTextbox.Text;
						result.Quantity = int.Parse(stockQuantityTextBox.Text);
						result.DataEntered = DateTime.Now;
						result.EnteredBy = MyCalimTypes.currentUser.Name + " " + MyCalimTypes.currentUser.Surname;
						_stockService.Save(result);
						MessageBox.Show("Stock saved!!!");
				}
				else
				{
					StockEntity data = new StockEntity();
					data.Name = stockNameTextBox.Text;
					data.Model = stockModelTextBox.Text;
					data.SerialNo = stockSerialNoTextbox.Text;
					data.Quantity = int.Parse(stockQuantityTextBox.Text);
					data.DataEntered = DateTime.Now;
					data.EnteredBy = MyCalimTypes.currentUser.Name + " " + MyCalimTypes.currentUser.Surname;
					_stockService.Save(data);
					MessageBox.Show("Stock saved!!!");
				}
				FillTheList();
				ResetTextBoxes();
			}
			else
			{
				MessageBox.Show("Please fill the required blanks!!!");
			}
		}

		private void deleteButton_Click(object sender, EventArgs e)
		{
			if(stockDataGridView.SelectedRows.Count != 0)
			{
				_stockService.Delete(Convert.ToInt32(stockDataGridView.CurrentRow.Cells[0].Value));
				MessageBox.Show("Stock deleted!!!");
				FillTheList();
				ResetTextBoxes();
			}
			else
			{
				MessageBox.Show("Please select the stock you want to delete!!!");
			}
		}

		void FillTheList()
		{
			stockDataGridView.DataSource = _stockService.GetStocks();
			stockDataGridView.CurrentCell.Selected = false;
			stockDataGridView.CurrentRow.Selected = false;
			stockDataGridView.Rows[0].Cells[0].Selected = false;
		}

		private void orderButton_Click(object sender, EventArgs e)
		{
			if(stockOrderTextBox.Text != string.Empty)
			{
				_stockService.Order(Convert.ToInt32(stockDataGridView.CurrentRow.Cells[0].Value), Convert.ToInt32(stockOrderTextBox.Text));
				FillTheList();
				ResetTextBoxes();
			}
			else
			{
				MessageBox.Show("Please enter the quantity you want order!!!");
			}
		}

		private void stockNameSearchTextBox_TextChanged(object sender, EventArgs e)
		{
			AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
			foreach(var item in _stockService.GetStocks())
			{
				collection.Add(item.Name).ToString();
				collection.Add(item.Model).ToString();
				collection.Add(item.SerialNo).ToString();
			}
			if(stockSearchTextBox.Text != String.Empty)
			{
				stockSearchTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
				stockSearchTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
				stockSearchTextBox.AutoCompleteCustomSource = collection;
				stockDataGridView.DataSource = _stockService.Search(stockSearchTextBox.Text);
			}
			else
			{
				FillTheList();
			}
		}

		private void stockDataGridView_cellClick(object sender, DataGridViewCellEventArgs e)
		{
			stockNameTextBox.Text = stockDataGridView.CurrentRow.Cells[1].Value.ToString();
			stockModelTextBox.Text = stockDataGridView.CurrentRow.Cells[2].Value.ToString();
			stockSerialNoTextbox.Text = stockDataGridView.CurrentRow.Cells[3].Value.ToString();
			stockQuantityTextBox.Text = stockDataGridView.CurrentRow.Cells[4].Value.ToString();
		}

		void ResetTextBoxes()
		{
			stockNameTextBox.ResetText();
			stockModelTextBox.ResetText();
			stockSerialNoTextbox.ResetText();
			stockQuantityTextBox.ResetText();
		}
	}
}
