using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HappyJourney.services;

namespace HappyJourney
{
    public partial class Flights : Form
    {
        string originPlaceholder = "";
        string destPlaceholder = "";
        public Flights()
        {
            InitializeComponent();

            FetchAndDisplayFlights(false);

            originPlaceholder = "Where from?";
            destPlaceholder = "Where To?";

            PlaceholderService.SetupPlaceholder(originTextBox, originPlaceholder);
            PlaceholderService.SetupPlaceholder(destTextBox, destPlaceholder);

            Font inputFont = new Font("Segoe UI", 10);
            Size textBoxSize = new Size(180, 30);

            // Style "Where from?" TextBox
            originTextBox.Font = inputFont;
            originTextBox.Size = textBoxSize;
            originTextBox.BorderStyle = BorderStyle.FixedSingle;

            // Style "Where to?" TextBox
            destTextBox.Font = inputFont;
            destTextBox.Size = textBoxSize;
            destTextBox.BorderStyle = BorderStyle.FixedSingle;

            // Style DateTimePickers
            departDateTimePicker.Font = inputFont;
            departDateTimePicker.Size = textBoxSize;
            departDateTimePicker.Format = DateTimePickerFormat.Custom;
            departDateTimePicker.CustomFormat = "dd-MM-yyyy";

            arrivalDateTimePicker.Font = inputFont;
            arrivalDateTimePicker.Size = textBoxSize;
            arrivalDateTimePicker.Format = DateTimePickerFormat.Custom;
            arrivalDateTimePicker.CustomFormat = "dd-MM-yyyy";

            btnSearch.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            btnSearch.Size = new Size(100, 30);
            btnSearch.BackColor = Color.Black;
            btnSearch.ForeColor = Color.White;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.Cursor = Cursors.Hand;

            btnClear.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            btnClear.Size = new Size(100, 30);
            btnClear.BackColor = Color.White;
            btnClear.ForeColor = Color.Black;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.Cursor = Cursors.Hand;

            flightsGridView.CellMouseEnter += (s, e) =>
            {
                DataGridViewColumn flightIdColumn = flightsGridView.Columns["Flight ID"];

                if (e.ColumnIndex == flightIdColumn.Index && e.RowIndex >= 0)
                {
                    flightsGridView.Cursor = Cursors.Hand;
                }
            };
            flightsGridView.CellMouseLeave += (s, e) =>
            {
                flightsGridView.Cursor = Cursors.Default;
            };
        }

        private void FetchAndDisplayFlights(bool applyFilters)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = @"
        SELECT 
            f.flight_number as 'Flight ID',
            a1.iata_code as 'Origin',
            a2.iata_code as 'Destination',
            f.departure_time as 'Departure',
            f.arrival_time as 'Arrival',
            CONCAT(f.price, ' BHD') as 'Starting Price'
        FROM Flight f
        INNER JOIN Airport a1 ON f.origin_airport_id = a1.airport_id
        INNER JOIN Airport a2 ON f.destination_airport_id = a2.airport_id
        WHERE 1=1";

            if (applyFilters) { 
                // Add filters based on input fields
                if (!string.IsNullOrEmpty(originTextBox.Text) && originTextBox.Text != originPlaceholder)
                {
                    query += " AND a1.iata_code = @Origin";
                }
                if (!string.IsNullOrEmpty(destTextBox.Text) && destTextBox.Text != destPlaceholder)
                {
                    Console.WriteLine(destTextBox.Text);
                    query += " AND a2.iata_code = @Destination";
                }
                if (departDateTimePicker.Value != null)
                {
                    query += @" AND CAST(f.departure_time AS DATE) = CAST(@DepartureDate AS DATE)";
                }
                if (arrivalDateTimePicker.Value != null)
                {
                    query += @" AND CAST(f.arrival_time AS DATE) = CAST(@ArrivalDate AS DATE)";
                }
            }
            query += " ORDER BY f.departure_time";

