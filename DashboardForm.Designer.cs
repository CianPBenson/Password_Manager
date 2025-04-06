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
            txtWebsite.Location = new Point(285, 148);
            txtWebsite.Name = "txtWebsite";
            txtWebsite.Size = new Size(150, 31);
            txtWebsite.TabIndex = 1;
            // 
            // txtWebsitePassword
            // 
            txtWebsitePassword.Location = new Point(285, 230);
            txtWebsitePassword.Name = "txtWebsitePassword";
            txtWebsitePassword.Size = new Size(150, 31);
            txtWebsitePassword.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(137, 154);
            label1.Name = "label1";
            label1.Size = new Size(75, 25);
            label1.TabIndex = 4;
            label1.Text = "Website";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(137, 236);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // btnSavePassword
            // 
            btnSavePassword.Location = new Point(285, 340);
            btnSavePassword.Name = "btnSavePassword";
            btnSavePassword.Size = new Size(112, 34);
            btnSavePassword.TabIndex = 6;
            btnSavePassword.Text = "Save";
            btnSavePassword.UseVisualStyleBackColor = true;
            btnSavePassword.Click += btnSavePassword_Click;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}