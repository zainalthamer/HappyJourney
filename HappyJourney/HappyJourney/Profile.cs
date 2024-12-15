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
    public partial class Profile : Form
    {
        private int roleId;

        public Profile(int roleId)
        {
            InitializeComponent();
            this.roleId = roleId;
        }

        private void Profile_Load(object sender, EventArgs e)
        {

        }
    }
}
