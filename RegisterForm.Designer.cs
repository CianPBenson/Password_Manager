namespace Password_Manager
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtConfirm = new TextBox();
            label4 = new Label();
            txtEmail = new TextBox();
            btnSubmit = new Button();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(298, 122);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(203, 27);
            txtUsername.TabIndex = 0;
            txtUsername.Text = "Username";
            txtUsername.Click += txtUsername_Click;
            txtUsername.TextChanged += textBox1_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(298, 209);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(203, 27);
            txtPassword.TabIndex = 1;
            txtPassword.Text = "Password";
            txtPassword.Click += txtPassword_Click;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // txtConfirm
            // 
            txtConfirm.Location = new Point(298, 254);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.Size = new Size(203, 27);
            txtConfirm.TabIndex = 2;
            txtConfirm.Text = "Confirm Password";
            txtConfirm.Click += txtConfirm_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 27F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(301, 19);
            label4.Name = "label4";
            label4.Size = new Size(200, 61);
            label4.TabIndex = 6;
            label4.Text = "Register";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(298, 164);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(203, 27);
            txtEmail.TabIndex = 7;
            txtEmail.Text = "Email";
            txtEmail.Click += txtEmail_Click;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(298, 328);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(203, 47);
            btnSubmit.TabIndex = 9;
            btnSubmit.Text = "Submit";
            btnSubmit.TextImageRelation = TextImageRelation.TextAboveImage;
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSubmit);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(txtConfirm);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RegisterForm";
            Text = "Register";
            Load += RegisterForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtConfirm;
        private Label label4;
        private TextBox txtEmail;
        private Button btnSubmit;
    }
}