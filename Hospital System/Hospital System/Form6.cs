using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Hospital_System
{
    public partial class Form6 : Form
    {
        //Connects the program to the SQLite database
        string connectionString = @"Data Source=Hospital Database System.db;Version=3;";

        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM patient WHERE @id = patientID AND username = @username";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", textBox1.Text);
                    cmd.Parameters.AddWithValue("@username", textBox2.Text);
                    var result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        string updateQuery = "UPDATE patient set password = @password WHERE @id = patientID";
                        using (SQLiteCommand cmd2 = new SQLiteCommand(updateQuery, conn))
                        {
                            cmd2.Parameters.AddWithValue("@password", textBox3.Text);
                            cmd2.Parameters.AddWithValue("@id", textBox1.Text);
                            cmd2.ExecuteScalar();
                            MessageBox.Show("Your password has been updated.");
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login form1 = new Login();
            form1.ShowDialog();
            this.Close();
        }
    }
}
