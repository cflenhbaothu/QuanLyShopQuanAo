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
    public partial class Form_Product : Form
    {
        Class_Business bd = new Class_Business();
        string err = string.Empty;
        public static string i = "";
        string A_permission = "SELECT * FROM [Current All Product List]";
        string C_permission = "SELECT * FROM [Current Product List For Guest]";

        public Form_Product()
        {
            InitializeComponent();
        }

        private void Form_Product_Load(object sender, EventArgs e)
        {
            if (Main.Search_Alert != "")
            {

                if (A_UName.ID_PERMISSON == 3)
                {
                    dataGridView1.DataSource = bd.DataFields(ref err, "EXEC [Search Product With C] " + Main.Search_Alert);
                    for (int i = 0; i <= 5; i++)
                    {
                        dataGridView1.Columns[i].ReadOnly = true;
                    }
                }
                else
                {
                    dataGridView1.DataSource = bd.DataFields(ref err, "EXEC [Search Product With A] " + Main.Search_Alert);
                    for (int i = 0; i < 8; i++)
                    {
                        dataGridView1.Columns[i].ReadOnly = true;
                    }
                }
            }
            else
            {

                if (A_UName.ID_PERMISSON == 3)
                {
                    dataGridView1.DataSource = bd.DataFields(ref err, C_permission);
                    for (int i = 0; i <= 5; i++)
                    {
                        dataGridView1.Columns[i].ReadOnly = true;
                    }
                }
                else
                {
                    dataGridView1.DataSource = bd.DataFields(ref err, A_permission);
                    for (int i = 0; i < 8; i++)
                    {
                        dataGridView1.Columns[i].ReadOnly = true;
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                DataRowView drv = this.dataGridView1.CurrentRow.DataBoundItem as DataRowView;
                if (drv != null)
                {
                    int a = int.Parse(drv[0].ToString());
                    bd.UpdateFields(ref err, "EXEC [Increase View] " + a);

                    if (A_UName.ID_PERMISSON > 2)
                    {
                        ProductInfo_Guest f = new ProductInfo_Guest(a);
                        f.ShowDialog();
                    }
                    else if (A_UName.ID_PERMISSON < 3)
                    {
                        ProductInfo_Staff f = new ProductInfo_Staff(a);
                        f.ShowDialog();
                        
                        if (f.Visible==false && ProductInfo_Staff.stateChange==1)
                        {
                            Form_Product_Load(sender, e);
                        }
                    }
                }
            }
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
    }
}
