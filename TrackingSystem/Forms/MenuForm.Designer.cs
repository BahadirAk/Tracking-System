
namespace TrackingSystem.Forms
{
	partial class MenuForm
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
			this.stockTrackingSystemLabel = new System.Windows.Forms.Label();
			this.workTrackingSystemLabel = new System.Windows.Forms.Label();
			this.workTrackingSystemPictureBox = new System.Windows.Forms.PictureBox();
			this.stockTrackingSystemPictureBox = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.workTrackingSystemPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.stockTrackingSystemPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// stockTrackingSystemLabel
			// 
			this.stockTrackingSystemLabel.AutoSize = true;
			this.stockTrackingSystemLabel.Location = new System.Drawing.Point(336, 451);
			this.stockTrackingSystemLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.stockTrackingSystemLabel.Name = "stockTrackingSystemLabel";
			this.stockTrackingSystemLabel.Size = new System.Drawing.Size(171, 20);
			this.stockTrackingSystemLabel.TabIndex = 1;
			this.stockTrackingSystemLabel.Text = "Stock Tracking System";
			// 
			// workTrackingSystemLabel
			// 
			this.workTrackingSystemLabel.AutoSize = true;
			this.workTrackingSystemLabel.Location = new System.Drawing.Point(710, 451);
			this.workTrackingSystemLabel.Name = "workTrackingSystemLabel";
			this.workTrackingSystemLabel.Size = new System.Drawing.Size(167, 20);
			this.workTrackingSystemLabel.TabIndex = 3;
			this.workTrackingSystemLabel.Text = "Work Tracking System";
			// 
			// workTrackingSystemPictureBox
			// 
			this.workTrackingSystemPictureBox.Image = global::TrackingSystem.Properties.Resources.construction_worker;
			this.workTrackingSystemPictureBox.Location = new System.Drawing.Point(664, 134);
			this.workTrackingSystemPictureBox.Name = "workTrackingSystemPictureBox";
			this.workTrackingSystemPictureBox.Size = new System.Drawing.Size(268, 298);
			this.workTrackingSystemPictureBox.TabIndex = 2;
			this.workTrackingSystemPictureBox.TabStop = false;
			this.workTrackingSystemPictureBox.Click += new System.EventHandler(this.workTrackingSystemPictureBox_Click);
			// 
			// stockTrackingSystemPictureBox
			// 
			this.stockTrackingSystemPictureBox.Image = global::TrackingSystem.Properties.Resources.boxPhoto3;
			this.stockTrackingSystemPictureBox.Location = new System.Drawing.Point(286, 134);
			this.stockTrackingSystemPictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.stockTrackingSystemPictureBox.Name = "stockTrackingSystemPictureBox";
			this.stockTrackingSystemPictureBox.Size = new System.Drawing.Size(268, 298);
			this.stockTrackingSystemPictureBox.TabIndex = 0;
			this.stockTrackingSystemPictureBox.TabStop = false;
			this.stockTrackingSystemPictureBox.Click += new System.EventHandler(this.stockTrackingSystemPictureBox_Click);
			// 
			// MenuForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1200, 692);
			this.Controls.Add(this.workTrackingSystemLabel);
			this.Controls.Add(this.workTrackingSystemPictureBox);
			this.Controls.Add(this.stockTrackingSystemLabel);
			this.Controls.Add(this.stockTrackingSystemPictureBox);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "MenuForm";
			this.Text = "Menu";
			this.Load += new System.EventHandler(this.MenuForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.workTrackingSystemPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.stockTrackingSystemPictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox stockTrackingSystemPictureBox;
		private System.Windows.Forms.Label stockTrackingSystemLabel;
		private System.Windows.Forms.PictureBox workTrackingSystemPictureBox;
		private System.Windows.Forms.Label workTrackingSystemLabel;
	}
}