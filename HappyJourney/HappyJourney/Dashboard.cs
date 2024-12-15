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
    public partial class Dashboard : Form
    {
        private int roleId;

        public Dashboard(int roleId)
        {
            InitializeComponent();
            this.roleId = roleId;
        }

        private void inboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inbox inbox = new Inbox(roleId);
            inbox.Show();
            this.Close();
        }

        private void composeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Compose compose = new Compose(roleId);
            compose.Show();
            this.Close();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home home = new Home(roleId);
            home.Show();
            this.Close();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile(roleId);
            profile.Show();
            this.Close();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
