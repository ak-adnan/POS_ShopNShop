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
    public partial class CategoryFromUpdate : Form
    {
        private string username;

        public CategoryFromUpdate(string username)
        {
            InitializeComponent();
            this.username = username;
            dgvCategory = new DataGridView(); // Create a new instance of DataGridView
            dgvCategory.Dock = DockStyle.Fill;
            Controls.Add(dgvCategory);
        }

        private void CategoryFromUpdate_Load(object sender, EventArgs e)
        {
            getCategoryTable();
            dgvCategory.CellValueChanged += dgvCategory_CellValueChanged;
        }
        private void getCategoryTable()
        {
            try
            {
                string connectionString = "Data Source=DESKTOP-QRC7DE0\\SQLEXPRESS;Initial Catalog=POS_DB;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Category";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dgvCategory.DataSource = dataTable;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading the data: " + ex.Message);
            }
        }

        private void dgvCategory_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dgvCategory.Rows[e.RowIndex];
                    int categoryId = Convert.ToInt32(row.Cells["ID"].Value);
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

                    string newName = row.Cells["Name"].Value.ToString();
                    string newDescription = row.Cells["Description"].Value.ToString();

                    string connectionString = "Data Source=DESKTOP-QRC7DE0\\SQLEXPRESS;Initial Catalog=POS_DB;Integrated Security=True";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        // Get the current username and datetime
                        string updatedBy = username;
                        DateTime updatedDate = DateTime.Now;

                        string query = "UPDATE Category SET Name = @Name, Description = @Description, UpdatedBy = @UpdatedBy, UpdatedDate = @UpdatedDate, IsDeleted = @IsDeleted WHERE ID = @CategoryId";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@Name", newName);
                        command.Parameters.AddWithValue("@Description", newDescription);
                        command.Parameters.AddWithValue("@UpdatedBy", updatedBy);
                        command.Parameters.AddWithValue("@UpdatedDate", updatedDate);
                        command.Parameters.AddWithValue("@IsDeleted", deleted); // Use the "deleted" variable
                        command.Parameters.AddWithValue("@CategoryId", categoryId);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Category information updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to update category information.");
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            category categoryForm = new category(username);
            categoryForm.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
