namespace Hospital_System
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            UsernamePassword = new TextBox();
            LoginButton = new Button();
            PasswordTitle = new TextBox();
            UsernameTextBox = new RichTextBox();
            PasswordTextBox = new RichTextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            incorrectBox = new TextBox();
            textBox3 = new TextBox();
            idTextBox = new RichTextBox();
            textBox4 = new TextBox();
            DoctorLoginButton = new Button();
            SuspendLayout();
            // 
            // UsernamePassword
            // 
            UsernamePassword.Location = new Point(67, 150);
            UsernamePassword.Name = "UsernamePassword";
            UsernamePassword.ReadOnly = true;
            UsernamePassword.Size = new Size(62, 23);
            UsernamePassword.TabIndex = 0;
            UsernamePassword.Text = "Username:";
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(135, 224);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(85, 39);
            LoginButton.TabIndex = 1;
            LoginButton.Text = "PATIENT LOGIN";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // PasswordTitle
            // 
            PasswordTitle.Location = new Point(67, 179);
            PasswordTitle.Name = "PasswordTitle";
            PasswordTitle.ReadOnly = true;
            PasswordTitle.Size = new Size(62, 23);
            PasswordTitle.TabIndex = 2;
            PasswordTitle.Text = "Password:";
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.Location = new Point(135, 150);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(203, 23);
            UsernameTextBox.TabIndex = 3;
            UsernameTextBox.Text = "";
            UsernameTextBox.TextChanged += UsernameTextBox_TextChanged;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(135, 179);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(203, 23);
            PasswordTextBox.TabIndex = 4;
            PasswordTextBox.Text = "";
            PasswordTextBox.TextChanged += PasswordTextBox_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(67, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(314, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(67, 41);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(314, 23);
            textBox2.TabIndex = 6;
            // 
            // incorrectBox
            // 
            incorrectBox.BorderStyle = BorderStyle.None;
            incorrectBox.ForeColor = Color.Black;
            incorrectBox.Location = new Point(123, 208);
            incorrectBox.Name = "incorrectBox";
            incorrectBox.ReadOnly = true;
            incorrectBox.Size = new Size(258, 16);
            incorrectBox.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(67, 121);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(62, 23);
            textBox3.TabIndex = 8;
            textBox3.Text = " ID:";
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(135, 121);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(203, 23);
            idTextBox.TabIndex = 9;
            idTextBox.Text = "";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(12, 70);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(520, 23);
            textBox4.TabIndex = 10;
            textBox4.Text = "To devs we have a test user the log in is ID = 1 Usename = TS1! Password = password123!";
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // DoctorLoginButton
            // 
            DoctorLoginButton.Location = new Point(253, 224);
            DoctorLoginButton.Name = "DoctorLoginButton";
            DoctorLoginButton.Size = new Size(85, 39);
            DoctorLoginButton.TabIndex = 11;
            DoctorLoginButton.Text = "DOCTOR LOGIN";
            DoctorLoginButton.UseVisualStyleBackColor = true;
            DoctorLoginButton.Click += DoctorLoginButton_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CausesValidation = false;
            ClientSize = new Size(535, 278);
            Controls.Add(DoctorLoginButton);
            Controls.Add(textBox4);
            Controls.Add(idTextBox);
            Controls.Add(textBox3);
            Controls.Add(incorrectBox);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(PasswordTextBox);
            Controls.Add(UsernameTextBox);
            Controls.Add(PasswordTitle);
            Controls.Add(LoginButton);
            Controls.Add(UsernamePassword);
            Name = "Login";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox UsernamePassword;
        private Button LoginButton;
        private TextBox PasswordTitle;
        private RichTextBox UsernameTextBox;
        private RichTextBox PasswordTextBox;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox incorrectBox;
        private TextBox textBox3;
        private RichTextBox idTextBox;
        private TextBox textBox4;
        private Button DoctorLoginButton;
    }
}
