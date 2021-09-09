
namespace TrackingSystem.Forms
{
	partial class LoginForm
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
			this.loginButton = new System.Windows.Forms.Button();
			this.fordOtosanLogoPictureBox = new System.Windows.Forms.PictureBox();
			this.loginPeopleComboBox = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.fordOtosanLogoPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// loginButton
			// 
			this.loginButton.Location = new System.Drawing.Point(453, 174);
			this.loginButton.Name = "loginButton";
			this.loginButton.Size = new System.Drawing.Size(103, 23);
			this.loginButton.TabIndex = 4;
			this.loginButton.Text = "Login";
			this.loginButton.UseVisualStyleBackColor = true;
			this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
			// 
			// fordOtosanLogoPictureBox
			// 
			this.fordOtosanLogoPictureBox.Image = global::TrackingSystem.Properties.Resources.Ford_Otosan_logo_svg;
			this.fordOtosanLogoPictureBox.Location = new System.Drawing.Point(237, 50);
			this.fordOtosanLogoPictureBox.Margin = new System.Windows.Forms.Padding(2);
			this.fordOtosanLogoPictureBox.Name = "fordOtosanLogoPictureBox";
			this.fordOtosanLogoPictureBox.Size = new System.Drawing.Size(319, 58);
			this.fordOtosanLogoPictureBox.TabIndex = 6;
			this.fordOtosanLogoPictureBox.TabStop = false;
			// 
			// loginPeopleComboBox
			// 
			this.loginPeopleComboBox.FormattingEnabled = true;
			this.loginPeopleComboBox.Location = new System.Drawing.Point(237, 130);
			this.loginPeopleComboBox.Name = "loginPeopleComboBox";
			this.loginPeopleComboBox.Size = new System.Drawing.Size(319, 21);
			this.loginPeopleComboBox.TabIndex = 7;
			this.loginPeopleComboBox.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.LoginPeopleComboBoxFormat);
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.loginPeopleComboBox);
			this.Controls.Add(this.fordOtosanLogoPictureBox);
			this.Controls.Add(this.loginButton);
			this.Name = "LoginForm";
			this.Text = "Login";
			this.Load += new System.EventHandler(this.LoginForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.fordOtosanLogoPictureBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button loginButton;
		private System.Windows.Forms.PictureBox fordOtosanLogoPictureBox;
		private System.Windows.Forms.ComboBox loginPeopleComboBox;
	}
}