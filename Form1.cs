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

using StarLib;
using System.Reflection.Emit;

<<<<<<< HEAD
//Cian
namespace Password_Manager
{ 
=======
namespace Password_Manager
{
>>>>>>> 2be342d865c5d17aaab434381559123833612930
    public partial class Form1 : Form
    {
        private StarField starField = new StarField();
        private System.Windows.Forms.Timer timer;
        private Point mousePos;
        public Form1()
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
        private void Form1_Resize(object sender, EventArgs e)
        {
            CenterItems();
        }
        private void CenterItems()
        {
            int buttonSpacing = 60; 

            lblPasswordManager.Location = new Point(
                (this.ClientSize.Width - lblPasswordManager.Width) / 2,
                (this.ClientSize.Height / 2) - 50);

            int totalButtonsWidth = btnLogin.Width + buttonSpacing + btnRegister.Width;

            int startX = (this.ClientSize.Width - totalButtonsWidth) / 2;
            int y = (this.ClientSize.Height / 2) + 30;

            btnLogin.Location = new Point(startX, y);
            btnRegister.Location = new Point(startX + btnLogin.Width + buttonSpacing, y);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Resize += Form1_Resize;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            starField.Draw(e.Graphics);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {


            string charachterSet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_-+=[]{}|;:,.<>?/";

            string inputString = "Password Manager";

            Random random = new Random();

            char[] charArray = inputString.ToCharArray();

            int numberOfChanges = 4;

            for (int i = 0; i < numberOfChanges; i++)
            {
                int randomIndex = random.Next(0, charArray.Length);

                char randomChar = charachterSet[random.Next(charachterSet.Length)];

                charArray[randomIndex] = randomChar;
            }

            string alteredString = new string(charArray);

            lblPasswordManager.Text = alteredString;

        }

        private void lblPasswordManager_MouseHover(object sender, EventArgs e)
        {
            lblAnimation.Tick += Timer_Tick;
            lblAnimation.Interval = 160;
            lblAnimation.Start();
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
            lblAnimation.Stop();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
