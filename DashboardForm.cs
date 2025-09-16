<<<<<<< HEAD
﻿using StarLib;
using System;
=======
﻿using System;
>>>>>>> 2be342d865c5d17aaab434381559123833612930
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

<<<<<<< HEAD
//Cian, Arman, Pedro
namespace Password_Manager
{
    public partial class DashboardForm : Form
    { //Cian
        private StarField starField = new StarField();
        private System.Windows.Forms.Timer timer;
        private Point mousePos;

        private string loggedInUsername;

        public DashboardForm(string username)
        { //Arman
            InitializeComponent();
            loggedInUsername = username;
            lblWelcome.Text = $"Hello {username}, welcome to your password manager!";

            //Cian
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
        {   //Cian
            base.OnPaint(e);
            starField.Draw(e.Graphics);
        }
        
        private void DashboardForm_Load(object sender, EventArgs e)
        {//Arman
=======
namespace Password_Manager
{
    public partial class DashboardForm : Form
    {
        private string loggedInUsername;
        public DashboardForm(string username)
        {
            InitializeComponent();
            loggedInUsername = username;
            lblWelcome.Text = $"Hello {username}, welcome to your password manager!";
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
>>>>>>> 2be342d865c5d17aaab434381559123833612930
            LoadUserPasswords();
        }

        private void btnSavePassword_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            //Pedro
            isEditingPassword = false;


            //Arman
=======
>>>>>>> 2be342d865c5d17aaab434381559123833612930
            string website = txtWebsite.Text.Trim();
            string password = txtWebsitePassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(website) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both website and password.");
                return;
            }


            string filePath = $"C:\\Temp\\{loggedInUsername}_passwords.txt";

            Directory.CreateDirectory("C:\\Temp");

            string entry = $"{website},{password}";

            File.AppendAllText(filePath, entry + Environment.NewLine);

            MessageBox.Show("Password saved!");
            txtWebsite.Clear();
            txtWebsitePassword.Clear();
<<<<<<< HEAD

            LoadUserPasswords();
            lvPasswords.Refresh();
        }

        private void LoadUserPasswords()
        {//Cian
            string filePath = $"C:\\Temp\\{loggedInUsername}_passwords.txt";

            lvPasswords.Items.Clear();

            if (!File.Exists(filePath))
            {
                return; 
=======
        }

        private void LoadUserPasswords()
        {
            string filePath = $"C:\\Temp\\{loggedInUsername}_passwords.txt";

            lvPasswords.Items.Clear(); // Clear existing items

            if (!File.Exists(filePath))
            {
                return; // No passwords saved yet
>>>>>>> 2be342d865c5d17aaab434381559123833612930
            }

            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if (parts.Length == 2)
                {
                    string website = parts[0].Trim();
                    string password = parts[1].Trim();

                    ListViewItem item = new ListViewItem(website);
                    item.SubItems.Add(password);

                    lvPasswords.Items.Add(item);
                }
            }
        }

        private void btnTogglePasswords_Click(object sender, EventArgs e)
<<<<<<< HEAD
        { //Arman
=======
        {
>>>>>>> 2be342d865c5d17aaab434381559123833612930

            lvPasswords.Visible = !lvPasswords.Visible;

            if (lvPasswords.Visible)
            {
                LoadUserPasswords();
                btnTogglePasswords.Text = "Hide Passwords";
            }
            else
            {
                btnTogglePasswords.Text = "See All Passwords";
            }
        }

<<<<<<< HEAD
        //Pedro
        private bool isEditingPassword = false;

        private void btnEditPassword_Click(object sender, EventArgs e)
        {
            if (isEditingPassword)
            {
                MessageBox.Show("A password is already being edited. Please finish editing before selecting another.");
                return; 
            }

            if (lvPasswords.SelectedItems.Count > 0)
            {
                
                isEditingPassword = true;

                ListViewItem selectedItem = lvPasswords.SelectedItems[0];
                string website = selectedItem.Text;
                string password = selectedItem.SubItems[1].Text;

                txtWebsite.Text = website;
                txtWebsitePassword.Text = password;

                lvPasswords.Items.Remove(selectedItem);

                string filePath = $"C:\\Temp\\{loggedInUsername}_passwords.txt";

                if (!File.Exists(filePath))
                {
                    MessageBox.Show("Password file not found!");
                    return;
                }

                string[] lines = File.ReadAllLines(filePath);
                List<string> updatedLines = new List<string>();

                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 2 && parts[0].Trim() != website) 
                    {
                        updatedLines.Add(line);
                    }
                }

                File.WriteAllLines(filePath, updatedLines);

                MessageBox.Show("Password removed from the list and file.");
=======
        private void btnEditPassword_Click(object sender, EventArgs e)
        {
            if (lvPasswords.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvPasswords.SelectedItems[0];
                string website = selectedItem.Text;
                string password = selectedItem.SubItems[1].Text;
                txtWebsite.Text = website;
                txtWebsitePassword.Text = password;
                // Optionally, you can remove the selected item from the list
                lvPasswords.Items.Remove(selectedItem);
>>>>>>> 2be342d865c5d17aaab434381559123833612930
            }
            else
            {
                MessageBox.Show("Please select a password to edit.");
            }
        }

        private void btnDeletePassword_Click(object sender, EventArgs e)
<<<<<<< HEAD
        { //Pedro
=======
        {
>>>>>>> 2be342d865c5d17aaab434381559123833612930
            if (lvPasswords.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvPasswords.SelectedItems[0];
                string website = selectedItem.Text;
                string filePath = $"C:\\Temp\\{loggedInUsername}_passwords.txt";
                string[] lines = File.ReadAllLines(filePath);
                List<string> updatedLines = new List<string>(lines);
                updatedLines.RemoveAll(line => line.StartsWith(website + ","));
                File.WriteAllLines(filePath, updatedLines);
                lvPasswords.Items.Remove(selectedItem);
                MessageBox.Show("Password deleted!");
            }
            else
            {
                MessageBox.Show("Please select a password to delete.");
            }
        }

        private void btnGeneratePassword_Click(object sender, EventArgs e)
<<<<<<< HEAD
        { //Pedro
            txtWebsitePassword.Text = GenerateRandomPassword();
        }
        private string GenerateRandomPassword()
        { //Pedro
=======
        {
            txtWebsitePassword.Text = GenerateRandomPassword();
        }
        private string GenerateRandomPassword()
        {
>>>>>>> 2be342d865c5d17aaab434381559123833612930
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_-+=[]{}|;:,.<>?";
            Random random = new Random();
            char[] passwordChars = new char[12]; // Length of the password
            for (int i = 0; i < passwordChars.Length; i++)
            {
                passwordChars[i] = chars[random.Next(chars.Length)];
            }
            return new string(passwordChars);
        }

        private void btnBulkDeletePasswords_Click(object sender, EventArgs e)
<<<<<<< HEAD
        {// Pedro
=======
        {
>>>>>>> 2be342d865c5d17aaab434381559123833612930
            if (lvPasswords.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select passwords to delete.");
                return;
            }

            string filePath = Path.Combine("C:\\Temp", $"{loggedInUsername}_passwords.txt");

            try
            {
                if (!File.Exists(filePath))
                {
                    MessageBox.Show("Password file not found!");
                    return;
                }

<<<<<<< HEAD
=======
                // Get all selected websites first
>>>>>>> 2be342d865c5d17aaab434381559123833612930
                var websitesToDelete = new List<string>();
                foreach (ListViewItem item in lvPasswords.SelectedItems)
                {
                    websitesToDelete.Add(item.Text);
                }

<<<<<<< HEAD
=======
                // Read all lines from file
>>>>>>> 2be342d865c5d17aaab434381559123833612930
                var lines = File.ReadAllLines(filePath).ToList();
                int initialCount = lines.Count;

                // Remove all matching lines
                lines.RemoveAll(line => websitesToDelete.Any(website => line.StartsWith(website + ",")));

<<<<<<< HEAD
=======
                // Remove from ListView
>>>>>>> 2be342d865c5d17aaab434381559123833612930
                foreach (string website in websitesToDelete)
                {
                    foreach (ListViewItem item in lvPasswords.Items.Cast<ListViewItem>().Where(x => x.Text == website).ToList())
                    {
                        lvPasswords.Items.Remove(item);
                    }
                }

<<<<<<< HEAD
=======
                // Save changes if any
>>>>>>> 2be342d865c5d17aaab434381559123833612930
                if (initialCount != lines.Count)
                {
                    File.WriteAllLines(filePath, lines);
                    MessageBox.Show($"Deleted {initialCount - lines.Count} password(s) successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting passwords: {ex.Message}");
            }
        }

        private void btnSharePassword_Click(object sender, EventArgs e)
<<<<<<< HEAD
        { // Cian
=======
        {
>>>>>>> 2be342d865c5d17aaab434381559123833612930
            if (lvPasswords.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvPasswords.SelectedItems[0];
                string website = selectedItem.Text;
                string password = selectedItem.SubItems[1].Text;

<<<<<<< HEAD
                string recipientUsername = txtRecipientUsername.Text.Trim(); 

                if (string.IsNullOrWhiteSpace(recipientUsername))
                {
                    MessageBox.Show("Please enter a recipient username.");
                    return;
                }

                if (UserExists(recipientUsername))
                {
                    string recipientFilePath = $"C:\\Temp\\{recipientUsername}_passwords.txt";
                    string entry = $"{website},{password}";

                    File.AppendAllText(recipientFilePath, entry + Environment.NewLine);
                    MessageBox.Show($"Password shared successfully with {recipientUsername}!");

                }
                else
                {
                    MessageBox.Show("Recipient username not found.");
                }
=======
                string encryptedPassword = EncryptPassword(password);
                Clipboard.SetText($"Website: {website}\nPassword: {encryptedPassword}");

                MessageBox.Show("Password copied to clipboard with encryption!");
>>>>>>> 2be342d865c5d17aaab434381559123833612930
            }
            else
            {
                MessageBox.Show("Please select a password to share.");
            }
        }
<<<<<<< HEAD

        private bool UserExists(string username)
        { //Cian
            string userFilePath = @"C:\Temp\userPersistance.txt"; 

            if (!File.Exists(userFilePath))
            {
                return false;
            }

            string[] lines = File.ReadAllLines(userFilePath);
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if (parts.Length > 0 && parts[0].Trim() == username)
                {
                    return true;
                }
            }
            return false;
        }

        private void btnBackup_Click(object sender, EventArgs e)
        { // Arman
=======
        private string EncryptPassword(string password)
        {
            using (Aes aes = Aes.Create())
            {
                aes.GenerateKey();
                aes.GenerateIV();
                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter sw = new StreamWriter(cs))
                        {
                            sw.Write(password);
                        }
                    }

                    byte[] encrypted = ms.ToArray();
                    return Convert.ToBase64String(encrypted);
                }
            }
        }


        private void btnBackup_Click(object sender, EventArgs e)
        {
>>>>>>> 2be342d865c5d17aaab434381559123833612930
            string username = loggedInUsername;
            string userFile = $@"C:\Temp\{username}_passwords.txt";
            string backupFile = $@"C:\Temp\{username}_backup.txt";

            if (File.Exists(userFile))
            {
                File.Copy(userFile, backupFile, true);
                MessageBox.Show("Backup created successfully!");
            }
            else
            {
                MessageBox.Show("No password file found to backup.");
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
<<<<<<< HEAD
        { //Arman
=======
        {
>>>>>>> 2be342d865c5d17aaab434381559123833612930
            string username = loggedInUsername;
            string backupFile = $@"C:\Temp\{username}_backup.txt";
            string userFile = $@"C:\Temp\{username}_passwords.txt";

            if (File.Exists(backupFile))
            {
                File.Copy(backupFile, userFile, true);
                MessageBox.Show("Password file restored from backup!");
                LoadUserPasswords();
            }
            else
            {
                MessageBox.Show("No backup file found to restore.");
            }

        }

        private void btnExport_Click(object sender, EventArgs e)
<<<<<<< HEAD
        {//Arman
=======
        {
>>>>>>> 2be342d865c5d17aaab434381559123833612930
            string username = loggedInUsername;
            string exportPath = $@"C:\Temp\{username}_export.txt";

            try
            {
                using (StreamWriter writer = new StreamWriter(exportPath))
                {
                    foreach (ListViewItem item in lvPasswords.Items)
                    {
                        string website = item.SubItems[0].Text;
                        string password = item.SubItems[1].Text;

                        writer.WriteLine($"Website: {website}");
                        writer.WriteLine($"Password: {password}");
<<<<<<< HEAD

                        writer.WriteLine();

                        writer.WriteLine(); 

=======
<<<<<<< HEAD
                        writer.WriteLine();
=======
                        writer.WriteLine(); 
>>>>>>> aa6324302b48e1cb9fb552a2091333ee4b01857b
>>>>>>> 2be342d865c5d17aaab434381559123833612930
                    }
                }

                MessageBox.Show("Passwords exported successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting passwords: {ex.Message}");
            }
        }
<<<<<<< HEAD
        private void btnAccountDetails_Click(object sender, EventArgs e)
        { // Cian
            AccountForm accountForm = new AccountForm(loggedInUsername, this);
            accountForm.Show();
        }
=======

<<<<<<< HEAD
        private void btnAccountDetails_Click(object sender, EventArgs e)
        {
            AccountForm accountForm = new AccountForm(loggedInUsername, this);
            accountForm.Show();
        }
=======
>>>>>>> aa6324302b48e1cb9fb552a2091333ee4b01857b
>>>>>>> 2be342d865c5d17aaab434381559123833612930
    }
}

