namespace QuanLyShopQuanAo
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_user = new System.Windows.Forms.Label();
            this.txt_UserName = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_pass = new System.Windows.Forms.Label();
            this.lb_warning = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.lb_provideAusernameAndpassword = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(24, 257);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(238, 34);
            this.panel3.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(138, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 34);
            this.label3.TabIndex = 16;
            this.label3.Text = "Sign up";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 34);
            this.label2.TabIndex = 12;
            this.label2.Text = "Not a member?";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(-1, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Member Login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.lb_user);
            this.panel1.Controls.Add(this.txt_UserName);
            this.panel1.Location = new System.Drawing.Point(24, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 39);
            this.panel1.TabIndex = 17;
            this.panel1.Click += new System.EventHandler(this.panel1_Click_1);
            // 
            // lb_user
            // 
            this.lb_user.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lb_user.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lb_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_user.ForeColor = System.Drawing.Color.Gray;
            this.lb_user.Location = new System.Drawing.Point(10, 9);
            this.lb_user.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.lb_user.Name = "lb_user";
            this.lb_user.Size = new System.Drawing.Size(76, 20);
            this.lb_user.TabIndex = 4;
            this.lb_user.Text = "Username";
            this.lb_user.Click += new System.EventHandler(this.lb_user_Click_1);
            // 
            // txt_UserName
            // 
            this.txt_UserName.BackColor = System.Drawing.Color.LightGray;
            this.txt_UserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UserName.Location = new System.Drawing.Point(8, 9);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(222, 22);
            this.txt_UserName.TabIndex = 5;
            this.txt_UserName.Text = "";
            this.txt_UserName.TextChanged += new System.EventHandler(this.txt_UserName_TextChanged_1);
            this.txt_UserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_UserName_KeyDown_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.lb_pass);
            this.panel2.Controls.Add(this.txt_Password);
            this.panel2.Location = new System.Drawing.Point(24, 140);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(238, 39);
            this.panel2.TabIndex = 18;
            this.panel2.Click += new System.EventHandler(this.panel2_Click_1);
            // 
            // lb_pass
            // 
            this.lb_pass.AutoSize = true;
            this.lb_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lb_pass.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lb_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_pass.ForeColor = System.Drawing.Color.Gray;
            this.lb_pass.Location = new System.Drawing.Point(10, 9);
            this.lb_pass.Name = "lb_pass";
            this.lb_pass.Size = new System.Drawing.Size(78, 20);
            this.lb_pass.TabIndex = 5;
            this.lb_pass.Text = "Password";
            this.lb_pass.Click += new System.EventHandler(this.lb_pass_Click_1);
            // 
            // lb_warning
            // 
            this.lb_warning.AutoSize = true;
            this.lb_warning.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_warning.ForeColor = System.Drawing.Color.Red;
            this.lb_warning.Location = new System.Drawing.Point(42, 188);
            this.lb_warning.Name = "lb_warning";
            this.lb_warning.Size = new System.Drawing.Size(202, 15);
            this.lb_warning.TabIndex = 20;
            this.lb_warning.Text = "*Username or password is incorrect";
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(169)))), ((int)(((byte)(87)))));
            this.btn_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Login.FlatAppearance.BorderSize = 0;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Login.Location = new System.Drawing.Point(24, 211);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(238, 40);
            this.btn_Login.TabIndex = 19;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // lb_provideAusernameAndpassword
            // 
            this.lb_provideAusernameAndpassword.AutoSize = true;
            this.lb_provideAusernameAndpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_provideAusernameAndpassword.ForeColor = System.Drawing.Color.Red;
            this.lb_provideAusernameAndpassword.Location = new System.Drawing.Point(42, 188);
            this.lb_provideAusernameAndpassword.Name = "lb_provideAusernameAndpassword";
            this.lb_provideAusernameAndpassword.Size = new System.Drawing.Size(202, 15);
            this.lb_provideAusernameAndpassword.TabIndex = 21;
            this.lb_provideAusernameAndpassword.Text = "*Provide a username and password";
            this.lb_provideAusernameAndpassword.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txt_Password
            // 
            this.txt_Password.BackColor = System.Drawing.Color.LightGray;
            this.txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.Location = new System.Drawing.Point(8, 9);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(222, 20);
            this.txt_Password.TabIndex = 6;
            this.txt_Password.TextChanged += new System.EventHandler(this.txt_Password_TextChanged_1);
            this.txt_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Password_KeyDown_1);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 331);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.lb_provideAusernameAndpassword);
            this.Controls.Add(this.lb_warning);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb_warning;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label lb_provideAusernameAndpassword;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lb_user;
        private System.Windows.Forms.Label lb_pass;
        private System.Windows.Forms.RichTextBox txt_UserName;
        private System.Windows.Forms.TextBox txt_Password;
    }
}