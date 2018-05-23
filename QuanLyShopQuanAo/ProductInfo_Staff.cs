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
using System.Text.RegularExpressions;

namespace QuanLyShopQuanAo
{
    public partial class ProductInfo_Staff : Form
    {
        int IDProduct = 0;
        public static int stateChange = 0;


        SqlConnection con = new SqlConnection("server=DESKTOP-64SRSV4; database=QuanLyShopQuanAo; Integrated Security=True");
        string load = "EXEC [Load Product] ";
        string filename, err;
        Class_Business bd = new Class_Business();

        public ProductInfo_Staff(int x)
        {
            IDProduct = x;
            InitializeComponent();
        }

        public void Product_Load(int x)
        {
            IDProduct = x;
            stateChange = 0;

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

            txt_name.Text = dataset.Tables[0].Rows[0]["ProductName"].ToString();
            txt_productColor.Text = dataset.Tables[0].Rows[0]["Color"].ToString();
            comboBox1.Text = dataset.Tables[0].Rows[0]["Gender"].ToString();
            txt_productPrice.Text = dataset.Tables[0].Rows[0]["Price"].ToString();
            txt_productAmount.Text = dataset.Tables[0].Rows[0]["Amount"].ToString();

        }

        private void ProductInfo_Staff_Load(object sender, EventArgs e)
        {
            Product_Load(IDProduct);
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (btn_Save.Visible == false)
            {
                btn_Edit.Text = "Cancel";
                btn_Save.Visible = true;
                txt_name.Enabled = txt_productColor.Enabled = txt_productAmount.Enabled = txt_productPrice.Enabled = comboBox1.Enabled = true;
                pictureBox1.Enabled = true;
            }
            else
            {
                btn_Edit.Text = "Edit";
                btn_Save.Visible = false;
                txt_name.Enabled = txt_productColor.Enabled = txt_productAmount.Enabled = txt_productPrice.Enabled = comboBox1.Enabled = false;
                pictureBox1.Enabled = false;
            }
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    filename = ofd.FileName;
                    pictureBox1.Image = Image.FromFile(filename);
                }
            }
        }

        private void txt_productAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_productPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                string _name = "";
                string _color = "";
                _name = Regex.Replace(txt_name.Text, @"\s+", " ");
                _color = Regex.Replace(txt_productColor.Text, @"\s+", " ");

                int _amount = int.Parse(txt_productAmount.Text);
                int _price = int.Parse(txt_productPrice.Text);

                if (_amount < 0) _amount = 0;
                if (_price < 0) _price = 0;

                bd.InsertToSQL(ref err, "EXEC [Update Product] " + IDProduct + ", " + "[" + _name + "], " + "[" + _color + "], " + "[" + comboBox1.Text + "], " + " " + _amount + ", " + _price);

                UpImage();

                MessageBox.Show("Successful!");
                stateChange = 1;

                btn_Edit.PerformClick();
            }
            catch
            {
                MessageBox.Show(err);
            }
        }

        public void UpImage()
        {
            SqlConnection con = new SqlConnection("server=DESKTOP-9TUE63E; database=QuanLyShopQuanAo; Integrated Security=True");

            if (err != "") { }
            else
            {
                con.Open();
                ImageConverter imgcon = new ImageConverter();
                byte[] data = (System.Byte[])imgcon.ConvertTo(pictureBox1.Image, Type.GetType("System.Byte[]"));

                SqlCommand cmd = new SqlCommand("UPDATE Products SET [Image] = @data WHERE ProductID= " + IDProduct, con);
                cmd.Parameters.AddWithValue("@data", data);
                cmd.ExecuteNonQuery();

                con.Close();
            }
        }
    }
}
