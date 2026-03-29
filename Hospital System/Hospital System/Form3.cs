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
using System.DirectoryServices.ActiveDirectory;
using System.Diagnostics;

namespace Hospital_System
{
    public partial class Form3 : Form //doctor booking and time viewing form
    {
        int uID;
        string userTag;

        string connectionString = @"Data Source=Hospital Database System_encrypted.db;Password=a3lKC467MQsD2d3F;"; //Connects the program to the SQLite database
        int indexMonth = DateTime.Today.Month;
        int indexYear = DateTime.Today.Year;
        string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        string selectedDate = string.Empty;
        public Form3(string userName, int ID)
        {
            InitializeComponent();
            populateDoctorDropDown();
            doctorAppoitmentStructure();
            populateAppoitmentDates(indexMonth, indexYear); //all these functions set up all the different elements of the form

            uID = ID;
            userTag = userName;

            button1.Enabled = false;
            timeDropDown.DropDownStyle = ComboBoxStyle.DropDownList;
            doctorDropDown.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        void populateAppoitmentDates(int indexM, int indexY) //creates the dates within the calender system
        {
            for (int i = 0; i < datePicker.Rows.Count; i++)
            {
                for (int j = 0; j < datePicker.Columns.Count; j++)
                {
                    datePicker.Rows[i].Cells[j].Value = null;
                    datePicker.Rows[i].Cells[j].Style.BackColor = Color.White;
                    datePicker.Rows[i].Cells[j].ReadOnly = false;
                }
            }

            int daysInCurrentMonth = DateTime.DaysInMonth(indexY, indexM);
            DateTime firstDayOfMonth = new DateTime(indexY, indexM, 1);
            int firstDayOfWeek = (int)firstDayOfMonth.DayOfWeek; //these varribles gather the amount of days in a month

            int day = 1;

            for (int row = 0; row < datePicker.Rows.Count; row++) //Loop through equal to the number of rows
            {
                for (int col = 0; col < 7; col++) // Move to the next row after 7 days
                {
                    if (row == 1 && col >= firstDayOfWeek)
                    {
                        DateTime currentDate = new DateTime(indexY, indexM, day);
                        datePicker.Rows[row].Cells[col].Value = day;

                        if (currentDate < DateTime.Today) //if the date has passed make the cell unable to be clicked and grey
                        {
                            datePicker.Rows[row].Cells[col].Style.BackColor = Color.Gray;
                            datePicker.Rows[row].Cells[col].ReadOnly = true;
                        }
                        else
                        {
                            datePicker.Rows[row].Cells[col].Style.BackColor = Color.White;
                            datePicker.Rows[row].Cells[col].ReadOnly = false;
                        }

                        day++;
                    }
                    else if (row > 1 && day <= daysInCurrentMonth)
                    {
                        DateTime currentDate = new DateTime(indexY, indexM, day);
                        datePicker.Rows[row].Cells[col].Value = day;

                        if (currentDate < DateTime.Today)
                        {
                            datePicker.Rows[row].Cells[col].Style.BackColor = Color.Gray;
                            datePicker.Rows[row].Cells[col].ReadOnly = true;
                        }
                        else
                        {
                            datePicker.Rows[row].Cells[col].Style.BackColor = Color.White;
                            datePicker.Rows[row].Cells[col].ReadOnly = false;
                        }

                        day++;
                    }
                }
            }
            datePicker.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datePicker.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            string[] months = { "January", "Febuary", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            monthYear.Text = months[indexMonth - 1] + " " + indexYear; 
        }
        void doctorAppoitmentStructure() //Creates the structure of the calender system
        {
            if (datePicker.Columns.Count == 0)
            {
                for (int i = 0; i < 7; i++)
                {
                    datePicker.Columns.Add("col" + i, days[i]);
                }
                for (int i = 0; i < datePicker.Columns.Count; i++)
                {
                    datePicker.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                }
                for (int i = 0; i < 6; i++)
                {
                    datePicker.Rows.Add();
                }
            }
        }
        void populateDoctorDropDown() //Adds the doctors from the database to the drop down menu
        {
            using (SqliteConnection conn = new SqliteConnection(connectionString))
            {
                conn.Open();

                string getDoctors = "SELECT doctorID, firstName, lastName FROM doctor";

                using (SqliteCommand cmd = new SqliteCommand(getDoctors, conn))
                {
                    using (SqliteDataReader dr = cmd.ExecuteReader())
                    {
                        doctorDropDown.Items.Clear();
                        while (dr.Read())
                        {
                            string doctorName = dr["firstName"].ToString() + " " + dr["lastName"].ToString();
                            doctorDropDown.Items.Add(doctorName);
                        }
                    }
                }
            }
        }

        void populateTimeDropDown() // Adds the times to the drop down menu
        {
            int hour = 9;
            int min = 0;
            timeDropDown.Items.Clear();

            using (SqliteConnection conn = new SqliteConnection(connectionString))
            {
                conn.Open();

                // Query to check the count of appointments for a specific doctor and date
                string checkTime = @"SELECT COUNT(*) FROM appointment WHERE doctorID = @dID AND date = @date AND time = @time";

                for (int i = 1; i < 18; i++)
                {
                    // Build the time slot for the loop
                    string timeSlot = $"{hour}:{min:D2}";

                    using (SqliteCommand cmd = new SqliteCommand(checkTime, conn))
                    {
                        // Add parameters for doctorID and date
                        cmd.Parameters.AddWithValue("@dID", doctorDropDown.SelectedIndex + 1);
                        cmd.Parameters.AddWithValue("@date", selectedDate);
                        cmd.Parameters.AddWithValue("@time", timeSlot);

                        // Execute the query and get the count of existing appointments at that time
                        int appointmentCount = Convert.ToInt32(cmd.ExecuteScalar());
                        

                        // If no appointments are found for this time, add it to the dropdown
                        if (appointmentCount == 0)
                        {
                            timeDropDown.Items.Add(timeSlot);
                        }
                    }

                    // Increment the time to the next slot (9:00, 9:30, 10:00, 10:30, etc.)
                    if (min == 0)
                    {
                        min = 30;
                    }
                    else
                    {
                        min = 0;
                        hour++;
                    }
                }
            }
        }

        private void datePicker_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore clicks outside valid rows/columns
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }

            var cell = datePicker.Rows[e.RowIndex].Cells[e.ColumnIndex];

            // Ignore clicks on empty cells
            if (cell.Value == null)
            {
                return;
            }
            // Ignore clicks on past dates (gray) or any invalid cells
            if (cell.Style.BackColor == Color.Gray)
            {
                timeDropDown.Enabled = false;
                return;
            }

            // Valid date selected
            timeDropDown.Enabled = true;
            selectedDate = datePicker.CurrentCell.Value + "/" + indexMonth + "/" + indexYear;
            populateTimeDropDown();
        }

