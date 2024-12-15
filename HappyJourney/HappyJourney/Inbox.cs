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
    public partial class Inbox : Form
    {
        public int roleId;

        public Inbox(int roleId)
        {
            InitializeComponent();
            this.roleId = roleId;
        }

        private void Inbox_Load(object sender, EventArgs e)
        {

        }
    }
}
