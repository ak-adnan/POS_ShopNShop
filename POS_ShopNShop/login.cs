using System.Data.SqlClient;

namespace POS_ShopNShop
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            string connectionString = "Data Source=DESKTOP-QRC7DE0\\SQLEXPRESS;Initial Catalog=POS_DB;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Admin WHERE Username = @Username AND Password = @Password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                int result = (int)command.ExecuteScalar();

                if (result > 0)
                {

                    //MessageBox.Show("Login successful!");

                    dashboard dashboardForm = new dashboard(username);
                    dashboardForm.Show();
                    this.Hide();

                }
                else
                {

                    MessageBox.Show("Invalid username or password. Please try again.");
                }



            }

        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}