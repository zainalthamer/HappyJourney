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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace HappyJourney
{
    public partial class Bookings : Form
    {
        public Bookings()
        {
            InitializeComponent();
            FetchAndLogBookings(2);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FetchAndLogBookings(int travelerId)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = @"
        SELECT 
            b.booking_id as 'Booking ID',
            f.flight_number as 'Flight Number',
            b.totalPrice as 'Paid Amount',
            b.status as 'Status',
            f.departure_time as 'Departure Time',
            a1.name as 'From',
            a2.name as 'To'
        FROM Booking b
        INNER JOIN Flight f ON b.flight_id = f.flight_id
        INNER JOIN Airport a1 ON f.origin_airport_id = a1.airport_id
        INNER JOIN Airport a2 ON f.destination_airport_id = a2.airport_id
        WHERE b.traveler_id = @TravelerId
        ORDER BY b.date DESC";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@TravelerId", travelerId);

                        // Create a DataTable to hold the results
                        DataTable dt = new DataTable();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(dt);

                        // Bind the DataTable to the DataGridView
                        dataGridView1.DataSource = dt;

                        // Format the grid
                        dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                        dataGridView1.Columns["Paid Amount"].DefaultCellStyle.Format = "C2"; // Currency format
                        dataGridView1.Columns["Departure Time"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";

                        // Color coding for status
                        dataGridView1.CellFormatting += (s, e) =>
                        {
                            if (e.ColumnIndex == dataGridView1.Columns["Status"].Index)
                            {
                                string status = e.Value?.ToString().ToLower();
                                switch (status)
                                {
                                    case "confirmed":
                                        e.CellStyle.BackColor = Color.LightGreen;
                                        break;
                                    case "cancelled":
                                        e.CellStyle.BackColor = Color.LightPink;
                                        break;
                                    case "pending":
                                        e.CellStyle.BackColor = Color.LightYellow;
                                        break;
                                }
                            }
                        };

                        // Log to file

                        Console.WriteLine($"\nBookings fetched for Traveler ID: {travelerId} at {DateTime.Now}");
                        foreach (DataRow row in dt.Rows)
                        {
                            Console.WriteLine($"Booking {row["Booking ID"]}: Flight {row["Flight Number"]} from {row["From"]} to {row["To"]} on {row["Departure Time"]}");
                        }
                        Console.WriteLine("----------------------------------------");

                        // Show message if no bookings found
                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("No bookings found for this traveler.", "Information",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching bookings: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Log error
                string logPath = Path.Combine(Application.StartupPath, "error_logs.txt");
                File.AppendAllText(logPath,
                    $"\n[{DateTime.Now}] Error fetching bookings for Traveler ID {travelerId}: {ex.Message}");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString)) {
                string query = "SELECT * FROM [Booking]";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    connection.Open();

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        Console.WriteLine(result.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Invalid email or password.");
                    }
                }
            }
        }
    }
}
