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
    public partial class EditUser : Form
    {
        private int loggedInUserId;
        private int loggedInUserRoleId;
        private int passedUserId;

        public EditUser(int currentUserId, int roleId, int userId)
        {
            InitializeComponent();
            loggedInUserId = currentUserId;
            loggedInUserRoleId = roleId;
            passedUserId = userId;
        }

        private void EditUser_Load(object sender, EventArgs e)
        {

        }
    }
}
