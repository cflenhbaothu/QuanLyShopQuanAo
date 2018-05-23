using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyShopQuanAo
{
    public partial class Login : Form
    {
        Class_Business bd;
        string err = string.Empty;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            lb_provideAusernameAndpassword.Visible = lb_warning.Visible = false;
        }

        public int i = 3;
        private void timer1_Tick(object sender, EventArgs e)
        {
            lb_provideAusernameAndpassword.Left += i;
            if (lb_provideAusernameAndpassword.Left >= 60)
            {
                lb_provideAusernameAndpassword.Left -= i + 14;
                timer1.Stop();
            }
            lb_warning.Left += i;
            if (lb_warning.Left >= 60)
            {
                lb_warning.Left -= i + 14;
                timer1.Stop();
            }
        }

        // check user password func
        public void checkUserID()
        {
            if (txt_UserName.TextLength == 0 || txt_Password.TextLength == 0)
            {
                lb_provideAusernameAndpassword.Visible = true;
                lb_warning.Visible = false;
                timer1.Start();
            }
            else
            {
                bd = new Class_Business();

                //check user password
                if (bd.Login(ref err, txt_UserName.Text, txt_Password.Text))
                {
                    A_UName.ID_USER = txt_UserName.Text;
                    this.Hide();
                    Main f = new Main();
                    f.ShowDialog();
                    lb_provideAusernameAndpassword.Visible = lb_warning.Visible = false;

                }
                else
                {
                    lb_provideAusernameAndpassword.Visible = false;
                    lb_warning.Visible = true;
                    timer1.Start();
                }
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            checkUserID();
        }
        
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }

        private void panel1_Click_1(object sender, EventArgs e)
        {
            this.ActiveControl = txt_UserName;
        }

        private void panel2_Click_1(object sender, EventArgs e)
        {
            this.ActiveControl = txt_Password;
        }

        private void lb_user_Click_1(object sender, EventArgs e)
        {
            this.ActiveControl = txt_UserName;
        }
        
        private void lb_pass_Click_1(object sender, EventArgs e)
        {
            this.ActiveControl = txt_Password;
        }

        private void txt_UserName_TextChanged_1(object sender, EventArgs e)
        {
            if (this.txt_UserName.Text == "")
            {
                lb_user.Visible = true;
            }
            else
            {
                lb_user.Visible = false;
            }
        }

        private void txt_Password_TextChanged_1(object sender, EventArgs e)
        {
            if (this.txt_Password.Text == "")
            {
                lb_pass.Visible = true;
            }
            else
            {
                lb_pass.Visible = false;
            }
        }

        private void txt_UserName_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = e.SuppressKeyPress = true;
                btn_Login.PerformClick();
            }
        }

        private void txt_Password_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = e.SuppressKeyPress = true;
                btn_Login.PerformClick();

            }
        }
    }
}
