using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Manager
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    control.Leave += TextBox_Leave;
                }
            }
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                switch (textBox.Name)
                {
                    case "txtUsername":
                        textBox.Text = "Username";
                        break;
                    case "txtEmail":
                        textBox.Text = "Email";
                        break;
                    case "txtPassword":
                        textBox.Text = "Password";
                        break;
                    case "txtConfirm":
                        textBox.Text = "Confirm Password";
                        break;
                    default:
                        break;
                }

            }
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Clear();
            }
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email")
            {
                txtEmail.Clear();
            }
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Clear();
            }
        }

        private void txtConfirm_Click(object sender, EventArgs e)
        {
            if (txtConfirm.Text == "Confirm Password")
            {
                txtConfirm.Clear();
            }
        }








        private void RegisterForm_Click(object sender, EventArgs e)
        {
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }












        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }





        List<User> userList = new List<User>();

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;

            string usernamePattern = @"^[a-zA-Z0-9_]{3,15}$";
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            string passwordPattern = @"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$";

            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Username cannot be empty!");
                return;
            }
            if (!Regex.IsMatch(username, usernamePattern))
            {
                MessageBox.Show("Invalid username! Must be 3-15 characters, letters, numbers, or underscores.");
                return;
            }
            if (string.IsNullOrWhiteSpace(email) || !Regex.IsMatch(email, emailPattern))
            {
                MessageBox.Show("Invalid email! Please enter a valid email address.");
                return;
            }
            if (string.IsNullOrWhiteSpace(password) || !Regex.IsMatch(password, passwordPattern))
            {
                MessageBox.Show("Invalid password! Must be at least 8 characters long and contain at least one letter and one number.");
                return;
            }

            UserPersistanceRead(username, email);

            if (txtUsername.Text != "Username")
            {
                User newUser = new User(username, email, password);
                userList.Add(newUser);

                UserPersistanceWrite(userList);

                MessageBox.Show("User registered successfully!");
            }
            else
            {
                return;
            }

        }

        public void UserPersistanceRead(string username, string email)
        {
            string filePath = "C:\\Temp\\userPersistance.txt";

            // Make sure the folder exists
            Directory.CreateDirectory("C:\\Temp");

            // If the file doesn't exist, just return (no existing users yet)
            if (!File.Exists(filePath))
                return;

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(',');
                    if (words.Length < 3) continue;

                    string usernameF = words[0].Trim();
                    string emailF = words[1].Trim();
                    string passwordF = words[2].Trim();

                    if (usernameF == username)
                    {
                        MessageBox.Show("Username Taken!");
                        txtUsername.Text = "Username";
                    }
                    if (emailF == email)
                    {
                        MessageBox.Show("Email already in use!");
                        txtEmail.Text = "Email";
                    }
                }
            }
        }


        private void UserPersistanceWrite(List<User> users)
        {
            try
            {
                string filePath = "C:\\Temp\\userPersistance.txt";  

                Directory.CreateDirectory("C:\\Temp");

                MessageBox.Show($"Saving to: {filePath}");

                using (StreamWriter writer = new StreamWriter(filePath, true)) 
                {
                    foreach (User user in users)
                    {
                        writer.WriteLine(user.ToString());
                    }
                }

                MessageBox.Show("User data saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error writing to file: {ex.Message}");
            }
        }


    }
}
