namespace POS_ShopNShop
{
    partial class customer
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
            txtname = new TextBox();
            txtMobile = new TextBox();
            txtEmail = new TextBox();
            txtAddress = new TextBox();
            btnSave = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.arrow_back_3783;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.MediumPurple;
            label1.Location = new Point(363, 41);
            label1.Name = "label1";
            label1.Size = new Size(200, 28);
            label1.TabIndex = 1;
            label1.Text = "Add a new customer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(159, 154);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 2;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(148, 220);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 3;
            label3.Text = "Contact";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(162, 284);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 4;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(146, 347);
            label5.Name = "label5";
            label5.Size = new Size(63, 20);
            label5.TabIndex = 5;
            label5.Text = "Address";
            // 
            // txtname
            // 
            txtname.Location = new Point(271, 147);
            txtname.Name = "txtname";
            txtname.Size = new Size(232, 27);
            txtname.TabIndex = 6;
            // 
            // txtMobile
            // 
            txtMobile.Location = new Point(271, 213);
            txtMobile.Name = "txtMobile";
            txtMobile.Size = new Size(232, 27);
            txtMobile.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(271, 281);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(232, 27);
            txtEmail.TabIndex = 8;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(271, 344);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(232, 27);
            txtAddress.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.CornflowerBlue;
            btnSave.Location = new Point(335, 412);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(96, 39);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.pngtree_add_customers_icon_color_flat_png_image_7822733;
            pictureBox2.Location = new Point(568, 99);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(375, 352);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // customer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(pictureBox2);
            Controls.Add(btnSave);
            Controls.Add(txtAddress);
            Controls.Add(txtEmail);
            Controls.Add(txtMobile);
            Controls.Add(txtname);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "customer";
            Text = "customer";
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
        private TextBox txtname;
        private TextBox txtMobile;
        private TextBox txtEmail;
        private TextBox txtAddress;
        private Button btnSave;
        private PictureBox pictureBox2;
    }
}