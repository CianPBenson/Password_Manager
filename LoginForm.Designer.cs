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
            SuspendLayout();
            // 
            // LblEmail
            // 
            LblEmail.AutoSize = true;
            LblEmail.BackColor = SystemColors.ButtonHighlight;
            LblEmail.Location = new Point(164, 130);
            LblEmail.Name = "LblEmail";
            LblEmail.Size = new Size(54, 25);
            LblEmail.TabIndex = 0;
            LblEmail.Text = "Email";
            // 
            // LblPassword
            // 
            LblPassword.AutoSize = true;
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
            txtEmail.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.ControlLight;
            txtPassword.Location = new Point(284, 216);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(150, 31);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
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
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(LblPassword);
            Controls.Add(LblEmail);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblEmail;
        private Label LblPassword;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btnLogin;
    }
}