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
            lblRegister = new Label();
            txtEmail = new TextBox();
            btnSubmit = new Button();
            SuspendLayout();
            // 
            // txtUsername
            // 
<<<<<<< HEAD
            txtUsername.Location = new Point(261, 92);
            txtUsername.Margin = new Padding(3, 2, 3, 2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(178, 23);
=======
            txtUsername.Location = new Point(298, 122);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(203, 27);
>>>>>>> 2be342d865c5d17aaab434381559123833612930
            txtUsername.TabIndex = 0;
            txtUsername.Text = "Username";
            // 
            // txtPassword
            // 
<<<<<<< HEAD
            txtPassword.Location = new Point(261, 157);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(178, 23);
=======
            txtPassword.Location = new Point(298, 209);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(203, 27);
>>>>>>> 2be342d865c5d17aaab434381559123833612930
            txtPassword.TabIndex = 1;
            txtPassword.Text = "Password";
            // 
            // txtConfirm
            // 
<<<<<<< HEAD
            txtConfirm.Location = new Point(261, 190);
            txtConfirm.Margin = new Padding(3, 2, 3, 2);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.Size = new Size(178, 23);
=======
            txtConfirm.Location = new Point(298, 254);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.Size = new Size(203, 27);
>>>>>>> 2be342d865c5d17aaab434381559123833612930
            txtConfirm.TabIndex = 2;
            txtConfirm.Text = "Confirm Password";
            // 
            // lblRegister
            // 
            lblRegister.AutoSize = true;
            lblRegister.Font = new Font("Segoe UI", 27F, FontStyle.Bold);
            lblRegister.ForeColor = Color.White;
<<<<<<< HEAD
            lblRegister.Location = new Point(263, 14);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(157, 48);
=======
            lblRegister.Location = new Point(301, 19);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(200, 61);
>>>>>>> 2be342d865c5d17aaab434381559123833612930
            lblRegister.TabIndex = 6;
            lblRegister.Text = "Register";
            // 
            // txtEmail
            // 
<<<<<<< HEAD
            txtEmail.Location = new Point(261, 123);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(178, 23);
=======
            txtEmail.Location = new Point(298, 164);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(203, 27);
>>>>>>> 2be342d865c5d17aaab434381559123833612930
            txtEmail.TabIndex = 7;
            txtEmail.Text = "Email";
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
<<<<<<< HEAD
            btnSubmit.Location = new Point(261, 246);
            btnSubmit.Margin = new Padding(3, 2, 3, 2);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(178, 35);
=======
            btnSubmit.Location = new Point(298, 328);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(203, 47);
>>>>>>> 2be342d865c5d17aaab434381559123833612930
            btnSubmit.TabIndex = 9;
            btnSubmit.Text = "Submit";
            btnSubmit.TextImageRelation = TextImageRelation.TextAboveImage;
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // RegisterForm
            // 
<<<<<<< HEAD
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(700, 417);
=======
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
>>>>>>> 2be342d865c5d17aaab434381559123833612930
            Controls.Add(btnSubmit);
            Controls.Add(txtEmail);
            Controls.Add(lblRegister);
            Controls.Add(txtConfirm);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Icon = (Icon)resources.GetObject("$this.Icon");
<<<<<<< HEAD
            Margin = new Padding(3, 2, 3, 2);
=======
>>>>>>> 2be342d865c5d17aaab434381559123833612930
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
        private Label lblRegister;
        private TextBox txtEmail;
        private Button btnSubmit;
    }
}