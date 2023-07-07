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
    public partial class updateCategory : Form
    {
        private string username;
        private DataGridView dataGridViewCategory;



        public updateCategory(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void updateCategory_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-QRC7DE0\\SQLEXPRESS;Initial Catalog=POS_DB;Integrated Security=True";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                dataGridViewCategory = new DataGridView();
                dataGridViewCategory.Dock = DockStyle.Fill;
                Controls.Add(dataGridViewCategory);

                string query = "SELECT Name, Description FROM Category"; // Select only the desired columns
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridViewCategory.DataSource = dataTable;
            }
        }

        private void dataGridViewCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            category categoryForm = new category(username);
            categoryForm.Show();
            this.Hide();
        }

        private void updateCategoty_Load(object sender, EventArgs e)
        {

        }
    }
}
