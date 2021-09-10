
namespace TrackingSystem.Forms
{
	partial class StockForm
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
			this.stockDataGridView = new System.Windows.Forms.DataGridView();
			this.stockNameTextBox = new System.Windows.Forms.TextBox();
			this.stockNameLabel = new System.Windows.Forms.Label();
			this.stockModelTextBox = new System.Windows.Forms.TextBox();
			this.stockModelLabel = new System.Windows.Forms.Label();
			this.stockSerialNoTextbox = new System.Windows.Forms.TextBox();
			this.stockQuantityTextBox = new System.Windows.Forms.TextBox();
			this.stockSerialNoLabel = new System.Windows.Forms.Label();
			this.stockQuantityLabel = new System.Windows.Forms.Label();
			this.saveButton = new System.Windows.Forms.Button();
			this.deleteButton = new System.Windows.Forms.Button();
			this.stockOp = new System.Windows.Forms.GroupBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.stockDecreaseButton = new System.Windows.Forms.Button();
			this.stockChangeQuantityLabel = new System.Windows.Forms.Label();
			this.stockChangeQuantityTextBox = new System.Windows.Forms.TextBox();
			this.stockIncreaseButton = new System.Windows.Forms.Button();
			this.stockSearchTextBox = new System.Windows.Forms.TextBox();
			this.searchOpeartionsGroupBox = new System.Windows.Forms.GroupBox();
			this.exitStockButton = new System.Windows.Forms.Button();
			this.menuStockButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.stockDataGridView)).BeginInit();
			this.stockOp.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.searchOpeartionsGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// stockDataGridView
			// 
			this.stockDataGridView.AllowUserToAddRows = false;
			this.stockDataGridView.AllowUserToDeleteRows = false;
			this.stockDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.stockDataGridView.Location = new System.Drawing.Point(509, 12);
			this.stockDataGridView.Margin = new System.Windows.Forms.Padding(2);
			this.stockDataGridView.Name = "stockDataGridView";
			this.stockDataGridView.ReadOnly = true;
			this.stockDataGridView.RowHeadersWidth = 62;
			this.stockDataGridView.RowTemplate.Height = 28;
			this.stockDataGridView.Size = new System.Drawing.Size(763, 654);
			this.stockDataGridView.TabIndex = 1;
			this.stockDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stockDataGridView_cellClick);
			// 
			// stockNameTextBox
			// 
			this.stockNameTextBox.Location = new System.Drawing.Point(106, 29);
			this.stockNameTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.stockNameTextBox.Name = "stockNameTextBox";
			this.stockNameTextBox.Size = new System.Drawing.Size(241, 20);
			this.stockNameTextBox.TabIndex = 2;
			// 
			// stockNameLabel
			// 
			this.stockNameLabel.AutoSize = true;
			this.stockNameLabel.Location = new System.Drawing.Point(15, 32);
			this.stockNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.stockNameLabel.Name = "stockNameLabel";
			this.stockNameLabel.Size = new System.Drawing.Size(72, 13);
			this.stockNameLabel.TabIndex = 3;
			this.stockNameLabel.Text = "Stock Name :";
			// 
			// stockModelTextBox
			// 
			this.stockModelTextBox.Location = new System.Drawing.Point(106, 76);
			this.stockModelTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.stockModelTextBox.Name = "stockModelTextBox";
			this.stockModelTextBox.Size = new System.Drawing.Size(241, 20);
			this.stockModelTextBox.TabIndex = 4;
			// 
			// stockModelLabel
			// 
			this.stockModelLabel.AutoSize = true;
			this.stockModelLabel.Location = new System.Drawing.Point(15, 79);
			this.stockModelLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.stockModelLabel.Name = "stockModelLabel";
			this.stockModelLabel.Size = new System.Drawing.Size(73, 13);
			this.stockModelLabel.TabIndex = 5;
			this.stockModelLabel.Text = "Stock Model :";
			// 
			// stockSerialNoTextbox
			// 
			this.stockSerialNoTextbox.Location = new System.Drawing.Point(106, 124);
			this.stockSerialNoTextbox.Margin = new System.Windows.Forms.Padding(2);
			this.stockSerialNoTextbox.Name = "stockSerialNoTextbox";
			this.stockSerialNoTextbox.Size = new System.Drawing.Size(241, 20);
			this.stockSerialNoTextbox.TabIndex = 6;
			// 
			// stockQuantityTextBox
			// 
			this.stockQuantityTextBox.Location = new System.Drawing.Point(106, 170);
			this.stockQuantityTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.stockQuantityTextBox.Name = "stockQuantityTextBox";
			this.stockQuantityTextBox.Size = new System.Drawing.Size(241, 20);
			this.stockQuantityTextBox.TabIndex = 7;
			// 
			// stockSerialNoLabel
			// 
			this.stockSerialNoLabel.AutoSize = true;
			this.stockSerialNoLabel.Location = new System.Drawing.Point(15, 127);
			this.stockSerialNoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.stockSerialNoLabel.Name = "stockSerialNoLabel";
			this.stockSerialNoLabel.Size = new System.Drawing.Size(87, 13);
			this.stockSerialNoLabel.TabIndex = 10;
			this.stockSerialNoLabel.Text = "Stock Serial No :";
			// 
			// stockQuantityLabel
			// 
			this.stockQuantityLabel.AutoSize = true;
			this.stockQuantityLabel.Location = new System.Drawing.Point(15, 173);
			this.stockQuantityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.stockQuantityLabel.Name = "stockQuantityLabel";
			this.stockQuantityLabel.Size = new System.Drawing.Size(83, 13);
			this.stockQuantityLabel.TabIndex = 11;
			this.stockQuantityLabel.Text = "Stock Quantity :";
			// 
			// saveButton
			// 
			this.saveButton.Location = new System.Drawing.Point(106, 233);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(104, 29);
			this.saveButton.TabIndex = 12;
			this.saveButton.Text = "Save";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// deleteButton
			// 
			this.deleteButton.Location = new System.Drawing.Point(242, 233);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(104, 29);
			this.deleteButton.TabIndex = 13;
			this.deleteButton.Text = "Delete";
			this.deleteButton.UseVisualStyleBackColor = true;
			this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
			// 
			// stockOp
			// 
			this.stockOp.Controls.Add(this.groupBox1);
			this.stockOp.Controls.Add(this.deleteButton);
			this.stockOp.Controls.Add(this.saveButton);
			this.stockOp.Controls.Add(this.stockQuantityLabel);
			this.stockOp.Controls.Add(this.stockSerialNoLabel);
			this.stockOp.Controls.Add(this.stockQuantityTextBox);
			this.stockOp.Controls.Add(this.stockSerialNoTextbox);
			this.stockOp.Controls.Add(this.stockModelLabel);
			this.stockOp.Controls.Add(this.stockModelTextBox);
			this.stockOp.Controls.Add(this.stockNameLabel);
			this.stockOp.Controls.Add(this.stockNameTextBox);
			this.stockOp.Location = new System.Drawing.Point(12, 12);
			this.stockOp.Name = "stockOp";
			this.stockOp.Size = new System.Drawing.Size(482, 417);
			this.stockOp.TabIndex = 15;
			this.stockOp.TabStop = false;
			this.stockOp.Text = "Stock Operations";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.stockDecreaseButton);
			this.groupBox1.Controls.Add(this.stockChangeQuantityLabel);
			this.groupBox1.Controls.Add(this.stockChangeQuantityTextBox);
			this.groupBox1.Controls.Add(this.stockIncreaseButton);
			this.groupBox1.Location = new System.Drawing.Point(77, 281);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox1.Size = new System.Drawing.Size(310, 126);
			this.groupBox1.TabIndex = 17;
			this.groupBox1.TabStop = false;
			// 
			// stockDecreaseButton
			// 
			this.stockDecreaseButton.Location = new System.Drawing.Point(166, 81);
			this.stockDecreaseButton.Name = "stockDecreaseButton";
			this.stockDecreaseButton.Size = new System.Drawing.Size(104, 29);
			this.stockDecreaseButton.TabIndex = 17;
			this.stockDecreaseButton.Text = "Decrease";
			this.stockDecreaseButton.UseVisualStyleBackColor = true;
			this.stockDecreaseButton.Click += new System.EventHandler(this.stockDecreaseButton_Click);
			// 
			// stockChangeQuantityLabel
			// 
			this.stockChangeQuantityLabel.AutoSize = true;
			this.stockChangeQuantityLabel.Location = new System.Drawing.Point(23, 15);
			this.stockChangeQuantityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.stockChangeQuantityLabel.Name = "stockChangeQuantityLabel";
			this.stockChangeQuantityLabel.Size = new System.Drawing.Size(246, 13);
			this.stockChangeQuantityLabel.TabIndex = 16;
			this.stockChangeQuantityLabel.Text = "Please enter the quantity of the stock you selected";
			// 
			// stockChangeQuantityTextBox
			// 
			this.stockChangeQuantityTextBox.Location = new System.Drawing.Point(29, 41);
			this.stockChangeQuantityTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.stockChangeQuantityTextBox.Name = "stockChangeQuantityTextBox";
			this.stockChangeQuantityTextBox.Size = new System.Drawing.Size(241, 20);
			this.stockChangeQuantityTextBox.TabIndex = 15;
			// 
			// stockIncreaseButton
			// 
			this.stockIncreaseButton.Location = new System.Drawing.Point(29, 81);
			this.stockIncreaseButton.Name = "stockIncreaseButton";
			this.stockIncreaseButton.Size = new System.Drawing.Size(104, 29);
			this.stockIncreaseButton.TabIndex = 14;
			this.stockIncreaseButton.Text = "Increase";
			this.stockIncreaseButton.UseVisualStyleBackColor = true;
			this.stockIncreaseButton.Click += new System.EventHandler(this.stockIncreaseButton_Click_1);
			// 
			// stockSearchTextBox
			// 
			this.stockSearchTextBox.Location = new System.Drawing.Point(47, 25);
			this.stockSearchTextBox.Name = "stockSearchTextBox";
			this.stockSearchTextBox.Size = new System.Drawing.Size(334, 20);
			this.stockSearchTextBox.TabIndex = 16;
			this.stockSearchTextBox.TextChanged += new System.EventHandler(this.stockNameSearchTextBox_TextChanged);
			// 
			// searchOpeartionsGroupBox
			// 
			this.searchOpeartionsGroupBox.Controls.Add(this.stockSearchTextBox);
			this.searchOpeartionsGroupBox.Location = new System.Drawing.Point(12, 460);
			this.searchOpeartionsGroupBox.Name = "searchOpeartionsGroupBox";
			this.searchOpeartionsGroupBox.Size = new System.Drawing.Size(478, 65);
			this.searchOpeartionsGroupBox.TabIndex = 18;
			this.searchOpeartionsGroupBox.TabStop = false;
			this.searchOpeartionsGroupBox.Text = "Search Opeariton";
			// 
			// exitStockButton
			// 
			this.exitStockButton.Location = new System.Drawing.Point(287, 577);
			this.exitStockButton.Name = "exitStockButton";
			this.exitStockButton.Size = new System.Drawing.Size(104, 29);
			this.exitStockButton.TabIndex = 19;
			this.exitStockButton.Text = "Exit";
			this.exitStockButton.UseVisualStyleBackColor = true;
			this.exitStockButton.Click += new System.EventHandler(this.exitStockButton_Click);
			// 
			// menuStockButton
			// 
			this.menuStockButton.Location = new System.Drawing.Point(71, 577);
			this.menuStockButton.Name = "menuStockButton";
			this.menuStockButton.Size = new System.Drawing.Size(104, 29);
			this.menuStockButton.TabIndex = 20;
			this.menuStockButton.Text = "Menu";
			this.menuStockButton.UseVisualStyleBackColor = true;
			this.menuStockButton.Click += new System.EventHandler(this.menuStockButton_Click);
			// 
			// StockForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1283, 677);
			this.Controls.Add(this.menuStockButton);
			this.Controls.Add(this.exitStockButton);
			this.Controls.Add(this.searchOpeartionsGroupBox);
			this.Controls.Add(this.stockOp);
			this.Controls.Add(this.stockDataGridView);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "StockForm";
			this.Text = "StockTracking";
			this.Load += new System.EventHandler(this.StockForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.stockDataGridView)).EndInit();
			this.stockOp.ResumeLayout(false);
			this.stockOp.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.searchOpeartionsGroupBox.ResumeLayout(false);
			this.searchOpeartionsGroupBox.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView stockDataGridView;
		private System.Windows.Forms.TextBox stockNameTextBox;
		private System.Windows.Forms.Label stockNameLabel;
		private System.Windows.Forms.TextBox stockModelTextBox;
		private System.Windows.Forms.Label stockModelLabel;
		private System.Windows.Forms.TextBox stockSerialNoTextbox;
		private System.Windows.Forms.TextBox stockQuantityTextBox;
		private System.Windows.Forms.Label stockSerialNoLabel;
		private System.Windows.Forms.Label stockQuantityLabel;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.Button deleteButton;
		private System.Windows.Forms.GroupBox stockOp;
		private System.Windows.Forms.TextBox stockSearchTextBox;
		private System.Windows.Forms.GroupBox searchOpeartionsGroupBox;
		private System.Windows.Forms.Button exitStockButton;
		private System.Windows.Forms.Button menuStockButton;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button stockDecreaseButton;
		private System.Windows.Forms.Label stockChangeQuantityLabel;
		private System.Windows.Forms.TextBox stockChangeQuantityTextBox;
		private System.Windows.Forms.Button stockIncreaseButton;
	}
}