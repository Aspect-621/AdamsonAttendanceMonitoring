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
        private Dictionary<string, UserData> userData = new Dictionary<string, UserData>
{
    { "202320107", new UserData("202320107", "AGAN", true, "MICHAEL CHRISTIAN AGAN") },
    { "202312640", new UserData("202312640", "ALANGSAB", true, "RIQUETA ALANGSAB") },
    { "202311220", new UserData("202311220", "AÑASCO", true, "ALTHEA ZOE AÑASCO") },
    { "202313737", new UserData("202313737", "AÑONUEVO", true, "CHRYSLER AÑONUEVO") },
    { "202311985", new UserData("202311985", "ATIM", true, "ARIELLE ERSHY ATIM") },
    { "202311009", new UserData("202311009", "BAUTISTA", true, "GEORGE KIEL BAUTISTA") },
    { "202314266", new UserData("202314266", "BECINA", true, "CYRILL JOHN BECINA") },
    { "202311209", new UserData("202311209", "BIADOR", true, "MARK JACOB BIADOR") },
    { "201811248", new UserData("201811248", "CABILAN", true, "RAFAEL CABILAN") },
    { "202313091", new UserData("202313091", "CAPATI", true, "KENTVER CAPATI") },
    { "202310421", new UserData("202310421", "CASTILLO", true, "KRISTIAN JEROME CASTILLO") },
    { "202310879", new UserData("202310879", "CONCEPCION", true, "LEE HENDRIX CONCEPCION") },
    { "202312442", new UserData("202312442", "DE GULA", true, "KERBY BRENT DE GULA") },
    { "202311626", new UserData("202311626", "DEL PRADO", true, "JERRYCO DEL PRADO") },
    { "202313294", new UserData("202313294", "DIAZANA", true, "JOHN DARREN DIAZANA") },
    { "202310447", new UserData("202310447", "DUMALAG", true, "JORDAN DUMALAG") },
    { "202311579", new UserData("202311579", "EDILLON", true, "JOSHUA LLOYD EDILLON") },
    { "202310673", new UserData("202310673", "ESCAÑO", true, "KRISHA ANN AME ESCAÑO") },
    { "202314222", new UserData("202314222", "ESPAÑOL", true, "JEM THEONIE ESPAÑOL") },
    { "202312225", new UserData("202312225", "GAPASIN", true, "MICHAEL ANDREI GAPASIN") },
    { "202311127", new UserData("202311127", "GARCIA", true, "ENJO MAE GARCIA") },
    { "202312392", new UserData("202312392", "GRICO", true, "CIRGS ALYXANDER GRICO") },
    { "202312710", new UserData("202312710", "LEYESA", true, "DANN MARTIN LEYESA") },
    { "202312813", new UserData("202312813", "LUZON", true, "ADRIAN DOMINIC LUZON") },
    { "202311906", new UserData("202311906", "MADIO", true, "JONALYN MADIO") },
    { "202313046", new UserData("202313046", "MARTINEZ", true, "HERO MARTINEZ") },
    { "202310536", new UserData("202310536", "MENDOZA", true, "WELLHEMSTAD MENDOZA") },
    { "202313050", new UserData("202313050", "MERCADO", true, "NICO MERCADO") },
    { "202116311", new UserData("202116311", "PANAGA", true, "CHARRY PANAGA") },
    { "202310292", new UserData("202310292", "PINLAC", true, "KENJI LUIS PINLAC") },
    { "202313343", new UserData("202313343", "QUIJANO", true, "TIM QUIJANO") },
    { "202313882", new UserData("202313882", "QUILATAN", true, "MARCIS JOSEPH QUILATAN") },
    { "202311528", new UserData("202311528", "REYNANCIA", true, "JESSIE LEI REYNANCIA") },
    { "202119459", new UserData("202119459", "RODRIGUEZ", true, "RHEGILLE GABRIEL RODRIGUEZ") },
    { "202313427", new UserData("202313427", "SAMACO", true, "CYRUS SAMACO") },
    { "202311959", new UserData("202311959", "SILANG", true, "LE BRON JAMES SILANG") },
    { "202311615", new UserData("202311615", "SIMON", true, "KIELLE FRANCEZ SIMON") },
    { "202310850", new UserData("202310850", "SOLO", true, "JOHN SOLO") },
    { "202313020", new UserData("202313020", "STA. ANA", true, "MARY ANGELIQUE STA. ANA") },
    { "202313899", new UserData("202313899", "TAGLE", true, "JEL KYANN TAGLE") },
    { "202310728", new UserData("202310728", "VARELA", true, "VENICE ARIANE VARELA") },
    { "202312834", new UserData("202312834", "YABUT", true, "ALEERAH MARISHKA YABUT") },
    { "202312647", new UserData("202312647", "ZAPATA", true, "KURT ANTHONY ZAPATA") },
    { "200000000", new UserData("200000000", "ALVEZ", false, "JEROME ALVEZ") }

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