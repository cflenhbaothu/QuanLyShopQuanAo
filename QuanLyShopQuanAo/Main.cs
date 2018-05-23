using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace QuanLyShopQuanAo
{
    public partial class Main : Form
    {
        Class_AboutThisUser thisUser = new Class_AboutThisUser();
        Class_Business bd = new Class_Business();
        Class_Search sr = new Class_Search();
        string ID_USER = A_UName.ID_USER;
        string err = string.Empty;
        int ID_PER = 0;
        public static string Search_Alert = String.Empty;
        private int fHome = 0;

        string _d_FirstN = "";
        string _d_LastN = "";
        string _d_Gender = "";


        public Main()
        {
            InitializeComponent();
            btn_searchItems.MouseEnter += new EventHandler(btn_searchItems_MouseEnter);
            btn_searchItems.MouseLeave += new EventHandler(btn_searchItems_MouseLeave);
        }

        private void btn_searchItems_MouseLeave(object sender, EventArgs e)
        {
            this.btn_searchItems.Image = Properties.Resources.magnifying_glass;
        }

        private void btn_searchItems_MouseEnter(object sender, EventArgs e)
        {
            this.btn_searchItems.Image = Properties.Resources.magnifying_glass_hover;
        }

        public void permission()
        {
            _d_FirstN = thisUser.get_FirstName(ID_USER);
            _d_LastN = thisUser.get_LastName(ID_USER);
            _d_Gender = thisUser.get_Gender(ID_USER);

            ID_PER = int.Parse(bd.Get_Permission(thisUser.get_UserID(ID_USER)));
            A_UName.ID_PERMISSON = ID_PER;
            if (ID_PER > 2)
            {
                menuStrip_Left.Items.Remove(toolStrip_userManage);
                menuStrip_Left.Items.Remove(toolStrip_addProduct);
                btn_deleteItems.Visible = false;
            }
            Search_Alert = String.Empty;

            if (fHome == 0) toolStrip_Home.PerformClick();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            lb_UserInfo.Text = thisUser.get_LastName(ID_USER) + " " + thisUser.get_FirstName(ID_USER) + "\n" + thisUser.get_Permission(ID_USER) + "\n______________________";

            permission();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Visible)
            {
                DialogResult msgresult = MessageBox.Show("Do you really want to exit?", "Exit and Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (msgresult == DialogResult.Yes)
                {
                    Dispose();
                    Environment.Exit(1);
                }
                else e.Cancel = true;
            }
        }

        private void toolStrip_Logout_Click(object sender, EventArgs e)
        {
            Form_User.i = string.Empty;

            this.Hide();
            Login f = new Login();
            f.ShowDialog();

            Dispose();
        }

        private void toolStrip_profileSetting_Click(object sender, EventArgs e)
        {
            UserInfo f = new UserInfo();
            f.ShowDialog();
            Form fc = Application.OpenForms["Form_User"];

            if (f.Visible == false)
            {
                if (fc != null && A_UName.ID_PERMISSON < 3 && (thisUser.get_UserName(ID_USER) != ID_USER || thisUser.get_FirstName(ID_USER) != _d_FirstN || thisUser.get_LastName(ID_USER) != _d_LastN || thisUser.get_Gender(ID_USER) != _d_Gender))
                    toolStrip_userManage.PerformClick();
                ID_USER = A_UName.ID_USER;
                Main_Load(sender, e);
            }
        }


        //Delete items
        private void button1_Click(object sender, EventArgs e)
        {
            if (Form_User.i.Contains("1000000000"))
            {
                MessageBox.Show("Can not delete");
            }
            else
            {
                DialogResult msgresult = MessageBox.Show("Do you really want to detele?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (msgresult == DialogResult.Yes)
                {
                    Form fc01 = Application.OpenForms["Form_User"];
                    Form fc02 = Application.OpenForms["Form_Product"];
                    if (fc01 != null)
                    {
                        bd.Delete_User(ref err, Form_User.i);
                        userManageToolStripMenuItem_Click(sender, e);
                    }
                    if (fc02 != null)
                    {
                        bd.Delete_Product(ref err, Form_Product.i);
                        toolStrip_product.PerformClick();
                    }
                }
            }
        }

        private void lb_search_Click_1(object sender, EventArgs e)
        {
            txt_searchBar.Focus();
        }

        private void txt_searchBar_TextChanged(object sender, EventArgs e)
        {
            if (txt_searchBar.TextLength != 0)
            {
                lb_search.Visible = false;
            }
            else
            {
                lb_search.Visible = true;
            }
        }


        //Search here...
        private void btn_searchItems_Click(object sender, EventArgs e)
        {
            Search_Alert = txt_searchBar.Text;
            Search_Alert = Regex.Replace(Search_Alert, @"\s+", "_");

            Form fc01 = Application.OpenForms["Form_User"];
            Form fc02 = Application.OpenForms["Form_Product"];
            if (fc01 != null) toolStrip_userManage.PerformClick();
            if (fc02 != null) toolStrip_product.PerformClick();
            else { }
        }

        private void txt_searchBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_searchItems.PerformClick();
                e.Handled = true;
            }
        }

        //--------------------------------------------

        public void init_From(Form x)
        {
            List<Form> openForms = new List<Form>();

            foreach (Form f in Application.OpenForms)
                openForms.Add(f);

            foreach (Form f in openForms)
            {
                if (f.Name != "Login" && f.Name != this.Name && f.Name != x.Name)
                    f.Close();
            }
            x.FormBorderStyle = FormBorderStyle.None;
            x.TopLevel = false;
            x.AutoScroll = true;
            wapper_body_center_bottom.Controls.Add(x);
            x.Show();
        }

        private void toolStrip_Home_Click(object sender, EventArgs e)
        {
            while (wapper_body_center_bottom.Controls.Count > 0)
            {
                wapper_body_center_bottom.Controls[0].Dispose();
            }
            Form_Home f = new Form_Home();

            init_From(f);
            fHome = 1;
        }

        private void userManageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            while (wapper_body_center_bottom.Controls.Count > 0)
            {
                wapper_body_center_bottom.Controls[0].Dispose();
            }
            Form_User f = new Form_User();

            init_From(f);
        }

        private void toolStrip_productManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {

            while (wapper_body_center_bottom.Controls.Count > 0)
            {
                wapper_body_center_bottom.Controls[0].Dispose();
            }
            Form_Product f = new Form_Product();

            init_From(f);
        }

        private void toolStrip_addProduct_Click(object sender, EventArgs e)
        {
            Form_AddProduct f = new Form_AddProduct();
            f.ShowDialog();
            Form fc = Application.OpenForms["Form_Home"];

            if (f.Visible == false && Form_AddProduct.stateChange == 1)
            {
                if (fc != null) toolStrip_Home.PerformClick();
            }
        }
    }
}
