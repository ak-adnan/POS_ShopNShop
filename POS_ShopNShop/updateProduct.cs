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
    public partial class updateProduct : Form
    {
        private string username;
        public updateProduct(string username)
        {
            InitializeComponent();
            this.username = username;
            dgvUpdateProduct = new DataGridView(); // Create a new instance of DataGridView
            dgvUpdateProduct.Dock = DockStyle.Fill;
            Controls.Add(dgvUpdateProduct);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            product productForm = new product(username);
            productForm.Show();
            this.Hide();
        }

        private void updateProduct_Load(object sender, EventArgs e)
        {
            getProductTable();
            dgvUpdateProduct.CellValueChanged += dgvUpdateProduct_CellValueChanged;
        }

        private void getProductTable()
        {
            try
            {
                string connectionString = "Data Source=DESKTOP-QRC7DE0\\SQLEXPRESS;Initial Catalog=POS_DB;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Product";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dgvUpdateProduct.DataSource = dataTable;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading the data: " + ex.Message);
            }
        }

        private void dgvUpdateProduct_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dgvUpdateProduct.Rows[e.RowIndex];
                    int productId = Convert.ToInt32(row.Cells["ProductId"].Value);
                    string newName = row.Cells["Name"].Value.ToString();
                    string newDescription = row.Cells["Description"].Value.ToString();
                    decimal newPrice = Convert.ToDecimal(row.Cells["Price"].Value);
                    decimal newVAT = Convert.ToDecimal(row.Cells["VATPercent"].Value);
                    bool newIsDiscountAllow = Convert.ToBoolean(row.Cells["IsDiscountAllow"].Value);

                    object valueFromDatabase = row.Cells["IsDeleted"].Value;

                    bool deleted;
                    if (valueFromDatabase != DBNull.Value)
                    {
                        deleted = Convert.ToBoolean(valueFromDatabase);
                    }
                    else
                    {
                        // Provide a default value when the database value is null
                        deleted = false;
                    }

                    string connectionString = "Data Source=DESKTOP-QRC7DE0\\SQLEXPRESS;Initial Catalog=POS_DB;Integrated Security=True";
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                        

                            // Get the current username and datetime
                            string updatedBy = username;
                            DateTime updatedDate = DateTime.Now;

                            string query = "UPDATE Product SET Name = @Name, Description = @Description, Price = @Price, VATPercent = @VAT, IsDiscountAllow = @IsDiscountAllow, UpdatedBy = @UpdatedBy, UpdatedDate = @UpdatedDate, IsDeleted = @IsDeleted WHERE ProductID = @ProductId";
                            SqlCommand command = new SqlCommand(query, connection);
                            command.Parameters.AddWithValue("@Name", newName);
                            command.Parameters.AddWithValue("@Description", newDescription);
                            command.Parameters.AddWithValue("@Price", newPrice);
                            command.Parameters.AddWithValue("@VAT", newVAT);
                            command.Parameters.AddWithValue("@IsDiscountAllow", newIsDiscountAllow);
                            command.Parameters.AddWithValue("@UpdatedBy", updatedBy);
                            command.Parameters.AddWithValue("@UpdatedDate", updatedDate);
                            command.Parameters.AddWithValue("@ProductId", productId);
                            command.Parameters.AddWithValue("@IsDeleted", deleted);


                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Product information updated successfully.");
                            }
                            else
                            {
                                MessageBox.Show("Failed to update product information.");
                            }
                        }
                    
                }
                catch (InvalidCastException ex)
                {
                    MessageBox.Show("Invalid cast exception occurred: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while updating the data: " + ex.Message);
                }
            }
        }
    }
}
