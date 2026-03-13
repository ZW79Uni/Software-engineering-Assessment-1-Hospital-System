namespace Hospital_System
{
    partial class Form3
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
            doctorDropDown = new ComboBox();
            datePicker = new DataGridView();
            previousMonth = new Button();
            nextMonth = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            timeDropDown = new ComboBox();
            bookAppoitment = new Button();
            appointmentNoteTextBox = new TextBox();
            mainMenuButton = new Button();
            ((System.ComponentModel.ISupportInitialize)datePicker).BeginInit();
            SuspendLayout();
            // 
            // doctorDropDown
            // 
            doctorDropDown.FormattingEnabled = true;
            doctorDropDown.Location = new Point(27, 31);
            doctorDropDown.Name = "doctorDropDown";
            doctorDropDown.Size = new Size(121, 23);
            doctorDropDown.TabIndex = 0;
            doctorDropDown.SelectedIndexChanged += doctorDropDown_SelectedIndexChanged;
            // 
            // datePicker
            // 
            datePicker.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datePicker.Location = new Point(27, 60);
            datePicker.Name = "datePicker";
            datePicker.ScrollBars = ScrollBars.None;
            datePicker.Size = new Size(761, 321);
            datePicker.TabIndex = 1;
            datePicker.CellContentClick += datePicker_CellContentClick;
            // 
            // previousMonth
            // 
            previousMonth.Location = new Point(154, 31);
            previousMonth.Name = "previousMonth";
            previousMonth.Size = new Size(138, 23);
            previousMonth.TabIndex = 2;
            previousMonth.Text = "Previous Month";
            previousMonth.UseVisualStyleBackColor = true;
            previousMonth.Click += previousMonth_Click;
            // 
            // nextMonth
            // 
            nextMonth.Location = new Point(298, 31);
            nextMonth.Name = "nextMonth";
            nextMonth.Size = new Size(138, 23);
            nextMonth.TabIndex = 3;
            nextMonth.Text = "Next Month";
            nextMonth.UseVisualStyleBackColor = true;
            nextMonth.Click += nextMonth_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(27, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;
            textBox1.Text = "Choose A doctor!";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(442, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 5;
            textBox2.Text = "Choose a time!";
            // 
            // timeDropDown
            // 
            timeDropDown.FormattingEnabled = true;
            timeDropDown.Location = new Point(442, 31);
            timeDropDown.Name = "timeDropDown";
            timeDropDown.Size = new Size(121, 23);
            timeDropDown.TabIndex = 6;
            // 
            // bookAppoitment
            // 
            bookAppoitment.Location = new Point(660, 397);
            bookAppoitment.Name = "bookAppoitment";
            bookAppoitment.Size = new Size(97, 41);
            bookAppoitment.TabIndex = 7;
            bookAppoitment.Text = "Book Appointment";
            bookAppoitment.UseVisualStyleBackColor = true;
            bookAppoitment.Click += bookAppoitment_Click;
            // 
            // appointmentNoteTextBox
            // 
            appointmentNoteTextBox.Location = new Point(27, 387);
            appointmentNoteTextBox.Name = "appointmentNoteTextBox";
            appointmentNoteTextBox.Size = new Size(515, 23);
            appointmentNoteTextBox.TabIndex = 8;
            // 
            // mainMenuButton
            // 
            mainMenuButton.Location = new Point(629, 12);
            mainMenuButton.Name = "mainMenuButton";
            mainMenuButton.Size = new Size(159, 41);
            mainMenuButton.TabIndex = 9;
            mainMenuButton.Text = "Back to main menu";
            mainMenuButton.UseVisualStyleBackColor = true;
            mainMenuButton.Click += mainMenuButton_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mainMenuButton);
            Controls.Add(appointmentNoteTextBox);
            Controls.Add(bookAppoitment);
            Controls.Add(timeDropDown);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(nextMonth);
            Controls.Add(previousMonth);
            Controls.Add(datePicker);
            Controls.Add(doctorDropDown);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)datePicker).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox doctorDropDown;
        private DataGridView datePicker;
        private Button previousMonth;
        private Button nextMonth;
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox timeDropDown;
        private Button bookAppoitment;
        private TextBox appointmentNoteTextBox;
        private Button mainMenuButton;
    }
}