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
    public partial class updateStock : Form
    {
        private string username;
        public updateStock(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            stock stockForm = new stock(username);
            stockForm.Show();
            this.Hide();
        }

        private void updateStock_Load(object sender, EventArgs e)
        {
            getStockTable();
            dgvStock.CellValueChanged += dgvStock_CellValueChanged;
        }
        private void getStockTable()
        {
            try
            {
                string connectionString = "Data Source=DESKTOP-QRC7DE0\\SQLEXPRESS;Initial Catalog=POS_DB;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Stock";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dgvStock.DataSource = dataTable;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading the data: " + ex.Message);
            }
        }
        private void dgvStock_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dgvStock.Rows[e.RowIndex];
                    int stockId = Convert.ToInt32(row.Cells["StockId"].Value);
                    int newQuantity = Convert.ToInt32(row.Cells["Qty"].Value);
                    DateTime newExpiryDate = Convert.ToDateTime(row.Cells["ExpiryDate"].Value);

                    string connectionString = "Data Source=DESKTOP-QRC7DE0\\SQLEXPRESS;Initial Catalog=POS_DB;Integrated Security=True";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        // Get the current username and datetime
                        string updatedBy = username;
                        DateTime updatedDate = DateTime.Now;

                        string query = "UPDATE Stock SET Qty = @Quantity, ExpiryDate = @ExpiryDate, UpdatedBy = @UpdatedBy, UpdatedDate = @UpdatedDate WHERE StockId = @StockId";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@Quantity", newQuantity);
                        command.Parameters.AddWithValue("@ExpiryDate", newExpiryDate);
                        command.Parameters.AddWithValue("@UpdatedBy", updatedBy);
                        command.Parameters.AddWithValue("@UpdatedDate", updatedDate);
                        command.Parameters.AddWithValue("@StockId", stockId);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Stock information updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to update stock information.");
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
