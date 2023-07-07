namespace POS_ShopNShop
{
    partial class product
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            cmbCategory = new ComboBox();
            rtxProductDescription = new RichTextBox();
            txtName = new TextBox();
            txtPrice = new TextBox();
            txtVAT = new TextBox();
            cbIsDiscountAllow = new CheckBox();
            btnSaveProduct = new Button();
            lblUpdate = new Label();
            pictureBox2 = new PictureBox();
            btnUpdateProduct = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.arrow_back_3783;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.MediumPurple;
            label1.Location = new Point(391, 39);
            label1.Name = "label1";
            label1.Size = new Size(171, 25);
            label1.TabIndex = 1;
            label1.Text = "Add a new product";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(89, 191);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 2;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(96, 236);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 3;
            label3.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(512, 144);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 4;
            label4.Text = "Description";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(82, 285);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 5;
            label5.Text = "VAT pt.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(68, 144);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 6;
            label6.Text = "Category";
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(183, 144);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(212, 28);
            cmbCategory.TabIndex = 8;
            // 
            // rtxProductDescription
            // 
            rtxProductDescription.Location = new Point(617, 144);
            rtxProductDescription.Name = "rtxProductDescription";
            rtxProductDescription.Size = new Size(294, 213);
            rtxProductDescription.TabIndex = 9;
            rtxProductDescription.Text = "";
            // 
            // txtName
            // 
            txtName.Location = new Point(183, 184);
            txtName.Name = "txtName";
            txtName.Size = new Size(190, 27);
            txtName.TabIndex = 10;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(183, 229);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(190, 27);
            txtPrice.TabIndex = 11;
            // 
            // txtVAT
            // 
            txtVAT.Location = new Point(183, 282);
            txtVAT.Name = "txtVAT";
            txtVAT.Size = new Size(190, 27);
            txtVAT.TabIndex = 12;
            // 
            // cbIsDiscountAllow
            // 
            cbIsDiscountAllow.AutoSize = true;
            cbIsDiscountAllow.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cbIsDiscountAllow.Location = new Point(183, 354);
            cbIsDiscountAllow.Name = "cbIsDiscountAllow";
            cbIsDiscountAllow.Size = new Size(133, 24);
            cbIsDiscountAllow.TabIndex = 13;
            cbIsDiscountAllow.Text = "Allow Discount";
            cbIsDiscountAllow.UseVisualStyleBackColor = true;
            // 
            // btnSaveProduct
            // 
            btnSaveProduct.BackColor = Color.MediumPurple;
            btnSaveProduct.ForeColor = SystemColors.ButtonHighlight;
            btnSaveProduct.Location = new Point(183, 448);
            btnSaveProduct.Name = "btnSaveProduct";
            btnSaveProduct.Size = new Size(101, 39);
            btnSaveProduct.TabIndex = 14;
            btnSaveProduct.Text = "Save";
            btnSaveProduct.UseVisualStyleBackColor = false;
            btnSaveProduct.Click += btnSaveProduct_Click;
            // 
            // lblUpdate
            // 
            lblUpdate.AutoSize = true;
            lblUpdate.BackColor = Color.LightGreen;
            lblUpdate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblUpdate.Location = new Point(697, 466);
            lblUpdate.Name = "lblUpdate";
            lblUpdate.Size = new Size(117, 20);
            lblUpdate.TabIndex = 16;
            lblUpdate.Text = "Update Product";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.LightGreen;
            pictureBox2.Image = Properties.Resources.updated;
            pictureBox2.Location = new Point(722, 416);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(63, 47);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // btnUpdateProduct
            // 
            btnUpdateProduct.BackColor = Color.LightGreen;
            btnUpdateProduct.Location = new Point(691, 395);
            btnUpdateProduct.Name = "btnUpdateProduct";
            btnUpdateProduct.Size = new Size(126, 101);
            btnUpdateProduct.TabIndex = 17;
            btnUpdateProduct.Text = "Update";
            btnUpdateProduct.UseVisualStyleBackColor = false;
            btnUpdateProduct.Click += btnUpdateProduct_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.ForeColor = SystemColors.ButtonHighlight;
            btnExit.Location = new Point(817, 49);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 37);
            btnExit.TabIndex = 18;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // product
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(btnExit);
            Controls.Add(lblUpdate);
            Controls.Add(pictureBox2);
            Controls.Add(btnUpdateProduct);
            Controls.Add(btnSaveProduct);
            Controls.Add(cbIsDiscountAllow);
            Controls.Add(txtVAT);
            Controls.Add(txtPrice);
            Controls.Add(txtName);
            Controls.Add(rtxProductDescription);
            Controls.Add(cmbCategory);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "product";
            Text = "product";
            Load += product_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox cmbCategory;
        private RichTextBox rtxProductDescription;
        private TextBox txtName;
        private TextBox txtPrice;
        private TextBox txtVAT;
        private CheckBox cbIsDiscountAllow;
        private Button btnSaveProduct;
        private Label lblUpdate;
        private PictureBox pictureBox2;
        private Button btnUpdateProduct;
        private Button btnExit;
    }
}