namespace POS_ShopNShop
{
    partial class category
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
            rtxtDescription = new RichTextBox();
            txtName = new TextBox();
            label3 = new Label();
            btnSave = new Button();
            pictureBox2 = new PictureBox();
            lblUpdate = new Label();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.arrow_back_3783;
            pictureBox1.Location = new Point(25, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(86, 134);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 1;
            label1.Text = "Category Name:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(116, 188);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 2;
            label2.Text = "Description:";
            label2.Click += label2_Click;
            // 
            // rtxtDescription
            // 
            rtxtDescription.Location = new Point(215, 185);
            rtxtDescription.Name = "rtxtDescription";
            rtxtDescription.Size = new Size(307, 84);
            rtxtDescription.TabIndex = 3;
            rtxtDescription.Text = "";
            // 
            // txtName
            // 
            txtName.Location = new Point(215, 131);
            txtName.Name = "txtName";
            txtName.Size = new Size(307, 27);
            txtName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.MediumSlateBlue;
            label3.Location = new Point(396, 28);
            label3.Name = "label3";
            label3.Size = new Size(220, 25);
            label3.TabIndex = 5;
            label3.Text = "Enlist a product category";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.MediumPurple;
            btnSave.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(426, 296);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(96, 39);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.updated;
            pictureBox2.Location = new Point(739, 149);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(88, 76);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // lblUpdate
            // 
            lblUpdate.AutoSize = true;
            lblUpdate.BackColor = SystemColors.ControlLightLight;
            lblUpdate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblUpdate.Location = new Point(713, 238);
            lblUpdate.Name = "lblUpdate";
            lblUpdate.Size = new Size(138, 20);
            lblUpdate.TabIndex = 9;
            lblUpdate.Text = "Update a Category";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(704, 130);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(156, 137);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click_1;
            // 
            // category
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(lblUpdate);
            Controls.Add(pictureBox2);
            Controls.Add(btnSave);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(rtxtDescription);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnUpdate);
            Name = "category";
            Text = "category";
            Load += category_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void dataGridViewCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private RichTextBox rtxtDescription;
        private TextBox txtName;
        private Label label3;
        private Button btnSave;
        private PictureBox pictureBox2;
        private Label lblUpdate;
        private Button btnUpdate;
    }
}