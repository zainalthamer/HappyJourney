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
    public partial class EditFlight : Form
    {
        private int loggedInUserId;
        private int loggedInUserRoleId;
        private int passedFlightId;

        public EditFlight(int userId, int roleId, int flightId)
        {
            InitializeComponent();
            loggedInUserId = userId;
            loggedInUserRoleId = roleId;
            passedFlightId = flightId;
        }

        private void EditFlight_Load(object sender, EventArgs e)
        {

        }
    }
}
