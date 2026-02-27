using System.Data.SQLite;
using System.Drawing.Text;

namespace Hospital_System
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=Hospital Database System.db;Version=3;"; //Connects the program to the SQLite database
        public Form1()
        {
            InitializeComponent();
            createTables(); //runs the create table method placed here to run on start up
        }

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

                    CREATE TABLE IF NOT EXISTS appointment (
                        appointmentID INTEGER PRIMARY KEY AUTOINCREMENT,
                        patientID INTEGER,
                        doctorID INTEGER,
                        appointmentDateTime TEXT,
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
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string insert = "INSERT INTO patient (password) VALUES (@text)";

                using (SQLiteCommand cmd = new SQLiteCommand(insert, conn))
                {
                    cmd.Parameters.AddWithValue("@text", writeTo.Text);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
