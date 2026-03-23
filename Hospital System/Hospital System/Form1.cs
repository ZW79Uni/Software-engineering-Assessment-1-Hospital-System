using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing.Text;

namespace Hospital_System
{
    //this is the LOGIN PORTAL
    public partial class Login : Form
    {
        string connectionString = @"Data Source=Hospital Database System.db;Version=3;"; //Connects the program to the SQLite database
        public Login()
        {
            InitializeComponent();
            createTables();
        }
        string UsernameDisplay = String.Empty;
        string PasswordDisplay = String.Empty; //might have to encrypt this or something

        private void LoginButton_Click(object sender, EventArgs e)
        {
            //if username and password match the database,
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open(); //opens the connection to the database
                string query = "SELECT * FROM patient WHERE @id = patientID AND username = @username AND password = @password"; // Query to see if the inputted credentials exist in the database
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idTextBox.Text);
                    cmd.Parameters.AddWithValue("@username", UsernameTextBox.Text); // inputs the ID and password into the query
                    cmd.Parameters.AddWithValue("@password", PasswordTextBox.Text); // May need to add encryption I think
                    var result = cmd.ExecuteScalar(); // var makes the compiler infers the type of the variable, ExecuteScalar is used to execute the query and return a single value (the patientID if the credentials are correct, or null if they are not)
                    if (result != null)
                    {
                        //if they do, open the next form
                        this.Hide();
                        Form2 form2 = new Form2(UsernameTextBox.Text, Convert.ToInt32(idTextBox.Text));
                        form2.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        //if they don't, display an error message
                        incorrectBox.Text = "Incorrect username or password. Please try again.";
                    }
                }
            }
        }

        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {
            UsernameDisplay = UsernameTextBox.Text;
            textBox1.Text = UsernameDisplay; //puts whatever's in the username field into a variable
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            PasswordDisplay = PasswordTextBox.Text;
            textBox2.Text = PasswordDisplay; //puts whatever's in the password field into a variable
        }

        private void createTables() // This functions creates the tables, SQL placed in string varrible
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open(); //opens the connection to the database
                string createTables = @"                  

                    CREATE TABLE IF NOT EXISTS patient (
                        patientID INTEGER PRIMARY KEY AUTOINCREMENT,
                        password VARCHAR(50),
                        username VARCHAR(50),
                        firstName VARCHAR(50),
                        lastName VARCHAR(50)
                    );

                    CREATE TABLE IF NOT EXISTS doctor (
                        doctorID INTEGER PRIMARY KEY AUTOINCREMENT,
                        firstName VARCHAR(50),
                        lastName VARCHAR(50)
                    );

                    CREATE TABLE IF NOT EXISTS appointment (
                        appointmentID INTEGER PRIMARY KEY AUTOINCREMENT,
                        patientID INTEGER,
                        doctorID INTEGER,
                        date VARCHAR(50),
                        time VARCHAR(50),
                        appointmentNote TEXT,
                        FOREIGN KEY(patientID) REFERENCES patient(patientID),
                        FOREIGN KEY(doctorID) REFERENCES doctor(doctorID)
                    );
                    
                ";
                using (SQLiteCommand cmd = new SQLiteCommand(createTables, conn))
                {
                    cmd.ExecuteNonQuery(); //runs the query
                }
            }
            /*
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string insert = "INSERT INTO patient (password, username, firstName, lastName) VALUES (@password, @username, @firstName, @lastName)";
                using (SQLiteCommand cmd = new SQLiteCommand(insert, conn))
                {
                    cmd.Parameters.AddWithValue("@password", "password123!");
                    cmd.Parameters.AddWithValue("@username", "TS1!");
                    cmd.Parameters.AddWithValue("@firstName", "Thomas");
                    cmd.Parameters.AddWithValue("@lastName", "Simpson");
                    cmd.ExecuteNonQuery();
                }
            }
            
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string insert = "INSERT INTO doctor (firstName, lastName) VALUES (@firstName, @lastName)";
                using (SQLiteCommand cmd = new SQLiteCommand(insert, conn))
                {
                    cmd.Parameters.AddWithValue("@firstName", "Martha");
                    cmd.Parameters.AddWithValue("@lastName", "Adams");
                    cmd.ExecuteNonQuery();
                }
            }1qa    \
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string insert = "INSERT INTO appointment (patientID, doctorID, date, time, appointmentNote) VALUES (@patientID, @doctorID, @date, @time, @appoitmentNote)";
                using (SQLiteCommand cmd = new SQLiteCommand(insert, conn))
                {
                    cmd.Parameters.AddWithValue("@patientID", "1");
                    cmd.Parameters.AddWithValue("@doctorID", "1");
                    cmd.Parameters.AddWithValue("@date", "20/3/2026");
                    cmd.Parameters.AddWithValue("@time", "10:30");
                    cmd.Parameters.AddWithValue("@appoitmentNote", "test");
                    cmd.ExecuteNonQuery();
                }
            }
            */
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
