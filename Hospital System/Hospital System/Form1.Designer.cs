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
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox allDisplay;
        private TextBox writeTo;
        private Button allButton;
        private Button writeButtton;
    }
}
