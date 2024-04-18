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
            DisplayTotalAttendance();

        }
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
        private void DisplayTotalAttendance()
        {
            // Clear existing controls from flowLayoutPanel1
            flowLayoutPanel1.Controls.Clear();

            // Create a dictionary to store the total attendance count for each student
            Dictionary<string, int> totalAttendanceCount = new Dictionary<string, int>();

            // Count total attendance for each student
            foreach (var attendanceRecord in attendanceList)
            {
                for (int i = 0; i < attendanceRecord.AttendanceStatus.Length; i++)
                {
                    string studentName = attendanceRecord.StudentNames[i];
                    if (!totalAttendanceCount.ContainsKey(studentName))
                    {
                        totalAttendanceCount[studentName] = 0;
                    }

                    // Count only actual present attendance
                    if (attendanceRecord.AttendanceStatus[i] == 4) // Present
                    {
                        totalAttendanceCount[studentName]++;
                    }
                }
            }

            // Calculate and display total attendance percentage for each student
            // Calculate and display total attendance percentage for each student
            foreach (var kvp in totalAttendanceCount)
            {
                GroupBox groupBox = new GroupBox();
                groupBox.Text = kvp.Key; // Student name

                int totalClasses = attendanceList.Count;
                double attendancePercentage = (double)kvp.Value / totalClasses * 100; // Calculate percentage

                Label attendanceLabel = new Label();
                attendanceLabel.Location = new System.Drawing.Point(150, 0);

                // Set the label text
                attendanceLabel.Text = $"{attendancePercentage:F2}%"; // Display attendance percentage

                // Add the label to the group box
                groupBox.Controls.Add(attendanceLabel);
                groupBox.Size = new System.Drawing.Size(500, 40);

                // Add groupBox to flowLayoutPanel1
                flowLayoutPanel1.Controls.Add(groupBox);
            }

        }











        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TotalReport_Load(object sender, EventArgs e)
        {

        }
    }
}
