namespace Monitoring
{

    public partial class Form1 : Form
    {
        private Dictionary<string, string> adminUsers = new Dictionary<string, string>
        {
            {"admin1", "password1"},
        };
        private Dictionary<string, string> studentUsers = new Dictionary<string, string>
        {
            { "Student1", "ID1"},
{ "Student2", "ID2"},
{ "Student3", "ID3"},
{ "Student4", "ID4"},
{ "Student5", "ID5"}

           /* {"202320107", "AGAN"},
            {"202312640", "ALANGSAB"},
            { "202311220", "AÑASCO"},
            { "202313737", "AÑONUEVO"},
            { "202311985", "ATIM"},
            { "202311009", "BAUTISTA"},
            { "202314266", "BECINA"},
            { "202311209", "BIADOR"},
            { "201811248", "CABILAN"},
            { "202313091", "CAPATI"},
            { "202310421", "CASTILLO"},
            { "202310879", "CONCEPCION"},
            { "202312442", "DE GULA"},
            { "202311626", "DEL PRADO"},
            { "202313294", "DIAZANA"},
            { "202310447", "DUMALAG"},
            { "202311579", "EDILLON"},
            { "202310673", "ESCAÑO"},
            { "202314222", "ESPAÑOL"},
            { "202312225", "GAPASIN"},
            { "202311127", "GARCIA"},
            { "202312392", "GRICO"},
            { "202312710", "LEYESA"},
            { "202312813", "LUZON"},
            { "202311906", "MADIO"},
            { "202313046", "MARTINEZ"},
            { "202310536", "MENDOZA"},
            { "202313050", "MERCADO"},
            { "202116311", "PANAGA"},
            { "202310292", "PINLAC"},
            { "202313343", "QUIJANO"},
            { "202313882", "QUILATAN"},
            { "202311528", "REYNANCIA"},
            { "202119459", "RODRIGUEZ"},
            { "202313427", "SAMACO"},
            { "202311959", "SILANG"},
            { "202311615", "SIMON"},
            { "202310850", "SOLO"},
            { "202313020", "STA. ANA"},
            { "202313899", "TAGLE"},
            { "202310728", "VARELA"},
            { "202312834", "YABUT"},
            { "202312647", "ZAPATA"}*/
        };
        public static class GlobalDataStudent
        {
            public static Dictionary<string, string> StudentUsers { get; set; }
        }

        public Form1()
        {
            InitializeComponent();
            GlobalDataStudent.StudentUsers = studentUsers;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string inputUsername = usernameTextBox.Text;
            string inputPassword = passwordTextBox.Text;

            if (adminUsers.ContainsKey(inputUsername) && adminUsers[inputUsername] == inputPassword)
            {

                MessageBox.Show("Login successful as Admin");
                Courses courseForm = new Courses();
                courseForm.Show();
                this.Hide();
            }
            else if (studentUsers.ContainsKey(inputUsername) && studentUsers[inputUsername] == inputPassword)
            {
                MessageBox.Show("Login successful as Student");
                Courses studentForm = new Courses();
                studentForm.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");

            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }


    }
}