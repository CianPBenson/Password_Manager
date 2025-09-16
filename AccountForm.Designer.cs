namespace Password_Manager
{
    partial class AccountForm
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
            btnDelete = new Button();
            label1 = new Label();
            label2 = new Label();
            txtUsername = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            btnEdit = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
<<<<<<< HEAD
            btnDelete.Location = new Point(211, 258);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(282, 40);
=======
            btnDelete.Location = new Point(251, 344);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(312, 54);
>>>>>>> 2be342d865c5d17aaab434381559123833612930
            btnDelete.TabIndex = 0;
            btnDelete.Text = "DELETE ACCOUNT";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDeleteAccount_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.8000011F, FontStyle.Bold);
            label1.ForeColor = Color.White;
<<<<<<< HEAD
            label1.Location = new Point(211, 42);
            label1.Name = "label1";
            label1.Size = new Size(288, 41);
=======
            label1.Location = new Point(228, 60);
            label1.Name = "label1";
            label1.Size = new Size(352, 50);
>>>>>>> 2be342d865c5d17aaab434381559123833612930
            label1.TabIndex = 1;
            label1.Text = "ACCOUNT DETAILS";
            // 
            // label2
            // 
            label2.AutoSize = true;
<<<<<<< HEAD
            label2.Location = new Point(396, 100);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
=======
            label2.Location = new Point(452, 133);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
>>>>>>> 2be342d865c5d17aaab434381559123833612930
            label2.TabIndex = 3;
            // 
            // txtUsername
            // 
<<<<<<< HEAD
            txtUsername.Location = new Point(292, 94);
            txtUsername.Margin = new Padding(3, 2, 3, 2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(201, 23);
=======
            txtUsername.Location = new Point(334, 126);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(229, 27);
>>>>>>> 2be342d865c5d17aaab434381559123833612930
            txtUsername.TabIndex = 4;
            txtUsername.Enter += txtUsername_Enter;
            txtUsername.Leave += txtUsername_Leave;
            // 
            // txtEmail
            // 
<<<<<<< HEAD
            txtEmail.Location = new Point(292, 129);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(201, 23);
=======
            txtEmail.Location = new Point(334, 172);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(229, 27);
>>>>>>> 2be342d865c5d17aaab434381559123833612930
            txtEmail.TabIndex = 5;
            txtEmail.Enter += txtEmail_Enter;
            txtEmail.Leave += txtEmail_Leave;
            // 
            // txtPassword
            // 
<<<<<<< HEAD
            txtPassword.Location = new Point(292, 162);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(201, 23);
=======
            txtPassword.Location = new Point(334, 216);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(229, 27);
>>>>>>> 2be342d865c5d17aaab434381559123833612930
            txtPassword.TabIndex = 6;
            txtPassword.Enter += txtPassword_Enter;
            txtPassword.Leave += txtPassword_Leave;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
<<<<<<< HEAD
            btnEdit.Location = new Point(211, 203);
            btnEdit.Margin = new Padding(3, 2, 3, 2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(282, 40);
=======
            btnEdit.Location = new Point(251, 271);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(312, 54);
>>>>>>> 2be342d865c5d17aaab434381559123833612930
            btnEdit.TabIndex = 7;
            btnEdit.Text = "EDIT ACCOUNT";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.ForeColor = Color.White;
<<<<<<< HEAD
            label3.Location = new Point(211, 95);
            label3.Name = "label3";
            label3.Size = new Size(80, 19);
=======
            label3.Location = new Point(237, 127);
            label3.Name = "label3";
            label3.Size = new Size(94, 23);
>>>>>>> 2be342d865c5d17aaab434381559123833612930
            label3.TabIndex = 8;
            label3.Text = "Username:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.ForeColor = Color.White;
<<<<<<< HEAD
            label4.Location = new Point(235, 130);
            label4.Name = "label4";
            label4.Size = new Size(49, 19);
=======
            label4.Location = new Point(269, 173);
            label4.Name = "label4";
            label4.Size = new Size(59, 23);
>>>>>>> 2be342d865c5d17aaab434381559123833612930
            label4.TabIndex = 9;
            label4.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.ForeColor = Color.White;
<<<<<<< HEAD
            label5.Location = new Point(211, 163);
            label5.Name = "label5";
            label5.Size = new Size(77, 19);
=======
            label5.Location = new Point(241, 217);
            label5.Name = "label5";
            label5.Size = new Size(90, 23);
>>>>>>> 2be342d865c5d17aaab434381559123833612930
            label5.TabIndex = 10;
            label5.Text = "Password:";
            // 
            // AccountForm
            // 
<<<<<<< HEAD
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(700, 356);
=======
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 475);
>>>>>>> 2be342d865c5d17aaab434381559123833612930
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnEdit);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDelete);
<<<<<<< HEAD
            Margin = new Padding(3, 2, 3, 2);
=======
>>>>>>> 2be342d865c5d17aaab434381559123833612930
            Name = "AccountForm";
            Text = "AccountForm";
            Load += AccountForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDelete;
        private Label label1;
        private Label label2;
        private TextBox txtUsername;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btnEdit;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}