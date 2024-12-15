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
    public partial class Home : Form
    {
        private int roleId;

        public Home(int roleId)
        {
            InitializeComponent();
            this.roleId = roleId;
            SetupMenuStrip();
        }

        private void Home_Load(object sender, EventArgs e)
        {

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

            if (roleId == 1)
            {
                ToolStripMenuItem dashboardItem = new ToolStripMenuItem("Dashboard");
                dashboardItem.Click += (s, e) => NavigateToDashboard();
                menuStrip.Items.Add(dashboardItem);
            }

            else if (roleId == 3)
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
            this.Hide(); 
            Inbox inbox = new Inbox(roleId);
            inbox.FormClosed += (s, e) => this.Show();
            inbox.Show();
        }

        private void NavigateToCompose()
        {
            this.Hide();
            Compose compose = new Compose(roleId);
            compose.FormClosed += (s, e) => this.Show();
            compose.Show();
        }

        private void NavigateToProfile()
        {
            this.Hide();
            Profile profile = new Profile(roleId);
            profile.FormClosed += (s, e) => this.Show();
            profile.Show();
        }

        private void NavigateToDashboard()
        {
            this.Hide();
            Dashboard dashboard = new Dashboard(roleId);
            dashboard.FormClosed += (s, e) => this.Show();
            dashboard.Show();
        }

        private void NavigateToBookings()
        {
            this.Hide();
            Bookings bookings = new Bookings(roleId);
            bookings.FormClosed += (s, e) => this.Show();
            bookings.Show();
        }

        private void NavigateToHome()
        {
            this.Hide();
            Home home = new Home(roleId);
            home.FormClosed += (s, e) => this.Show();
            home.Show();
        }

    }
    }

