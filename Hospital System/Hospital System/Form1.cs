using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Text;

namespace Hospital_System
{
    public partial class Form1 : Form
    {
        string connectionString = @"Server=(localdb)\ProjectModels;Database=Hospital database system;Trusted_Connection=True;"; //This basically serves as a link between the program and the database, don't change it please
        public Form1()
        {
            InitializeComponent();
        }

        private void crazyDatabaseInput_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString)) //Creates a new SQL connection, connection string is placed in the brackets as this is the path to the database basically
            {
                conn.Open(); //Opems the connection must be used at the start of EVERY function involving the database

                string query = "SELECT * FROM patient"; // Queries are placed in stringd the following is an exampple of a select all
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string line = "";

                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            line += $"{reader.GetName(i)}: {reader[i]}";
                        }
                        awesomeDatabaseOutput.AppendText(line + Environment.NewLine);
                    }
                }
            }
        }

        private void awesomeDatabaseOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void crazyDatabaseSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(inputpasswordyo.Text))
            {
                MessageBox.Show("WRONG I HATE YOU");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string highestID = "SELECT ISNULL (MAX(patientID), 0) FROM patient"; //Query getting the highest ID will be useful for forms involving us entering new things
                int newID;
                using (SqlCommand cmd = new SqlCommand(highestID, conn))
            S    {
                    newID = (int)cmd.ExecuteScalar() + 1;
                }
                string insert = "INSERT INTO patient (patientID, patientPassword) VALUES (@Id, @Password)"; //Insert script again would be useful in a lot of areas
                using (SqlCommand cmdInsert = new SqlCommand(insert, conn))
                {
                    cmdInsert.Parameters.AddWithValue("@Id", newID);
                    cmdInsert.Parameters.AddWithValue("@Password", inputpasswordyo.Text);

                    cmdInsert.ExecuteNonQuery();
                }

            }
            inputpasswordyo.Clear();
        }
    }
}
