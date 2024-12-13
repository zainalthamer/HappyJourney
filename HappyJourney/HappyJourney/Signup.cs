using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyJourney
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();

            SetupPlaceholder(txtFirstName, "First Name");
            SetupPlaceholder(txtLastName, "Last Name");
            SetupPlaceholder(txtDateOfBirth, "Date of Birth");
            SetupPlaceholder(txtNationality, "Nationality");
            SetupPlaceholder(txtPhone, "Phone");
            SetupPlaceholder(txtEmail, "Email Address");
            SetupPlaceholder(txtPassword, "Password");
        }

        private void Signup_Load(object sender, EventArgs e)
        {
            
        }

        private void SetupPlaceholder(TextBox textBox, string placeholderText)
        {
            // Set placeholder text and color
            textBox.Text = placeholderText;
            textBox.ForeColor = Color.LightGray;

            // clear placeholder text on focus
            textBox.GotFocus += (sender, e) =>
            {
                if (textBox.Text == placeholderText)
                {
                    textBox.Text = ""; // Clear the placeholder text
                    textBox.ForeColor = Color.Black; // Reset text color
                }
            };

            // Restore placeholder text if empty
            textBox.LostFocus += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholderText; // Restore placeholder text
                    textBox.ForeColor = Color.LightGray; // Set placeholder color
                }
            };
        }
        }
}
