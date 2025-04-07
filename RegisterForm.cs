using Microsoft.VisualBasic.ApplicationServices;
using StarLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Manager
{
    public partial class RegisterForm : Form
    {
        private StarField starField = new StarField();
        private System.Windows.Forms.Timer timer;
        private Point mousePos;
        List<User> userList = new List<User>();

        public RegisterForm()
        {
            InitializeComponent();

            this.DoubleBuffered = true;
            this.BackColor = Color.Black;

            this.MouseMove += (s, e) => mousePos = e.Location;
            this.Resize += (s, e) => starField.Initialize(this.ClientSize);

            starField.Initialize(this.ClientSize);

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 16;
            timer.Tick += (s, e) =>
            {
                starField.Update(mousePos, this.ClientSize);
                Invalidate();
            };
            timer.Start();

            txtPassword.Enter += txtPassword_Enter;
            txtPassword.Leave += txtPassword_Leave;
            txtConfirm.Enter += txtConfirm_Enter;
            txtConfirm.Leave += txtConfirm_Leave;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            starField.Draw(e.Graphics);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            CenterItems();
        }

        private void CenterItems()
        {
            int verticalSpacing = 20;
            int verticalOffset = 50;

            lblRegister.Location = new Point((this.ClientSize.Width - lblRegister.Width) / 2, 30 + verticalOffset);

            int startY = lblRegister.Bottom + verticalSpacing;
            int centerX = (this.ClientSize.Width - txtUsername.Width) / 2;

            txtUsername.Location = new Point(centerX, startY);
            txtEmail.Location = new Point(centerX, txtUsername.Bottom + verticalSpacing);
            txtPassword.Location = new Point(centerX, txtEmail.Bottom + verticalSpacing);
            txtConfirm.Location = new Point(centerX, txtPassword.Bottom + verticalSpacing);

            btnSubmit.Location = new Point((this.ClientSize.Width - btnSubmit.Width) / 2, txtConfirm.Bottom + verticalSpacing);
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            this.Resize += Form1_Resize;
            CenterItems();

            // Initial placeholders
            txtUsername.Text = "Username";
            txtEmail.Text = "Email";
            txtPassword.Text = "Password";
            txtConfirm.Text = "Confirm Password";

            txtPassword.PasswordChar = '\0';
            txtConfirm.PasswordChar = '\0';

            txtPassword.ForeColor = Color.Gray;
            txtConfirm.ForeColor = Color.Gray;

            txtUsername.ForeColor = Color.Gray;
            txtEmail.ForeColor = Color.Gray;

            txtUsername.Enter += txtUsername_Enter;
            txtUsername.Leave += txtUsername_Leave;

            txtEmail.Enter += txtEmail_Enter;
            txtEmail.Leave += txtEmail_Leave;
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                txtPassword.PasswordChar = '*';
                txtPassword.ForeColor = Color.Black;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPassword.PasswordChar = '\0';
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.Gray;
            }
        }

        private void txtConfirm_Enter(object sender, EventArgs e)
        {
            if (txtConfirm.Text == "Confirm Password")
            {
                txtConfirm.Text = "";
                txtConfirm.PasswordChar = '*';
                txtConfirm.ForeColor = Color.Black;
            }
        }

        private void txtConfirm_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtConfirm.Text))
            {
                txtConfirm.PasswordChar = '\0';
                txtConfirm.Text = "Confirm Password";
                txtConfirm.ForeColor = Color.Gray;
            }
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Gray;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                txtUsername.Text = "Username";
                txtUsername.ForeColor = Color.Gray;
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Gray;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                txtEmail.Text = "Email";
                txtEmail.ForeColor = Color.Gray;
            }
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;

            string usernamePattern = @"^[a-zA-Z0-9_]{3,15}$";
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            string passwordPattern = @"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$";

            if (username == "Username" || email == "Email" || password == "Password")
            {
                MessageBox.Show("Please fill out all fields.");
                return;
            }

            if (!Regex.IsMatch(username, usernamePattern))
            {
                MessageBox.Show("Invalid username! Must be 3-15 characters, letters, numbers, or underscores.");
                return;
            }
            if (!Regex.IsMatch(email, emailPattern))
            {
                MessageBox.Show("Invalid email! Please enter a valid email address.");
                return;
            }
            if (string.IsNullOrWhiteSpace(password) || !Regex.IsMatch(password, passwordPattern))
            {
                MessageBox.Show("Invalid password! Must be at least 8 characters long and contain at least one letter and one number.");
                return;
            }

            if (txtConfirm.Text != txtPassword.Text)
            {
                MessageBox.Show("Passwords do not match!");
                return;
            }

            if (UserPersistanceRead(username, email))
            {
                return;
            }

            User newUser = new User(username, email, password);
            userList.Add(newUser);
            UserPersistanceWrite(userList);
            MessageBox.Show("User registered successfully!");
        }

        public bool UserPersistanceRead(string username, string email)
        {
            string filePath = @"C:\Temp\userPersistance.txt";
            Directory.CreateDirectory(@"C:\Temp");

            if (!File.Exists(filePath)) return false;

            bool usernameTaken = false;
            bool emailTaken = false;

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(',');
                    string usernameF = words[0].Trim();
                    string emailF = words[1].Trim();

                    if (usernameF == username)
                    {
                        MessageBox.Show("Username Taken!");
                        txtUsername.Text = "Username";
                        usernameTaken = true;
                    }
                    if (emailF == email)
                    {
                        MessageBox.Show("Email already in use!");
                        txtEmail.Text = "Email";
                        emailTaken = true;
                    }
                }
            }

            return usernameTaken || emailTaken;
        }

        private void UserPersistanceWrite(List<User> users)
        {
            try
            {
                string filePath = @"C:\Temp\userPersistance.txt";
                Directory.CreateDirectory(@"C:\Temp");

                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    foreach (User user in users)
                    {
                        writer.WriteLine(user.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error writing to file: {ex.Message}");
            }
        }
    }
}
