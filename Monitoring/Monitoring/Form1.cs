namespace Monitoring
{
    public partial class Form1 : Form
    {
        public class UserData
        {
            public string UserID { get; set; }
            public string Surname { get; set; }
            public bool IsStudent { get; set; }
            public string FullName { get; set; }

            public UserData(string userID, string surname, bool isStudent, string fullName)
            {
                UserID = userID;
                Surname = surname;
                IsStudent = isStudent;
                FullName = fullName;
            }
        }
        private Dictionary<string,  UserData> userData = new Dictionary<string, UserData>
{
    { "202320107", new UserData("202320107", "AGAN", true, "Michael Christian AGAN") },
    { "202312640", new UserData("202312640", "ALANGSAB", true, "Riqueta ALANGSAB") },
    { "202311220", new UserData("202311220", "AÑASCO", true, "Althea Zoe AÑASCO") },
    { "202313737", new UserData("202313737", "AÑONUEVO", true, "Chrysler AÑONUEVO") },
    { "202311985", new UserData("202311985", "ATIM", true, "Arielle Ershey ATIM") },
    { "202311009", new UserData("202311009", "BAUTISTA", true, "George Kiel BAUTISTA") },
    { "202314266", new UserData("202314266", "BECINA", true, "Cyrill John BECINA") },
    { "202311209", new UserData("202311209", "BIADOR", true, "Mark Jacob BIADOR") },
    { "201811248", new UserData("201811248", "CABILAN", true, "Rafael CABILAN") },
    { "202313091", new UserData("202313091", "CAPATI", true, "Kentver CAPATI") },
    { "202310421", new UserData("202310421", "CASTILLO", true, "Kristian Jerome CASTILLO") },
    { "202310879", new UserData("202310879", "CONCEPCION", true, "Lee Hendrix CONCEPCION") },
    { "202312442", new UserData("202312442", "DE GULA", true, "Kerby Brent DE GULA") },
    { "202311626", new UserData("202311626", "DEL PRADO", true, "Jerryco DEL PRADO") },
    { "202313294", new UserData("202313294", "DIAZANA", true, "John Darren DIAZANA") },
    { "202310447", new UserData("202310447", "DUMALAG", true, "Jordan DUMALAG") },
    { "202311579", new UserData("202311579", "EDILLON", true, "Joshua Lloyd EDILLON") },
    { "202310673", new UserData("202310673", "ESCAÑO", true, "Krisha Ann Ame ESCAÑO") },
    { "202314222", new UserData("202314222", "ESPAÑOL", true, "Jem Theonie ESPAÑOL") },
    { "202312225", new UserData("202312225", "GAPASIN", true, "Michael Andrei GAPASIN") },
    { "202311127", new UserData("202311127", "GARCIA", true, "Enjo Mae GARCIA") },
    { "202312392", new UserData("202312392", "GRICO", true, "Cirgs Alyxander GRICO") },
    { "202312710", new UserData("202312710", "LEYESA", true, "Dann Martin LEYESA") },
    { "202312813", new UserData("202312813", "LUZON", true, "Adrian Dominic LUZON") },
    { "202311906", new UserData("202311906", "MADIO", true, "Jonalyn MADIO") },
    { "202313046", new UserData("202313046", "MARTINEZ", true, "Hero MARTINEZ") },
    { "202310536", new UserData("202310536", "MENDOZA", true, "Wellhemstad MENDOZA") },
    { "202313050", new UserData("202313050", "MERCADO", true, "Nico MERCADO") },
    { "202116311", new UserData("202116311", "PANAGA", true, "Charry PANAGA") },
    { "202310292", new UserData("202310292", "PINLAC", true, "Kenji Luis PINLAC") },
    { "202313343", new UserData("202313343", "QUIJANO", true, "Tim QUIJANO") },
    { "202313882", new UserData("202313882", "QUILATAN", true, "Marcis Joseph QUILATAN") },
    { "202311528", new UserData("202311528", "REYNANCIA", true, "Jessie Lei REYNANCIA") },
    { "202119459", new UserData("202119459", "RODRIGUEZ", true, "Rhegille Gabriel RODRIGUEZ") },
    { "202313427", new UserData("202313427", "SAMACO", true, "Cyrus SAMACO") },
    { "202311959", new UserData("202311959", "SILANG", true, "Le Bron James SILANG") },
    { "202311615", new UserData("202311615", "SIMON", true, "Kielle Francez SIMON") },
    { "202310850", new UserData("202310850", "SOLO", true, "John SOLO") },
    { "202313020", new UserData("202313020", "STA. ANA", true, "Mary Angelique STA. ANA") },
    { "202313899", new UserData("202313899", "TAGLE", true, "Jel Kyann TAGLE") },
    { "202310728", new UserData("202310728", "VARELA", true, "Venice Ariane VARELA") },
    { "202312834", new UserData("202312834", "YABUT", true, "Aleerah Marishka YABUT") },
    { "202312647", new UserData("202312647", "ZAPATA", true, "Kurt Anthony ZAPATA") },
    { "200000000", new UserData("200000000", "ALVEZ", false, "Jerome ALVEZ") }

};

        public Form1()
        {
            InitializeComponent();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string inputUsername = usernameTextBox.Text;
            string inputPassword = passwordTextBox.Text;

            if (userData.ContainsKey(inputUsername) && userData[inputUsername].Surname == inputPassword)
            {
                UserData loggedInUser = userData[inputUsername];

                if (loggedInUser.IsStudent)
                {
                    MessageBox.Show("Login successful as Student!");
                    Courses studentForm = new Courses(loggedInUser);
                    studentForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login successful as Admin!");
                    Courses courseForm = new Courses(loggedInUser);
                    courseForm.Show();
                    this.Hide();
                }
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