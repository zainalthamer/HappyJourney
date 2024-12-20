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
    public partial class Home : Form
    {
        private int loggedInUserId;
        private int loggedInUserRoleId;
        string originPlaceholder = "Where from?";
        string destPlaceholder = "Where To?";

        public Home(int userId, int roleId)
        {
            InitializeComponent();
            loggedInUserId = userId;
            loggedInUserRoleId = roleId;
            SetupMenuStrip();

            FetchAndDisplayFlights(false);

            PlaceholderService.SetupPlaceholder(originTextBox, originPlaceholder);
            PlaceholderService.SetupPlaceholder(destTextBox, destPlaceholder);

            StyleComponents();
        }

        private void Home_Load(object sender, EventArgs e) { }

        private void StyleComponents()
        {
            Font inputFont = new Font("Segoe UI", 10);
            Size textBoxSize = new Size(180, 30);

            // Style text boxes
            originTextBox.Font = inputFont;
            originTextBox.Size = textBoxSize;
            originTextBox.BorderStyle = BorderStyle.FixedSingle;

            destTextBox.Font = inputFont;
            destTextBox.Size = textBoxSize;
            destTextBox.BorderStyle = BorderStyle.FixedSingle;

            // Style DateTimePickers
            departDateTimePicker.Font = inputFont;
            departDateTimePicker.Size = textBoxSize;
            departDateTimePicker.Format = DateTimePickerFormat.Custom;
            departDateTimePicker.CustomFormat = "yyyy-MM-dd";

            arrivalDateTimePicker.Font = inputFont;
            arrivalDateTimePicker.Size = textBoxSize;
            arrivalDateTimePicker.Format = DateTimePickerFormat.Custom;
            arrivalDateTimePicker.CustomFormat = "yyyy-MM-dd";

            // Style buttons
            btnSearch.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            btnSearch.Size = new Size(100, 30);
            btnSearch.BackColor = Color.Black;
            btnSearch.ForeColor = Color.White;
            btnSearch.FlatStyle = FlatStyle.Flat;

            flightsGridView.CellMouseEnter += (s, e) =>
            {
                if (e.ColumnIndex == flightsGridView.Columns["Flight ID"]?.Index && e.RowIndex >= 0)
                {
                    flightsGridView.Cursor = Cursors.Hand;
                }
            };

            flightsGridView.CellMouseLeave += (s, e) =>
            {
                flightsGridView.Cursor = Cursors.Default;
            };
        }

        private void SetupMenuStrip()
        {
            MenuStrip menuStrip = new MenuStrip();

            ToolStripMenuItem homeItem = new ToolStripMenuItem("Home");
            homeItem.Click += (s, e) =>
            {
                MessageBox.Show("You are already on the Home page.");
            };

            ToolStripMenuItem profileItem = new ToolStripMenuItem("Profile");
            profileItem.Click += (s, e) => NavigateToProfile();

            ToolStripMenuItem inboxItem = new ToolStripMenuItem("Inbox");
            inboxItem.Click += (s, e) => NavigateToInbox();

            ToolStripMenuItem composeItem = new ToolStripMenuItem("Compose");
            composeItem.Click += (s, e) => NavigateToCompose();

            menuStrip.Items.Add(homeItem);

            if (loggedInUserRoleId == 1)
            {
                ToolStripMenuItem dashboardItem = new ToolStripMenuItem("Dashboard");
                dashboardItem.Click += (s, e) => NavigateToDashboard();
                menuStrip.Items.Add(dashboardItem);
            }

            else if (loggedInUserRoleId == 3)
            {
                ToolStripMenuItem bookingsItem = new ToolStripMenuItem("Bookings");
                bookingsItem.Click += (s, e) => NavigateToBookings();
                menuStrip.Items.Add(bookingsItem);
            }

            menuStrip.Items.Add(profileItem);
            menuStrip.Items.Add(inboxItem);
            menuStrip.Items.Add(composeItem);

            this.mnuHome = menuStrip;
            this.Controls.Add(menuStrip);
        }

        private void NavigateToInbox()
        {
            Inbox inbox = new Inbox(loggedInUserId, loggedInUserRoleId);
            inbox.ShowDialog();
            this.Hide();

        }

        private void NavigateToCompose()
        {
            Compose compose = new Compose(loggedInUserId, loggedInUserRoleId);
            compose.ShowDialog();
            this.Hide();
        }

        private void NavigateToProfile()
        {
            Profile profile = new Profile(loggedInUserId, loggedInUserRoleId);
            profile.ShowDialog();
            this.Hide();
        }

        private void NavigateToDashboard()
        {
            Dashboard dashboard = new Dashboard(loggedInUserId, loggedInUserRoleId);
            dashboard.ShowDialog();
            this.Hide();
        }

        private void NavigateToBookings()
        {
            Bookings bookings = new Bookings(loggedInUserId, loggedInUserRoleId);
            bookings.ShowDialog();
            this.Hide();
        }

        private void NavigateToHome()
        {
            MessageBox.Show("You are already on the Home page.");
        }

        private void FetchAndDisplayFlights(bool applyFilters)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            string query = @"
    SELECT 
        f.flight_number AS 'Flight ID',
        a1.iata_code AS 'Origin',
        a2.iata_code AS 'Destination',
        f.departure_time AS 'Departure',
        f.arrival_time AS 'Arrival',
        CONCAT(f.price, ' BHD') AS 'Starting Price'
    FROM Flight f
    INNER JOIN Airport a1 ON f.origin_airport_id = a1.airport_id
    INNER JOIN Airport a2 ON f.destination_airport_id = a2.airport_id
    WHERE 1=1";

            // Add conditions dynamically based on user inputs
            if (applyFilters)
            {
                if (!string.IsNullOrWhiteSpace(originTextBox.Text) && originTextBox.Text != originPlaceholder)
                {
                    query += " AND a1.iata_code = @Origin";
                }
                if (!string.IsNullOrWhiteSpace(destTextBox.Text) && destTextBox.Text != destPlaceholder)
                {
                    query += " AND a2.iata_code = @Destination";
                }
                if (departDateTimePicker.Checked)
                {
                    query += " AND CAST(f.departure_time AS DATE) = @DepartureDate";
                }
                if (arrivalDateTimePicker.Checked)
                {
                    query += " AND CAST(f.arrival_time AS DATE) = @ArrivalDate";
                }
            }

            query += " ORDER BY f.departure_time";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        if (applyFilters)
                        {
                            if (!string.IsNullOrWhiteSpace(originTextBox.Text) && originTextBox.Text != originPlaceholder)
                            {
                                cmd.Parameters.AddWithValue("@Origin", originTextBox.Text.Trim().ToUpper());
                            }
                            if (!string.IsNullOrWhiteSpace(destTextBox.Text) && destTextBox.Text != destPlaceholder)
                            {
                                cmd.Parameters.AddWithValue("@Destination", destTextBox.Text.Trim().ToUpper());
                            }
                            if (departDateTimePicker.Checked)
                            {
                                cmd.Parameters.AddWithValue("@DepartureDate", departDateTimePicker.Value.Date);
                            }
                            if (arrivalDateTimePicker.Checked)
                            {
                                cmd.Parameters.AddWithValue("@ArrivalDate", arrivalDateTimePicker.Value.Date);
                            }
                        }

                        DataTable dt = new DataTable();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(dt);

                        flightsGridView.DataSource = dt;

                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("No flights found matching your search criteria.", "Information",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching flights: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FetchAndDisplayFlights(true);
        }
    }
}
