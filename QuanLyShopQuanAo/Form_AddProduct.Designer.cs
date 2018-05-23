namespace QuanLyShopQuanAo
{
    partial class Form_AddProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_productID = new System.Windows.Forms.Label();
            this.txt_productID = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_productName = new System.Windows.Forms.Label();
            this.txt_productName = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lb_productColor = new System.Windows.Forms.Label();
            this.txt_productColor = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lb_productAmount = new System.Windows.Forms.Label();
            this.txt_productAmount = new System.Windows.Forms.RichTextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lb_productPrice = new System.Windows.Forms.Label();
            this.txt_productPrice = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.lb_productID);
            this.panel1.Controls.Add(this.txt_productID);
            this.panel1.Location = new System.Drawing.Point(297, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 39);
            this.panel1.TabIndex = 18;
            // 
            // lb_productID
            // 
            this.lb_productID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lb_productID.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lb_productID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_productID.ForeColor = System.Drawing.Color.Gray;
            this.lb_productID.Location = new System.Drawing.Point(10, 9);
            this.lb_productID.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.lb_productID.Name = "lb_productID";
            this.lb_productID.Size = new System.Drawing.Size(83, 20);
            this.lb_productID.TabIndex = 4;
            this.lb_productID.Text = "Product ID";
            this.lb_productID.Click += new System.EventHandler(this.lb_productID_Click);
            // 
            // txt_productID
            // 
            this.txt_productID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_productID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_productID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_productID.Location = new System.Drawing.Point(8, 9);
            this.txt_productID.Name = "txt_productID";
            this.txt_productID.Size = new System.Drawing.Size(286, 22);
            this.txt_productID.TabIndex = 5;
            this.txt_productID.Text = "";
            this.txt_productID.TextChanged += new System.EventHandler(this.txt_productID_TextChanged);
            this.txt_productID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_productID_KeyPress);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.lb_productName);
            this.panel2.Controls.Add(this.txt_productName);
            this.panel2.Location = new System.Drawing.Point(297, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(302, 39);
            this.panel2.TabIndex = 19;
            // 
            // lb_productName
            // 
            this.lb_productName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lb_productName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lb_productName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_productName.ForeColor = System.Drawing.Color.Gray;
            this.lb_productName.Location = new System.Drawing.Point(10, 9);
            this.lb_productName.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.lb_productName.Name = "lb_productName";
            this.lb_productName.Size = new System.Drawing.Size(115, 20);
            this.lb_productName.TabIndex = 4;
            this.lb_productName.Text = "Product Name";
            this.lb_productName.Click += new System.EventHandler(this.lb_productName_Click);
            // 
            // txt_productName
            // 
            this.txt_productName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_productName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_productName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_productName.Location = new System.Drawing.Point(8, 9);
            this.txt_productName.Name = "txt_productName";
            this.txt_productName.Size = new System.Drawing.Size(286, 22);
            this.txt_productName.TabIndex = 5;
            this.txt_productName.Text = "";
            this.txt_productName.TextChanged += new System.EventHandler(this.txt_productName_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.Controls.Add(this.lb_productColor);
            this.panel3.Controls.Add(this.txt_productColor);
            this.panel3.Location = new System.Drawing.Point(297, 129);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(302, 39);
            this.panel3.TabIndex = 20;
            // 
            // lb_productColor
            // 
            this.lb_productColor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lb_productColor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lb_productColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_productColor.ForeColor = System.Drawing.Color.Gray;
            this.lb_productColor.Location = new System.Drawing.Point(10, 9);
            this.lb_productColor.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.lb_productColor.Name = "lb_productColor";
            this.lb_productColor.Size = new System.Drawing.Size(101, 20);
            this.lb_productColor.TabIndex = 4;
            this.lb_productColor.Text = "Product Color";
            this.lb_productColor.Click += new System.EventHandler(this.lb_productColor_Click);
            // 
            // txt_productColor
            // 
            this.txt_productColor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_productColor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_productColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_productColor.Location = new System.Drawing.Point(8, 9);
            this.txt_productColor.Name = "txt_productColor";
            this.txt_productColor.Size = new System.Drawing.Size(286, 22);
            this.txt_productColor.TabIndex = 5;
            this.txt_productColor.Text = "";
            this.txt_productColor.TextChanged += new System.EventHandler(this.txt_productColor_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBox1.Location = new System.Drawing.Point(297, 186);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(302, 28);
            this.comboBox1.TabIndex = 21;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel4.Controls.Add(this.lb_productAmount);
            this.panel4.Controls.Add(this.txt_productAmount);
            this.panel4.Location = new System.Drawing.Point(297, 232);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(302, 39);
            this.panel4.TabIndex = 22;
            // 
            // lb_productAmount
            // 
            this.lb_productAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lb_productAmount.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lb_productAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_productAmount.ForeColor = System.Drawing.Color.Gray;
            this.lb_productAmount.Location = new System.Drawing.Point(10, 9);
            this.lb_productAmount.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.lb_productAmount.Name = "lb_productAmount";
            this.lb_productAmount.Size = new System.Drawing.Size(125, 20);
            this.lb_productAmount.TabIndex = 4;
            this.lb_productAmount.Text = "Product Amount";
            this.lb_productAmount.Click += new System.EventHandler(this.lb_productAmount_Click);
            // 
            // txt_productAmount
            // 
            this.txt_productAmount.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_productAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_productAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_productAmount.Location = new System.Drawing.Point(8, 9);
            this.txt_productAmount.Name = "txt_productAmount";
            this.txt_productAmount.Size = new System.Drawing.Size(286, 22);
            this.txt_productAmount.TabIndex = 5;
            this.txt_productAmount.Text = "";
            this.txt_productAmount.TextChanged += new System.EventHandler(this.txt_productAmount_TextChanged);
            this.txt_productAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_productAmount_KeyPress);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel5.Controls.Add(this.lb_productPrice);
            this.panel5.Controls.Add(this.txt_productPrice);
            this.panel5.Location = new System.Drawing.Point(297, 287);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(302, 39);
            this.panel5.TabIndex = 23;
            // 
            // lb_productPrice
            // 
            this.lb_productPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lb_productPrice.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lb_productPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_productPrice.ForeColor = System.Drawing.Color.Gray;
            this.lb_productPrice.Location = new System.Drawing.Point(10, 9);
            this.lb_productPrice.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.lb_productPrice.Name = "lb_productPrice";
            this.lb_productPrice.Size = new System.Drawing.Size(101, 20);
            this.lb_productPrice.TabIndex = 4;
            this.lb_productPrice.Text = "Product Price";
            this.lb_productPrice.Click += new System.EventHandler(this.lb_productPrice_Click);
            // 
            // txt_productPrice
            // 
            this.txt_productPrice.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_productPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_productPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_productPrice.Location = new System.Drawing.Point(8, 9);
            this.txt_productPrice.Name = "txt_productPrice";
            this.txt_productPrice.Size = new System.Drawing.Size(286, 22);
            this.txt_productPrice.TabIndex = 5;
            this.txt_productPrice.Text = "";
            this.txt_productPrice.TextChanged += new System.EventHandler(this.txt_productPrice_TextChanged);
            this.txt_productPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_productPrice_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyShopQuanAo.Properties.Resources.NO_Image;
            this.pictureBox1.Location = new System.Drawing.Point(9, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 344);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.DarkGray;
            this.btn_Save.FlatAppearance.BorderSize = 0;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Save.Location = new System.Drawing.Point(411, 342);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 24;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.DarkGray;
            this.btn_Cancel.FlatAppearance.BorderSize = 0;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Cancel.Location = new System.Drawing.Point(524, 342);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 25;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // Form_AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(637, 392);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_AddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_AddProduct";
            this.Load += new System.EventHandler(this.Form_AddProduct_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_productID;
        private System.Windows.Forms.RichTextBox txt_productID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb_productName;
        private System.Windows.Forms.RichTextBox txt_productName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lb_productColor;
        private System.Windows.Forms.RichTextBox txt_productColor;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lb_productAmount;
        private System.Windows.Forms.RichTextBox txt_productAmount;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lb_productPrice;
        private System.Windows.Forms.RichTextBox txt_productPrice;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Cancel;
    }
}