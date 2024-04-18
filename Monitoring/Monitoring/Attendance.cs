using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using GroupBox = System.Windows.Forms.GroupBox;
using RadioButton = System.Windows.Forms.RadioButton;
using static Monitoring.Form1;

namespace Monitoring
{
    public partial class Attendance : Form
    {

        /*
        public string[] students = {
            "AGAN, Michael Christian",
            "ALANGSAB, Riqueta",
            "AÑASCO, Althea Zoe",
            "AÑONUEVO, Chrysler",
            "ATIM, Arielle Ershey",
            "BAUTISTA, George Kiel",
            "BECINA, Cyrill John",
            "BIADOR, Mark Jacob",
            "CABILAN, Rafael",
            "CAPATI, Kentver",
            "CASTILLO, Kristian Jerome",
            "CONCEPCION, Lee Hendrix",
            "DE GULA, Kerby Brent",
            "DEL PRADO, Jerryco",
            "DIAZANA, John Darren",
            "DUMALAG, Jordan",
            "EDILLON, Joshua Lloyd",
            "ESCAÑO, Krisha Ann Ame",
            "ESPAÑOL, Jem Theonie",
            "GAPASIN, Michael Andrei",
            "GARCIA, Enjo Mae",
            "GRICO, Cirgs Alyxander",
            "LEYESA, Dann Martin",
            "LUZON, Adrian Dominic",
            "MADIO, Jonalyn",
            "MARTINEZ, Hero",
            "MENDOZA, Wellhemstad",
            "MERCADO, Nico",
            "PANAGA, Charry",
            "PINLAC, Kenji Luis",
            "QUIJANO, Tim",
            "QUILATAN, Marcis Joseph",
            "REYNANCIA, Jessie Lei",
            "RODRIGUEZ, Rhegille Gabriel",
            "SAMACO, Cyrus",
            "SILANG, Le Bron James",
            "SIMON, Kielle Francez",
            "SOLO, John",
            "STA. ANA, Mary Angelique",
            "TAGLE, Jel Kyann",
            "VARELA, Venice Ariane",
            "YABUT, Aleerah Marishka",
            "ZAPATA, Kurt Anthony"
                };



                 public string[] studentID = {"202320107",
            "202312640",
            "202311220",
            "202313737",
            "202311985",
            "202311009",
            "202314266",
            "202311209",
            "201811248",
            "202313091",
            "202310421",
            "202310879",
            "202312442",
            "202311626",
            "202313294",
            "202310447",
            "202311579",
            "202310673",
            "202314222",
            "202312225",
            "202311127",
            "202312392",
            "202312710",
            "202312813",
            "202311906",
            "202313046",
            "202310536",
            "202313050",
            "202116311",
            "202310292",
            "202313343",
            "202313882",
            "202311528",
            "202119459",
            "202313427",
            "202311959",
            "202311615",
            "202310850",
            "202313020",
            "202313899",
            "202310728",
            "202312834",
            "202312647" };
                */
        //FOR TEST CASE
        public string[] students = { "Student1", "Student2", "Student3", "Student4", "Student5" };
        public string[] studentID = { "ID1", "ID2", "ID3", "ID4", "ID5" };
        public int[] attendanceStatus;
        public DateTime date = new DateTime();
        public int subject;
        public Status attendance;
        private UserData loggedInUser;

        public class Status
        {
            public DateTime DateTimeStamp { get; set; }
            public string[] StudentNames { get; set; } // Array of student names
            public int[] AttendanceStatus { get; set; }
            public int Subject { get; set; }
            public string[] Student_ID { get; set; } // Array of student names
            public Status(DateTime dateTimeStamp, string[] studentNames, int[] attendanceStatus, int subject, string[] studentID)
            {
                DateTimeStamp = dateTimeStamp;
                StudentNames = studentNames;
                AttendanceStatus = attendanceStatus;
                Subject = subject;
                Student_ID = studentID;
            }
        }


