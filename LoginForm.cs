using StarLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Arman
namespace Password_Manager
{ 
    public partial class LoginForm : Form
    {
        private StarField starField = new StarField();
        private System.Windows.Forms.Timer timer;
        private Point mousePos;

        public LoginForm()
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
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            starField.Draw(e.Graphics);
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
            string loggedInUsername = "";

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
                        loggedInUsername = fileUsername;
                        break;
                    }
                }
            }

            if (loginSuccess)
            {
                MessageBox.Show("Login successful!");
                DashboardForm dashboard = new DashboardForm(loggedInUsername);
                dashboard.Show();
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

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
