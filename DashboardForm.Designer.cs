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
<<<<<<< HEAD
            btnDeletePassword = new Button();
            btnGeneratePassword = new Button();
            btnBulkDeletePasswords = new Button();
            btnSharePassword = new Button();
            btnBackup = new Button();
            btnRestore = new Button();
            btnExport = new Button();
            btnAccountDetails = new Button();
=======
btnDeletePassword = new Button();
btnGeneratePassword = new Button();
btnBulkDeletePasswords = new Button();
btnSharePassword = new Button();

btnBackup = new Button();
btnRestore = new Button();
btnExport = new Button();

>>>>>>> aa6324302b48e1cb9fb552a2091333ee4b01857b
            SuspendLayout();
            // 
            // lblWelcome
            // 
<<<<<<< HEAD
            lblWelcome.Location = new Point(190, 58);
            lblWelcome.Margin = new Padding(2, 0, 2, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(211, 44);
=======
            lblWelcome.Location = new Point(237, 72);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(264, 55);
>>>>>>> aa6324302b48e1cb9fb552a2091333ee4b01857b
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "label1";
            lblWelcome.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtWebsite
            // 
<<<<<<< HEAD
            txtWebsite.Location = new Point(178, 118);
            txtWebsite.Margin = new Padding(2, 2, 2, 2);
            txtWebsite.Name = "txtWebsite";
            txtWebsite.Size = new Size(121, 27);
=======
            txtWebsite.Location = new Point(223, 148);
            txtWebsite.Name = "txtWebsite";
            txtWebsite.Size = new Size(150, 31);
>>>>>>> aa6324302b48e1cb9fb552a2091333ee4b01857b
            txtWebsite.TabIndex = 1;
            // 
            // txtWebsitePassword
            // 
<<<<<<< HEAD
            txtWebsitePassword.Location = new Point(178, 186);
            txtWebsitePassword.Margin = new Padding(2, 2, 2, 2);
            txtWebsitePassword.Name = "txtWebsitePassword";
            txtWebsitePassword.Size = new Size(121, 27);
=======
            txtWebsitePassword.Location = new Point(223, 233);
            txtWebsitePassword.Name = "txtWebsitePassword";
            txtWebsitePassword.Size = new Size(150, 31);
>>>>>>> aa6324302b48e1cb9fb552a2091333ee4b01857b
            txtWebsitePassword.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
<<<<<<< HEAD
            label1.Location = new Point(64, 121);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
=======
            label1.Location = new Point(80, 151);
            label1.Name = "label1";
            label1.Size = new Size(75, 25);
>>>>>>> aa6324302b48e1cb9fb552a2091333ee4b01857b
            label1.TabIndex = 4;
            label1.Text = "Website";
            // 
            // label2
            // 
            label2.AutoSize = true;
<<<<<<< HEAD
            label2.Location = new Point(64, 189);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
=======
            label2.Location = new Point(80, 236);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
>>>>>>> aa6324302b48e1cb9fb552a2091333ee4b01857b
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // btnSavePassword
            // 
<<<<<<< HEAD
            btnSavePassword.Location = new Point(217, 230);
            btnSavePassword.Margin = new Padding(2, 2, 2, 2);
            btnSavePassword.Name = "btnSavePassword";
            btnSavePassword.Size = new Size(90, 27);
=======
            btnSavePassword.Location = new Point(271, 288);
            btnSavePassword.Name = "btnSavePassword";
            btnSavePassword.Size = new Size(112, 34);
>>>>>>> aa6324302b48e1cb9fb552a2091333ee4b01857b
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
<<<<<<< HEAD
            lvPasswords.Location = new Point(509, 121);
            lvPasswords.Margin = new Padding(2, 2, 2, 2);
            lvPasswords.Name = "lvPasswords";
            lvPasswords.Size = new Size(226, 166);
=======
            lvPasswords.Location = new Point(636, 151);
            lvPasswords.Name = "lvPasswords";
            lvPasswords.Size = new Size(282, 206);
>>>>>>> aa6324302b48e1cb9fb552a2091333ee4b01857b
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
<<<<<<< HEAD
            btnTogglePasswords.Location = new Point(532, 74);
            btnTogglePasswords.Margin = new Padding(2, 2, 2, 2);
            btnTogglePasswords.Name = "btnTogglePasswords";
            btnTogglePasswords.Size = new Size(167, 27);
=======
            btnTogglePasswords.Location = new Point(665, 93);
            btnTogglePasswords.Name = "btnTogglePasswords";
            btnTogglePasswords.Size = new Size(209, 34);
>>>>>>> aa6324302b48e1cb9fb552a2091333ee4b01857b
            btnTogglePasswords.TabIndex = 8;
            btnTogglePasswords.Text = "See all passwords";
            btnTogglePasswords.UseVisualStyleBackColor = true;
            btnTogglePasswords.Click += btnTogglePasswords_Click;
            // 
<<<<<<< HEAD
            // btnEditPassword
            // 
            btnEditPassword.Location = new Point(30, 230);
            btnEditPassword.Margin = new Padding(2, 2, 2, 2);
            btnEditPassword.Name = "btnEditPassword";
            btnEditPassword.Size = new Size(111, 27);
            btnEditPassword.TabIndex = 9;
            btnEditPassword.Text = "Edit Password";
            btnEditPassword.UseVisualStyleBackColor = true;
            btnEditPassword.Click += btnEditPassword_Click;
            // 
            // btnDeletePassword
            // 
            btnDeletePassword.Location = new Point(30, 262);
            btnDeletePassword.Margin = new Padding(2, 2, 2, 2);
            btnDeletePassword.Name = "btnDeletePassword";
            btnDeletePassword.Size = new Size(111, 27);
            btnDeletePassword.TabIndex = 10;
            btnDeletePassword.Text = "Delete Password";
            btnDeletePassword.UseVisualStyleBackColor = true;
            btnDeletePassword.Click += btnDeletePassword_Click;
            // 
            // btnGeneratePassword
            // 
            btnGeneratePassword.Location = new Point(217, 262);
            btnGeneratePassword.Margin = new Padding(2, 2, 2, 2);
            btnGeneratePassword.Name = "btnGeneratePassword";
            btnGeneratePassword.Size = new Size(90, 27);
            btnGeneratePassword.TabIndex = 11;
            btnGeneratePassword.Text = "Generate Password";
            btnGeneratePassword.UseVisualStyleBackColor = true;
            btnGeneratePassword.Click += btnGeneratePassword_Click;
            // 
            // btnBulkDeletePasswords
            // 
            btnBulkDeletePasswords.Location = new Point(30, 294);
            btnBulkDeletePasswords.Margin = new Padding(2, 2, 2, 2);
            btnBulkDeletePasswords.Name = "btnBulkDeletePasswords";
            btnBulkDeletePasswords.Size = new Size(111, 27);
            btnBulkDeletePasswords.TabIndex = 12;
            btnBulkDeletePasswords.Text = "Bulk Delete Passwords";
            btnBulkDeletePasswords.UseVisualStyleBackColor = true;
            btnBulkDeletePasswords.Click += btnBulkDeletePasswords_Click;
            // 
            // btnSharePassword
            // 
            btnSharePassword.Location = new Point(217, 294);
            btnSharePassword.Margin = new Padding(2, 2, 2, 2);
            btnSharePassword.Name = "btnSharePassword";
            btnSharePassword.Size = new Size(90, 27);
            btnSharePassword.TabIndex = 13;
            btnSharePassword.Text = "Share Password";
            btnSharePassword.UseVisualStyleBackColor = true;
            btnSharePassword.Click += btnSharePassword_Click;
            // 
            // btnBackup
            // 
            btnBackup.Location = new Point(540, 315);
            btnBackup.Margin = new Padding(2, 2, 2, 2);
            btnBackup.Name = "btnBackup";
            btnBackup.Size = new Size(177, 27);
            btnBackup.TabIndex = 14;
            btnBackup.Text = "BackUpPasswords";
            btnBackup.UseVisualStyleBackColor = true;
            btnBackup.Click += btnBackup_Click;
            // 
            // btnRestore
            // 
            btnRestore.Location = new Point(554, 382);
            btnRestore.Margin = new Padding(2, 2, 2, 2);
            btnRestore.Name = "btnRestore";
            btnRestore.Size = new Size(154, 27);
            btnRestore.TabIndex = 15;
            btnRestore.Text = "Restore from Backup";
            btnRestore.UseVisualStyleBackColor = true;
            btnRestore.Click += btnRestore_Click;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(813, 344);
            btnExport.Margin = new Padding(2, 2, 2, 2);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(90, 27);
            btnExport.TabIndex = 16;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // btnAccountDetails
            // 
            btnAccountDetails.Location = new Point(801, 12);
            btnAccountDetails.Name = "btnAccountDetails";
            btnAccountDetails.Size = new Size(184, 69);
            btnAccountDetails.TabIndex = 17;
            btnAccountDetails.Text = "MY ACCOUNT";
            btnAccountDetails.UseVisualStyleBackColor = true;
            btnAccountDetails.Click += btnAccountDetails_Click;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(997, 544);
            Controls.Add(btnAccountDetails);
            Controls.Add(btnSharePassword);
            Controls.Add(btnBulkDeletePasswords);
            Controls.Add(btnGeneratePassword);
            Controls.Add(btnDeletePassword);
            Controls.Add(btnEditPassword);
            Controls.Add(btnExport);
            Controls.Add(btnRestore);
            Controls.Add(btnBackup);
=======
btnEditPassword.Location = new Point(37, 288);
btnEditPassword.Name = "btnEditPassword";
btnEditPassword.Size = new Size(139, 34);
btnEditPassword.TabIndex = 9;
btnEditPassword.Text = "Edit Password";
btnEditPassword.UseVisualStyleBackColor = true;
btnEditPassword.Click += btnEditPassword_Click;

btnDeletePassword.Location = new Point(37, 328);
btnDeletePassword.Name = "btnDeletePassword";
btnDeletePassword.Size = new Size(139, 34);
btnDeletePassword.TabIndex = 10;
btnDeletePassword.Text = "Delete Password";
btnDeletePassword.UseVisualStyleBackColor = true;
btnDeletePassword.Click += btnDeletePassword_Click;

btnGeneratePassword.Location = new Point(271, 328);
btnGeneratePassword.Name = "btnGeneratePassword";
btnGeneratePassword.Size = new Size(112, 34);
btnGeneratePassword.TabIndex = 11;
btnGeneratePassword.Text = "Generate Password";
btnGeneratePassword.UseVisualStyleBackColor = true;
btnGeneratePassword.Click += btnGeneratePassword_Click;

btnBulkDeletePasswords.Location = new Point(37, 368);
btnBulkDeletePasswords.Name = "btnBulkDeletePasswords";
btnBulkDeletePasswords.Size = new Size(139, 34);
btnBulkDeletePasswords.TabIndex = 12;
btnBulkDeletePasswords.Text = "Bulk Delete Passwords";
btnBulkDeletePasswords.UseVisualStyleBackColor = true;
btnBulkDeletePasswords.Click += btnBulkDeletePasswords_Click;

btnSharePassword.Location = new Point(271, 368);
btnSharePassword.Name = "btnSharePassword";
btnSharePassword.Size = new Size(112, 34);
btnSharePassword.TabIndex = 13;
btnSharePassword.Text = "Share Password";
btnSharePassword.UseVisualStyleBackColor = true;
btnSharePassword.Click += btnSharePassword_Click;

btnBackup.Location = new Point(675, 394);
btnBackup.Name = "btnBackup";
btnBackup.Size = new Size(221, 34);
btnBackup.TabIndex = 14;
btnBackup.Text = "BackUpPasswords";
btnBackup.UseVisualStyleBackColor = true;
btnBackup.Click += btnBackup_Click;

btnRestore.Location = new Point(692, 477);
btnRestore.Name = "btnRestore";
btnRestore.Size = new Size(192, 34);
btnRestore.TabIndex = 15;
btnRestore.Text = "Restore from Backup";
btnRestore.UseVisualStyleBackColor = true;
btnRestore.Click += btnRestore_Click;

btnExport.Location = new Point(1016, 430);
btnExport.Name = "btnExport";
btnExport.Size = new Size(112, 34);
btnExport.TabIndex = 16;
btnExport.Text = "Export";
btnExport.UseVisualStyleBackColor = true;
btnExport.Click += btnExport_Click;

            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
ClientSize = new Size(1246, 680);
Controls.Add(btnSharePassword);
Controls.Add(btnBulkDeletePasswords);
Controls.Add(btnGeneratePassword);
Controls.Add(btnDeletePassword);
Controls.Add(btnEditPassword);
Controls.Add(btnExport);
Controls.Add(btnRestore);
Controls.Add(btnBackup);

>>>>>>> aa6324302b48e1cb9fb552a2091333ee4b01857b
            Controls.Add(btnTogglePasswords);
            Controls.Add(lvPasswords);
            Controls.Add(btnSavePassword);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtWebsitePassword);
            Controls.Add(txtWebsite);
            Controls.Add(lblWelcome);
<<<<<<< HEAD
            Margin = new Padding(2, 2, 2, 2);
=======
>>>>>>> aa6324302b48e1cb9fb552a2091333ee4b01857b
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
private Button btnBackup;
private Button btnRestore;
private Button btnExport;
<<<<<<< HEAD
        private Button btnAccountDetails;
=======
>>>>>>> aa6324302b48e1cb9fb552a2091333ee4b01857b
    }
}