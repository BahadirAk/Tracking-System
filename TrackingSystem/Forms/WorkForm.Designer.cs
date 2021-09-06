
namespace TrackingSystem.Forms
{
	partial class WorkForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.workToDoLabel = new System.Windows.Forms.Label();
			this.workToDoDataGridView = new System.Windows.Forms.DataGridView();
			this.workInProgressDataGridView = new System.Windows.Forms.DataGridView();
			this.workDoneDataGridView = new System.Windows.Forms.DataGridView();
			this.workInProgressLabel = new System.Windows.Forms.Label();
			this.workDoneLabel = new System.Windows.Forms.Label();
			this.listByTeamLabel = new System.Windows.Forms.Label();
			this.listByPersonLabel = new System.Windows.Forms.Label();
			this.workListByTeamComboBox = new System.Windows.Forms.ComboBox();
			this.workListByPersonComboBox = new System.Windows.Forms.ComboBox();
			this.listOperationsGroupBox = new System.Windows.Forms.GroupBox();
			this.workListOperationsResetButton = new System.Windows.Forms.Button();
			this.workMenuButton = new System.Windows.Forms.Button();
			this.workExitButton = new System.Windows.Forms.Button();
			this.workNameComboBox = new System.Windows.Forms.ComboBox();
			this.workDoByComboBox = new System.Windows.Forms.ComboBox();
			this.workStatusComboBox = new System.Windows.Forms.ComboBox();
			this.workStartedTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.workEndedTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.workNameLabel = new System.Windows.Forms.Label();
			this.doByLabel = new System.Windows.Forms.Label();
			this.statusLabel = new System.Windows.Forms.Label();
			this.workStartedTime = new System.Windows.Forms.Label();
			this.workEndedTimeLabel = new System.Windows.Forms.Label();
			this.undertakeButton = new System.Windows.Forms.Button();
			this.workSaveButton = new System.Windows.Forms.Button();
			this.workOperationsGroupBox = new System.Windows.Forms.GroupBox();
			this.deleteButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.workToDoDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.workInProgressDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.workDoneDataGridView)).BeginInit();
			this.listOperationsGroupBox.SuspendLayout();
			this.workOperationsGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// workToDoLabel
			// 
			this.workToDoLabel.AutoSize = true;
			this.workToDoLabel.Location = new System.Drawing.Point(162, 265);
			this.workToDoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.workToDoLabel.Name = "workToDoLabel";
			this.workToDoLabel.Size = new System.Drawing.Size(41, 13);
			this.workToDoLabel.TabIndex = 0;
			this.workToDoLabel.Text = "TO DO";
			// 
			// workToDoDataGridView
			// 
			this.workToDoDataGridView.AllowUserToAddRows = false;
			this.workToDoDataGridView.AllowUserToDeleteRows = false;
			this.workToDoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.workToDoDataGridView.Location = new System.Drawing.Point(14, 281);
			this.workToDoDataGridView.Name = "workToDoDataGridView";
			this.workToDoDataGridView.ReadOnly = true;
			this.workToDoDataGridView.Size = new System.Drawing.Size(400, 393);
			this.workToDoDataGridView.TabIndex = 1;
			this.workToDoDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.workToDoDataGridView_CellClick);
			// 
			// workInProgressDataGridView
			// 
			this.workInProgressDataGridView.AllowUserToAddRows = false;
			this.workInProgressDataGridView.AllowUserToDeleteRows = false;
			this.workInProgressDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.workInProgressDataGridView.Location = new System.Drawing.Point(420, 281);
			this.workInProgressDataGridView.Name = "workInProgressDataGridView";
			this.workInProgressDataGridView.ReadOnly = true;
			this.workInProgressDataGridView.Size = new System.Drawing.Size(400, 393);
			this.workInProgressDataGridView.TabIndex = 2;
			this.workInProgressDataGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.workInProgressDataGridView_cellClick);
			// 
			// workDoneDataGridView
			// 
			this.workDoneDataGridView.AllowUserToAddRows = false;
			this.workDoneDataGridView.AllowUserToDeleteRows = false;
			this.workDoneDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.workDoneDataGridView.Location = new System.Drawing.Point(826, 281);
			this.workDoneDataGridView.Name = "workDoneDataGridView";
			this.workDoneDataGridView.ReadOnly = true;
			this.workDoneDataGridView.Size = new System.Drawing.Size(400, 393);
			this.workDoneDataGridView.TabIndex = 3;
			this.workDoneDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.workDoneDataGridView_cellClick);
			// 
			// workInProgressLabel
			// 
			this.workInProgressLabel.AutoSize = true;
			this.workInProgressLabel.Location = new System.Drawing.Point(580, 265);
			this.workInProgressLabel.Name = "workInProgressLabel";
			this.workInProgressLabel.Size = new System.Drawing.Size(81, 13);
			this.workInProgressLabel.TabIndex = 4;
			this.workInProgressLabel.Text = "IN PROGRESS";
			// 
			// workDoneLabel
			// 
			this.workDoneLabel.AutoSize = true;
			this.workDoneLabel.Location = new System.Drawing.Point(1004, 265);
			this.workDoneLabel.Name = "workDoneLabel";
			this.workDoneLabel.Size = new System.Drawing.Size(38, 13);
			this.workDoneLabel.TabIndex = 5;
			this.workDoneLabel.Text = "DONE";
			// 
			// listByTeamLabel
			// 
			this.listByTeamLabel.AutoSize = true;
			this.listByTeamLabel.Location = new System.Drawing.Point(1, 21);
			this.listByTeamLabel.Name = "listByTeamLabel";
			this.listByTeamLabel.Size = new System.Drawing.Size(74, 13);
			this.listByTeamLabel.TabIndex = 7;
			this.listByTeamLabel.Text = "List By Team :";
			// 
			// listByPersonLabel
			// 
			this.listByPersonLabel.AutoSize = true;
			this.listByPersonLabel.Location = new System.Drawing.Point(1, 69);
			this.listByPersonLabel.Name = "listByPersonLabel";
			this.listByPersonLabel.Size = new System.Drawing.Size(80, 13);
			this.listByPersonLabel.TabIndex = 8;
			this.listByPersonLabel.Text = "List By Person :";
			// 
			// workListByTeamComboBox
			// 
			this.workListByTeamComboBox.FormattingEnabled = true;
			this.workListByTeamComboBox.Location = new System.Drawing.Point(102, 18);
			this.workListByTeamComboBox.Name = "workListByTeamComboBox";
			this.workListByTeamComboBox.Size = new System.Drawing.Size(173, 21);
			this.workListByTeamComboBox.TabIndex = 10;
			this.workListByTeamComboBox.SelectedIndexChanged += new System.EventHandler(this.workListByTeam_selectedIndexChange);
			// 
			// workListByPersonComboBox
			// 
			this.workListByPersonComboBox.FormattingEnabled = true;
			this.workListByPersonComboBox.Location = new System.Drawing.Point(102, 66);
			this.workListByPersonComboBox.Name = "workListByPersonComboBox";
			this.workListByPersonComboBox.Size = new System.Drawing.Size(173, 21);
			this.workListByPersonComboBox.TabIndex = 0;
			this.workListByPersonComboBox.SelectedIndexChanged += new System.EventHandler(this.workListByPerson_selectedIndexChanged);
			this.workListByPersonComboBox.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.workListByPersonComboBoxFormat);
			// 
			// listOperationsGroupBox
			// 
			this.listOperationsGroupBox.Controls.Add(this.workListOperationsResetButton);
			this.listOperationsGroupBox.Controls.Add(this.workListByPersonComboBox);
			this.listOperationsGroupBox.Controls.Add(this.workListByTeamComboBox);
			this.listOperationsGroupBox.Controls.Add(this.listByPersonLabel);
			this.listOperationsGroupBox.Controls.Add(this.listByTeamLabel);
			this.listOperationsGroupBox.Location = new System.Drawing.Point(12, 12);
			this.listOperationsGroupBox.Name = "listOperationsGroupBox";
			this.listOperationsGroupBox.Size = new System.Drawing.Size(402, 110);
			this.listOperationsGroupBox.TabIndex = 12;
			this.listOperationsGroupBox.TabStop = false;
			this.listOperationsGroupBox.Text = "List Operations";
			// 
			// workListOperationsResetButton
			// 
			this.workListOperationsResetButton.Location = new System.Drawing.Point(298, 35);
			this.workListOperationsResetButton.Name = "workListOperationsResetButton";
			this.workListOperationsResetButton.Size = new System.Drawing.Size(98, 31);
			this.workListOperationsResetButton.TabIndex = 15;
			this.workListOperationsResetButton.Text = "Reset";
			this.workListOperationsResetButton.UseVisualStyleBackColor = true;
			this.workListOperationsResetButton.Click += new System.EventHandler(this.workListOperationsResetButton_Click);
			// 
			// workMenuButton
			// 
			this.workMenuButton.Location = new System.Drawing.Point(16, 164);
			this.workMenuButton.Name = "workMenuButton";
			this.workMenuButton.Size = new System.Drawing.Size(98, 31);
			this.workMenuButton.TabIndex = 13;
			this.workMenuButton.Text = "Menu";
			this.workMenuButton.UseVisualStyleBackColor = true;
			this.workMenuButton.Click += new System.EventHandler(this.workMenuButton_Click);
			// 
			// workExitButton
			// 
			this.workExitButton.Location = new System.Drawing.Point(189, 164);
			this.workExitButton.Name = "workExitButton";
			this.workExitButton.Size = new System.Drawing.Size(98, 31);
			this.workExitButton.TabIndex = 14;
			this.workExitButton.Text = "Exit";
			this.workExitButton.UseVisualStyleBackColor = true;
			this.workExitButton.Click += new System.EventHandler(this.workExitButton_Click);
			// 
			// workNameComboBox
			// 
			this.workNameComboBox.FormattingEnabled = true;
			this.workNameComboBox.Location = new System.Drawing.Point(80, 15);
			this.workNameComboBox.Name = "workNameComboBox";
			this.workNameComboBox.Size = new System.Drawing.Size(173, 21);
			this.workNameComboBox.TabIndex = 15;
			// 
			// workDoByComboBox
			// 
			this.workDoByComboBox.FormattingEnabled = true;
			this.workDoByComboBox.Location = new System.Drawing.Point(80, 63);
			this.workDoByComboBox.Name = "workDoByComboBox";
			this.workDoByComboBox.Size = new System.Drawing.Size(173, 21);
			this.workDoByComboBox.TabIndex = 16;
			this.workDoByComboBox.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.workDoByComboBoxFormat);
			// 
			// workStatusComboBox
			// 
			this.workStatusComboBox.FormattingEnabled = true;
			this.workStatusComboBox.Location = new System.Drawing.Point(80, 109);
			this.workStatusComboBox.Name = "workStatusComboBox";
			this.workStatusComboBox.Size = new System.Drawing.Size(173, 21);
			this.workStatusComboBox.TabIndex = 17;
			// 
			// workStartedTimeDateTimePicker
			// 
			this.workStartedTimeDateTimePicker.Location = new System.Drawing.Point(411, 37);
			this.workStartedTimeDateTimePicker.Name = "workStartedTimeDateTimePicker";
			this.workStartedTimeDateTimePicker.Size = new System.Drawing.Size(173, 20);
			this.workStartedTimeDateTimePicker.TabIndex = 18;
			// 
			// workEndedTimeDateTimePicker
			// 
			this.workEndedTimeDateTimePicker.Location = new System.Drawing.Point(411, 87);
			this.workEndedTimeDateTimePicker.Name = "workEndedTimeDateTimePicker";
			this.workEndedTimeDateTimePicker.Size = new System.Drawing.Size(173, 20);
			this.workEndedTimeDateTimePicker.TabIndex = 19;
			// 
			// workNameLabel
			// 
			this.workNameLabel.AutoSize = true;
			this.workNameLabel.Location = new System.Drawing.Point(9, 18);
			this.workNameLabel.Name = "workNameLabel";
			this.workNameLabel.Size = new System.Drawing.Size(41, 13);
			this.workNameLabel.TabIndex = 20;
			this.workNameLabel.Text = "Name :";
			// 
			// doByLabel
			// 
			this.doByLabel.AutoSize = true;
			this.doByLabel.Location = new System.Drawing.Point(9, 66);
			this.doByLabel.Name = "doByLabel";
			this.doByLabel.Size = new System.Drawing.Size(39, 13);
			this.doByLabel.TabIndex = 21;
			this.doByLabel.Text = "DoBy :";
			// 
			// statusLabel
			// 
			this.statusLabel.AutoSize = true;
			this.statusLabel.Location = new System.Drawing.Point(9, 112);
			this.statusLabel.Name = "statusLabel";
			this.statusLabel.Size = new System.Drawing.Size(43, 13);
			this.statusLabel.TabIndex = 22;
			this.statusLabel.Text = "Status :";
			// 
			// workStartedTime
			// 
			this.workStartedTime.AutoSize = true;
			this.workStartedTime.Location = new System.Drawing.Point(300, 44);
			this.workStartedTime.Name = "workStartedTime";
			this.workStartedTime.Size = new System.Drawing.Size(70, 13);
			this.workStartedTime.TabIndex = 23;
			this.workStartedTime.Text = "StartedTime :";
			// 
			// workEndedTimeLabel
			// 
			this.workEndedTimeLabel.AutoSize = true;
			this.workEndedTimeLabel.Location = new System.Drawing.Point(300, 94);
			this.workEndedTimeLabel.Name = "workEndedTimeLabel";
			this.workEndedTimeLabel.Size = new System.Drawing.Size(67, 13);
			this.workEndedTimeLabel.TabIndex = 24;
			this.workEndedTimeLabel.Text = "EndedTime :";
			// 
			// undertakeButton
			// 
			this.undertakeButton.Location = new System.Drawing.Point(303, 149);
			this.undertakeButton.Name = "undertakeButton";
			this.undertakeButton.Size = new System.Drawing.Size(98, 31);
			this.undertakeButton.TabIndex = 25;
			this.undertakeButton.Text = "Undertake";
			this.undertakeButton.UseVisualStyleBackColor = true;
			this.undertakeButton.Click += new System.EventHandler(this.undertakeButton_Click);
			// 
			// workSaveButton
			// 
			this.workSaveButton.Location = new System.Drawing.Point(411, 149);
			this.workSaveButton.Name = "workSaveButton";
			this.workSaveButton.Size = new System.Drawing.Size(98, 31);
			this.workSaveButton.TabIndex = 26;
			this.workSaveButton.Text = "Save";
			this.workSaveButton.UseVisualStyleBackColor = true;
			this.workSaveButton.Click += new System.EventHandler(this.workSaveButton_Click);
			// 
			// workOperationsGroupBox
			// 
			this.workOperationsGroupBox.Controls.Add(this.deleteButton);
			this.workOperationsGroupBox.Controls.Add(this.workSaveButton);
			this.workOperationsGroupBox.Controls.Add(this.undertakeButton);
			this.workOperationsGroupBox.Controls.Add(this.workEndedTimeLabel);
			this.workOperationsGroupBox.Controls.Add(this.workStartedTime);
			this.workOperationsGroupBox.Controls.Add(this.statusLabel);
			this.workOperationsGroupBox.Controls.Add(this.doByLabel);
			this.workOperationsGroupBox.Controls.Add(this.workNameLabel);
			this.workOperationsGroupBox.Controls.Add(this.workEndedTimeDateTimePicker);
			this.workOperationsGroupBox.Controls.Add(this.workStartedTimeDateTimePicker);
			this.workOperationsGroupBox.Controls.Add(this.workStatusComboBox);
			this.workOperationsGroupBox.Controls.Add(this.workDoByComboBox);
			this.workOperationsGroupBox.Controls.Add(this.workNameComboBox);
			this.workOperationsGroupBox.Location = new System.Drawing.Point(583, 12);
			this.workOperationsGroupBox.Name = "workOperationsGroupBox";
			this.workOperationsGroupBox.Size = new System.Drawing.Size(643, 207);
			this.workOperationsGroupBox.TabIndex = 27;
			this.workOperationsGroupBox.TabStop = false;
			this.workOperationsGroupBox.Text = "Work Operations";
			// 
			// deleteButton
			// 
			this.deleteButton.Location = new System.Drawing.Point(515, 149);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(98, 31);
			this.deleteButton.TabIndex = 27;
			this.deleteButton.Text = "Delete";
			this.deleteButton.UseVisualStyleBackColor = true;
			this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
			// 
			// WorkForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1240, 686);
			this.Controls.Add(this.workOperationsGroupBox);
			this.Controls.Add(this.workExitButton);
			this.Controls.Add(this.workMenuButton);
			this.Controls.Add(this.listOperationsGroupBox);
			this.Controls.Add(this.workDoneLabel);
			this.Controls.Add(this.workInProgressLabel);
			this.Controls.Add(this.workDoneDataGridView);
			this.Controls.Add(this.workInProgressDataGridView);
			this.Controls.Add(this.workToDoDataGridView);
			this.Controls.Add(this.workToDoLabel);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "WorkForm";
			this.Text = "WorkForm";
			this.Load += new System.EventHandler(this.WorkForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.workToDoDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.workInProgressDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.workDoneDataGridView)).EndInit();
			this.listOperationsGroupBox.ResumeLayout(false);
			this.listOperationsGroupBox.PerformLayout();
			this.workOperationsGroupBox.ResumeLayout(false);
			this.workOperationsGroupBox.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label workToDoLabel;
		private System.Windows.Forms.DataGridView workToDoDataGridView;
		private System.Windows.Forms.DataGridView workInProgressDataGridView;
		private System.Windows.Forms.DataGridView workDoneDataGridView;
		private System.Windows.Forms.Label workInProgressLabel;
		private System.Windows.Forms.Label workDoneLabel;
		private System.Windows.Forms.Label listByTeamLabel;
		private System.Windows.Forms.Label listByPersonLabel;
		private System.Windows.Forms.ComboBox workListByTeamComboBox;
		private System.Windows.Forms.ComboBox workListByPersonComboBox;
		private System.Windows.Forms.GroupBox listOperationsGroupBox;
		private System.Windows.Forms.Button workMenuButton;
		private System.Windows.Forms.Button workExitButton;
		private System.Windows.Forms.ComboBox workNameComboBox;
		private System.Windows.Forms.ComboBox workDoByComboBox;
		private System.Windows.Forms.ComboBox workStatusComboBox;
		private System.Windows.Forms.DateTimePicker workStartedTimeDateTimePicker;
		private System.Windows.Forms.DateTimePicker workEndedTimeDateTimePicker;
		private System.Windows.Forms.Label workNameLabel;
		private System.Windows.Forms.Label doByLabel;
		private System.Windows.Forms.Label statusLabel;
		private System.Windows.Forms.Label workStartedTime;
		private System.Windows.Forms.Label workEndedTimeLabel;
		private System.Windows.Forms.Button undertakeButton;
		private System.Windows.Forms.Button workSaveButton;
		private System.Windows.Forms.GroupBox workOperationsGroupBox;
		private System.Windows.Forms.Button deleteButton;
		private System.Windows.Forms.Button workListOperationsResetButton;
	}
}