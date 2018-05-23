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
    public partial class Test : Form
    {
        string IMGdata = "SELECT * FROM [Hot Today]";

        public Test()
        {
            InitializeComponent();
        }

        private void Test_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server=DESKTOP-64SRSV4; database=QuanLyShopQuanAo; Integrated Security=True");

            con.Open();

            SqlDataAdapter sda = new SqlDataAdapter(new SqlCommand(IMGdata, con));
            DataSet dataset = new DataSet();
            sda.Fill(dataset);
            imageList1.ImageSize = new Size(146, 200);
            imageList1.ColorDepth = ColorDepth.Depth32Bit;

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

            for(int i = 0; i < 4; i++)
            {

                string outputTEXT = "";
                outputTEXT = (dataset.Tables[0].Rows[i]["ProductName"]).ToString();
                string outputPRICE = "";
                outputPRICE = (dataset.Tables[0].Rows[i]["Price"]).ToString();

                var listViewItem = listView1.Items.Add(outputTEXT+"\n"+outputPRICE);
                listViewItem.ImageKey = i.ToString();
            }
        }
    }
}
