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
    }
}
