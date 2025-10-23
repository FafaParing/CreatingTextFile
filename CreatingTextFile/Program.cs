using CreatingTextFile;
using System;
using System.Windows.Forms;

namespace CreatingTextFile
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Create all your forms
            
            FrmRegistration regForm = new FrmRegistration();

            // Show all forms at the same time
            
            regForm.Show();

            // Keep the application running using one main form
            Application.Run(regForm);
        }
    }
}
