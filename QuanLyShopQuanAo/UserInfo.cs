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
    public partial class UserInfo : Form
    {
        Class_AboutThisUser thisUser = new Class_AboutThisUser();
        Class_Business bd = new Class_Business();
        string err = string.Empty;
        string _d_User = "";
        string _d_FirstN = "";
        string _d_LastN = "";
        string _d_Gender = "";

        public UserInfo()
        {
            InitializeComponent();
        }

        private void UserInfo_Load(object sender, EventArgs e)
        {
            txt_userName.Text = thisUser.get_UserName(A_UName.ID_USER);
            txt_firstName.Text = thisUser.get_FirstName(A_UName.ID_USER);
            txt_lastName.Text = thisUser.get_LastName(A_UName.ID_USER);
            comboBox_gender.SelectedIndex = comboBox_gender.FindStringExact(thisUser.get_Gender(A_UName.ID_USER));
            _d_User = txt_userName.Text;
            _d_FirstN = txt_firstName.Text;
            _d_LastN = txt_lastName.Text;
            _d_Gender = comboBox_gender.Text;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (btn_save.Visible == false)
            {
                txt_userName.Enabled = txt_firstName.Enabled = txt_lastName.Enabled = comboBox_gender.Enabled = true;
                btn_save.Visible = true;
                btn_edit.Text = "cancel";
            }
            else
            {
                txt_userName.Enabled = txt_firstName.Enabled = txt_lastName.Enabled = comboBox_gender.Enabled = false;
                btn_save.Visible = false;
                btn_edit.Text = "edit";
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_userName.TextLength != 0 && txt_firstName.TextLength != 0 && txt_lastName.TextLength != 0)
            {
                string query = string.Empty;
                DialogResult msgresult = MessageBox.Show("Do you want to save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (msgresult == DialogResult.Yes)
                {
                    if (txt_firstName.Text != _d_FirstN) { query += "FirstName"; }
                    if (txt_lastName.Text != _d_LastN) { query += "LastName"; }
                    if (comboBox_gender.Text != _d_Gender) { query += "Gender"; }
                    if (txt_userName.Text != _d_User) { query += "UserName"; }

                    if (query != "")
                    {
                        bd.Update_User(ref err, A_UName.ID_USER, String_Concatenation(query, txt_firstName.Text, txt_lastName.Text, comboBox_gender.Text, txt_userName.Text));
                        if (err == "")
                        {
                            A_UName.ID_USER = txt_userName.Text;
                            UserInfo_Load(sender, e);
                            btn_edit_Click(sender, e);
                        }
                        else MessageBox.Show(err);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill all the fields");
            }
        }

        //Concatenate string
        public string String_Concatenation(string query, string fn, string ln, string gd, string un)
        {
            StringBuilder builder = new StringBuilder();
            if (query.Contains("FirstName")) builder.Append("FirstName = '" + fn + "', ");
            if (query.Contains("LastName")) builder.Append("LastName = '" + ln + "', ");
            if (query.Contains("Gender")) builder.Append("Gender = '" + gd + "', ");
            if (query.Contains("UserName")) builder.Append("UserName = '" + un + "', ");
            

                string sql = string.Empty;
            sql = builder.ToString();
            if (sql.EndsWith(", ")) sql = sql.Substring(0, sql.Length - 2);

            return sql;
        }
        

        #region  bla bla...

        private void txt_userName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_save_Click(sender, e);
                e.Handled = true;
            }
        }

        private void txt_firstName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_save_Click(sender, e);
                e.Handled = true;
            }
        }

        private void txt_lastName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_save_Click(sender, e);
                e.Handled = true;
            }
        }

        private void comboBox_gender_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_save_Click(sender, e);
                e.Handled = true;
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            txt_userName.Focus();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            txt_firstName.Focus();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            txt_lastName.Focus();
        }
        #endregion
    }
}
