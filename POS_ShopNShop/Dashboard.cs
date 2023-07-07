using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_ShopNShop
{
    public partial class dashboard : Form
    {
        private string username;
        //private string name;


        public dashboard(string username)
        {
            InitializeComponent();
            this.username = username;


        }

        public void SetName(string name)
        {
            lblName.Text = "Welcome, " + name;
        }



        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click_1(object sender, EventArgs e)
        {
            login logoutForm = new login();
            logoutForm.Show();
            this.Hide();


        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            // Retrieve the name from the SQL table and display it in lblName

            string connectionString = "Data Source=DESKTOP-QRC7DE0\\SQLEXPRESS;Initial Catalog=POS_DB;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT Name FROM Admin WHERE Username = @Username";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@Username", username);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string name = reader.GetString(0);
                    SetName(name);
                }

                reader.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Click(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void btnStock_Click(object sender, EventArgs e)
        {
            stock stockForm = new stock(username);
            stockForm.Show();
            this.Hide();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            category categoryForm = new category(username); // Pass the username to the category form
            categoryForm.Show();
            this.Hide();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            product productForm = new product(username);
            productForm.Show();
            this.Hide();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            customer customerForm = new customer(username);
            customerForm.Show();
            this.Hide();
        }
    }
}
