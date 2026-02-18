namespace Hospital_System
{
    partial class Form1
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
            crazyDatabaseInput = new Button();
            awesomeDatabaseOutput = new TextBox();
            crazyDatabaseSubmit = new Button();
            inputpasswordyo = new TextBox();
            SuspendLayout();
            // 
            // crazyDatabaseInput
            // 
            crazyDatabaseInput.Location = new Point(112, 310);
            crazyDatabaseInput.Name = "crazyDatabaseInput";
            crazyDatabaseInput.Size = new Size(75, 23);
            crazyDatabaseInput.TabIndex = 0;
            crazyDatabaseInput.Text = "button1";
            crazyDatabaseInput.UseVisualStyleBackColor = true;
            crazyDatabaseInput.Click += crazyDatabaseInput_Click;
            // 
            // awesomeDatabaseOutput
            // 
            awesomeDatabaseOutput.Location = new Point(31, 228);
            awesomeDatabaseOutput.Name = "awesomeDatabaseOutput";
            awesomeDatabaseOutput.Size = new Size(331, 23);
            awesomeDatabaseOutput.TabIndex = 1;
            awesomeDatabaseOutput.TextChanged += awesomeDatabaseOutput_TextChanged;
            // 
            // crazyDatabaseSubmit
            // 
            crazyDatabaseSubmit.Location = new Point(604, 310);
            crazyDatabaseSubmit.Name = "crazyDatabaseSubmit";
            crazyDatabaseSubmit.Size = new Size(75, 23);
            crazyDatabaseSubmit.TabIndex = 2;
            crazyDatabaseSubmit.Text = "button2";
            crazyDatabaseSubmit.UseVisualStyleBackColor = true;
            crazyDatabaseSubmit.Click += crazyDatabaseSubmit_Click;
            // 
            // inputpasswordyo
            // 
            inputpasswordyo.Location = new Point(451, 228);
            inputpasswordyo.Name = "inputpasswordyo";
            inputpasswordyo.Size = new Size(337, 23);
            inputpasswordyo.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(inputpasswordyo);
            Controls.Add(crazyDatabaseSubmit);
            Controls.Add(awesomeDatabaseOutput);
            Controls.Add(crazyDatabaseInput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button crazyDatabaseInput;
        private TextBox awesomeDatabaseOutput;
        private Button crazyDatabaseSubmit;
        private TextBox inputpasswordyo;
    }
}
