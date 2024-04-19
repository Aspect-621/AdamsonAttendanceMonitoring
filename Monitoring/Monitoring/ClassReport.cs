using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Monitoring.Attendance;

namespace Monitoring
{
    public partial class ClassReport : Form
    {
        public List<Attendance.Status> attendanceList;
        public string labelZeor = "";

        public ClassReport(List<Attendance.Status> attendanceList, string labelText)
        {
            InitializeComponent();

            labelZeor = labelText;
            label7.Text = labelText;



            this.attendanceList = attendanceList;
            SelectedDate = DateTime.Now;
        }

        public DateTime SelectedDate = new DateTime();
        public int SelectedSubject;
        public string[] StudentName;
        public string[] StudentNo;
        public Status Status;
        public int Subject;
        public void GetData(string[] studentName, string[] studentNo, int subject)
        {
            StudentName = studentName;
            StudentNo = studentNo;
            Subject = subject;
        }

        public void DisplayAttendance()
        {
            // Clear existing controls from flowLayoutPanel1
            flowLayoutPanel1.Controls.Clear();

            // Filter attendance records for the selected date and subject
            var filteredAttendance = attendanceList.Where(record => record.DateTimeStamp.Date == SelectedDate.Date && record.Subject == SelectedSubject);

            // Iterate through filtered attendance records
            foreach (var attendanceRecord in filteredAttendance)
            {
                for (int i = 0; i < StudentName.Length; i++)
                {
                    GroupBox groupBox = new GroupBox();
                    groupBox.Text = StudentName[i];

                    Label id = new Label();
                    id.Text = StudentNo[i];
                    id.Location = new System.Drawing.Point(150, 0);

                    Label present = new Label();
                    present.Text = GetAttendanceStatus(attendanceRecord.AttendanceStatus[i]); // Get status text
                    present.Location = new System.Drawing.Point(345, 0);

                    groupBox.Controls.Add(id);
                    groupBox.Controls.Add(present);
                    groupBox.Size = new System.Drawing.Size(500, 25); // Width = 200, Height = 150

                    flowLayoutPanel1.Controls.Add(groupBox);
                    groupBox.TabIndex = i;
                }
            }

            // If no records found, display a message
            if (!filteredAttendance.Any())
            {
                MessageBox.Show("No attendance records found for the selected date/subject.");
            }
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



        private void label5_Click(object sender, EventArgs e)
        {
            TotalReport totalReport = new TotalReport(StudentName, StudentNo, attendanceList, labelZeor);
            totalReport.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            SelectedDate = dateTimePicker1.Value;
            DisplayAttendance();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedSubject = comboBox1.SelectedIndex;
            DisplayAttendance();
        }


        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Courses coursesForm = Application.OpenForms["Courses"] as Courses;
            coursesForm.Show();
            coursesForm.BringToFront();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Courses coursesForm = Application.OpenForms["Courses"] as Courses;
            coursesForm.Show();
            coursesForm.BringToFront();
            this.Close();
        }

        private void ClassReport_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Attendance attendanceForm = Application.OpenForms["Attendance"] as Attendance;
            attendanceForm.Show();
            attendanceForm.BringToFront();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Attendance attendanceForm = Application.OpenForms["Attendance"] as Attendance;
            attendanceForm.Show();
            attendanceForm.BringToFront();
            this.Close();
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

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            TotalReport totalReport = new TotalReport(StudentName, StudentNo, attendanceList, labelZeor);
            totalReport.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