        public Attendance(UserData userData)
        {
            InitializeComponent();
            CreateGroupBoxes();
            this.loggedInUser = userData;
            attendanceStatus = new int[students.Length];
            comboBox1.SelectedIndex = 0;
            date = DateTime.Today;


        }
        private void CreateGroupBoxes()
        {
            for (int i = 0; i < students.Length; i++)
            {
                // group box
                GroupBox groupBox = new GroupBox();
                groupBox.Text = students[i];

                //label = student num
                Label label = new Label();
                label.Text = studentID[i];
                label.Location = new System.Drawing.Point(150, -1);

                groupBox.Controls.Add(label);
                groupBox.Size = new System.Drawing.Size(500, 25); // Width = 500, Height = 25

                for (int j = 0; j < 4; j++)
                {
                    RadioButton radioButton = new RadioButton();
                    radioButton.Text = "";
                    radioButton.BackColor = Color.Transparent;
                    radioButton.Location = new System.Drawing.Point(475 + (-(j * 65)), -1);
                    radioButton.CheckedChanged += (sender, e) =>
                    {
                        // Store the selected index when a radio button changes
                        RadioButton btn = (RadioButton)sender;
                        if (btn.Checked)
                        {
                            int index = (btn.Parent as GroupBox).TabIndex; // Get the index of the group box
                            attendanceStatus[index] = Array.IndexOf(btn.Parent.Controls.OfType<RadioButton>().ToArray(), btn) + 1; // Store the selected index
                            // 4 - Present, 3 - Absent, 2 - Late, 1 - Excused, 0 - No input
                        }
                    };

                    groupBox.Controls.Add(radioButton);
                }
                flowLayoutPanel1.Controls.Add(groupBox);
                groupBox.TabIndex = i;
            }
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Courses courseNew = new Courses(loggedInUser);
            courseNew.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Attendance_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            date = dateTimePicker1.Value;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            subject = comboBox1.SelectedIndex;
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void displayClassReport(object sender, EventArgs e)
        {

        }

        private void submitAttendance_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Submitted successfully.");


            Status existingRecord = attendanceList.FirstOrDefault(record => record.DateTimeStamp.Date == date.Date && record.Subject == subject);

            if (existingRecord != null)
            {
                // Update existing record
                existingRecord.AttendanceStatus = attendanceStatus.ToArray();
                existingRecord.Subject = subject;
            }
            else
            {
                // Create new record
                Status attendanceRecord = new Status(new DateTime(date.Year, date.Month, date.Day),students, attendanceStatus.ToArray(), subject, studentID);
                attendanceList.Add(attendanceRecord); // Add attendance to the list
            }

            // Print the attendance list to the console
        }

        private void label3_Click(object sender, EventArgs e)
        {
            ClassReport classReport = new ClassReport(attendanceList);
            classReport.GetData(students, studentID, attendance, subject);
            classReport.Show();
            this.Hide();

        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ClassReport classReport = new ClassReport(attendanceList);
            classReport.GetData(students, studentID, attendance, subject);
            classReport.Show();
            this.Hide();
        }


        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Form1 Form = new Form1();
            Form.Show();
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form1 Form = new Form1();
            Form.Show();
            this.Close();
        }
        private void PrintAttendanceList()
        {
            foreach (var attendanceRecord in attendanceList)
            {
                Console.WriteLine("Date: " + attendanceRecord.DateTimeStamp);
                Console.WriteLine("Subject: " + attendanceRecord.Subject);
                Console.WriteLine("Attendance Status:");
                for (int i = 0; i < attendanceRecord.AttendanceStatus.Length; i++)
                {
                    Console.WriteLine(students[i] + ": " + GetAttendanceStatus(attendanceRecord.AttendanceStatus[i]));
                }
                Console.WriteLine();
            }
        }
        public static List<Status> attendanceList = new List<Status>();

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

        private void button1_Click(object sender, EventArgs e)
        {
            AllocConsole();
            PrintAttendanceList();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Courses courseNew = new Courses(loggedInUser);
            courseNew.Show();
            this.Close();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            TotalReport totalReportForm = new TotalReport(attendanceList);
            totalReportForm.Show();
        }
    }
}
