using System;
using System.IO;
using System.Windows.Forms;
namespace CreatingTextFile
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }
        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            string studentNo = txtStudentNo.Text;
            string lastName = txtLastName.Text;
            string firstName = txtFirstName.Text;
            string middleInitial = txtMI.Text;
            string program = cmbProgram.Text;
            string age = txtAge.Text;
            string gender = cmbGender.Text;
            string birthday = dtpBirthday.Text;
            string contactNo = txtContactNo.Text;

            string[] registrationInfo = {
                "Student Number: " + studentNo,
                "Last Name: " + lastName,
                "First Name: " + firstName,
                "M.I.: " + middleInitial,
                "Program: " + program,
                "Age: " + age,
                "Gender: " + gender,
                "Birthday: " + birthday,
                "Contact No.: " + contactNo
            };

            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filePath = Path.Combine(docPath, studentNo + ".txt");

            using (StreamWriter outputFile = new StreamWriter(filePath))
            {
                foreach (string info in registrationInfo)
                {
                    outputFile.WriteLine(info);
                }
            }

            MessageBox.Show("Registration text file created successfully!\nSaved as " + studentNo + ".txt",
                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            FrmStudentRecord record = new FrmStudentRecord();
            record.Show();
            this.Hide();
        }
    }
}

