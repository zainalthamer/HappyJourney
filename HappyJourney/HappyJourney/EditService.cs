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
    public partial class EditService : Form
    {
        private int loggedInUserId;
        private int loggedInUserRoleId;
        private int passedServiceId;

        public EditService(int userId, int roleId, int serviceId)
        {
            InitializeComponent();
            loggedInUserId = userId;
            loggedInUserRoleId = roleId;
            passedServiceId = serviceId;
        }

        private void EditService_Load(object sender, EventArgs e)
        {

        }
    }
}
