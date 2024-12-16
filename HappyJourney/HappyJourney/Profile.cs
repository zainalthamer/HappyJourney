using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HappyJourney.entities;
using HappyJourney.observers;
using HappyJourney.singletons;

namespace HappyJourney
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();

            User user = UserSession.Instance.CurrentUser;

            if (user != null)
            {
                labelName.Text = user.FullName;
                txtDob.Text = user.DateOfBirth;
                txtEmail.Text = user.Email;
                txtPhone.Text = user.Phone;
                txtNationality.Text = user.Nationality;

                string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

                // Query for flight details
                string query = @"
            SELECT role_name
            FROM UserRole
            WHERE role_id = @RoleId";

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        // Load flight details
                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@RoleId", user.RoleId);
                            txtRole.Text = cmd.ExecuteScalar().ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading role name: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            UserObserver.Subscribe(() =>
            {
                 User newUser = UserSession.Instance.CurrentUser;

                if (newUser != null)
                {
                    labelName.Text = newUser.FullName;
                    txtPhone.Text = newUser.Phone;
                }
            });
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditProfile editProfile = new EditProfile();
            editProfile.ShowDialog();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            UserSession.Instance.ClearSession();
            
            Signup signup = new Signup();
            signup.Show();
            Hide();
        }
    }
}
