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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace POS_ShopNShop
{
    public partial class category : Form
    {
        private string username;
        public category(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dashboard categoryForm = new dashboard(username);
            categoryForm.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string description = rtxtDescription.Text;
            DateTime date = DateTime.Now;
            string connectionString = "Data Source=DESKTOP-QRC7DE0\\SQLEXPRESS;Initial Catalog=POS_DB;Integrated Security=True";
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter a category name.");
                return; // Stop further execution if the category name is empty or whitespace
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Category (Name, Description,CreatedBy, CreatedDate) VALUES (@Name, @Description,@CreatedBy, @Date)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Description", description);
                command.Parameters.AddWithValue("@CreatedBy", username);
                command.Parameters.AddWithValue("@Date", date);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Category information saved successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to save category information.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void category_Load(object sender, EventArgs e)
        {

        }

        //private void btnUpdat_Click(object sender, EventArgs e)
        //{

        //}

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            CategoryFromUpdate updatecategoryForm = new CategoryFromUpdate(username); // Pass the username to the category form
            updatecategoryForm.Show();
            this.Hide();
        }
    }
}
