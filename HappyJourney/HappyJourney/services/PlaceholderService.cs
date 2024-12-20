﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyJourney.services
{
    class PlaceholderService
    {
        static public void SetupPlaceholder(TextBox textBox, string placeholderText)
        {
            // Set placeholder text and color
            clearText(textBox, placeholderText);

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
                    clearText(textBox, placeholderText);
                }
            };
        }

        static public void clearText(TextBox textBox, string placeholderText)
        {
            textBox.Text = placeholderText;
            textBox.ForeColor = Color.LightGray;
        }
    }
}
