using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace QuanLyShopQuanAo
{
    public partial class Form_AddProduct : Form
    {
        string filename;
        string err = string.Empty;
        public static int stateChange = 0;
        Class_Business bd = new Class_Business();

        public Form_AddProduct()
        {
            InitializeComponent();
        }

        private void Form_AddProduct_Load(object sender, EventArgs e)
        {
            pictureBox1.Tag = "Unchecked";
            stateChange = 0;
        }

        private void txt_productID_TextChanged(object sender, EventArgs e)
        {
            if (txt_productID.TextLength > 0)
                lb_productID.Visible = false;
            else lb_productID.Visible = true;
        }

        private void lb_productID_Click(object sender, EventArgs e)
        {
            txt_productID.Focus();
        }

        private void txt_productName_TextChanged(object sender, EventArgs e)
        {
            if (txt_productName.TextLength > 0)
                lb_productName.Visible = false;
            else lb_productName.Visible = true;
        }

        private void lb_productName_Click(object sender, EventArgs e)
        {
            txt_productName.Focus();
        }

        private void txt_productColor_TextChanged(object sender, EventArgs e)
        {
            if (txt_productColor.TextLength > 0)
                lb_productColor.Visible = false;
            else lb_productColor.Visible = true;
        }

        private void lb_productColor_Click(object sender, EventArgs e)
        {
            txt_productColor.Focus();
        }

        private void txt_productAmount_TextChanged(object sender, EventArgs e)
        {
            if (txt_productAmount.TextLength > 0)
                lb_productAmount.Visible = false;
            else lb_productAmount.Visible = true;
        }

        private void lb_productAmount_Click(object sender, EventArgs e)
        {
            txt_productAmount.Focus();
        }

        private void txt_productPrice_TextChanged(object sender, EventArgs e)
        {
            if (txt_productPrice.TextLength > 0)
                lb_productPrice.Visible = false;
            else lb_productPrice.Visible = true;
        }

        private void lb_productPrice_Click(object sender, EventArgs e)
        {
            txt_productPrice.Focus();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    filename = ofd.FileName;
                    pictureBox1.Image = Image.FromFile(filename);
                    pictureBox1.Tag = "Checked";
                }
                else
                {
                    if (pictureBox1.Tag.ToString() == "Checked") { }
                }
            }
        }

        public byte[] convertImageToBinary(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            err = string.Empty;
            if (txt_productName.TextLength == 0 || txt_productID.TextLength == 0 || txt_productColor.TextLength == 0 || txt_productAmount.TextLength == 0 || txt_productPrice.TextLength == 0 || comboBox1.Text == "" || pictureBox1.Tag.ToString() == "Unchecked")
            {
                MessageBox.Show("Please fill all the fields!");
            }
            else
            {
                string sql = "EXEC [Add Product] " + int.Parse(txt_productID.Text) + ", [" + txt_productName.Text + "], [" + txt_productColor.Text + "], " + comboBox1.Text + ", " + int.Parse(txt_productAmount.Text) + ", " + int.Parse(txt_productPrice.Text);

                bd.InsertToSQL(ref err, sql);

                SqlConnection con = new SqlConnection("server=DESKTOP-64SRSV4; database=QuanLyShopQuanAo; Integrated Security=True");

                if (err != "") MessageBox.Show(err);
                else
                {
                    con.Open();
                    ImageConverter imgcon = new ImageConverter();
                    byte[] data = (System.Byte[])imgcon.ConvertTo(pictureBox1.Image, Type.GetType("System.Byte[]"));

                    SqlCommand cmd = new SqlCommand("UPDATE Products SET [Image] = @data WHERE ProductID= " + int.Parse(txt_productID.Text), con);
                    cmd.Parameters.AddWithValue("@data", data);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show(err + "successfully");
                    con.Close();
                }
                stateChange = 1;
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_productID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_productID.TextLength <= 10)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            else { e.Handled = true; }
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
    }
}
