using System;
using System.Windows.Forms;

namespace StudentRecordsApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StudentForm.Student_Page()); // Assuming your main form is named StudentPage
        }
    }
}