using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Monitoring.Form1;

namespace Monitoring
{
    public partial class StudentViewAttendance : Form
    {
        private UserData loggedInUser;
<<<<<<< Updated upstream
          
        public StudentViewAttendance(UserData userData)
        {
            InitializeComponent();
            this.loggedInUser = userData; 
=======

        public StudentViewAttendance(UserData userData)
        {
            InitializeComponent();
            this.loggedInUser = userData;
>>>>>>> Stashed changes
            label7.Text = loggedInUser.FullName;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void StudentViewAttendance_Load(object sender, EventArgs e)
        {

        }
    }
}
