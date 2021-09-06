
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
			this.loginUsernameTextBox.Location = new System.Drawing.Point(356, 185);
			this.loginUsernameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.loginUsernameTextBox.Name = "loginUsernameTextBox";
			this.loginUsernameTextBox.Size = new System.Drawing.Size(476, 26);
			this.loginUsernameTextBox.TabIndex = 0;
			// 
			// loginPasswordTextBox
			// 
			this.loginPasswordTextBox.Location = new System.Drawing.Point(356, 246);
			this.loginPasswordTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.loginPasswordTextBox.Name = "loginPasswordTextBox";
			this.loginPasswordTextBox.Size = new System.Drawing.Size(476, 26);
			this.loginPasswordTextBox.TabIndex = 1;
			this.loginPasswordTextBox.UseSystemPasswordChar = true;
			// 
			// loginUsernameLabel
			// 
			this.loginUsernameLabel.AutoSize = true;
			this.loginUsernameLabel.Location = new System.Drawing.Point(230, 195);
			this.loginUsernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.loginUsernameLabel.Name = "loginUsernameLabel";
			this.loginUsernameLabel.Size = new System.Drawing.Size(91, 20);
			this.loginUsernameLabel.TabIndex = 2;
			this.loginUsernameLabel.Text = "Username :";
			// 
			// loginPasswordLabel
			// 
			this.loginPasswordLabel.AutoSize = true;
			this.loginPasswordLabel.Location = new System.Drawing.Point(230, 257);
			this.loginPasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.loginPasswordLabel.Name = "loginPasswordLabel";
			this.loginPasswordLabel.Size = new System.Drawing.Size(86, 20);
			this.loginPasswordLabel.TabIndex = 3;
			this.loginPasswordLabel.Text = "Password :";
			// 
			// loginButton
			// 
			this.loginButton.Location = new System.Drawing.Point(680, 322);
			this.loginButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.loginButton.Name = "loginButton";
			this.loginButton.Size = new System.Drawing.Size(154, 35);
			this.loginButton.TabIndex = 4;
			this.loginButton.Text = "Login";
			this.loginButton.UseVisualStyleBackColor = true;
			this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
			// 
			// fordOtosanLogoPictureBox
			// 
			this.fordOtosanLogoPictureBox.Image = global::TrackingSystem.Properties.Resources.Ford_Otosan_logo_svg;
			this.fordOtosanLogoPictureBox.Location = new System.Drawing.Point(356, 77);
			this.fordOtosanLogoPictureBox.Name = "fordOtosanLogoPictureBox";
			this.fordOtosanLogoPictureBox.Size = new System.Drawing.Size(478, 89);
			this.fordOtosanLogoPictureBox.TabIndex = 6;
			this.fordOtosanLogoPictureBox.TabStop = false;
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(1200, 692);
			this.Controls.Add(this.fordOtosanLogoPictureBox);
			this.Controls.Add(this.loginButton);
			this.Controls.Add(this.loginPasswordLabel);
			this.Controls.Add(this.loginUsernameLabel);
			this.Controls.Add(this.loginPasswordTextBox);
			this.Controls.Add(this.loginUsernameTextBox);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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