namespace Password_Manager
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
=======
<<<<<<< HEAD
            btnDeletePassword = new Button();
            btnGeneratePassword = new Button();
            btnBulkDeletePasswords = new Button();
            btnSharePassword = new Button();
>>>>>>> 2be342d865c5d17aaab434381559123833612930
            btnBackup = new Button();
            btnRestore = new Button();
            btnExport = new Button();
            btnAccountDetails = new Button();
<<<<<<< HEAD
            btnAccount = new Button();
            txtRecipientUsername = new TextBox();
            label3 = new Label();
            btnSharePassword = new Button();
=======
=======
btnDeletePassword = new Button();
btnGeneratePassword = new Button();
btnBulkDeletePasswords = new Button();
btnSharePassword = new Button();

btnBackup = new Button();
btnRestore = new Button();
btnExport = new Button();

>>>>>>> aa6324302b48e1cb9fb552a2091333ee4b01857b
>>>>>>> 2be342d865c5d17aaab434381559123833612930
            SuspendLayout();
            // 
            // lblWelcome
            // 
<<<<<<< HEAD
            lblWelcome.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(280, 34);
            lblWelcome.Margin = new Padding(2, 0, 2, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(782, 49);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "label1";
            // 
            // txtWebsite
            // 
            txtWebsite.Location = new Point(122, 119);
            txtWebsite.Margin = new Padding(2);
            txtWebsite.Name = "txtWebsite";
            txtWebsite.Size = new Size(175, 23);
=======
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
>>>>>>> 2be342d865c5d17aaab434381559123833612930
            txtWebsite.TabIndex = 1;
            // 
            // txtWebsitePassword
            // 
<<<<<<< HEAD
            txtWebsitePassword.Location = new Point(122, 166);
            txtWebsitePassword.Margin = new Padding(2);
            txtWebsitePassword.Name = "txtWebsitePassword";
            txtWebsitePassword.Size = new Size(175, 23);
=======
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
>>>>>>> 2be342d865c5d17aaab434381559123833612930
            txtWebsitePassword.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
<<<<<<< HEAD
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(42, 117);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(76, 21);
            label1.TabIndex = 4;
            label1.Text = "Website:";
=======
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
>>>>>>> 2be342d865c5d17aaab434381559123833612930
            // 
            // label2
            // 
            label2.AutoSize = true;
<<<<<<< HEAD
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(32, 164);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(86, 21);
            label2.TabIndex = 5;
            label2.Text = "Password:";
            // 
            // btnSavePassword
            // 
            btnSavePassword.BackColor = Color.Black;
            btnSavePassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSavePassword.ForeColor = Color.White;
            btnSavePassword.Location = new Point(122, 211);
            btnSavePassword.Margin = new Padding(2);
            btnSavePassword.Name = "btnSavePassword";
            btnSavePassword.Size = new Size(175, 59);
            btnSavePassword.TabIndex = 6;
            btnSavePassword.Text = "Save";
            btnSavePassword.UseVisualStyleBackColor = false;
=======
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
>>>>>>> 2be342d865c5d17aaab434381559123833612930
            btnSavePassword.Click += btnSavePassword_Click;
            // 
            // lvPasswords
            // 
            lvPasswords.Columns.AddRange(new ColumnHeader[] { Website, Password });
            lvPasswords.FullRowSelect = true;
            lvPasswords.GridLines = true;
<<<<<<< HEAD
            lvPasswords.Location = new Point(457, 99);
            lvPasswords.Margin = new Padding(2);
            lvPasswords.Name = "lvPasswords";
            lvPasswords.Size = new Size(499, 315);
            lvPasswords.TabIndex = 7;
            lvPasswords.UseCompatibleStateImageBehavior = false;
            lvPasswords.View = View.Details;
=======
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
>>>>>>> 2be342d865c5d17aaab434381559123833612930
            // 
            // Website
            // 
            Website.Text = "Website";
<<<<<<< HEAD
            Website.Width = 285;
=======
            Website.Width = 150;
>>>>>>> 2be342d865c5d17aaab434381559123833612930
            // 
            // Password
            // 
            Password.Text = "Password";
<<<<<<< HEAD
            Password.Width = 280;
            // 
            // btnTogglePasswords
            // 
            btnTogglePasswords.BackColor = Color.White;
            btnTogglePasswords.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTogglePasswords.Location = new Point(457, 421);
            btnTogglePasswords.Margin = new Padding(2);
            btnTogglePasswords.Name = "btnTogglePasswords";
            btnTogglePasswords.Size = new Size(499, 58);
            btnTogglePasswords.TabIndex = 8;
            btnTogglePasswords.Text = "See all passwords";
            btnTogglePasswords.UseVisualStyleBackColor = false;
            btnTogglePasswords.Click += btnTogglePasswords_Click;
            // 
            // btnEditPassword
            // 
            btnEditPassword.BackColor = Color.White;
            btnEditPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEditPassword.Location = new Point(336, 355);
            btnEditPassword.Margin = new Padding(2);
            btnEditPassword.Name = "btnEditPassword";
            btnEditPassword.Size = new Size(117, 59);
            btnEditPassword.TabIndex = 9;
            btnEditPassword.Text = "Edit Password";
            btnEditPassword.UseVisualStyleBackColor = false;
=======
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
>>>>>>> 2be342d865c5d17aaab434381559123833612930
            btnEditPassword.Click += btnEditPassword_Click;
            // 
            // btnDeletePassword
            // 
<<<<<<< HEAD
            btnDeletePassword.BackColor = Color.White;
            btnDeletePassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDeletePassword.Location = new Point(336, 164);
            btnDeletePassword.Margin = new Padding(2);
            btnDeletePassword.Name = "btnDeletePassword";
            btnDeletePassword.Size = new Size(117, 61);
            btnDeletePassword.TabIndex = 10;
            btnDeletePassword.Text = "Delete Password";
            btnDeletePassword.UseVisualStyleBackColor = false;
=======
            btnDeletePassword.Location = new Point(30, 262);
            btnDeletePassword.Margin = new Padding(2, 2, 2, 2);
            btnDeletePassword.Name = "btnDeletePassword";
            btnDeletePassword.Size = new Size(111, 27);
            btnDeletePassword.TabIndex = 10;
            btnDeletePassword.Text = "Delete Password";
            btnDeletePassword.UseVisualStyleBackColor = true;
>>>>>>> 2be342d865c5d17aaab434381559123833612930
            btnDeletePassword.Click += btnDeletePassword_Click;
            // 
            // btnGeneratePassword
            // 
<<<<<<< HEAD
            btnGeneratePassword.BackColor = Color.White;
            btnGeneratePassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGeneratePassword.Location = new Point(336, 292);
            btnGeneratePassword.Margin = new Padding(2);
            btnGeneratePassword.Name = "btnGeneratePassword";
            btnGeneratePassword.Size = new Size(117, 59);
            btnGeneratePassword.TabIndex = 11;
            btnGeneratePassword.Text = "Generate Password";
            btnGeneratePassword.UseVisualStyleBackColor = false;
=======
            btnGeneratePassword.Location = new Point(217, 262);
            btnGeneratePassword.Margin = new Padding(2, 2, 2, 2);
            btnGeneratePassword.Name = "btnGeneratePassword";
            btnGeneratePassword.Size = new Size(90, 27);
            btnGeneratePassword.TabIndex = 11;
            btnGeneratePassword.Text = "Generate Password";
            btnGeneratePassword.UseVisualStyleBackColor = true;
>>>>>>> 2be342d865c5d17aaab434381559123833612930
            btnGeneratePassword.Click += btnGeneratePassword_Click;
            // 
            // btnBulkDeletePasswords
            // 
<<<<<<< HEAD
            btnBulkDeletePasswords.BackColor = Color.White;
            btnBulkDeletePasswords.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBulkDeletePasswords.Location = new Point(336, 99);
            btnBulkDeletePasswords.Margin = new Padding(2);
            btnBulkDeletePasswords.Name = "btnBulkDeletePasswords";
            btnBulkDeletePasswords.Size = new Size(117, 61);
            btnBulkDeletePasswords.TabIndex = 12;
            btnBulkDeletePasswords.Text = "Bulk Delete Passwords";
            btnBulkDeletePasswords.UseVisualStyleBackColor = false;
            btnBulkDeletePasswords.Click += btnBulkDeletePasswords_Click;
            // 
            // btnBackup
            // 
            btnBackup.BackColor = Color.White;
            btnBackup.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBackup.ForeColor = SystemColors.ControlText;
            btnBackup.Location = new Point(961, 231);
            btnBackup.Margin = new Padding(2);
            btnBackup.Name = "btnBackup";
            btnBackup.Size = new Size(117, 58);
            btnBackup.TabIndex = 14;
            btnBackup.Text = "BackUpPasswords";
            btnBackup.UseVisualStyleBackColor = false;
=======
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
>>>>>>> 2be342d865c5d17aaab434381559123833612930
            btnBackup.Click += btnBackup_Click;
            // 
            // btnRestore
            // 
<<<<<<< HEAD
            btnRestore.BackColor = Color.White;
            btnRestore.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRestore.ForeColor = SystemColors.ControlText;
            btnRestore.Location = new Point(961, 293);
            btnRestore.Margin = new Padding(2);
            btnRestore.Name = "btnRestore";
            btnRestore.Size = new Size(117, 59);
            btnRestore.TabIndex = 15;
            btnRestore.Text = "Restore from Backup";
            btnRestore.UseVisualStyleBackColor = false;
=======
            btnRestore.Location = new Point(554, 382);
            btnRestore.Margin = new Padding(2, 2, 2, 2);
            btnRestore.Name = "btnRestore";
            btnRestore.Size = new Size(154, 27);
            btnRestore.TabIndex = 15;
            btnRestore.Text = "Restore from Backup";
            btnRestore.UseVisualStyleBackColor = true;
>>>>>>> 2be342d865c5d17aaab434381559123833612930
            btnRestore.Click += btnRestore_Click;
            // 
            // btnExport
            // 
<<<<<<< HEAD
            btnExport.BackColor = Color.White;
            btnExport.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnExport.ForeColor = SystemColors.ControlText;
            btnExport.Location = new Point(961, 356);
            btnExport.Margin = new Padding(2);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(117, 58);
            btnExport.TabIndex = 16;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = false;
=======
            btnExport.Location = new Point(813, 344);
            btnExport.Margin = new Padding(2, 2, 2, 2);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(90, 27);
            btnExport.TabIndex = 16;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = true;
>>>>>>> 2be342d865c5d17aaab434381559123833612930
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
<<<<<<< HEAD
            // btnAccount
            // 
            btnAccount.BackColor = Color.Black;
            btnAccount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAccount.ForeColor = Color.White;
            btnAccount.Location = new Point(961, 99);
            btnAccount.Name = "btnAccount";
            btnAccount.Size = new Size(117, 61);
            btnAccount.TabIndex = 17;
            btnAccount.Text = "MY ACCOUNT";
            btnAccount.UseVisualStyleBackColor = false;
            btnAccount.Click += btnAccountDetails_Click;
            // 
            // txtRecipientUsername
            // 
            txtRecipientUsername.Location = new Point(122, 293);
            txtRecipientUsername.Name = "txtRecipientUsername";
            txtRecipientUsername.Size = new Size(175, 23);
            txtRecipientUsername.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(37, 293);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(81, 21);
            label3.TabIndex = 19;
            label3.Text = "Recipent:";
            // 
            // btnSharePassword
            // 
            btnSharePassword.BackColor = Color.Black;
            btnSharePassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSharePassword.ForeColor = Color.White;
            btnSharePassword.Location = new Point(122, 338);
            btnSharePassword.Margin = new Padding(2);
            btnSharePassword.Name = "btnSharePassword";
            btnSharePassword.Size = new Size(175, 59);
            btnSharePassword.TabIndex = 20;
            btnSharePassword.Text = "Share Password";
            btnSharePassword.UseVisualStyleBackColor = false;
            btnSharePassword.Click += btnSharePassword_Click;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1137, 553);
            Controls.Add(btnSharePassword);
            Controls.Add(label3);
            Controls.Add(txtRecipientUsername);
            Controls.Add(btnAccount);
