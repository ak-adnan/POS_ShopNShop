namespace POS_ShopNShop
{
    partial class dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            label3 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            lblName = new Label();
            btnLogOut = new Button();
            pictureBox4 = new PictureBox();
            label6 = new Label();
            pictureBox5 = new PictureBox();
            label2 = new Label();
            pictureBox6 = new PictureBox();
            label5 = new Label();
            label1 = new Label();
            btnStock = new Button();
            btnCategory = new Button();
            btnProduct = new Button();
            btnCustomer = new Button();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            btnCheckOut = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Popup;
            label3.Font = new Font("Sweet Sensations Personal Use", 47.9999962F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.MediumSlateBlue;
            label3.Location = new Point(331, 9);
            label3.Name = "label3";
            label3.Size = new Size(331, 98);
            label3.TabIndex = 4;
            label3.Text = "Shop n Shop";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(172, 162);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(146, 134);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.User_icon;
            pictureBox1.Location = new Point(31, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(51, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Tahoma", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblName.Location = new Point(31, 89);
            lblName.Name = "lblName";
            lblName.Size = new Size(85, 18);
            lblName.TabIndex = 7;
            lblName.Text = "Welcome, ";
            lblName.Click += lblName_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.Location = new Point(876, 38);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(94, 29);
            btnLogOut.TabIndex = 6;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click_1;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.OrangeRed;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(396, 175);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(81, 61);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.OrangeRed;
            label6.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(413, 246);
            label6.Name = "label6";
            label6.Size = new Size(51, 19);
            label6.TabIndex = 2;
            label6.Text = "Stock";
            label6.Click += label6_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(385, 309);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(160, 122);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 3;
            pictureBox5.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Chartreuse;
            label2.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(402, 444);
            label2.Name = "label2";
            label2.Size = new Size(117, 19);
            label2.TabIndex = 1;
            label2.Text = "Add a Product";
            label2.Click += label2_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Turquoise;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(599, 309);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(98, 83);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 3;
            pictureBox6.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Turquoise;
            label5.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(604, 398);
            label5.Name = "label5";
            label5.Size = new Size(87, 19);
            label5.TabIndex = 2;
            label5.Text = "Check Out";
            label5.Click += label5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(185, 309);
            label1.Name = "label1";
            label1.Size = new Size(124, 19);
            label1.TabIndex = 0;
            label1.Text = "Add a category";
            // 
            // btnStock
            // 
            btnStock.BackColor = Color.OrangeRed;
            btnStock.Location = new Point(366, 149);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(143, 124);
            btnStock.TabIndex = 12;
            btnStock.Text = "Stock";
            btnStock.UseVisualStyleBackColor = false;
            btnStock.Click += btnStock_Click;
            // 
            // btnCategory
            // 
            btnCategory.Location = new Point(136, 149);
            btnCategory.Name = "btnCategory";
            btnCategory.Size = new Size(213, 197);
            btnCategory.TabIndex = 13;
            btnCategory.Text = "button1";
            btnCategory.UseVisualStyleBackColor = true;
            btnCategory.Click += btnCategory_Click;
            // 
            // btnProduct
            // 
            btnProduct.BackColor = Color.Chartreuse;
            btnProduct.Location = new Point(366, 289);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(199, 195);
            btnProduct.TabIndex = 14;
            btnProduct.Text = "Product";
            btnProduct.UseVisualStyleBackColor = false;
            btnProduct.Click += btnProduct_Click;
            // 
            // btnCustomer
            // 
            btnCustomer.BackColor = Color.RoyalBlue;
            btnCustomer.ForeColor = Color.RoyalBlue;
            btnCustomer.Location = new Point(515, 149);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(270, 134);
            btnCustomer.TabIndex = 15;
            btnCustomer.Text = "Customer";
            btnCustomer.UseVisualStyleBackColor = false;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.RoyalBlue;
            label4.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(601, 254);
            label4.Name = "label4";
            label4.Size = new Size(82, 19);
            label4.TabIndex = 2;
            label4.Text = "Customer";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.RoyalBlue;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(590, 162);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(107, 83);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // btnCheckOut
            // 
            btnCheckOut.BackColor = Color.Turquoise;
            btnCheckOut.Location = new Point(571, 298);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(161, 133);
            btnCheckOut.TabIndex = 16;
            btnCheckOut.Text = "Check Out";
            btnCheckOut.UseVisualStyleBackColor = false;
            // 
            // dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(label5);
            Controls.Add(pictureBox6);
            Controls.Add(btnCheckOut);
            Controls.Add(label4);
            Controls.Add(pictureBox2);
            Controls.Add(btnCustomer);
            Controls.Add(label2);
            Controls.Add(pictureBox5);
            Controls.Add(btnProduct);
            Controls.Add(label6);
            Controls.Add(pictureBox4);
            Controls.Add(btnStock);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(btnLogOut);
            Controls.Add(pictureBox1);
            Controls.Add(lblName);
            Controls.Add(label3);
            Controls.Add(btnCategory);
            Name = "dashboard";
            Text = "dashboard";
            Load += dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label3;
        private PictureBox pictureBox1;
        private Label lblName;
        private Button btnLogOut;
        private Label label2;
        private Label label6;
        private Label label5;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Label label1;
        private Button btnStock;
        private Button btnCategory;
        private Button btnProduct;
        private Button btnCustomer;
        private Label label4;
        private PictureBox pictureBox2;
        private Button btnCheckOut;
    }
}