        private void previousMonth_Click(object sender, EventArgs e) //when clicked shows the previous month
        {
            if (indexMonth == 1)
            {
                indexMonth = 12;
                indexYear--;
            }
            else
            {
                indexMonth--;
            }


            populateAppoitmentDates(indexMonth, indexYear);
        }

        private void nextMonth_Click(object sender, EventArgs e) //when clicked shows previous month
        {
            if (indexMonth == 12)
            {
                indexMonth = 1;
                indexYear++;
            }
            else
            {
                indexMonth++;
            }

            populateAppoitmentDates(indexMonth, indexYear);
        }

        private void doctorDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            datePicker.Enabled = doctorDropDown.SelectedItem != null; //locks the calender as long as there is no doctor selected.
        }

        private void bookAppoitment_Click(object sender, EventArgs e) //when clicked stores the appoitment in the database
        {
            if (doctorDropDown.SelectedItem == null) // validation for if certain fields have no entry to prevent error
            {
                MessageBox.Show("Please select a doctor.");
                return;
            }

            if (datePicker.CurrentCell == null || datePicker.CurrentCell.Value == null)
            {
                MessageBox.Show("Please select a date.");
                return;
            }

            if (timeDropDown.SelectedItem == null)
            {
                MessageBox.Show("Please select a time.");
                return;
            }

            int doctorID = doctorDropDown.SelectedIndex + 1; //grabs the doctor id
            string selectedDate = datePicker.CurrentCell.Value.ToString(); //gets the date
            string selectedTime = timeDropDown.SelectedItem.ToString(); //gets the time

            string appointmentNote = appointmentNoteTextBox.Text; //gets the appointment note


            int patientID = uID; //gets the patient ID (carried over from login form)


            using (SqliteConnection conn = new SqliteConnection(connectionString)) //insert query
            {
                conn.Open();
                string insertQuery = "INSERT INTO appointment (patientID, doctorID, date, time, appointmentNote) VALUES (@patientID, @doctorID, @date, @time, @note)";

                using (SqliteCommand cmd = new SqliteCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@patientID", patientID);
                    cmd.Parameters.AddWithValue("@doctorID", doctorID);
                    cmd.Parameters.AddWithValue("@date", selectedDate + "/" + indexMonth + "/" + indexYear);
                    cmd.Parameters.AddWithValue("@time", selectedTime);
                    cmd.Parameters.AddWithValue("@note", appointmentNote);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Appointment booked successfully!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error booking appointment: " + ex.Message);
                    }
                }
            }
        }

        private void mainMenuButton_Click(object sender, EventArgs e) //quit button to take you back to main menu
        {
            this.Hide();
            Form5 form5 = new Form5(userTag, uID);
            form5.ShowDialog();
            this.Close();
        }
    }
}