=======
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(997, 544);
            Controls.Add(btnAccountDetails);
            Controls.Add(btnSharePassword);
>>>>>>> 2be342d865c5d17aaab434381559123833612930
            Controls.Add(btnBulkDeletePasswords);
            Controls.Add(btnGeneratePassword);
            Controls.Add(btnDeletePassword);
            Controls.Add(btnEditPassword);
            Controls.Add(btnExport);
            Controls.Add(btnRestore);
            Controls.Add(btnBackup);
<<<<<<< HEAD
=======
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
>>>>>>> 2be342d865c5d17aaab434381559123833612930
            Controls.Add(btnTogglePasswords);
            Controls.Add(lvPasswords);
            Controls.Add(btnSavePassword);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtWebsitePassword);
            Controls.Add(txtWebsite);
            Controls.Add(lblWelcome);
<<<<<<< HEAD
            Margin = new Padding(2);
=======
<<<<<<< HEAD
            Margin = new Padding(2, 2, 2, 2);
=======
>>>>>>> aa6324302b48e1cb9fb552a2091333ee4b01857b
>>>>>>> 2be342d865c5d17aaab434381559123833612930
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
<<<<<<< HEAD
        private Button btnEditPassword;
        private Button btnDeletePassword;
        private Button btnGeneratePassword;
        private Button btnBulkDeletePasswords;
        private Button btnBackup;
        private Button btnRestore;
        private Button btnExport;
        private Button btnAccountDetails;
        private Button btnAccount;
        private TextBox txtRecipientUsername;
        private Label label3;
        private Button btnSharePassword;
    }
}
=======
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
>>>>>>> 2be342d865c5d17aaab434381559123833612930
