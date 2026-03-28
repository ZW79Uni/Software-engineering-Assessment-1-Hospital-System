using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_System
{
    //this is the HOMEPAGE (and everything else)
    public partial class Form2 : Form
    {
        string userTag = string.Empty;
        int uID;
        public Form2(string userName, int ID) //pulls the username from the login for to display on here.
        {
            InitializeComponent();
            WelcomeTextBox.Text = "Welcome " + userName + "!"; // Edit text for the text box here
            userTag = userName;
            uID = ID;
        }

        private void timingFormButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3(userTag, uID);
            form3.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 form5 = new Form5(userTag, uID);
            form5.ShowDialog();
            this.Close();
        }
    }
}
