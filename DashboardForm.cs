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
    }
}
