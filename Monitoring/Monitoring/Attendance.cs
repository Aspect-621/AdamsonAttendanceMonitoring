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
        private int[] studentStatus; 

        public Attendance()
        {
            InitializeComponent();
            CreateGroupBoxes();
            studentStatus = new int[students.Length];

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
                            studentStatus[index] = Array.IndexOf(btn.Parent.Controls.OfType<RadioButton>().ToArray(), btn) + 1; // Store the selected index
                        }
                    };
          
                    groupBox.Controls.Add(radioButton);
                }
                flowLayoutPanel1.Controls.Add(groupBox);
                groupBox.TabIndex = i;
            }
        }

     





        private void submitAttendance_Click(object sender, EventArgs e)
        {

            //FOR CHECKING
            AllocConsole();
            foreach (int selectedIndex in studentStatus)
            {
                Console.WriteLine(selectedIndex);
            }
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();





















        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
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

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label474_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label570_Click(object sender, EventArgs e)
        {

        }

        private void label948_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }


    }
}
