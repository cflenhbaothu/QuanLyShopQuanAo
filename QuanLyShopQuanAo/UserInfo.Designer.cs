namespace QuanLyShopQuanAo
{
    partial class UserInfo
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
            this.txt_userName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_firstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_lastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_gender = new System.Windows.Forms.ComboBox();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.txt_userName);
            this.panel1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panel1.Location = new System.Drawing.Point(87, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 34);
            this.panel1.TabIndex = 18;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // txt_userName
            // 
            this.txt_userName.BackColor = System.Drawing.Color.LightGray;
            this.txt_userName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_userName.Enabled = false;
            this.txt_userName.Font = new System.Drawing.Font("Source Sans Pro Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_userName.Location = new System.Drawing.Point(8, 9);
            this.txt_userName.MaxLength = 30;
            this.txt_userName.Name = "txt_userName";
            this.txt_userName.Size = new System.Drawing.Size(328, 17);
            this.txt_userName.TabIndex = 1;
            this.txt_userName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_userName_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(12, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(12, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "First Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.txt_firstName);
            this.panel2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panel2.Location = new System.Drawing.Point(87, 143);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(99, 34);
            this.panel2.TabIndex = 20;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            // 
            // txt_firstName
            // 
            this.txt_firstName.BackColor = System.Drawing.Color.LightGray;
            this.txt_firstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_firstName.Enabled = false;
            this.txt_firstName.Font = new System.Drawing.Font("Source Sans Pro Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_firstName.Location = new System.Drawing.Point(8, 9);
            this.txt_firstName.MaxLength = 30;
            this.txt_firstName.Name = "txt_firstName";
            this.txt_firstName.Size = new System.Drawing.Size(83, 17);
            this.txt_firstName.TabIndex = 1;
            this.txt_firstName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_firstName_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(197, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 18);
            this.label3.TabIndex = 23;
            this.label3.Text = "Last Name";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.Controls.Add(this.txt_lastName);
            this.panel3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panel3.Location = new System.Drawing.Point(272, 143);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(160, 34);
            this.panel3.TabIndex = 22;
            this.panel3.Click += new System.EventHandler(this.panel3_Click);
            // 
            // txt_lastName
            // 
            this.txt_lastName.BackColor = System.Drawing.Color.LightGray;
            this.txt_lastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_lastName.Enabled = false;
            this.txt_lastName.Font = new System.Drawing.Font("Source Sans Pro Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lastName.Location = new System.Drawing.Point(8, 9);
            this.txt_lastName.MaxLength = 30;
            this.txt_lastName.Name = "txt_lastName";
            this.txt_lastName.Size = new System.Drawing.Size(143, 17);
            this.txt_lastName.TabIndex = 1;
            this.txt_lastName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_lastName_KeyDown);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(169)))), ((int)(((byte)(87)))));
            this.label4.Font = new System.Drawing.Font("Source Sans Pro Semibold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(-2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(447, 55);
            this.label4.TabIndex = 24;
            this.label4.Text = "User Information";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(14, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 18);
            this.label5.TabIndex = 25;
            this.label5.Text = "Gender";
            // 
            // comboBox_gender
            // 
            this.comboBox_gender.DropDownHeight = 120;
            this.comboBox_gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_gender.Enabled = false;
            this.comboBox_gender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_gender.Font = new System.Drawing.Font("Source Sans Pro Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_gender.FormattingEnabled = true;
            this.comboBox_gender.IntegralHeight = false;
            this.comboBox_gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBox_gender.Location = new System.Drawing.Point(87, 204);
            this.comboBox_gender.Name = "comboBox_gender";
            this.comboBox_gender.Size = new System.Drawing.Size(345, 24);
            this.comboBox_gender.TabIndex = 26;
            this.comboBox_gender.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox_gender_KeyDown);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.LightGray;
            this.btn_edit.FlatAppearance.BorderSize = 0;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Location = new System.Drawing.Point(357, 265);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 26);
            this.btn_edit.TabIndex = 27;
            this.btn_edit.Text = "edit";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.LightGray;
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Location = new System.Drawing.Point(256, 265);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 26);
            this.btn_save.TabIndex = 28;
            this.btn_save.Text = "save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Visible = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // UserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 303);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.comboBox_gender);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Source Sans Pro Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UserInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserInfo";
            this.Load += new System.EventHandler(this.UserInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_userName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_firstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_lastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_gender;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_save;
    }
}