﻿namespace Password_Manager
{
    partial class DashboardForm
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
            lblWelcome = new Label();
            txtWebsite = new TextBox();
            txtWebsitePassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnSavePassword = new Button();
            lvPasswords = new ListView();
            Website = new ColumnHeader();
            Password = new ColumnHeader();
            btnTogglePasswords = new Button();
            btnEditPassword = new Button();
            btnDeletePassword = new Button();
            btnGeneratePassword = new Button();
            btnBulkDeletePasswords = new Button();
            btnSharePassword = new Button();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.Location = new Point(237, 72);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(264, 55);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "label1";
            lblWelcome.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtWebsite
            // 
            txtWebsite.Location = new Point(223, 148);
            txtWebsite.Name = "txtWebsite";
            txtWebsite.Size = new Size(150, 31);
            txtWebsite.TabIndex = 1;
            // 
            // txtWebsitePassword
            // 
            txtWebsitePassword.Location = new Point(223, 233);
            txtWebsitePassword.Name = "txtWebsitePassword";
            txtWebsitePassword.Size = new Size(150, 31);
            txtWebsitePassword.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 151);
            label1.Name = "label1";
            label1.Size = new Size(75, 25);
            label1.TabIndex = 4;
            label1.Text = "Website";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 236);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // btnSavePassword
            // 
            btnSavePassword.Location = new Point(271, 288);
            btnSavePassword.Name = "btnSavePassword";
            btnSavePassword.Size = new Size(112, 34);
            btnSavePassword.TabIndex = 6;
            btnSavePassword.Text = "Save";
            btnSavePassword.UseVisualStyleBackColor = true;
            btnSavePassword.Click += btnSavePassword_Click;
            // 
            // lvPasswords
            // 
            lvPasswords.Columns.AddRange(new ColumnHeader[] { Website, Password });
            lvPasswords.FullRowSelect = true;
            lvPasswords.GridLines = true;
            lvPasswords.Location = new Point(636, 151);
            lvPasswords.Name = "lvPasswords";
            lvPasswords.Size = new Size(282, 206);
            lvPasswords.TabIndex = 7;
            lvPasswords.UseCompatibleStateImageBehavior = false;
            lvPasswords.View = View.Details;
            lvPasswords.Visible = false;
            // 
            // Website
            // 
            Website.Text = "Website";
            Website.Width = 150;
            // 
            // Password
            // 
            Password.Text = "Password";
            Password.Width = 150;
            // 
            // btnTogglePasswords
            // 
            btnTogglePasswords.Location = new Point(665, 93);
            btnTogglePasswords.Name = "btnTogglePasswords";
            btnTogglePasswords.Size = new Size(209, 34);
            btnTogglePasswords.TabIndex = 8;
            btnTogglePasswords.Text = "See all passwords";
            btnTogglePasswords.UseVisualStyleBackColor = true;
            btnTogglePasswords.Click += btnTogglePasswords_Click;
            // 
            // btnEditPassword
            // 
            btnEditPassword.Location = new Point(37, 288);
            btnEditPassword.Name = "btnEditPassword";
            btnEditPassword.Size = new Size(139, 34);
            btnEditPassword.TabIndex = 9;
            btnEditPassword.Text = "Edit Password";
            btnEditPassword.UseVisualStyleBackColor = true;
            btnEditPassword.Click += btnEditPassword_Click;
            // 
            // btnDeletePassword
            // 
            btnDeletePassword.Location = new Point(37, 328);
            btnDeletePassword.Name = "btnDeletePassword";
            btnDeletePassword.Size = new Size(139, 34);
            btnDeletePassword.TabIndex = 10;
            btnDeletePassword.Text = "Delete Password";
            btnDeletePassword.UseVisualStyleBackColor = true;
            btnDeletePassword.Click += btnDeletePassword_Click;
            // 
            // btnGeneratePassword
            // 
            btnGeneratePassword.Location = new Point(271, 328);
            btnGeneratePassword.Name = "btnGeneratePassword";
            btnGeneratePassword.Size = new Size(112, 34);
            btnGeneratePassword.TabIndex = 11;
            btnGeneratePassword.Text = "Generate Password";
            btnGeneratePassword.UseVisualStyleBackColor = true;
            btnGeneratePassword.Click += btnGeneratePassword_Click;
            // 
            // btnBulkDeletePasswords
            // 
            btnBulkDeletePasswords.Location = new Point(37, 368);
            btnBulkDeletePasswords.Name = "btnBulkDeletePasswords";
            btnBulkDeletePasswords.Size = new Size(139, 34);
            btnBulkDeletePasswords.TabIndex = 12;
            btnBulkDeletePasswords.Text = "Bulk Delete Passwords";
            btnBulkDeletePasswords.UseVisualStyleBackColor = true;
            btnBulkDeletePasswords.Click += btnBulkDeletePasswords_Click;
            // 
            // btnSharePassword
            // 
            btnSharePassword.Location = new Point(271, 368);
            btnSharePassword.Name = "btnSharePassword";
            btnSharePassword.Size = new Size(112, 34);
            btnSharePassword.TabIndex = 13;
            btnSharePassword.Text = "Share Password";
            btnSharePassword.UseVisualStyleBackColor = true;
            btnSharePassword.Click += btnSharePassword_Click;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1025, 450);
            Controls.Add(btnSharePassword);
            Controls.Add(btnBulkDeletePasswords);
            Controls.Add(btnGeneratePassword);
            Controls.Add(btnDeletePassword);
            Controls.Add(btnEditPassword);
            Controls.Add(btnTogglePasswords);
            Controls.Add(lvPasswords);
            Controls.Add(btnSavePassword);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtWebsitePassword);
            Controls.Add(txtWebsite);
            Controls.Add(lblWelcome);
            Name = "DashboardForm";
            Text = "DashboardForm";
            Load += DashboardForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private TextBox txtWebsite;
        private TextBox txtWebsitePassword;
        private Label label1;
        private Label label2;
        private Button btnSavePassword;
        private ListView lvPasswords;
        private ColumnHeader Website;
        private ColumnHeader Password;
        private Button btnTogglePasswords;
        private Button btnEditPassword;
        private Button btnDeletePassword;
        private Button btnGeneratePassword;
        private Button btnBulkDeletePasswords;
        private Button btnSharePassword;
    }
}