<<<<<<< Updated upstream
=======
using System.Collections.Generic;
>>>>>>> Stashed changes
using System.Data.SQLite;
using System.Drawing.Text;

namespace Hospital_System
{
    //this is the LOGIN PORTAL
    public partial class Login : Form
    {
        string connectionString = @"Data Source=Hospital Database System.db;Version=3;"; //Connects the program to the SQLite database
<<<<<<< Updated upstream
        public Form1()
        {
            InitializeComponent();
            createTables(); //runs the create table method placed here to run on start up
        }

=======
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
                string query = "SELECT CAST(patientID AS TEXT) FROM patient WHERE patientID = @id AND password = @password"; // Query to see if the inputted credentials exist in the database
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", UsernameTextBox.Text); // inputs the ID and password into the query
                    cmd.Parameters.AddWithValue("@password", PasswordTextBox.Text); // May need to add encryption I think
                    var result = cmd.ExecuteScalar(); // var makes the compiler infers the type of the variable, ExecuteScalar is used to execute the query and return a single value (the patientID if the credentials are correct, or null if they are not)
                    if (result != null)
                    {
                        //if they do, open the next form
                        this.Hide();
                        Form2 form2 = new Form2();
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
>>>>>>> Stashed changes
        private void createTables() // This functions creates the tables, SQL placed in string varrible
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open(); //opens the connection to the database
                string createTables = @"
                    CREATE TABLE IF NOT EXISTS patient (
                        patientID INTEGER PRIMARY KEY AUTOINCREMENT,
                        password TEXT
                    );

                    CREATE TABLE IF NOT EXISTS doctor (
                        doctorID INTEGER PRIMARY KEY AUTOINCREMENT
                    );

                    CREATE TABLE IF NOT EXISTS date (
                        dateID INTEGER PRIMARY KEY AUTOINCREMENT,
                        date VARCHAR(10)
                    );

                    CREATE TABLE IF NOT EXISTS time (
                        timeID INTEGER PRIMARY KEY AUTOINCREMENT,
                        time VARCHAR(5)
                    );

                    CREATE TABLE IF NOT EXISTS appointment (
                        appointmentID INTEGER PRIMARY KEY AUTOINCREMENT,
                        patientID INTEGER,
                        doctorID INTEGER,
                        dateID INTEGER,
                        timeID INTEGER,
                        appointmentNote TEXT,
                        FOREIGN KEY(dateID) REFERENCES date(dateID), 
                        FOREIGN KEY(timeID) REFERENCES time(timeID),
                        FOREIGN KEY(patientID) REFERENCES patient(patientID),
                        FOREIGN KEY(doctorID) REFERENCES doctor(doctorID)
                    );
                    
                ";
                using (SQLiteCommand cmd = new SQLiteCommand(createTables, conn))
                {
                    cmd.ExecuteNonQuery(); //runs the query
                }
            }
<<<<<<< Updated upstream
            /* using (SQLiteConnection conn = new SQLiteConnection(connectionString)) -- thing to add dates
=======
            /*
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
>>>>>>> Stashed changes
            {
                conn.Open();

                string insert = "INSERT INTO date (date) VALUES (@text)";
                int dateDay = 1;
                int dateMonth = 3; 
                int dateYear = 2026;
                for (int i = 0; i < 93; i++)
                {
                    if(i == 31)
                    {
                        dateDay = 1;
                        dateMonth = 4;
                    }
                    if(i == 62)
                    {
                        dateDay = 1;
                        dateMonth = 5;
                    }
                    using (SQLiteCommand cmd = new SQLiteCommand(insert, conn))
                    {
                        cmd.Parameters.AddWithValue("@text", dateDay + "/" + dateMonth + "/" + dateYear);
                        cmd.ExecuteNonQuery();
                    }
                    dateDay++;
                }
            }
<<<<<<< Updated upstream
            */
            /* using (SQLiteConnection conn = new SQLiteConnection(connectionString)) -- Adding times insert
=======
            
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
>>>>>>> Stashed changes
            {
                conn.Open();

                string insert = "INSERT INTO time (time) VALUES (@text)";
                string timeMin = "00";
                int timeHour = 0;
                for (int i = 0; i < 47; i++)
                {
                    using (SQLiteCommand cmd = new SQLiteCommand(insert, conn))
                    {
                        
                        if(i <= 9)
                        {
                            cmd.Parameters.AddWithValue("@text", "0" + timeHour + ":" + timeMin);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@text", timeHour + ":" + timeMin);
                        }
                        cmd.ExecuteNonQuery();
                    }
                    int rem = i % 2;
                    if(rem == 0)
                    {
                        timeMin = "00";
                        timeHour++;
                    }
                    else
                    {
                        timeMin = "30";
                    }
                }
            }
<<<<<<< Updated upstream
            */
        }

        private void allButton_Click(object sender, EventArgs e) //This button selects all the items in the patient table
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string selectALL = @" SELECT * FROM patient";
                using (SQLiteCommand cmd = new SQLiteCommand(selectALL, conn))
                using (SQLiteDataReader reader = cmd.ExecuteReader()) //Use this for reading the database
                {
                    allDisplay.Clear();

                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            allDisplay.AppendText(reader[i].ToString() + " ");
                        }
                    }
                }
            }
        }

        private void writeButtton_Click(object sender, EventArgs e) //This table lets the user add there password and adds that to the database
        {
=======
>>>>>>> Stashed changes
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string insert = "INSERT INTO patient (password) VALUES (@text)";
<<<<<<< Updated upstream

                using (SQLiteCommand cmd = new SQLiteCommand(insert, conn))
                {
                    cmd.Parameters.AddWithValue("@text", writeTo.Text);
                    cmd.ExecuteNonQuery();
                }
            }
=======
                using (SQLiteCommand cmd = new SQLiteCommand(insert, conn))
                {
                    cmd.Parameters.AddWithValue("@text", "password");
                }
            }
            */
>>>>>>> Stashed changes
        }
    }
}
