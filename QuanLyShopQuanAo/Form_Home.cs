using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace QuanLyShopQuanAo
{
    public partial class Form_Home : Form
    {
        string Hot_Today = "SELECT * FROM [Hot Today]";
        string Trending = "SELECT * FROM [Latest]";

        SqlConnection con = new SqlConnection("server=DESKTOP-64SRSV4; database=QuanLyShopQuanAo; Integrated Security=True");

        public Form_Home()
        {
            InitializeComponent();
        }

        private void Form_Home_Load(object sender, EventArgs e)
        {
            con.Open();

            hot_Today_Items();
            trending_Items();
        }

        public void hot_Today_Items()
        {
            listView1.Items.Clear();

            SqlDataAdapter sda = new SqlDataAdapter(new SqlCommand(Hot_Today, con));
            DataSet dataset = new DataSet();
            sda.Fill(dataset);

            for (int i = 0; i < 4; i++)
            {
                if (dataset.Tables[0].Rows[i]["Image"] != DBNull.Value)
                {
                    Byte[] outputIMG = new Byte[0];
                    outputIMG = (Byte[])(dataset.Tables[0].Rows[i]["Image"]);

                    MemoryStream mem = new MemoryStream(outputIMG);
                    imageList1.Images.Add(i.ToString(), Image.FromStream(mem));
                }
            }
            con.Close();
            listView1.LargeImageList = imageList1;

            for (int i = 0; i < 4; i++)
            {
                string outputTEXT = "";
                outputTEXT = (dataset.Tables[0].Rows[i]["ProductName"]).ToString();
                string outputPRICE = "";
                outputPRICE = (dataset.Tables[0].Rows[i]["Price"]).ToString();


                var listViewItem = listView1.Items.Add(outputTEXT + "\n" + outputPRICE);
                listViewItem.ImageKey = i.ToString();
            }
        }

        public void trending_Items()
        {
            listView2.Items.Clear();

            SqlDataAdapter sda = new SqlDataAdapter(new SqlCommand(Trending, con));
            DataSet dataset = new DataSet();
            sda.Fill(dataset);

            for (int i = 0; i < 4; i++)
            {
                if (dataset.Tables[0].Rows[i]["Image"] != DBNull.Value)
                {
                    Byte[] outputIMG = new Byte[0];
                    outputIMG = (Byte[])(dataset.Tables[0].Rows[i]["Image"]);

                    MemoryStream mem = new MemoryStream(outputIMG);
                    imageList2.Images.Add(i.ToString(), Image.FromStream(mem));
                }
            }
            con.Close();
            listView2.LargeImageList = imageList2;

            for (int i = 0; i < 4; i++)
            {

                string outputTEXT = "";
                outputTEXT = (dataset.Tables[0].Rows[i]["ProductName"]).ToString();
                string outputPRICE = "";
                outputPRICE = (dataset.Tables[0].Rows[i]["Price"]).ToString();


                var listViewItem = listView2.Items.Add(outputTEXT + "\n" + outputPRICE);
                listViewItem.ImageKey = i.ToString();
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter(new SqlCommand(Hot_Today, con));
            DataSet dataset = new DataSet();
            sda.Fill(dataset);

            int firstSelectedItem = listView1.Items.IndexOf(listView1.SelectedItems[0]);
            int ID = int.Parse(dataset.Tables[0].Rows[firstSelectedItem]["ProductID"].ToString());

            if (A_UName.ID_PERMISSON > 2)
            {
                ProductInfo_Guest f = new ProductInfo_Guest(ID);
                f.ShowDialog();
            }
            else if (A_UName.ID_PERMISSON < 3)
            {
                ProductInfo_Staff f = new ProductInfo_Staff(ID);
                f.ShowDialog();

                if (f.Visible == false && ProductInfo_Staff.stateChange == 1)
                {
                    hot_Today_Items();
                    trending_Items();
                }
            }
        }

        private void listView2_DoubleClick(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter(new SqlCommand(Trending, con));
            DataSet dataset = new DataSet();
            sda.Fill(dataset);

            int firstSelectedItem = listView2.Items.IndexOf(listView2.SelectedItems[0]);
            int ID = int.Parse(dataset.Tables[0].Rows[firstSelectedItem]["ProductID"].ToString());

            if (A_UName.ID_PERMISSON > 2)
            {
                ProductInfo_Guest f = new ProductInfo_Guest(ID);
                f.ShowDialog();
            }
            else if (A_UName.ID_PERMISSON < 3)
            {
                ProductInfo_Staff f = new ProductInfo_Staff(ID);
                f.ShowDialog();

                if (f.Visible == false && ProductInfo_Staff.stateChange == 1)
                {
                    hot_Today_Items();
                    trending_Items();
                }
            }
        }
    }
}
