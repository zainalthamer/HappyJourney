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
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();

            SetupPlaceholder(txtCardNumer, "456825*****52064");
            SetupPlaceholder(txtExpiration, "MM/YY");
            SetupPlaceholder(txtCvv, "367");
        }

        private void Payment_Load(object sender, EventArgs e)
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

        private void imgBakArrow_Click(object sender, EventArgs e)
        {
            Book_flight book_flight = new Book_flight();
            book_flight.Show();
            this.Hide();
        }
    }
}
