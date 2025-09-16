namespace Password_Manager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnLogin = new Button();
            lblPasswordManager = new Label();
            btnRegister = new Button();
            lblAnimation = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
<<<<<<< HEAD
            btnLogin.Location = new Point(228, 184);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 35);
=======
            btnLogin.Location = new Point(325, 306);
            btnLogin.Margin = new Padding(4, 4, 4, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(134, 59);
>>>>>>> 2be342d865c5d17aaab434381559123833612930
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblPasswordManager
            // 
            lblPasswordManager.AutoSize = true;
            lblPasswordManager.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPasswordManager.ForeColor = Color.White;
<<<<<<< HEAD
            lblPasswordManager.Location = new Point(188, 120);
            lblPasswordManager.Name = "lblPasswordManager";
            lblPasswordManager.Size = new Size(284, 41);
=======
            lblPasswordManager.Location = new Point(268, 200);
            lblPasswordManager.Margin = new Padding(4, 0, 4, 0);
            lblPasswordManager.Name = "lblPasswordManager";
            lblPasswordManager.Size = new Size(428, 61);
>>>>>>> 2be342d865c5d17aaab434381559123833612930
            lblPasswordManager.TabIndex = 2;
            lblPasswordManager.Text = "Password Manager";
            lblPasswordManager.MouseHover += lblPasswordManager_MouseHover;
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
<<<<<<< HEAD
            btnRegister.Location = new Point(351, 184);
            btnRegister.Margin = new Padding(3, 2, 3, 2);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(94, 35);
=======
            btnRegister.Location = new Point(501, 306);
            btnRegister.Margin = new Padding(4, 4, 4, 4);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(134, 59);
>>>>>>> 2be342d865c5d17aaab434381559123833612930
            btnRegister.TabIndex = 3;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // lblAnimation
            // 
            lblAnimation.Tick += Form1_Load;
            // 
            // Form1
            // 
<<<<<<< HEAD
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(694, 334);
=======
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(992, 556);
>>>>>>> 2be342d865c5d17aaab434381559123833612930
            Controls.Add(btnRegister);
            Controls.Add(lblPasswordManager);
            Controls.Add(btnLogin);
            Icon = (Icon)resources.GetObject("$this.Icon");
<<<<<<< HEAD
            Margin = new Padding(3, 2, 3, 2);
=======
            Margin = new Padding(4, 4, 4, 4);
>>>>>>> 2be342d865c5d17aaab434381559123833612930
            Name = "Form1";
            Text = "Password Manager";
            Load += Form1_Load;
            MouseHover += Form1_MouseHover;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Label lblPasswordManager;
        private Button btnRegister;
        private System.Windows.Forms.Timer lblAnimation;
    }
}
