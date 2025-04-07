using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            LoadUserPasswords();
        }

        private void btnSavePassword_Click(object sender, EventArgs e)
        {
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
        }

        private void LoadUserPasswords()
        {
            string filePath = $"C:\\Temp\\{loggedInUsername}_passwords.txt";

            lvPasswords.Items.Clear(); // Clear existing items

            if (!File.Exists(filePath))
            {
                return; // No passwords saved yet
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
        {

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
            }
            else
            {
                MessageBox.Show("Please select a password to edit.");
            }
        }

        private void btnDeletePassword_Click(object sender, EventArgs e)
        {
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
        {
            txtWebsitePassword.Text = GenerateRandomPassword();
        }
        private string GenerateRandomPassword()
        {
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
        {
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

                // Get all selected websites first
                var websitesToDelete = new List<string>();
                foreach (ListViewItem item in lvPasswords.SelectedItems)
                {
                    websitesToDelete.Add(item.Text);
                }

                // Read all lines from file
                var lines = File.ReadAllLines(filePath).ToList();
                int initialCount = lines.Count;

                // Remove all matching lines
                lines.RemoveAll(line => websitesToDelete.Any(website => line.StartsWith(website + ",")));

                // Remove from ListView
                foreach (string website in websitesToDelete)
                {
                    foreach (ListViewItem item in lvPasswords.Items.Cast<ListViewItem>().Where(x => x.Text == website).ToList())
                    {
                        lvPasswords.Items.Remove(item);
                    }
                }

                // Save changes if any
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
        {
            if (lvPasswords.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvPasswords.SelectedItems[0];
                string website = selectedItem.Text;
                string password = selectedItem.SubItems[1].Text;

                string encryptedPassword = EncryptPassword(password);
                Clipboard.SetText($"Website: {website}\nPassword: {encryptedPassword}");

                MessageBox.Show("Password copied to clipboard with encryption!");
            }
            else
            {
                MessageBox.Show("Please select a password to share.");
            }
        }
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
        {
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
        {
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
                        writer.WriteLine();
                    }
                }

                MessageBox.Show("Passwords exported successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting passwords: {ex.Message}");
            }
        }

        private void btnAccountDetails_Click(object sender, EventArgs e)
        {
            AccountForm accountForm = new AccountForm(loggedInUsername, this);
            accountForm.Show();
        }
    }
}

