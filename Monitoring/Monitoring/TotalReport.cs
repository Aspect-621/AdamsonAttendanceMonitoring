using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Monitoring;

namespace Monitoring
{
    public partial class TotalReport : Form
    {

        private List<Attendance.Status> attendanceList;

        public TotalReport(List<Attendance.Status> attendanceList)
        {
            InitializeComponent();
            this.attendanceList = attendanceList;

        }
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
        private void DisplayTotalAttendance(List<Attendance.Status> attendanceList)
        {
            // Clear existing controls from flowLayoutPanel1
            flowLayoutPanel1.Controls.Clear();

            // Create a dictionary to store the total attendance count and classes attended for each student in the selected subject
            Dictionary<string, Tuple<int, int>> studentAttendanceCount = new Dictionary<string, Tuple<int, int>>();

            // Count total attendance for each student in the selected subject
            foreach (var attendanceRecord in attendanceList)
            {
                int subject = attendanceRecord.Subject;
                if (subject != comboBox1.SelectedIndex)
                    continue;

                for (int i = 0; i < attendanceRecord.StudentNames.Length; i++)
                {
                    string studentName = attendanceRecord.StudentNames[i];
                    string studentID = attendanceRecord.Student_ID[i];
                    if (!studentAttendanceCount.ContainsKey(studentName))
                    {
                        studentAttendanceCount[studentName] = new Tuple<int, int>(0, 0);
                    }

                    // Count only actual present attendance
                    if (attendanceRecord.AttendanceStatus[i] == 4) // Present
                    {
                        studentAttendanceCount[studentName] = Tuple.Create(studentAttendanceCount[studentName].Item1 + 1, studentAttendanceCount[studentName].Item2 + 1);
                    }
                    else if (attendanceRecord.AttendanceStatus[i] > 0) // Count all other statuses except No input
                    {
                        studentAttendanceCount[studentName] = Tuple.Create(studentAttendanceCount[studentName].Item1, studentAttendanceCount[studentName].Item2 + 1);
                    }
                }
            }

            // Calculate and display total attendance percentage for each student in the selected subject
            foreach (var kvp in studentAttendanceCount)
            {
                GroupBox groupBox = new GroupBox();
                groupBox.Text = kvp.Key; // Student name

                int totalClasses = kvp.Value.Item2;
                double attendancePercentage = totalClasses > 0 ? (double)kvp.Value.Item1 / totalClasses * 100 : 0; // Calculate percentage

                // Create label for student ID
                Label idLabel = new Label();
                idLabel.Text = $"{attendanceList.FirstOrDefault(record => record.StudentNames.Contains(kvp.Key))?.Student_ID.First()}";
                idLabel.Location = new System.Drawing.Point(200, 0);
                groupBox.Controls.Add(idLabel);

                // Create label for total attendance percentage
                Label attendanceLabel = new Label();
                attendanceLabel.Text = $"{attendancePercentage:F2}% ";
                attendanceLabel.Location = new System.Drawing.Point(400, 0);
                groupBox.Controls.Add(attendanceLabel);

                // Add the group box to the flow layout panel
                groupBox.Size = new System.Drawing.Size(500, 25);
                flowLayoutPanel1.Controls.Add(groupBox);
            }
        }


        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int selectedSubject = comboBox1.SelectedIndex;

            // Filter the attendance list for the selected subject
            List<Attendance.Status> filteredAttendanceList = attendanceList.Where(record => record.Subject == selectedSubject).ToList();

            // Display the attendance for the selected subject
            DisplayTotalAttendance(filteredAttendanceList);

        }













        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TotalReport_Load(object sender, EventArgs e)
        {

        }

    
    }
}
