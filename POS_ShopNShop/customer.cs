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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace POS_ShopNShop
{
    public partial class customer : Form
    {
        private string username;
        public customer(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dashboard dashboardForm = new dashboard(username);
            dashboardForm.Show();
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtname.Text;
            string mobile = txtMobile.Text;
            string email = txtEmail.Text;
            string address = txtAddress.Text;


            string connectionString = "Data Source=DESKTOP-QRC7DE0\\SQLEXPRESS;Initial Catalog=POS_DB;Integrated Security=True";
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter the customer name.");
                return; 
            }
            if (string.IsNullOrWhiteSpace(mobile))
            {
                MessageBox.Show("Please enter the conatct number.");
                return;
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Customer (Name, Email, Mobile, Address) VALUES (@Name, @Email, @Mobile, @Address)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Mobile", mobile);
                command.Parameters.AddWithValue("@Email", email) ;
                command.Parameters.AddWithValue("@Address", address);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Customer information saved successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to save customer information.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
