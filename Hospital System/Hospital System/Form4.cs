using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLitePCL;
using Microsoft.Data.Sqlite;
//using System.Data.SQLite;

namespace Hospital_System
{
    public partial class Form4 : Form
    {
        string connectionString = @"Data Source=Hospital Database System_encrypted.db;Password=a3lKC467MQsD2d3F;";//Connects the program to the SQLite database //Connects the program to the SQLite database
        int noOfAppointments = 0;
        int count = 0;
        public Form4()
        {
            InitializeComponent();
            WelcomeTextBox.Text = "Hello! Here are all your current appointments:";
            AppointmentTable_AddAppointments();
        }

        private void AppointmentTable_AddAppointments()
        {
            //appointmentTable.Rows.RemoveAt(appointmentTable.SelectedRows[1].Index);
            using (SqliteConnection conn = new SqliteConnection(connectionString))
            {
                conn.Open();
                using (SqliteCommand cmd = new SqliteCommand("PRAGMA foreign_keys = ON;", conn))
                {
                    cmd.ExecuteNonQuery();
                }
                string query = @"SELECT * from appointment INNER JOIN patient ON appointment.patientID = patient.patientID WHERE doctorID = @doctorID"; //check this works when the doctor form is fixed
                using (SqliteCommand cmd = new SqliteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@doctorID", 1);
                    using (SqliteDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            int rowIndex = appointmentTable.Rows.Add();

                            appointmentTable.Rows[rowIndex].Cells[0].Value = dr["date"];
                            appointmentTable.Rows[rowIndex].Cells[1].Value = dr["firstName"]; //figure out how to add lastname
                            appointmentTable.Rows[rowIndex].Cells[2].Value = dr["time"];
                            appointmentTable.Rows[rowIndex].Cells[3].Value = dr["appointmentNote"];
                        }
                    }
                }
            }
            //check how many appointments are booked
            //while (count <= noOfAppointments)
            //{
                //add row to table?
                //query the data for said row and slap it in there
            //}
        }
        private void WelcomeTextBox_TextChanged(object sender, EventArgs e)
        {
            //yoyoyo my homieeeee
        }

        private void appointmentTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
