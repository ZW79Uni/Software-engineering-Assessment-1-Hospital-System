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
            mainMenuButton = new Button();
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            button1 = new Button();
            appointmentNoteTextBox = new RichTextBox();
            monthYear = new Label();
            ((System.ComponentModel.ISupportInitialize)datePicker).BeginInit();
            SuspendLayout();
            // 
            // doctorDropDown
            // 
            doctorDropDown.FormattingEnabled = true;
            doctorDropDown.Location = new Point(91, 97);
            doctorDropDown.Name = "doctorDropDown";
            doctorDropDown.Size = new Size(213, 23);
            doctorDropDown.TabIndex = 0;
            doctorDropDown.SelectedIndexChanged += doctorDropDown_SelectedIndexChanged;
            // 
            // datePicker
            // 
            datePicker.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datePicker.Location = new Point(383, 87);
            datePicker.Name = "datePicker";
            datePicker.ScrollBars = ScrollBars.None;
            datePicker.Size = new Size(405, 249);
            datePicker.TabIndex = 1;
            datePicker.CellContentClick += datePicker_CellContentClick;
            // 
            // previousMonth
            // 
            previousMonth.Location = new Point(401, 58);
            previousMonth.Name = "previousMonth";
            previousMonth.Size = new Size(127, 23);
            previousMonth.TabIndex = 2;
            previousMonth.Text = "Previous Month";
            previousMonth.UseVisualStyleBackColor = true;
            previousMonth.Click += previousMonth_Click;
            // 
            // nextMonth
            // 
            nextMonth.Location = new Point(650, 58);
            nextMonth.Name = "nextMonth";
            nextMonth.Size = new Size(126, 23);
            nextMonth.TabIndex = 3;
            nextMonth.Text = "Next Month";
            nextMonth.UseVisualStyleBackColor = true;
            nextMonth.Click += nextMonth_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(91, 68);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(213, 23);
            textBox1.TabIndex = 4;
            textBox1.Text = "Choose A doctor!";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(383, 339);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(405, 23);
            textBox2.TabIndex = 5;
            textBox2.Text = "Choose a time!";
            // 
            // timeDropDown
            // 
            timeDropDown.FormattingEnabled = true;
            timeDropDown.Location = new Point(383, 362);
            timeDropDown.Name = "timeDropDown";
            timeDropDown.Size = new Size(405, 23);
            timeDropDown.TabIndex = 6;
            // 
            // bookAppoitment
            // 
            bookAppoitment.BackColor = Color.FromArgb(118, 134, 146);
            bookAppoitment.FlatStyle = FlatStyle.Popup;
            bookAppoitment.Location = new Point(499, 397);
            bookAppoitment.Name = "bookAppoitment";
            bookAppoitment.Size = new Size(190, 41);
            bookAppoitment.TabIndex = 7;
            bookAppoitment.Text = "C O N F I R M";
            bookAppoitment.UseVisualStyleBackColor = false;
            bookAppoitment.Click += bookAppoitment_Click;
            // 
            // mainMenuButton
            // 
            mainMenuButton.Location = new Point(401, -2);
            mainMenuButton.Name = "mainMenuButton";
            mainMenuButton.Size = new Size(402, 27);
            mainMenuButton.TabIndex = 9;
            mainMenuButton.Text = "View Medical Records";
            mainMenuButton.UseVisualStyleBackColor = true;
            mainMenuButton.Click += mainMenuButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Location = new Point(126, 142);
            label1.Name = "label1";
            label1.Size = new Size(135, 15);
            label1.TabIndex = 10;
            label1.Text = "Reason for appointment";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(48, 47);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(304, 302);
            richTextBox1.TabIndex = 11;
            richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = Color.FromArgb(35, 31, 32);
            richTextBox2.BorderStyle = BorderStyle.None;
            richTextBox2.Location = new Point(383, 50);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(405, 335);
            richTextBox2.TabIndex = 12;
            richTextBox2.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(0, -2);
            button1.Name = "button1";
            button1.Size = new Size(404, 27);
            button1.TabIndex = 13;
            button1.Text = "Book an appointment";
            button1.UseVisualStyleBackColor = true;
            // 
            // appointmentNoteTextBox
            // 
            appointmentNoteTextBox.Location = new Point(91, 160);
            appointmentNoteTextBox.Name = "appointmentNoteTextBox";
            appointmentNoteTextBox.Size = new Size(213, 176);
            appointmentNoteTextBox.TabIndex = 14;
            appointmentNoteTextBox.Text = "";
            // 
            // monthYear
            // 
            monthYear.AutoSize = true;
            monthYear.BackColor = Color.White;
            monthYear.Location = new Point(554, 62);
            monthYear.Name = "monthYear";
            monthYear.Size = new Size(71, 15);
            monthYear.TabIndex = 15;
            monthYear.Text = "PlaceHolder";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 94, 184);
            ClientSize = new Size(800, 450);
            Controls.Add(monthYear);
            Controls.Add(appointmentNoteTextBox);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(mainMenuButton);
            Controls.Add(bookAppoitment);
            Controls.Add(timeDropDown);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(nextMonth);
            Controls.Add(previousMonth);
            Controls.Add(datePicker);
            Controls.Add(doctorDropDown);
            Controls.Add(richTextBox1);
            Controls.Add(richTextBox2);
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
        private Button mainMenuButton;
        private Label label1;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private Button button1;
        private RichTextBox appointmentNoteTextBox;
        private Label monthYear;
    }
}