            Console.WriteLine(query);

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        if (applyFilters)
                        {
                            // Add parameters if filters are applied
                            if (!string.IsNullOrWhiteSpace(originTextBox.Text))
                            {
                                cmd.Parameters.AddWithValue("@Origin", originTextBox.Text.Trim().ToUpper());
                            }
                            if (!string.IsNullOrWhiteSpace(destTextBox.Text))
                            {
                                cmd.Parameters.AddWithValue("@Destination", destTextBox.Text.Trim().ToUpper());
                            }
                            if (departDateTimePicker.Value != null)
                            {
                                cmd.Parameters.AddWithValue("@DepartureDate", departDateTimePicker.Value.Date);
                            }
                            if (arrivalDateTimePicker.Value != null)
                            {
                                cmd.Parameters.AddWithValue("@ArrivalDate", arrivalDateTimePicker.Value.Date);
                            }
                        }

                        DataTable dt = new DataTable();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(dt);

                        // Bind the DataTable to the DataGridView
                        flightsGridView.DataSource = dt;

                        // Format grid
                        flightsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        flightsGridView.ReadOnly = true;  // Make grid non-editable
                        flightsGridView.RowHeadersVisible = false;  // Remove the left-most column
                        flightsGridView.BorderStyle = BorderStyle.None;
                        flightsGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;

                        // Add padding to cells
                        flightsGridView.DefaultCellStyle.Padding = new Padding(10, 5, 10, 5);
                        flightsGridView.RowTemplate.Height = 40;  // Increase row height

                        // Format date columns
                        flightsGridView.Columns["Departure"].DefaultCellStyle.Format = "yyyy/MM/dd HH:mm:ss";
                        flightsGridView.Columns["Arrival"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";

                        // Style the grid
                        flightsGridView.EnableHeadersVisualStyles = false;
                        flightsGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(35, 35, 35);
                        flightsGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                        flightsGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                        flightsGridView.ColumnHeadersDefaultCellStyle.Padding = new Padding(10, 5, 10, 5);
                        flightsGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
                        flightsGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(35, 35, 35); // Keep header black when selected
                        flightsGridView.ColumnHeadersHeight = 45;  // Increase header height

                        // Grid colors and borders
                        flightsGridView.BackgroundColor = Color.White;
                        flightsGridView.GridColor = Color.Black;
                        flightsGridView.DefaultCellStyle.SelectionBackColor = Color.White;
                        flightsGridView.DefaultCellStyle.SelectionForeColor = Color.Black;

                        // Center align all columns
                        foreach (DataGridViewColumn col in flightsGridView.Columns)
                        {
                            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                            if (col.HeaderText == "Flight ID")
                            {
                                col.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Underline);
                                col.DefaultCellStyle.ForeColor = Color.Blue;
                                col.DefaultCellStyle.SelectionForeColor = Color.Blue;
                            }
                        }

                        flightsGridView.Columns["Flight ID"].FillWeight = 15;
                        flightsGridView.Columns["Origin"].FillWeight = 15;
                        flightsGridView.Columns["Destination"].FillWeight = 15;
                        flightsGridView.Columns["Departure"].FillWeight = 20;
                        flightsGridView.Columns["Arrival"].FillWeight = 20;
                        flightsGridView.Columns["Starting Price"].FillWeight = 20;

                        // Show message if no flights found
                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("No flights found.", "Information",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching flights: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Log error
                string logPath = Path.Combine(Application.StartupPath, "error_logs.txt");
                File.AppendAllText(logPath,
                    $"\n[{DateTime.Now}] Error fetching flights: {ex.Message}");
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void flightsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if it's a valid row (not header, not out of bounds)
            if (e.RowIndex >= 0)
            {
                // Check if the clicked column is "Flight ID"
                if (flightsGridView.Columns[e.ColumnIndex].Name == "Flight ID")
                {
                    // Get the flight ID from the clicked cell
                    int flightId = Convert.ToInt32(flightsGridView.Rows[e.RowIndex].Cells["Flight ID"].Value);

                    // Create and show the FlightDetail form
                    FlightDetail detailForm = new FlightDetail(flightId);
                    detailForm.ShowDialog();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FetchAndDisplayFlights(true);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            FetchAndDisplayFlights(false);
            originTextBox.Text = "";
            destTextBox.Text = "";
        }
    }
}
