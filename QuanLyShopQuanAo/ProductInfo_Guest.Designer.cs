namespace QuanLyShopQuanAo
{
    partial class ProductInfo_Guest
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_productName = new System.Windows.Forms.Label();
            this.lb_productColor = new System.Windows.Forms.Label();
            this.lb_productGender = new System.Windows.Forms.Label();
            this.lb_productPrice = new System.Windows.Forms.Label();
            this.lb_productState = new System.Windows.Forms.Label();
            this.btn_buy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyShopQuanAo.Properties.Resources.NO_Image;
            this.pictureBox1.Location = new System.Drawing.Point(39, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 344);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lb_productName
            // 
            this.lb_productName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_productName.ForeColor = System.Drawing.Color.Firebrick;
            this.lb_productName.Location = new System.Drawing.Point(39, 422);
            this.lb_productName.Name = "lb_productName";
            this.lb_productName.Size = new System.Drawing.Size(258, 39);
            this.lb_productName.TabIndex = 2;
            this.lb_productName.Text = "product name";
            this.lb_productName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_productColor
            // 
            this.lb_productColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_productColor.ForeColor = System.Drawing.Color.Firebrick;
            this.lb_productColor.Location = new System.Drawing.Point(363, 37);
            this.lb_productColor.Name = "lb_productColor";
            this.lb_productColor.Size = new System.Drawing.Size(404, 38);
            this.lb_productColor.TabIndex = 3;
            this.lb_productColor.Text = "product color";
            this.lb_productColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_productGender
            // 
            this.lb_productGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_productGender.ForeColor = System.Drawing.Color.Firebrick;
            this.lb_productGender.Location = new System.Drawing.Point(363, 98);
            this.lb_productGender.Name = "lb_productGender";
            this.lb_productGender.Size = new System.Drawing.Size(404, 38);
            this.lb_productGender.TabIndex = 4;
            this.lb_productGender.Text = "product gender";
            this.lb_productGender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_productPrice
            // 
            this.lb_productPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_productPrice.ForeColor = System.Drawing.Color.Firebrick;
            this.lb_productPrice.Location = new System.Drawing.Point(363, 160);
            this.lb_productPrice.Name = "lb_productPrice";
            this.lb_productPrice.Size = new System.Drawing.Size(404, 38);
            this.lb_productPrice.TabIndex = 5;
            this.lb_productPrice.Text = "product price";
            this.lb_productPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_productState
            // 
            this.lb_productState.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_productState.ForeColor = System.Drawing.Color.Firebrick;
            this.lb_productState.Location = new System.Drawing.Point(363, 223);
            this.lb_productState.Name = "lb_productState";
            this.lb_productState.Size = new System.Drawing.Size(404, 38);
            this.lb_productState.TabIndex = 6;
            this.lb_productState.Text = "product state";
            this.lb_productState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_buy
            // 
            this.btn_buy.BackColor = System.Drawing.Color.Silver;
            this.btn_buy.FlatAppearance.BorderSize = 0;
            this.btn_buy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buy.Location = new System.Drawing.Point(368, 349);
            this.btn_buy.Name = "btn_buy";
            this.btn_buy.Size = new System.Drawing.Size(81, 31);
            this.btn_buy.TabIndex = 7;
            this.btn_buy.Text = "Buy";
            this.btn_buy.UseVisualStyleBackColor = false;
            // 
            // ProductInfo_Guest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(779, 589);
            this.Controls.Add(this.btn_buy);
            this.Controls.Add(this.lb_productState);
            this.Controls.Add(this.lb_productPrice);
            this.Controls.Add(this.lb_productGender);
            this.Controls.Add(this.lb_productColor);
            this.Controls.Add(this.lb_productName);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ProductInfo_Guest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductInfo";
            this.Load += new System.EventHandler(this.ProductInfo_Guest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_productName;
        private System.Windows.Forms.Label lb_productColor;
        private System.Windows.Forms.Label lb_productGender;
        private System.Windows.Forms.Label lb_productPrice;
        private System.Windows.Forms.Label lb_productState;
        private System.Windows.Forms.Button btn_buy;
    }
}