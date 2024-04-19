using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Monitoring.Login;

namespace Monitoring
{
    public partial class StudentViewAttendance : Form
    {
        private UserData loggedInUser;
        private double absentCount = 0;
        private double lateCount = 0;
        private double presentCount = 0;
        private double excusedCount = 0;
        private double totalCount = 0;
        public string labelZeor = "";

        public StudentViewAttendance(UserData userData, string labelText)
        {
            InitializeComponent();
            this.loggedInUser = userData;
            labelZeor = labelText;
            label7.Text = loggedInUser.FullName;
            int index = comboBox1.FindStringExact(labelZeor);
            if (index != -1) 
            {
                comboBox1.SelectedIndex = index;
            }
            updateStatus();
            changeTextStatus();
        }


        public void changeTextStatus() 
        {
            totalCount = presentCount + absentCount + excusedCount + lateCount;
            double percentageOverall;
            percentageOverall = ((presentCount + lateCount + excusedCount) / totalCount)*100;
            label8.Text = percentageOverall.ToString() + "%";
            label9.Text = presentCount.ToString();
            label10.Text = absentCount.ToString();
            label11.Text = lateCount.ToString();
            label12.Text = excusedCount.ToString();
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            StudentViewAttendance AttendanceStudent = new StudentViewAttendance(loggedInUser, labelZeor);
            AttendanceStudent.Show();
            this.Hide();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            StudentViewAttendance AttendanceStudent = new StudentViewAttendance(loggedInUser, labelZeor);
            AttendanceStudent.Show();
            this.Hide();
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void StudentViewAttendance_Load(object sender, EventArgs e)
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

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Mission StudentMission = new Mission(loggedInUser, labelZeor);
            StudentMission.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Mission StudentMission = new Mission(loggedInUser, labelZeor);
            StudentMission.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Vision StudentVision = new Vision(loggedInUser, labelZeor);
            StudentVision.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Vision StudentVision = new Vision(loggedInUser, labelZeor);
            StudentVision.Show();
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Login Form = new Login();
            Form.Show();
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Login Form = new Login();
            Form.Show();
            this.Close();
        }
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        private void updateStatus()
        {
            List<StudentAttendance> attendanceRecords = Student.AttendanceRecords;
            //AllocConsole();
            //For Testing
            string selectedSubject = comboBox1.SelectedItem.ToString();

            List<StudentAttendance> studentRecordsForSubject = attendanceRecords.Where(record =>
        record.StudentName == loggedInUser.FullName && record.Subject == selectedSubject).ToList();

            if (studentRecordsForSubject.Any())
            {
                Console.WriteLine($"Attendance Record for: {loggedInUser.FullName}, Subject: {selectedSubject}");
                foreach (var studentRecord in studentRecordsForSubject)
                {
                    Console.WriteLine("Date: " + studentRecord.Date);
                    Console.WriteLine("Attendance Status: " + GetAttendanceStatus(studentRecord.AttendanceStatus));
                    UpdateCounters(studentRecord.AttendanceStatus);
                }
            }
            else
            {
                Console.WriteLine($"Attendance record not found for: {loggedInUser.FullName}, Subject: {selectedSubject}");
            }
        }

        private void UpdateCounters(int status)
        {
            switch (status)
            {
                case 4:
                    presentCount++;
                    break;
                case 3:
                    absentCount++;
                    break;
                case 2:
                    lateCount++;
                    if (lateCount % 3 == 0)
                    {
                        absentCount++;
                        lateCount = 0;
                    }
                    break;
                case 1:
                    excusedCount++;
                    break;
            }

            Console.WriteLine($"Absent Count: {absentCount}");
            Console.WriteLine($"Late Count: {lateCount}");
            Console.WriteLine($"Present Count: {presentCount}");
            Console.WriteLine($"Excused Count: {excusedCount}");
        }

        private string GetAttendanceStatus(int status)
        {
            switch (status)
            {
                case 4:
                    return "Present";
                case 3:
                    return "Absent";
                case 2:
                    return "Late";
                case 1:
                    return "Excused";
                default:
                    return "No input";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            if (comboBox1.SelectedItem != null)
            {
                string selectedSubject = comboBox1.SelectedItem.ToString();

                //filter attendance records for the selected subject and logged-in user
                List<StudentAttendance> attendanceRecords = Student.AttendanceRecords;
                List<StudentAttendance> studentRecordsForSubject = attendanceRecords
                    .Where(record => record.StudentName == loggedInUser.FullName && record.Subject == selectedSubject)
                    .ToList();

                var groupedRecords = studentRecordsForSubject.GroupBy(record => record.Date);

                if (groupedRecords.Any())
                {
                    foreach (var group in groupedRecords)
                    {
                        GroupBox groupBox = new GroupBox();
                        groupBox.Text = "";

                        foreach (var studentRecord in group)
                        {
                            // displays only the attendance record of the logged-in user
                            if (studentRecord.StudentName == loggedInUser.FullName)
                            {
                                System.Windows.Forms.Label dateLabel = new System.Windows.Forms.Label();
                                dateLabel.Text = $"{studentRecord.Date}";
                                dateLabel.Location = new Point(45, 0 );
                                groupBox.Controls.Add(dateLabel);

                                System.Windows.Forms.Label statusLabel = new System.Windows.Forms.Label();
                                statusLabel.Text = $"{GetAttendanceStatus(studentRecord.AttendanceStatus)}";
                                statusLabel.Location = new Point(170, 0 );
                                groupBox.Controls.Add(statusLabel);
                            }
                        }

                        groupBox.Size = new Size(470, 25);
                        flowLayoutPanel1.Controls.Add(groupBox);
                    }
                }
                else
                {
                    MessageBox.Show($"No attendance records found for the selected subject: {selectedSubject}.");
                }
            }
        }
    }
}
