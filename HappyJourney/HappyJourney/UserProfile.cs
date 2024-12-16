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
    public partial class UserProfile : Form
    {
        private int loggedInUserId;
        private int loggedInUserRoleId;
        private int passedUserId;

        public UserProfile(int currentUserId, int roleId, int userId)
        {
            InitializeComponent();
            loggedInUserId = userId;
            loggedInUserRoleId = roleId;
            passedUserId = userId;
        }

        private void UserProfile_Load(object sender, EventArgs e)
        {

        }
    }
}
