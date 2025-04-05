using System;
using System.Windows.Forms;

namespace StudentForm
{
    internal static class ProgramHelpers
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Student_Page());
        }
    }
}