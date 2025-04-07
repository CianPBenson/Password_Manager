using StarLib;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Password_Manager
{
    public partial class AccountForm : Form
    {
        private StarField starField = new StarField();
        private System.Windows.Forms.Timer timer;
        private Point mousePos;

        private string loggedInUsername;
        private string userFile = @"C:\Temp\userPersistance.txt";
        private string originalUsername;
        private string originalEmail;
        private string originalPassword;
        private Form dashboardForm;

        public AccountForm(string username, Form dashboard)
        {
            InitializeComponent();
            loggedInUsername = username;
            dashboardForm = dashboard;

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
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            starField.Draw(e.Graphics);
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            LoadUserInfo();
        }

        private void LoadUserInfo()
        {
            if (!File.Exists(userFile)) return;

            var lines = File.ReadAllLines(userFile);
            foreach (var line in lines)
            {
                string[] parts = line.Split(',');
                if (parts.Length >= 3 && parts[0] == loggedInUsername)
                {
                    originalUsername = parts[0];
                    originalEmail = parts[1];
                    originalPassword = parts[2];

                    txtUsername.Text = originalUsername;
                    txtEmail.Text = originalEmail;
                    txtPassword.Text = originalPassword;
                    break;
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string newUsername = txtUsername.Text.Trim();
            string newEmail = txtEmail.Text.Trim();
            string newPassword = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(newUsername) || string.IsNullOrWhiteSpace(newEmail) || string.IsNullOrWhiteSpace(newPassword))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            var lines = File.ReadAllLines(userFile).ToList();
            for (int i = 0; i < lines.Count; i++)
            {
                var parts = lines[i].Split(',');
                if (parts[0] == loggedInUsername)
                {
                    lines[i] = $"{newUsername},{newEmail},{newPassword}";
                    loggedInUsername = newUsername;
                    break;
                }
            }

            File.WriteAllLines(userFile, lines);

            MessageBox.Show("Details updated.");
            LoadUserInfo();
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Are you sure you want to delete your account?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes) return;

            if (!File.Exists(userFile)) return;

            var lines = File.ReadAllLines(userFile).ToList();
            lines.RemoveAll(line => line.StartsWith(loggedInUsername + ","));
            File.WriteAllLines(userFile, lines);

            MessageBox.Show("Account deleted.");

            dashboardForm.Close();
            this.Close();
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == originalUsername)
            {
                txtUsername.Clear();
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == originalEmail)
            {
                txtEmail.Clear();
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == originalPassword)
            {
                txtPassword.Clear();
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                txtUsername.Text = originalUsername;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                txtEmail.Text = originalEmail;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPassword.Text = originalPassword;
            }
        }
    }
}
