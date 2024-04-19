using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Monitoring.Login;

namespace Monitoring
{
    public partial class Mission : Form
    {
        private UserData loggedInUser;
        public string labelZeor = "";
        public Mission(UserData userData, string labelText)
        {
            InitializeComponent();
            labelZeor = labelText;
            this.loggedInUser = userData;
        }

        private void Mission_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            Courses courseForm = new Courses(loggedInUser);
            courseForm.Show();
            this.Hide();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            Courses courseForm = new Courses(loggedInUser);
            courseForm.Show();
            this.Hide();
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            StudentViewAttendance AttendanceStudent = new StudentViewAttendance(loggedInUser, labelZeor);
            AttendanceStudent.Show();
            this.Hide();

        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            StudentViewAttendance AttendanceStudent = new StudentViewAttendance(loggedInUser, labelZeor);
            AttendanceStudent.Show();
            this.Hide();

        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            Mission StudentMission = new Mission(loggedInUser, labelZeor);
            StudentMission.Show();
            this.Hide();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            Mission StudentMission = new Mission(loggedInUser, labelZeor);
            StudentMission.Show();
            this.Hide();
        }

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {
            Vision StudentVision = new Vision(loggedInUser, labelZeor);
            StudentVision.Show();
            this.Hide();
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            Vision StudentVision = new Vision(loggedInUser, labelZeor);
            StudentVision.Show();
            this.Hide();
        }

        private void pictureBox8_Click_1(object sender, EventArgs e)
        {
            Login Form = new Login();
            Form.Show();
            this.Close();
        }

        private void label6_Click_1(object sender, EventArgs e)
        {
            Login Form = new Login();
            Form.Show();
            this.Close();
        }
    }
}
