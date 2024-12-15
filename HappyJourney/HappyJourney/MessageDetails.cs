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
    public partial class MessageDetails : Form
    {
        private int roleId;

        public MessageDetails(int roleId)
        {
            InitializeComponent();
            this.roleId = roleId;
        }

        private void imgBackArrow_Click(object sender, EventArgs e)
        {
            Inbox inbox = new Inbox(roleId);
            inbox.Show();
            this.Hide();
        }

        private void MessageDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
