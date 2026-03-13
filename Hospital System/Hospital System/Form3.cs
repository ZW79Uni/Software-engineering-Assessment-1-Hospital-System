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
using System.DirectoryServices.ActiveDirectory;

namespace Hospital_System
{
    public partial class Form3 : Form //doctor booking and time viewing form
    {
        int uID;
        string userTag;

        string connectionString = @"Data Source=Hospital Database System.db;Version=3;"; //Connects the program to the SQLite database
        int indexMonth = DateTime.Today.Month;
        int indexYear = DateTime.Today.Year;
        string[] days = { "Monday", "Teusday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        public Form3(string userName, int ID)
        { //BUG HERE: The functions when ran are supposed to show the the days of the week in the top cells but instead show on the bottom, when the next button is clicked this is fixed but need to figure out why its happening on start up
            InitializeComponent();
            populateDoctorDropDown();
            doctorAppoitmentStructure();
            populateAppoitmentDates(indexMonth, indexYear); //all these functions set up all the different elements of the form

            uID = ID;
            userTag = userName;
        }
        void populateAppoitmentDates(int indexM, int indexY) //creates the dates within the calender system
        {
            int daysInCurrentMonth = DateTime.DaysInMonth(indexY, indexM);
            DateTime firstDayOfMonth = new DateTime(indexY, indexM, 1);
            int firstDayOfWeek = (int)firstDayOfMonth.DayOfWeek; //these varribles gather the amount of days in a month

            int day = 1;

            for (int row = 1; row < datePicker.Rows.Count; row++) //Loop through equal to the number of rows
            {
                for (int col = 0; col < 7; col++) // Move to the next row after 7 days
                {
                    if (row == 1 && col >= firstDayOfWeek)
                    {
                        DateTime currentDate = new DateTime(indexY, indexM, day);
                        datePicker.Rows[row].Cells[col].Value = day + "/" + indexM + "/" + indexY;

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
                        datePicker.Rows[row].Cells[col].Value = day + "/" + indexM + "/" + indexY;

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
        }
        void doctorAppoitmentStructure() //Creates the structure of the calender system
        {
            for (int i = 0; i < 7; i++)
            {
                datePicker.Columns.Add("col" + i, "");
            }
            for (int i = 0; i < 7; i++)
            {
                datePicker.Rows[0].Cells[i].Value = days[i];
            }
            for (int i = 0; i < 6; i++)
            {
                datePicker.Rows.Add();
            }
        }
        void populateDoctorDropDown() //Adds the doctors from the database to the drop down menu
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string getDoctors = "SELECT doctorID, firstName, lastName FROM doctor";

                using (SQLiteCommand cmd = new SQLiteCommand(getDoctors, conn))
                {
                    using (SQLiteDataReader dr = cmd.ExecuteReader())
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

        void populateTimeDropDown(int doctorID, DateTime selectedDate) //Adds the times to the drop down menu
        { //THIS CURRENTLY BUGGED AND NEEDS TO BE FIXED: The drop down lets you select booked times eg you can select 20th of march 10:30pm 
            int hour = 9;
            int min = 00;
            timeDropDown.Items.Clear();
            for (int i = 1; i < 18; i++)
            {
                if (i % 2 == 0)
                {
                    string time = Convert.ToString(hour) + ":" + Convert.ToString(min);
                    timeDropDown.Items.Add(time);
                    hour++;
                    min = 00;
                }
                else
                {
                    string time = Convert.ToString(hour) + ":" + Convert.ToString(min) + "0";
                    timeDropDown.Items.Add(time);
                    min = 30;
                }
            }
        }

        private void datePicker_CellContentClick(object sender, DataGridViewCellEventArgs e) //click to pick a date
        {
            if (datePicker.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor != Color.Gray) //you can click on any cell that doesnt have the style grey
            {
                timeDropDown.Enabled = true; //enables time drop down

                string selectedDateString = datePicker.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                DateTime selectedDate = DateTime.Parse(selectedDateString);

                populateTimeDropDown(doctorDropDown.SelectedIndex, selectedDate);
            }
            else //Locks the time drop down so you cannot pick a time before a date
            {
                timeDropDown.Enabled = false;
            }
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

            doctorAppoitmentStructure();
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


            using (SQLiteConnection conn = new SQLiteConnection(connectionString)) //insert query
            {
                conn.Open();
                string insertQuery = "INSERT INTO appointment (patientID, doctorID, date, time, appointmentNote) VALUES (@patientID, @doctorID, @date, @time, @note)";

                using (SQLiteCommand cmd = new SQLiteCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@patientID", patientID);
                    cmd.Parameters.AddWithValue("@doctorID", doctorID);
                    cmd.Parameters.AddWithValue("@date", selectedDate);
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
            Form2 form2 = new Form2(userTag, uID);
            form2.ShowDialog();
            this.Close();
        }
    }
}
