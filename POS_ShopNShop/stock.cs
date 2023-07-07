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
    public partial class stock : Form
    {
        private string username;
        public stock(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dashboard dashboardForm = new dashboard(username);
            dashboardForm.Show();
            this.Hide();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void stock_Load(object sender, EventArgs e)
        {
            PopulateProductComboBox();
        }

        private void PopulateProductComboBox()
        {
            try
            {
                string connectionString = "Data Source=DESKTOP-QRC7DE0\\SQLEXPRESS;Initial Catalog=POS_DB;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT Name FROM Product WHERE IsDeleted IS NULL OR IsDeleted = 0 "; // Exclude deleted categories
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string productName = reader.GetString(0);
                        cmbName.Items.Add(productName);
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching category data: " + ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string selectedProductName = cmbName.SelectedItem.ToString();
            int quantity = Convert.ToInt32(txtQty.Text);
            DateTime expiryDate = dtpExpiryDate.Value;
            string createdBy = username;
            DateTime createdDate = DateTime.Now;
            if (string.IsNullOrEmpty(selectedProductName))
            {
                MessageBox.Show("Please select a product.");
                return;
            }

            if (!int.TryParse(txtQty.Text, out quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity.");
                return;
            }
            //if (IsProductInStock(selectedProductName))
            //{
            //    MessageBox.Show("Product already exists in the stock.");
            //    return;
            //}
            try
            {
                string connectionString = "Data Source=DESKTOP-QRC7DE0\\SQLEXPRESS;Initial Catalog=POS_DB;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Retrieve the product ID based on the selected product name
                    string getProductIDQuery = "SELECT ProductId FROM Product WHERE Name = @ProductName";
                    SqlCommand getProductIDCommand = new SqlCommand(getProductIDQuery, connection);
                    getProductIDCommand.Parameters.AddWithValue("@ProductName", selectedProductName);
                    int productID = Convert.ToInt32(getProductIDCommand.ExecuteScalar());

                    // Insert the stock information into the database
                    string insertStockQuery = "INSERT INTO Stock (ProductId, Qty, ExpiryDate, CreatedBy, CreatedDate) VALUES (@ProductID, @Quantity, @ExpiryDate, @CreatedBy, @CreatedDate)";
                    SqlCommand insertStockCommand = new SqlCommand(insertStockQuery, connection);
                    insertStockCommand.Parameters.AddWithValue("@ProductID", productID);
                    insertStockCommand.Parameters.AddWithValue("@Quantity", quantity);
                    insertStockCommand.Parameters.AddWithValue("@ExpiryDate", expiryDate);
                    insertStockCommand.Parameters.AddWithValue("@CreatedBy", createdBy);
                    insertStockCommand.Parameters.AddWithValue("@CreatedDate", createdDate);
                    int rowsAffected = insertStockCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Stock information saved successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to save stock information.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving stock information: " + ex.Message);
            }
        }
        /*
        private bool IsProductInStock(string selectedProductName)
        {
            try
            {
                string connectionString = "Data Source=DESKTOP-QRC7DE0\\SQLEXPRESS;Initial Catalog=POS_DB;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM Stock WHERE ProductName = @ProductName";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ProductName", selectedProductName);

                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while checking stock: " + ex.Message);
                return false;
            }
        }
        */

        private void btnUpdateStock_Click(object sender, EventArgs e)
        {
            updateStock updateStockForm = new updateStock(username);
            updateStockForm.Show();
            this.Hide();
        }
    }
}
