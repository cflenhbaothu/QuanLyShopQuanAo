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
    public partial class Form_User : Form
    {
        Class_Business bd = new Class_Business();
        Class_Search sr = new Class_Search();
        string err = string.Empty;
        public static string i = "";
        string A_permission = "SELECT * FROM Accounts";
        string B_permission = "SELECT * FROM Accounts WHERE permission > 2";

        public Form_User()
        {
            InitializeComponent();
        }

        private void Form_User_Load(object sender, EventArgs e)
        {
            if (Main.Search_Alert != "")
            {
                dataGridView1.DataSource = sr.search_UserFields(ref err, Main.Search_Alert);
                for (int i = 0; i < 8; i++)
                {
                    dataGridView1.Columns[i].ReadOnly = true;
                }
            }
            else
            {
                if (A_UName.ID_PERMISSON == 1) { dataGridView1.DataSource = bd.DataFields(ref err, A_permission); }
                if (A_UName.ID_PERMISSON == 2) { dataGridView1.DataSource = bd.DataFields(ref err, B_permission); }
                for (int i = 0; i < 8; i++)
                {
                    dataGridView1.Columns[i].ReadOnly = true;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataRowView drv = this.dataGridView1.CurrentRow.DataBoundItem as DataRowView;
            if (drv != null)
            {
                if (drv[8].ToString() == "True")
                {
                    if (i.Contains(drv[1].ToString()))
                    {

                    }
                    else
                    {
                        i += drv[0].ToString() + " ";
                    }
                }
                if (drv[8].ToString() == "False")
                {
                    i = i.Replace(drv[0].ToString() + " ", "");
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                DataRowView drv = this.dataGridView1.CurrentRow.DataBoundItem as DataRowView;
                if (drv != null)
                {
                    string a = drv[0].ToString();
                    MessageBox.Show(a);
                    Form_User_Load(sender, e);
                }
            }
        }
    }
}
