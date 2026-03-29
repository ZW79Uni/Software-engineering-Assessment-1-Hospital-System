using Hospital_System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.SqlClient;
using SQLitePCL;
using Microsoft.Data.Sqlite;
//using System.Data.SQLite;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hospital_System
{
    public partial class Form5 : Form
    {
        int uID;
        string userTag;
        string connectionString = @"Data Source=Hospital Database System_encrypted.db;Password=a3lKC467MQsD2d3F;";//Connects the program to the SQLite database

        public Form5(string Username, int ID)
        {
            InitializeComponent();
            uID = ID;
            userTag = Username;
            int IncrementIllness = 0;
            int IncrementingIllness = 1;
            bool AllergyCheck = false;
            bool InjuryCheck = false;
            string[] Top = { "Type", "Description" };
            string countQuery = "SELECT count(record.illness) from recordAllocation LEFT JOIN record ON (record.recordID = recordAllocation.recordID) LEFT JOIN patient ON (recordAllocation.patientID = patient.patientID) WHERE patient.patientID = @uID";
            string countQuery2 = "SELECT count(record.allergy) from recordAllocation LEFT JOIN record ON (record.recordID = recordAllocation.recordID) LEFT JOIN patient ON (recordAllocation.patientID = patient.patientID) WHERE patient.patientID = @uID";
            string countQuery3 = "SELECT count(record.injury) from recordAllocation LEFT JOIN record ON (record.recordID = recordAllocation.recordID) LEFT JOIN patient ON (recordAllocation.patientID = patient.patientID) WHERE patient.patientID = @uID";
            string selectIllness = "SELECT record.illness from recordAllocation LEFT JOIN record ON(record.recordID = recordAllocation.recordID) LEFT JOIN patient ON(recordAllocation.patientID = patient.patientID) WHERE patient.patientID = @uID AND record.recordID = @i";
            string selectAllergy = "SELECT record.allergy from recordAllocation LEFT JOIN record ON(record.recordID = recordAllocation.recordID) LEFT JOIN patient ON(recordAllocation.patientID = patient.patientID) WHERE patient.patientID = @uID AND record.recordID = @i";
            string selectInjury = "SELECT record.injury from recordAllocation LEFT JOIN record ON(record.recordID = recordAllocation.recordID) LEFT JOIN patient ON(recordAllocation.patientID = patient.patientID) WHERE patient.patientID = @uID AND record.recordID = @i";
            using (SqliteConnection conn = new SqliteConnection(connectionString))
            {
                conn.Open();
                using (SqliteCommand FIRSTQUERY = new SqliteCommand(countQuery, conn))
                {
                    FIRSTQUERY.Parameters.AddWithValue("@uID", uID);
                    var amountOfRow = FIRSTQUERY.ExecuteScalar().ToString();
                    int totalRow = 0;
                    totalRow = totalRow + (Convert.ToInt32(amountOfRow));
                    int amountOfIllness = (Convert.ToInt32(amountOfRow));


                    using (SqliteCommand SECONDQUERY = new SqliteCommand(countQuery2, conn))
                    {
                        SECONDQUERY.Parameters.AddWithValue("@uID", uID);
                        amountOfRow = SECONDQUERY.ExecuteScalar().ToString();
                        totalRow = totalRow + (Convert.ToInt32(amountOfRow));
                        int amountOfAllergy = (Convert.ToInt32(amountOfRow));
                        int IncrementAllergy = amountOfAllergy;
                        using (SqliteCommand THIRDQUERY = new SqliteCommand(countQuery3, conn))
                        {
                            THIRDQUERY.Parameters.AddWithValue("@uID", uID);
                            amountOfRow = THIRDQUERY.ExecuteScalar().ToString();
                            totalRow = totalRow + (Convert.ToInt32(amountOfRow));
                            int amountOfInjury = (Convert.ToInt32(amountOfRow));
                            int IncrementInjury = amountOfInjury;
                            if (dataGridView1.Columns.Count == 0)
                            {
                                for (int i = 0; i < 2; i++)
                                {
                                    dataGridView1.Columns.Add("col" + i, Top[i]);

                                }
                                for (int i = 0; i < (totalRow); i++)
                                {
                                    dataGridView1.Rows.Add();

                                }
                                for (int i = 0; i < (totalRow); i++)
                                {
                                    if (IncrementIllness != amountOfIllness)
                                    {
                                        using (SqliteCommand cmd = new SqliteCommand(selectIllness, conn))
                                        {
                                            cmd.Parameters.AddWithValue("@uID", uID);
                                            cmd.Parameters.AddWithValue("@i", IncrementingIllness);
                                            var illness = cmd.ExecuteScalar().ToString();
                                            dataGridView1.Rows[i].Cells[1].Value = illness;
                                            dataGridView1.Rows[i].Cells[0].Value = "Illness";
                                            IncrementIllness = IncrementIllness + 1;
                                            IncrementingIllness = IncrementingIllness + 1;

                                        }
                                    }
                                    else if (IncrementIllness == amountOfIllness && AllergyCheck == false)
                                    {
                                        IncrementingIllness = 1;
                                        IncrementAllergy = 0;
                                        AllergyCheck = true;
                                    }
                                    if (AllergyCheck == true)
                                    {
                                        if (IncrementAllergy != amountOfAllergy)
                                        {
                                            using (SqliteCommand ALLERGY = new SqliteCommand(selectAllergy, conn))
                                            {
                                                ALLERGY.Parameters.AddWithValue("@uID", uID);
                                                ALLERGY.Parameters.AddWithValue("@i", IncrementingIllness);
                                                var allergy = ALLERGY.ExecuteScalar().ToString();
                                                dataGridView1.Rows[i].Cells[1].Value = allergy;
                                                dataGridView1.Rows[i].Cells[0].Value = "Allergy";
                                                IncrementAllergy = IncrementAllergy + 1;
                                                IncrementingIllness = IncrementingIllness + 1;



                                            }
                                        }
                                        else if (IncrementAllergy == amountOfAllergy && InjuryCheck == false)
                                        {

                                            IncrementingIllness = 1;
                                            IncrementInjury = 0;
                                            InjuryCheck = true;
                                        }
                                    }
                                    if (InjuryCheck == true)
                                    {
                                        if (IncrementInjury != amountOfInjury)
                                        {
                                            using (SqliteCommand INJURY = new SqliteCommand(selectInjury, conn))
                                            {
                                                INJURY.Parameters.AddWithValue("@uID", uID);
                                                INJURY.Parameters.AddWithValue("@i", IncrementingIllness);
                                                var injury = INJURY.ExecuteScalar().ToString();
                                                dataGridView1.Rows[i].Cells[1].Value = injury;
                                                dataGridView1.Rows[i].Cells[0].Value = "Injury";
                                                IncrementInjury = IncrementInjury + 1;
                                                IncrementingIllness = IncrementingIllness + 1;

                                            }
                                        }



                                    }





                                }

                            }




                        }
                    }
                }

            }
            using (SqliteConnection conn = new SqliteConnection(connectionString))
            {
                conn.Open();
                using (SqliteCommand cmd = new SqliteCommand("PRAGMA foreign_keys = ON;", conn))
                {
                    cmd.ExecuteNonQuery();
                }
                string doctorName = @"SELECT * from doctor FULL JOIN appointment ON doctor.doctorID = appointment.doctorID LEFT JOIN patient ON appointment.patientID = patient.patientID WHERE patient.patientID = @uID";
                using (SqliteCommand cmd = new SqliteCommand(doctorName, conn))
                {
                    cmd.Parameters.AddWithValue("@uID", uID);
                    using (SqliteDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            int rowIndex = dataGridView2.Rows.Add();
                            dataGridView2.Rows[rowIndex].Cells[1].Value = dr["firstName"];
                            dataGridView2.Rows[rowIndex].Cells[0].Value = dr["date"];
                        }
                    }
                }

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2(userTag, uID);
            form2.ShowDialog();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2(userTag, uID);
            form2.ShowDialog();
            this.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
