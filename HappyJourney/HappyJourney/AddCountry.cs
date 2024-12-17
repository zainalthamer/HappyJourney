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
    public partial class AddCountry : Form
    {
        private int loggedInUserId;
        private int loggedInUserRoleId;

        public AddCountry(int userId, int roleId)
        {
            InitializeComponent();
            loggedInUserId = userId;
            loggedInUserRoleId = roleId;
        }

        private void AddCountry_Load(object sender, EventArgs e)
        {

        }
    }
}
