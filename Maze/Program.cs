using System;
using System.Windows.Forms;

namespace Navigator
{
    static class Program
    {
        internal const int n = 8; 
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (n > 3 && n < 9) 
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Navigator());
            }
            else MessageBox.Show("Out of range", "Error");

            
        }
    }
}
