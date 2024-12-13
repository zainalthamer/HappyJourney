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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HappyJourney
{
    public partial class Book_flight : Form
    {

        public Book_flight()
        {
            InitializeComponent();
        }

        private void Book_flight_Load(object sender, EventArgs e)
        {

        }

        private void btnBookFlight_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment();
            payment.Show();
            this.Hide();
        }
    }
}
