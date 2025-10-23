using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CreatingTextFile
{
    public partial class FrmStudentRecord: Form
    {
        public FrmStudentRecord()
        {
            InitializeComponent();
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.InitialDirectory = @"C:\";
                openFileDialog1.Title = "Browse Text Files";
                openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    lvShowText.Items.Clear();
                    string path = openFileDialog1.FileName;

                    if (!File.Exists(path))
                        throw new FileNotFoundException("The selected file does not exist.");

                    using (StreamReader reader = new StreamReader(path))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            lvShowText.Items.Add(line);
                        }
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException ex)
            {
                MessageBox.Show("An I/O error occurred while reading the file.\n\nDetails: " + ex.Message, "I/O Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred.\n\nDetails: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnUpload_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully Uploaded!");
            lvShowText.Items.Clear();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            FrmRegistration registration = new FrmRegistration();
            registration.Show();
            this.Hide();
        }
    }
}
