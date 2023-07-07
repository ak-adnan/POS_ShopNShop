namespace POS_ShopNShop
{
    partial class login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            btnLogin = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label3 = new Label();
            btnExit = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Text Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(111, 72);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Text Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(115, 160);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(601, 81);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(305, 389);
            panel1.TabIndex = 2;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.BlueViolet;
            btnLogin.Location = new Point(111, 265);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(104, 41);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Log In";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(51, 195);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Enter password";
            txtPassword.Size = new Size(212, 27);
            txtPassword.TabIndex = 3;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.Window;
            txtUsername.ForeColor = SystemColors.WindowText;
            txtUsername.Location = new Point(51, 110);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Enter username";
            txtUsername.Size = new Size(212, 27);
            txtUsername.TabIndex = 2;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Popup;
            label3.Font = new Font("Sweet Sensations Personal Use", 47.9999962F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.MediumSlateBlue;
            label3.Location = new Point(122, 205);
            label3.Name = "label3";
            label3.Size = new Size(331, 98);
            label3.TabIndex = 3;
            label3.Text = "Shop n Shop";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.DarkOrange;
            btnExit.ForeColor = SystemColors.InfoText;
            btnExit.Location = new Point(886, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(84, 38);
            btnExit.TabIndex = 5;
            btnExit.Text = "Turn Off";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-3, -5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(988, 588);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(982, 553);
            Controls.Add(btnExit);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            ForeColor = SystemColors.Control;
            Name = "login";
            Text = "Log In";
            Load += login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel panel1;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Button btnLogin;
        private Label label3;
        private Button btnExit;
        private PictureBox pictureBox1;
    }
}