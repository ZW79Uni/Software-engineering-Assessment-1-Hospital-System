namespace Hospital_System
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            WelcomeTextBox = new RichTextBox();
            appointmentTable = new DataGridView();
            AppointmentDate = new DataGridViewTextBoxColumn();
            AppointmentPatient = new DataGridViewTextBoxColumn();
            AppointmentTime = new DataGridViewTextBoxColumn();
            AppointmentNote = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)appointmentTable).BeginInit();
            SuspendLayout();
            // 
            // WelcomeTextBox
            // 
            WelcomeTextBox.Location = new Point(70, 12);
            WelcomeTextBox.Name = "WelcomeTextBox";
            WelcomeTextBox.ReadOnly = true;
            WelcomeTextBox.Size = new Size(626, 81);
            WelcomeTextBox.TabIndex = 1;
            WelcomeTextBox.Text = "placeholder text - you should not be seeing this";
            WelcomeTextBox.TextChanged += WelcomeTextBox_TextChanged;
            // 
            // appointmentTable
            // 
            appointmentTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            appointmentTable.Columns.AddRange(new DataGridViewColumn[] { AppointmentDate, AppointmentPatient, AppointmentTime, AppointmentNote });
            appointmentTable.Location = new Point(70, 115);
            appointmentTable.Name = "appointmentTable";
            appointmentTable.ReadOnly = true;
            appointmentTable.Size = new Size(626, 280);
            appointmentTable.TabIndex = 2;
            appointmentTable.CellContentClick += appointmentTable_CellContentClick;
            // 
            // AppointmentDate
            // 
            AppointmentDate.HeaderText = "Date";
            AppointmentDate.Name = "AppointmentDate";
            AppointmentDate.ReadOnly = true;
            // 
            // AppointmentPatient
            // 
            AppointmentPatient.HeaderText = "Patient";
            AppointmentPatient.Name = "AppointmentPatient";
            AppointmentPatient.ReadOnly = true;
            // 
            // AppointmentTime
            // 
            AppointmentTime.HeaderText = "Time";
            AppointmentTime.Name = "AppointmentTime";
            AppointmentTime.ReadOnly = true;
            // 
            // AppointmentNote
            // 
            AppointmentNote.HeaderText = "Patient Notes";
            AppointmentNote.Name = "AppointmentNote";
            AppointmentNote.ReadOnly = true;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 94, 184);
            ClientSize = new Size(800, 450);
            Controls.Add(appointmentTable);
            Controls.Add(WelcomeTextBox);
            Name = "Form4";
            Text = "Hosptial System";
            ((System.ComponentModel.ISupportInitialize)appointmentTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox WelcomeTextBox;
        private DataGridView appointmentTable;
        private DataGridViewTextBoxColumn AppointmentDate;
        private DataGridViewTextBoxColumn AppointmentPatient;
        private DataGridViewTextBoxColumn AppointmentTime;
        private DataGridViewTextBoxColumn AppointmentNote;
    }
}