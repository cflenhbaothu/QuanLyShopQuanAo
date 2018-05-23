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

namespace QuanLyShopQuanAo
{
    public partial class Form_DemoAddPic : Form
    {
        string filename;
        Class_Business bd = new Class_Business();
        string err = "";
        Byte[] data;

        public Form_DemoAddPic()
        {
            InitializeComponent();
        }

        private void btn_load_Click(object sender, EventArgs e)
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

        public byte[] convertImageToBinary(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (filename == "")
            {
                if (data.Length != 0) data = new byte[] { };
            }
            else
            {
                //Image temp = new Bitmap(filename);
                //MemoryStream strm = new MemoryStream();
                //temp.Save(strm, System.Drawing.Imaging.ImageFormat.Jpeg);
                //data = strm.ToArray();
                SqlConnection con = new SqlConnection("server=DESKTOP-64SRSV4; database=QuanLyShopQuanAo; Integrated Security=True");

                con.Open();
                ImageConverter imgcon = new ImageConverter();
                byte[] data = (System.Byte[])imgcon.ConvertTo(pictureBox1.Image, Type.GetType("System.Byte[]"));

                SqlCommand cmd = new SqlCommand("UPDATE Products SET [Image] = @data WHERE ProductID= " + int.Parse(textBox1.Text), con);
                cmd.Parameters.AddWithValue("@data", data);
                cmd.ExecuteNonQuery();
                
                MessageBox.Show("Done");

                string IMGdata = "SELECT [Image] FROM Products WHERE ProductID=" + int.Parse(textBox1.Text);
                SqlDataAdapter sda = new SqlDataAdapter(new SqlCommand(IMGdata, con));
                DataSet dataset = new DataSet();
                sda.Fill(dataset);

                if (dataset.Tables[0].Rows[0]["Image"] != DBNull.Value)
                {
                    Byte[] output = new Byte[0];
                    output = (Byte[])(dataset.Tables[0].Rows[0]["Image"]);
                    MemoryStream mem = new MemoryStream(output);
                    pictureBox2.Image = Image.FromStream(mem);
                }
                con.Close();
            }
        }
    }
}
