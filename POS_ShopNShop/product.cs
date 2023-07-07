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
    public partial class product : Form
    {
        private string username;
        public product(string username)
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

        private void product_Load(object sender, EventArgs e)
        {
            PopulateCategoryComboBox();
        }
        private void PopulateCategoryComboBox()
        {
            try
            {
                string connectionString = "Data Source=DESKTOP-QRC7DE0\\SQLEXPRESS;Initial Catalog=POS_DB;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT Name FROM Category WHERE IsDeleted IS NULL OR IsDeleted = 0 "; // Exclude deleted categories
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string categoryName = reader.GetString(0);
                        cmbCategory.Items.Add(categoryName);
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching category data: " + ex.Message);
            }
        }

        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string description = rtxProductDescription.Text;
            decimal price;
            decimal vatPercentage;
            bool allowDiscount = cbIsDiscountAllow.Checked;
            string categoryName = cmbCategory.SelectedItem.ToString();
            string connectionString = "Data Source=DESKTOP-QRC7DE0\\SQLEXPRESS;Initial Catalog=POS_DB;Integrated Security=True";
            DateTime date = DateTime.Now;

            // Validating inputs 
            if (cmbCategory.SelectedItem == null)
            {
                MessageBox.Show("Please select a category.");
                return;
            }

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter a valid product name.");
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out price) || price <= 0)
            {
                MessageBox.Show("Please enter a valid decimal value for the price.");
                return;
            }

            if (!decimal.TryParse(txtVAT.Text, out vatPercentage) || vatPercentage < 0)
            {
                MessageBox.Show("Please enter a valid decimal value for the VAT percentage.");
                return;
            }
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Retrieve the CategoryID based on the selected category name
                    string categoryIdQuery = "SELECT ID FROM Category WHERE Name = @CategoryName";
                    SqlCommand categoryIdCommand = new SqlCommand(categoryIdQuery, connection);
                    categoryIdCommand.Parameters.AddWithValue("@CategoryName", categoryName);
                    int categoryId = Convert.ToInt32(categoryIdCommand.ExecuteScalar());

                    // Insert the new product into the Product table
                    string insertQuery = "INSERT INTO Product (Name, Description, Price, VATPercent, IsDiscountAllow, CategoryID, CreatedDate, CreatedBy) " +
                                         "VALUES (@Name, @Description, @Price, @VATPercentage, @AllowDiscount, @CategoryID, @Date, @Username)";
                    SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                    insertCommand.Parameters.AddWithValue("@Name", name);
                    insertCommand.Parameters.AddWithValue("@Description", description);
                    insertCommand.Parameters.AddWithValue("@Price", price);
                    insertCommand.Parameters.AddWithValue("@VATPercentage", vatPercentage);
                    insertCommand.Parameters.AddWithValue("@AllowDiscount", allowDiscount);
                    insertCommand.Parameters.AddWithValue("@CategoryID", categoryId);
                    insertCommand.Parameters.AddWithValue("@Date", date);
                    insertCommand.Parameters.AddWithValue("@Username", username);
                    insertCommand.ExecuteNonQuery();

                    MessageBox.Show("Product added successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding the product: " + ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            updateProduct updateProductForm = new updateProduct(username);
            updateProductForm.Show();
            this.Hide();
        }
    }
}
