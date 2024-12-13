using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HappyJourney.services;

namespace HappyJourney
{
    public partial class Login : Form
    {
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
    }
}
