using Hospital_System;
using System;
using System.Windows.Forms;

namespace Hospital_System
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
<<<<<<< Updated upstream
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
=======
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
>>>>>>> Stashed changes
        }
    }
}
