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
	public partial class WorkForm : Form
	{
		private WorkService _workService;
		private PersonService _personService;
		public WorkForm(WorkService workService, PersonService personService)
		{
			_personService = personService;
			_workService = workService;
			InitializeComponent();
		}

		private void WorkForm_Load(object sender, EventArgs e)
		{
			FillTheList();
			FillWorkNameComboBox();
			FillDoByComboBox();
			FillStatusComboBox();
			FillWorkListByPersonComboBox();
			FillWorKListByTeamComboBox();
		}

		private void workMenuButton_Click(object sender, EventArgs e)
		{
			_workService.GetBackMenu();
			this.Hide();
		}

		private void workExitButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		void FillDoByComboBox()
		{
			workDoByComboBox.DataSource = _personService.GetPeople();
			workDoByComboBox.ValueMember = "id";
			workDoByComboBox.DisplayMember = "Name";
			workDoByComboBox.AutoCompleteMode = AutoCompleteMode.Suggest;
			workDoByComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
			workDoByComboBox.SelectedIndex = -1; 
		}

		private void workDoByComboBoxFormat(object sender, ListControlConvertEventArgs e)
		{
			string name = ((PersonEntity)e.ListItem).Name;
			string surname = ((PersonEntity)e.ListItem).Surname;
			e.Value = name + " " + surname;
		}

		void FillStatusComboBox()
		{
			string[] status = { "To Do", "In Progress", "Done" };
			workStatusComboBox.DataSource = status;
			workStatusComboBox.SelectedIndex = -1;
		}

		void FillWorkNameComboBox()
		{
			workNameComboBox.DataSource = _workService.GetWorkList();
			workNameComboBox.ValueMember = "id";
			workNameComboBox.DisplayMember = "Name";
			workNameComboBox.AutoCompleteMode = AutoCompleteMode.Suggest;
			workNameComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
			workNameComboBox.SelectedIndex = -1;
		}

		private void workSaveButton_Click(object sender, EventArgs e)
		{
			WorkEntity data = new WorkEntity();
			data.Name = _workService.GetNameById(Convert.ToInt32(workNameComboBox.SelectedValue));
			data.EnteredBy = MyCalimTypes.currentUser.Name + " " + MyCalimTypes.currentUser.Surname;
			data.EnteredTime = DateTime.Now;
			data.AssignedPerson = _personService.GetNameById(Convert.ToInt32(workDoByComboBox.SelectedValue));
			if (workDoByComboBox.SelectedItem != null)
			{
				data.AssignedBy = MyCalimTypes.currentUser.Name + " " + MyCalimTypes.currentUser.Surname;
			}
			else
			{
				data.AssignedBy = null;
			}
			data.WorkStartedTime = workStartedTimeDateTimePicker.Value;
			data.WorkEndedTime = workEndedTimeDateTimePicker.Value;
			data.DoneBy = _personService.GetNameById(Convert.ToInt32(workDoByComboBox.SelectedValue));
			if (workStatusComboBox.SelectedItem.ToString() == "To Do")
			{
				data.IsToDo = true;
				data.IsInProgress = false;
				data.IsDone = false;
			}
			else if (workStatusComboBox.SelectedItem.ToString() == "In Progress")
			{
				data.IsToDo = false;
				data.IsInProgress = true;
				data.IsDone = false;
			}
			else
			{
				data.IsToDo = false;
				data.IsInProgress = false;
				data.IsDone = true;
			}
			_workService.Save(data);
			MessageBox.Show("Work saved!!!");
			FillTheList();
			workNameComboBox.ResetText();
			workStatusComboBox.ResetText();
		}

		private void deleteButton_Click(object sender, EventArgs e)
		{
			if (workToDoDataGridView.SelectedRows.Count != 0 || workInProgressDataGridView.SelectedRows.Count != 0 || workDoneDataGridView.SelectedRows.Count != 0)
			{
				_workService.Delete(Convert.ToInt32(workToDoDataGridView.CurrentRow.Cells[0].Value));
				_workService.Delete(Convert.ToInt32(workInProgressDataGridView.CurrentRow.Cells[0].Value));
				_workService.Delete(Convert.ToInt32(workDoneDataGridView.CurrentRow.Cells[0].Value));
				MessageBox.Show("Stock deleted!!!");
				//FillTheList();
			}
			//a
			else
			{
				MessageBox.Show("Please select the work you want to delete!!!");
			}
		}

		void FillTheToDOList()
		{
			workToDoDataGridView.DataSource = _workService.GetAll().Where(x => x.IsToDo == true).ToList();
			//workToDoDataGridView.Selected = -1;
			workInProgressDataGridView.DataSource = _workService.GetAll().Where(x => x.IsInProgress == true).ToList();
			workInProgressDataGridView.CurrentCell.Selected = false;
			workInProgressDataGridView.CurrentRow.Selected = false;
			workInProgressDataGridView.Rows[0].Cells[0].Selected = false;
			workDoneDataGridView.DataSource = _workService.GetAll().Where(x => x.IsDone == true).ToList();
			workDoneDataGridView.CurrentCell.Selected = false;
			workDoneDataGridView.CurrentRow.Selected = false;
			workDoneDataGridView.Rows[0].Cells[0].Selected = false;
		}

		void FillTheInProgressList()
		{

		}

		void FillTheDoneList()
		{

		}

		private void workToDoDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
		{
				workNameComboBox.Text = workToDoDataGridView.CurrentRow.Cells[1].Value.ToString();
				workDoByComboBox.Text = (workToDoDataGridView.CurrentRow.Cells[4].Value != null) ? workToDoDataGridView.CurrentRow.Cells[4].Value.ToString() : "";
				workStatusComboBox.Text = "To Do";
				workStartedTimeDateTimePicker.Value = (workToDoDataGridView.CurrentRow.Cells[6].Value != null) ? (DateTime)workToDoDataGridView.CurrentRow.Cells[6].Value : DateTime.Now;
				workEndedTimeDateTimePicker.Value = (workToDoDataGridView.CurrentRow.Cells[7].Value != null) ? (DateTime)workToDoDataGridView.CurrentRow.Cells[7].Value : DateTime.Now;
		}

		private void workInProgressDataGridView_cellClick(object sender, DataGridViewCellEventArgs e)
		{
			//workNameComboBox.Text = workInProgressDataGridView.CurrentRow.Cells[1].Value.ToString();
			//workDoByComboBox.Text = (workInProgressDataGridView.CurrentRow.Cells[4].Value != null) ? workInProgressDataGridView.CurrentRow.Cells[4].Value.ToString() : "";
			//workStatusComboBox.Text = "In Progress";
			//workStartedTimeDateTimePicker.Value = (workInProgressDataGridView.CurrentRow.Cells[6].Value != null) ? (DateTime)workInProgressDataGridView.CurrentRow.Cells[6].Value : DateTime.Now;
			//workEndedTimeDateTimePicker.Value = (workInProgressDataGridView.CurrentRow.Cells[7].Value != null) ? (DateTime)workInProgressDataGridView.CurrentRow.Cells[7].Value : DateTime.Now;
		}

		private void workDoneDataGridView_cellClick(object sender, DataGridViewCellEventArgs e)
		{
				workNameComboBox.Text = workDoneDataGridView.CurrentRow.Cells[1].Value.ToString();
				workDoByComboBox.Text = (workDoneDataGridView.CurrentRow.Cells[4].Value != null) ? workDoneDataGridView.CurrentRow.Cells[4].Value.ToString() : "";
				workStatusComboBox.Text = "Done";
				workStartedTimeDateTimePicker.Value = (workDoneDataGridView.CurrentRow.Cells[6].Value != null) ? (DateTime)workDoneDataGridView.CurrentRow.Cells[6].Value : DateTime.Now;
				workEndedTimeDateTimePicker.Value = (workDoneDataGridView.CurrentRow.Cells[7].Value != null) ? (DateTime)workDoneDataGridView.CurrentRow.Cells[7].Value : DateTime.Now;
		}

		private void undertakeButton_Click(object sender, EventArgs e)
		{

		}

		void FillWorkListByPersonComboBox()
		{
			workListByPersonComboBox.DataSource = _personService.GetPeople();
			workListByPersonComboBox.ValueMember = "id";
			workListByPersonComboBox.DisplayMember = "Name";
			workListByPersonComboBox.AutoCompleteMode = AutoCompleteMode.Suggest;
			workListByPersonComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
			workListByPersonComboBox.SelectedIndex = -1;
		}

		void FillWorKListByTeamComboBox()
		{
			workListByTeamComboBox.DataSource = _workService.GetTeamList();
			workListByTeamComboBox.ValueMember = "id";
			workListByTeamComboBox.DisplayMember = "Name";
			workListByTeamComboBox.AutoCompleteMode = AutoCompleteMode.Suggest;
			workListByTeamComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
			workListByTeamComboBox.SelectedIndex = -1;
		}

		private void workListByPersonComboBoxFormat(object sender, ListControlConvertEventArgs e)
		{
			string name = ((PersonEntity)e.ListItem).Name;
			string surname = ((PersonEntity)e.ListItem).Surname;
			e.Value = name + " " + surname;
		}

		private void workListByPerson_selectedIndexChanged(object sender, EventArgs e)
		{
			if (workListByPersonComboBox.SelectedIndex == -1)
			{
				FillTheList();
			}
			else
			{
				workToDoDataGridView.DataSource = _workService.ListByPerson(workListByPersonComboBox.Text).Where(x => x.IsToDo == true).ToList();
				workInProgressDataGridView.DataSource = _workService.ListByPerson(workListByPersonComboBox.Text).Where(x => x.IsInProgress == true).ToList();
				workDoneDataGridView.DataSource = _workService.ListByPerson(workListByPersonComboBox.Text).Where(x => x.IsDone == true).ToList();
			}
		}

		private void workListByTeam_selectedIndexChange(object sender, EventArgs e)
		{
			if (workListByTeamComboBox.SelectedIndex == -1)
			{
				FillTheList();
			}
			else
			{
				var people = _personService.GetByTeam(workListByTeamComboBox.Text);
				List<WorkEntity> toDOWorks = new List<WorkEntity>();
				List<WorkEntity> inProgressWorks = new List<WorkEntity>();
				List<WorkEntity> doneWorks = new List<WorkEntity>();
				for (int i = 0; i < people.Count; i++)
				{
					toDOWorks.AddRange(_workService.ListByPerson(people[i].Name + " " + people[i].Surname).Where(x => x.IsToDo == true).ToList());
					inProgressWorks.AddRange(_workService.ListByPerson(people[i].Name + " " + people[i].Surname).Where(x => x.IsInProgress == true).ToList());
					doneWorks.AddRange(_workService.ListByPerson(people[i].Name + " " + people[i].Surname).Where(x => x.IsDone == true).ToList());
				}
				workToDoDataGridView.DataSource = toDOWorks.ToList();
				workInProgressDataGridView.DataSource = inProgressWorks.ToList();
				workDoneDataGridView.DataSource = doneWorks.ToList();
				toDOWorks.Clear();
				inProgressWorks.Clear();
				doneWorks.Clear();
			}
		}

		private void workListOperationsResetButton_Click(object sender, EventArgs e)
		{
			workListByTeamComboBox.ResetText();
			workListByPersonComboBox.ResetText();
			FillTheList();
		}
	}
}
