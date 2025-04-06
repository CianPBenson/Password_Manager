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
            btnLogin.Location = new Point(325, 306);
            btnLogin.Margin = new Padding(4, 4, 4, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(134, 59);
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
            lblPasswordManager.Location = new Point(268, 200);
            lblPasswordManager.Margin = new Padding(4, 0, 4, 0);
            lblPasswordManager.Name = "lblPasswordManager";
            lblPasswordManager.Size = new Size(428, 61);
            lblPasswordManager.TabIndex = 2;
            lblPasswordManager.Text = "Password Manager";
            lblPasswordManager.MouseHover += lblPasswordManager_MouseHover;
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(501, 306);
            btnRegister.Margin = new Padding(4, 4, 4, 4);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(134, 59);
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
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(992, 556);
            Controls.Add(btnRegister);
            Controls.Add(lblPasswordManager);
            Controls.Add(btnLogin);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 4, 4, 4);
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
