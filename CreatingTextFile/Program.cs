using CreatingTextFile;
using System;
using System.Windows.Forms;

namespace LabStream
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Create all your forms
            FrmLab1 labForm = new FrmLab1();
            FrmFileName fileForm = new FrmFileName();
            FrmRegistration regForm = new FrmRegistration();

            // Show all forms at the same time
            labForm.Show();
            fileForm.Show();
            regForm.Show();

            // Keep the application running using one main form
            Application.Run(labForm);
        }
    }
}
