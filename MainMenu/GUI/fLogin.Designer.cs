namespace MainMenu.GUI
{



	partial class fLogin
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnExit = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.lblPassword = new System.Windows.Forms.Label();
			this.btnLogin = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.lblUsername = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Tan;
			this.panel1.Controls.Add(this.btnExit);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.btnLogin);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel1.ForeColor = System.Drawing.Color.White;
			this.panel1.Location = new System.Drawing.Point(8, 8);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(346, 481);
			this.panel1.TabIndex = 0;
			// 
			// btnExit
			// 
			this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.btnExit.Location = new System.Drawing.Point(182, 410);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(114, 41);
			this.btnExit.TabIndex = 4;
			this.btnExit.Text = "Thoát";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.Tan;
			this.panel3.Controls.Add(this.txtPassword);
			this.panel3.Controls.Add(this.lblPassword);
			this.panel3.ForeColor = System.Drawing.Color.White;
			this.panel3.Location = new System.Drawing.Point(0, 296);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(343, 88);
			this.panel3.TabIndex = 1;
			// 
			// txtPassword
			// 
			this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtPassword.Location = new System.Drawing.Point(18, 46);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(305, 22);
			this.txtPassword.TabIndex = 2;
			this.txtPassword.UseSystemPasswordChar = true;
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.lblPassword.Location = new System.Drawing.Point(14, 23);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(83, 20);
			this.lblPassword.TabIndex = 0;
			this.lblPassword.Text = "Mật khẩu";
			// 
			// btnLogin
			// 
			this.btnLogin.BackColor = System.Drawing.Color.SeaShell;
			this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.btnLogin.Location = new System.Drawing.Point(35, 410);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(113, 41);
			this.btnLogin.TabIndex = 3;
			this.btnLogin.Text = "Đăng nhập";
			this.btnLogin.UseVisualStyleBackColor = false;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Tan;
			this.panel2.Controls.Add(this.txtUsername);
			this.panel2.Controls.Add(this.lblUsername);
			this.panel2.ForeColor = System.Drawing.Color.White;
			this.panel2.Location = new System.Drawing.Point(0, 211);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(343, 87);
			this.panel2.TabIndex = 0;
			// 
			// txtUsername
			// 
			this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtUsername.Location = new System.Drawing.Point(18, 51);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(305, 22);
			this.txtUsername.TabIndex = 1;
			// 
			// lblUsername
			// 
			this.lblUsername.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.lblUsername.Location = new System.Drawing.Point(14, 25);
			this.lblUsername.Name = "lblUsername";
			this.lblUsername.Size = new System.Drawing.Size(141, 23);
			this.lblUsername.TabIndex = 0;
			this.lblUsername.Text = "Tên đăng nhập";
			// 
			// fLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(357, 501);
			this.Controls.Add(this.panel1);
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.Name = "fLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fLogin_FormClosing);
			this.panel1.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label lblUsername;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnLogin;
	}

}

