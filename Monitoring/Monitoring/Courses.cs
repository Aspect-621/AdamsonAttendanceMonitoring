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
    public partial class Courses : Form
    {
        private UserData loggedInUser;

        public Courses(UserData userData)
        {
            InitializeComponent();
            this.loggedInUser = userData;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (loggedInUser.IsStudent)
            {
<<<<<<< Updated upstream
                MessageBox.Show("You are a Student");
=======
                MessageBox.Show("You are a Student!");
>>>>>>> Stashed changes
                StudentViewAttendance AppDevLabAttendanceStudent = new StudentViewAttendance(loggedInUser);
                AppDevLabAttendanceStudent.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You are an Admin");
                Attendance AppDevLabAttendance = new Attendance();
                AppDevLabAttendance.Show();
                this.Hide();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Attendance AppDevLecAttendance = new Attendance();
            AppDevLecAttendance.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Attendance ComProgLabAttendance = new Attendance();
            ComProgLabAttendance.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Attendance ComProgLecAttendance = new Attendance();
            ComProgLecAttendance.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Attendance OOPLabAttendance = new Attendance();
            OOPLabAttendance.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Attendance OOPLecAttendance = new Attendance();
            OOPLecAttendance.Show();
            this.Hide();
        }

        private void Courses_Load(object sender, EventArgs e)
        {

        }
    }
}
