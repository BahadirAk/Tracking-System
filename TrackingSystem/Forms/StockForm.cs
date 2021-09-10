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
		private AutoCompleteStringCollection _collection;
		public StockForm(StockService stockService, AutoCompleteStringCollection collection)
		{
			_collection = collection;
			_stockService = stockService;
			InitializeComponent();
		}

		private void StockForm_Load(object sender, EventArgs e)
		{
			FillTheList();
			FillTheStockSearchTextBox_AutoCompleteMode();
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
			if(stockDataGridView.SelectedCells.Count != 0)
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

		private void stockNameSearchTextBox_TextChanged(object sender, EventArgs e)
		{
			if(stockSearchTextBox.Text != String.Empty)
			{
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
			stockChangeQuantityTextBox.ResetText();
		}

		void FillTheStockSearchTextBox_AutoCompleteMode()
		{
			foreach (var item in _stockService.GetStocks())
			{
				_collection.Add(item.Name).ToString();
				_collection.Add(item.Model).ToString();
				_collection.Add(item.SerialNo).ToString();
			}
			stockSearchTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			stockSearchTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
			stockSearchTextBox.AutoCompleteCustomSource = _collection;
		}

		private void stockIncreaseButton_Click_1(object sender, EventArgs e)
		{
			if (stockChangeQuantityTextBox.Text != string.Empty)
			{
				_stockService.IncreaseQuantity(Convert.ToInt32(stockDataGridView.CurrentRow.Cells[0].Value), Convert.ToInt32(stockChangeQuantityTextBox.Text));
				MessageBox.Show("The stock quantity is increased!!!");
				FillTheList();
				ResetTextBoxes();
			}
			else
			{
				MessageBox.Show("Please enter the quantity you want increase!!!");
			}
		}

		private void stockDecreaseButton_Click(object sender, EventArgs e)
		{
			if (stockChangeQuantityTextBox.Text != string.Empty)
			{
				_stockService.DecreaseQuantity(Convert.ToInt32(stockDataGridView.CurrentRow.Cells[0].Value), Convert.ToInt32(stockChangeQuantityTextBox.Text));
				MessageBox.Show("The stock quantity is decreased!!!");
				FillTheList();
				ResetTextBoxes();
			}
			else
			{
				MessageBox.Show("Please enter the quantity you want decrease!!!");
			}
		}
	}
}
