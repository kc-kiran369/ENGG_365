using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassroomManagement.Tests;
using ClassroomManagement.DataBase;
using ClassroomManagement.Designs;

namespace ClassroomManagement.Home
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            BringDashboardToFrontByDefault();
            SQLConnector.Instance.Insert("Kikran", "KC");
        }
        void BringDashboardToFrontByDefault()
        {
            dashboardUserControl1.BringToFront();
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            dashboardUserControl1.BringToFront();
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            studentsUserControl1.BringToFront();
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            attendanceUserControl1.BringToFront();
        }

        private void btnAdmission_Click(object sender, EventArgs e)
        {
            admissionUserControl1.BringToFront();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            settingsUserControl1.BringToFront();
        }
    }
}
