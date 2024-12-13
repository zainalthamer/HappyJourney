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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Signup signup = new Signup();
            signup.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Book_flight book_flight = new Book_flight();
            book_flight.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void Inbox_Click(object sender, EventArgs e)
        {
            Inbox inbox = new Inbox();
            inbox.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageDetails message = new MessageDetails();
            message.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Compose compose = new Compose();
            compose.Show();
            this.Hide();
        }
    }
}
