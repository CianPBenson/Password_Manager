namespace Password_Manager
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LblEmail = new Label();
            LblPassword = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
<<<<<<< HEAD
            label1 = new Label();
=======
>>>>>>> 2be342d865c5d17aaab434381559123833612930
            SuspendLayout();
            // 
            // LblEmail
            // 
            LblEmail.AutoSize = true;
<<<<<<< HEAD
            LblEmail.BackColor = SystemColors.ActiveCaptionText;
            LblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblEmail.ForeColor = Color.White;
            LblEmail.Location = new Point(278, 168);
            LblEmail.Margin = new Padding(2, 0, 2, 0);
            LblEmail.Name = "LblEmail";
            LblEmail.Size = new Size(57, 21);
            LblEmail.TabIndex = 0;
            LblEmail.Text = "Email:";
=======
            LblEmail.BackColor = SystemColors.ButtonHighlight;
            LblEmail.Location = new Point(164, 130);
            LblEmail.Name = "LblEmail";
            LblEmail.Size = new Size(54, 25);
            LblEmail.TabIndex = 0;
            LblEmail.Text = "Email";
>>>>>>> 2be342d865c5d17aaab434381559123833612930
            // 
            // LblPassword
            // 
            LblPassword.AutoSize = true;
<<<<<<< HEAD
            LblPassword.BackColor = SystemColors.ActiveCaptionText;
            LblPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblPassword.ForeColor = Color.White;
            LblPassword.Location = new Point(249, 209);
            LblPassword.Margin = new Padding(2, 0, 2, 0);
            LblPassword.Name = "LblPassword";
            LblPassword.Size = new Size(86, 21);
            LblPassword.TabIndex = 1;
            LblPassword.Text = "Password:";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.Location = new Point(339, 170);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(231, 23);
=======
            LblPassword.BackColor = SystemColors.ControlLight;
            LblPassword.Location = new Point(154, 216);
            LblPassword.Name = "LblPassword";
            LblPassword.Size = new Size(87, 25);
            LblPassword.TabIndex = 1;
            LblPassword.Text = "Password";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(284, 130);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(150, 31);
>>>>>>> 2be342d865c5d17aaab434381559123833612930
            txtEmail.TabIndex = 2;
            // 
            // txtPassword
            // 
<<<<<<< HEAD
            txtPassword.BackColor = Color.White;
            txtPassword.Location = new Point(339, 211);
            txtPassword.Margin = new Padding(2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(231, 23);
=======
            txtPassword.BackColor = SystemColors.ControlLight;
            txtPassword.Location = new Point(284, 216);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(150, 31);
>>>>>>> 2be342d865c5d17aaab434381559123833612930
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
<<<<<<< HEAD
            btnLogin.BackColor = Color.White;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(339, 266);
            btnLogin.Margin = new Padding(2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(231, 48);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 27F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(389, 103);
            label1.Name = "label1";
            label1.Size = new Size(114, 48);
            label1.TabIndex = 5;
            label1.Text = "Login";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(892, 473);
            Controls.Add(label1);
=======
            btnLogin.Location = new Point(274, 307);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(112, 34);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
>>>>>>> 2be342d865c5d17aaab434381559123833612930
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(LblPassword);
            Controls.Add(LblEmail);
<<<<<<< HEAD
            Margin = new Padding(2);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
=======
            Name = "LoginForm";
            Text = "LoginForm";
>>>>>>> 2be342d865c5d17aaab434381559123833612930
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblEmail;
        private Label LblPassword;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btnLogin;
<<<<<<< HEAD
        private Label label1;
=======
>>>>>>> 2be342d865c5d17aaab434381559123833612930
    }
}