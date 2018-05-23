using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace QuanLyShopQuanAo
{
    public partial class ProductInfo_Guest : Form
    {
        int IDProduct = 0;

        SqlConnection con = new SqlConnection("server=DESKTOP-64SRSV4; database=QuanLyShopQuanAo; Integrated Security=True");
        string load = "EXEC [Load Product] ";

        public ProductInfo_Guest(int x)
        {
            IDProduct = x;
            InitializeComponent();
        }

        public void Product_Load(int x)
        {
            SqlDataAdapter sda = new SqlDataAdapter(new SqlCommand(load + IDProduct, con));
            DataSet dataset = new DataSet();
            sda.Fill(dataset);

            if (dataset.Tables[0].Rows[0]["Image"] != DBNull.Value)
            {
                Byte[] outputIMG = new Byte[0];
                outputIMG = (Byte[])(dataset.Tables[0].Rows[0]["Image"]);

                MemoryStream mem = new MemoryStream(outputIMG);
                pictureBox1.Image = Image.FromStream(mem);
            }
            else
            {
                pictureBox1.Image = Properties.Resources.NO_Image;
            }

            lb_productName.Text = dataset.Tables[0].Rows[0]["ProductName"].ToString();
            lb_productColor.Text = "Color: " + dataset.Tables[0].Rows[0]["Color"].ToString();
            lb_productGender.Text = "Gender: " + dataset.Tables[0].Rows[0]["Gender"].ToString();
            lb_productPrice.Text = "Price: " + dataset.Tables[0].Rows[0]["Price"].ToString() + " (đ)";

            if (int.Parse(dataset.Tables[0].Rows[0]["Amount"].ToString()) > 0)
            {
                lb_productState.Text = "State: Stocking";
            }
            else
            {
                lb_productState.Text = "State: Out of stocking";
            }
        }

        private void ProductInfo_Guest_Load(object sender, EventArgs e)
        {
            Product_Load(IDProduct);
        }
    }
}
