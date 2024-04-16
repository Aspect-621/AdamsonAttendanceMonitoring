﻿using System;
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
    public partial class Vision : Form
    {
        private UserData loggedInUser;
        public Vision(UserData userData)
        {
            InitializeComponent();
            this.loggedInUser = userData;
        }

        private void Vision_Load(object sender, EventArgs e)
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
            StudentViewAttendance AttendanceStudent = new StudentViewAttendance(loggedInUser);
            AttendanceStudent.Show();
            this.Hide();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            StudentViewAttendance AttendanceStudent = new StudentViewAttendance(loggedInUser);
            AttendanceStudent.Show();
            this.Hide();
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            Mission StudentMission = new Mission(loggedInUser);
            StudentMission.Show();
            this.Hide();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            Mission StudentMission = new Mission(loggedInUser);
            StudentMission.Show();
            this.Hide();
        }

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {
            Vision StudentVision = new Vision(loggedInUser);
            StudentVision.Show();
            this.Hide();
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            Vision StudentVision = new Vision(loggedInUser);
            StudentVision.Show();
            this.Hide();
        }

        private void pictureBox8_Click_1(object sender, EventArgs e)
        {
            Form1 Form = new Form1();
            Form.Show();
            this.Close();
        }

        private void label6_Click_1(object sender, EventArgs e)
        {
            Form1 Form = new Form1();
            Form.Show();
            this.Close();
        }
    }
}
