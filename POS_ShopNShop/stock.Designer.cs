namespace POS_ShopNShop
{
    partial class stock
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            btnExit = new Button();
            btnSave = new Button();
            cmbName = new ComboBox();
            txtQty = new TextBox();
            dtpExpiryDate = new DateTimePicker();
            lblUpdate = new Label();
            pictureBox2 = new PictureBox();
            btnUpdateStock = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.OrangeRed;
            label1.Location = new Point(391, 44);
            label1.Name = "label1";
            label1.Size = new Size(208, 31);
            label1.TabIndex = 0;
            label1.Text = "Add Product Stock";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(94, 153);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 1;
            label2.Text = "Product name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(131, 217);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 2;
            label3.Text = "Quantity";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(110, 270);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 3;
            label4.Text = "Expiry Date";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.arrow_back_37831;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.ForeColor = SystemColors.ButtonHighlight;
            btnExit.Location = new Point(880, 32);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(78, 32);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.DodgerBlue;
            btnSave.Location = new Point(324, 349);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(76, 37);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // cmbName
            // 
            cmbName.FormattingEnabled = true;
            cmbName.Location = new Point(260, 153);
            cmbName.Name = "cmbName";
            cmbName.Size = new Size(213, 28);
            cmbName.TabIndex = 7;
            // 
            // txtQty
            // 
            txtQty.Location = new Point(260, 210);
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(180, 27);
            txtQty.TabIndex = 8;
            // 
            // dtpExpiryDate
            // 
            dtpExpiryDate.Location = new Point(260, 263);
            dtpExpiryDate.Name = "dtpExpiryDate";
            dtpExpiryDate.Size = new Size(213, 27);
            dtpExpiryDate.TabIndex = 9;
            // 
            // lblUpdate
            // 
            lblUpdate.AutoSize = true;
            lblUpdate.BackColor = Color.LightGreen;
            lblUpdate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblUpdate.Location = new Point(716, 248);
            lblUpdate.Name = "lblUpdate";
            lblUpdate.Size = new Size(100, 20);
            lblUpdate.TabIndex = 19;
            lblUpdate.Text = "Update Stock";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.LightGreen;
            pictureBox2.Image = Properties.Resources.updated;
            pictureBox2.Location = new Point(732, 198);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(63, 47);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // btnUpdateStock
            // 
            btnUpdateStock.BackColor = Color.LightGreen;
            btnUpdateStock.Location = new Point(701, 177);
            btnUpdateStock.Name = "btnUpdateStock";
            btnUpdateStock.Size = new Size(126, 101);
            btnUpdateStock.TabIndex = 20;
            btnUpdateStock.Text = "Update";
            btnUpdateStock.UseVisualStyleBackColor = false;
            btnUpdateStock.Click += btnUpdateStock_Click;
            // 
            // stock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(lblUpdate);
            Controls.Add(pictureBox2);
            Controls.Add(btnUpdateStock);
            Controls.Add(dtpExpiryDate);
            Controls.Add(txtQty);
            Controls.Add(cmbName);
            Controls.Add(btnSave);
            Controls.Add(btnExit);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "stock";
            Text = "stock";
            Load += stock_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
        private Button btnExit;
        private Button btnSave;
        private ComboBox cmbName;
        private TextBox txtQty;
        private DateTimePicker dtpExpiryDate;
        private Label lblUpdate;
        private PictureBox pictureBox2;
        private Button btnUpdateStock;
    }
}