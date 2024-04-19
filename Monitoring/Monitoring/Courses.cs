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
                string clickedSubject = label2.Text;
                StudentViewAttendance AppDevLabAttendanceStudent = new StudentViewAttendance(loggedInUser, clickedSubject);
                AppDevLabAttendanceStudent.Show();
                this.Hide();
            }
            else
            {
                string clickedSubject = label2.Text;

                Attendance AppDevLabAttendance = new Attendance(loggedInUser, clickedSubject);
                AppDevLabAttendance.Show();
                this.Hide();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (loggedInUser.IsStudent)
            {
                string clickedSubject = label3.Text;
                StudentViewAttendance AppDevLecAttendanceStudent = new StudentViewAttendance(loggedInUser, clickedSubject);
                AppDevLecAttendanceStudent.Show();
                this.Hide();
            }
            else
            {
                string clickedSubject = label3.Text;

                Attendance AppDevLecAttendance = new Attendance(loggedInUser, clickedSubject);
                AppDevLecAttendance.Show();
                this.Hide();
            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (loggedInUser.IsStudent)
            {
                string clickedSubject = label4.Text;
                StudentViewAttendance ComProgLabAttendanceStudent = new StudentViewAttendance(loggedInUser, clickedSubject);
                ComProgLabAttendanceStudent.Show();
                this.Hide();
            }
            else
            {
                string clickedSubject = label4.Text;

                Attendance ComProgLabAttendance = new Attendance(loggedInUser, clickedSubject);
                ComProgLabAttendance.Show();
                this.Hide();
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (loggedInUser.IsStudent)
            {
                string clickedSubject = label5.Text;
                StudentViewAttendance ComProgLecAttendanceStudent = new StudentViewAttendance(loggedInUser, clickedSubject);
                ComProgLecAttendanceStudent.Show();
                this.Hide();
            }
            else
            {
                string clickedSubject = label5.Text;

                Attendance ComProgLecAttendance = new Attendance(loggedInUser, clickedSubject);
                ComProgLecAttendance.Show();
                this.Hide();
            }

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (loggedInUser.IsStudent)
            {
                string clickedSubject = label6.Text;
                StudentViewAttendance OOPLabAttendanceStudent = new StudentViewAttendance(loggedInUser, clickedSubject);
                OOPLabAttendanceStudent.Show();
                this.Hide();
            }
            else
            {
                string clickedSubject = label6.Text;

                Attendance OOPLabAttendance = new Attendance(loggedInUser, clickedSubject);
                OOPLabAttendance.Show();
                this.Hide();
            }

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (loggedInUser.IsStudent)
            {
                string clickedSubject = label7.Text;
                StudentViewAttendance OOPLecAttendanceStudent = new StudentViewAttendance(loggedInUser, clickedSubject);
                OOPLecAttendanceStudent.Show();
                this.Hide();
            }
            else
            {
                string clickedSubject = label7.Text;
                Attendance OOPLecAttendance = new Attendance(loggedInUser, clickedSubject);
                OOPLecAttendance.Show();
                this.Hide();
            }

        }

        private void Courses_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
