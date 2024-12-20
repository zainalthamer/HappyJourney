using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HappyJourney.services;
using HappyJourney.singletons;

namespace HappyJourney
{
    public partial class Login : Form
    {
        public static int LoggedInUserId = -1; // the default value indicates that no user is logged in
        public static int LoggedInUserRoleId = -1;

        public Login()
        {
            InitializeComponent();

            PlaceholderService.SetupPlaceholder(txtBoxEmail, "Email");
            PlaceholderService.SetupPlaceholder(txtBoxPassword, "Password");
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void lblSignupLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Signup signup = new Signup();
            signup.Show();
            Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            string email = txtBoxEmail.Text.Trim();
            string password = txtBoxPassword.Text.Trim();
            string hashedPassword = HashPassword(password);

            string query = "SELECT * FROM [User] WHERE email = @Email AND hashed_password = @Password";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue ("@Password", hashedPassword);
                    connection.Open();

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        LoggedInUserId = Convert.ToInt32(reader["user_id"]);
                        LoggedInUserRoleId = Convert.ToInt32(reader["role_id"]);

                        UserSession.Instance.Initialize(
                               reader["user_id"].ToString(),
                               reader["email"].ToString(),
                               reader["first_name"].ToString(),
                               reader["last_name"].ToString(),
                               reader["nationality"].ToString(),
                               reader["date_of_birth"].ToString(),
                               reader["phone"].ToString(),
                               reader["role_id"].ToString(),
                               reader["is_subscribed"].ToString()
                         );

                        Home home = new Home(LoggedInUserId, LoggedInUserRoleId);
                        this.Hide();
                        home.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid email or password.");
                    }
                }
            }
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(hashedBytes);
            }
        }
    }
}
