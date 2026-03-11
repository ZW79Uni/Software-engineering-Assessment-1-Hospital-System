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
<<<<<<< Updated upstream
            allDisplay = new TextBox();
            writeTo = new TextBox();
            allButton = new Button();
            writeButtton = new Button();
            SuspendLayout();
            // 
            // allDisplay
            // 
            allDisplay.Location = new Point(118, 212);
            allDisplay.Name = "allDisplay";
            allDisplay.Size = new Size(100, 23);
            allDisplay.TabIndex = 0;
            // 
            // writeTo
            // 
            writeTo.Location = new Point(536, 212);
            writeTo.Name = "writeTo";
            writeTo.Size = new Size(100, 23);
            writeTo.TabIndex = 1;
            // 
            // allButton
            // 
            allButton.Location = new Point(143, 317);
            allButton.Name = "allButton";
            allButton.Size = new Size(75, 23);
            allButton.TabIndex = 2;
            allButton.Text = "button1";
            allButton.UseVisualStyleBackColor = true;
            allButton.Click += allButton_Click;
            // 
            // writeButtton
            // 
            writeButtton.Location = new Point(536, 317);
            writeButtton.Name = "writeButtton";
            writeButtton.Size = new Size(75, 23);
            writeButtton.TabIndex = 3;
            writeButtton.Text = "button2";
            writeButtton.UseVisualStyleBackColor = true;
            writeButtton.Click += writeButtton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(writeButtton);
            Controls.Add(allButton);
            Controls.Add(writeTo);
            Controls.Add(allDisplay);
            Name = "Form1";
=======
            UsernamePassword = new TextBox();
            LoginButton = new Button();
            PasswordTitle = new TextBox();
            UsernameTextBox = new RichTextBox();
            PasswordTextBox = new RichTextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            incorrectBox = new TextBox();
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
            LoginButton.Location = new Point(166, 225);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(85, 33);
            LoginButton.TabIndex = 1;
            LoginButton.Text = "LOGIN";
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
            incorrectBox.Location = new Point(108, 208);
            incorrectBox.Name = "incorrectBox";
            incorrectBox.ReadOnly = true;
            incorrectBox.Size = new Size(258, 16);
            incorrectBox.TabIndex = 7;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 278);
            Controls.Add(incorrectBox);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(PasswordTextBox);
            Controls.Add(UsernameTextBox);
            Controls.Add(PasswordTitle);
            Controls.Add(LoginButton);
            Controls.Add(UsernamePassword);
            Name = "Login";
>>>>>>> Stashed changes
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

<<<<<<< Updated upstream
        private TextBox allDisplay;
        private TextBox writeTo;
        private Button allButton;
        private Button writeButtton;
=======
        private TextBox UsernamePassword;
        private Button LoginButton;
        private TextBox PasswordTitle;
        private RichTextBox UsernameTextBox;
        private RichTextBox PasswordTextBox;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox incorrectBox;
>>>>>>> Stashed changes
    }
}
