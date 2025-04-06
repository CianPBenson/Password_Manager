using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Manager
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string enteredEmail = txtEmail.Text.Trim();
            string enteredPassword = txtPassword.Text;

            string filePath = "C:\\Temp\\userPersistance.txt"; 

            if (!File.Exists(filePath))
            {
                MessageBox.Show("No registered users found!");
                return;
            }

            bool loginSuccess = false;

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length < 3) continue;

                    string fileUsername = parts[0].Trim();
                    string fileEmail = parts[1].Trim();
                    string filePassword = parts[2].Trim();

                    if (fileEmail == enteredEmail && filePassword == enteredPassword)
                    {
                        loginSuccess = true;
                        break;
                    }
                }
            }

            if (loginSuccess)
            {
                MessageBox.Show("Login successful!");
                this.Hide(); 
            }
            else
            {
                MessageBox.Show("Invalid email or password.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
