
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
			this.loginUsernameTextBox = new System.Windows.Forms.TextBox();
			this.loginPasswordTextBox = new System.Windows.Forms.TextBox();
			this.loginUsernameLabel = new System.Windows.Forms.Label();
			this.loginPasswordLabel = new System.Windows.Forms.Label();
			this.loginButton = new System.Windows.Forms.Button();
			this.fordOtosanLogoPictureBox = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.fordOtosanLogoPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// loginUsernameTextBox
			// 
			this.loginUsernameTextBox.Location = new System.Drawing.Point(237, 120);
			this.loginUsernameTextBox.Name = "loginUsernameTextBox";
			this.loginUsernameTextBox.Size = new System.Drawing.Size(319, 20);
			this.loginUsernameTextBox.TabIndex = 0;
			this.loginUsernameTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.LoginUsernameTextBox_KeyUp);
			// 
			// loginPasswordTextBox
			// 
			this.loginPasswordTextBox.Location = new System.Drawing.Point(237, 160);
			this.loginPasswordTextBox.Name = "loginPasswordTextBox";
			this.loginPasswordTextBox.Size = new System.Drawing.Size(319, 20);
			this.loginPasswordTextBox.TabIndex = 1;
			this.loginPasswordTextBox.UseSystemPasswordChar = true;
			this.loginPasswordTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.LoginPasswordTextBox_KeyUp);
			// 
			// loginUsernameLabel
			// 
			this.loginUsernameLabel.AutoSize = true;
			this.loginUsernameLabel.Location = new System.Drawing.Point(153, 127);
			this.loginUsernameLabel.Name = "loginUsernameLabel";
			this.loginUsernameLabel.Size = new System.Drawing.Size(61, 13);
			this.loginUsernameLabel.TabIndex = 2;
			this.loginUsernameLabel.Text = "Username :";
			// 
			// loginPasswordLabel
			// 
			this.loginPasswordLabel.AutoSize = true;
			this.loginPasswordLabel.Location = new System.Drawing.Point(153, 167);
			this.loginPasswordLabel.Name = "loginPasswordLabel";
			this.loginPasswordLabel.Size = new System.Drawing.Size(59, 13);
			this.loginPasswordLabel.TabIndex = 3;
			this.loginPasswordLabel.Text = "Password :";
			// 
			// loginButton
			// 
			this.loginButton.Location = new System.Drawing.Point(453, 209);
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
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.fordOtosanLogoPictureBox);
			this.Controls.Add(this.loginButton);
			this.Controls.Add(this.loginPasswordLabel);
			this.Controls.Add(this.loginUsernameLabel);
			this.Controls.Add(this.loginPasswordTextBox);
			this.Controls.Add(this.loginUsernameTextBox);
			this.Name = "LoginForm";
			this.Text = "Login";
			this.Load += new System.EventHandler(this.LoginForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.fordOtosanLogoPictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox loginUsernameTextBox;
		private System.Windows.Forms.TextBox loginPasswordTextBox;
		private System.Windows.Forms.Label loginUsernameLabel;
		private System.Windows.Forms.Label loginPasswordLabel;
		private System.Windows.Forms.Button loginButton;
		private System.Windows.Forms.PictureBox fordOtosanLogoPictureBox;
	}
}