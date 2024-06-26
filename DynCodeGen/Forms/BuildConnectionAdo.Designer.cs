﻿namespace DynCodeGen
{
    partial class BuildConnectionAdo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuildConnectionAdo));
            panel1 = new Panel();
            cmbDatabase = new ComboBox();
            lblDatabase = new Label();
            btnTestConnection = new Button();
            panel2 = new Panel();
            button1 = new Button();
            btnClose = new Button();
            lblHead = new Label();
            cmbAuthetication = new ComboBox();
            txtUserName = new TextBox();
            txtPassword = new MaskedTextBox();
            txtServerName = new TextBox();
            lblPassword = new Label();
            lblUsername = new Label();
            lblAuthentication = new Label();
            lblServerName = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(cmbDatabase);
            panel1.Controls.Add(lblDatabase);
            panel1.Controls.Add(btnTestConnection);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(cmbAuthetication);
            panel1.Controls.Add(txtUserName);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtServerName);
            panel1.Controls.Add(lblPassword);
            panel1.Controls.Add(lblUsername);
            panel1.Controls.Add(lblAuthentication);
            panel1.Controls.Add(lblServerName);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(523, 342);
            panel1.TabIndex = 1;
            // 
            // cmbDatabase
            // 
            cmbDatabase.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cmbDatabase.FormattingEnabled = true;
            cmbDatabase.Location = new Point(138, 247);
            cmbDatabase.Name = "cmbDatabase";
            cmbDatabase.Size = new Size(379, 31);
            cmbDatabase.TabIndex = 17;
            // 
            // lblDatabase
            // 
            lblDatabase.AutoSize = true;
            lblDatabase.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDatabase.Location = new Point(3, 256);
            lblDatabase.Name = "lblDatabase";
            lblDatabase.Size = new Size(81, 23);
            lblDatabase.TabIndex = 16;
            lblDatabase.Text = "Database";
            // 
            // btnTestConnection
            // 
            btnTestConnection.BackColor = Color.FromArgb(29, 51, 92);
            btnTestConnection.Cursor = Cursors.Hand;
            btnTestConnection.FlatAppearance.BorderSize = 0;
            btnTestConnection.FlatStyle = FlatStyle.Flat;
            btnTestConnection.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnTestConnection.ForeColor = Color.White;
            btnTestConnection.Location = new Point(417, 293);
            btnTestConnection.Margin = new Padding(0);
            btnTestConnection.Name = "btnTestConnection";
            btnTestConnection.Size = new Size(100, 40);
            btnTestConnection.TabIndex = 15;
            btnTestConnection.Text = "Confirm";
            btnTestConnection.UseVisualStyleBackColor = false;
            btnTestConnection.Click += btnTestConnection_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(29, 51, 92);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(btnClose);
            panel2.Controls.Add(lblHead);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(523, 39);
            panel2.TabIndex = 14;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(490, 3);
            button1.Name = "button1";
            button1.Size = new Size(30, 30);
            button1.TabIndex = 18;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(576, 7);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(25, 25);
            btnClose.TabIndex = 6;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // lblHead
            // 
            lblHead.AutoSize = true;
            lblHead.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblHead.ForeColor = Color.LightGray;
            lblHead.Location = new Point(8, 7);
            lblHead.Name = "lblHead";
            lblHead.Size = new Size(188, 25);
            lblHead.TabIndex = 13;
            lblHead.Text = "Connect to Database";
            // 
            // cmbAuthetication
            // 
            cmbAuthetication.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cmbAuthetication.FormattingEnabled = true;
            cmbAuthetication.Items.AddRange(new object[] { "SQL Server Authentication" });
            cmbAuthetication.Location = new Point(138, 100);
            cmbAuthetication.Name = "cmbAuthetication";
            cmbAuthetication.Size = new Size(379, 31);
            cmbAuthetication.TabIndex = 2;
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserName.Location = new Point(138, 151);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(379, 30);
            txtUserName.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtPassword.Location = new Point(138, 199);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(379, 30);
            txtPassword.TabIndex = 4;
            txtPassword.TextMaskFormat = MaskFormat.IncludePrompt;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtServerName
            // 
            txtServerName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtServerName.Location = new Point(138, 51);
            txtServerName.Name = "txtServerName";
            txtServerName.Size = new Size(379, 30);
            txtServerName.TabIndex = 1;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassword.Location = new Point(3, 206);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(80, 23);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsername.Location = new Point(3, 158);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(87, 23);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Username";
            // 
            // lblAuthentication
            // 
            lblAuthentication.AutoSize = true;
            lblAuthentication.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblAuthentication.Location = new Point(3, 109);
            lblAuthentication.Name = "lblAuthentication";
            lblAuthentication.Size = new Size(123, 23);
            lblAuthentication.TabIndex = 1;
            lblAuthentication.Text = "Authentication";
            // 
            // lblServerName
            // 
            lblServerName.AutoSize = true;
            lblServerName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblServerName.Location = new Point(3, 57);
            lblServerName.Name = "lblServerName";
            lblServerName.Size = new Size(108, 23);
            lblServerName.TabIndex = 0;
            lblServerName.Text = "Server Name";
            // 
            // BuildConnectionAdo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 342);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BuildConnectionAdo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Test Connection";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox cmbAuthetication;
        private TextBox txtUserName;
        private MaskedTextBox txtPassword;
        private TextBox txtServerName;
        private Label lblPassword;
        private Label lblUsername;
        private Label lblAuthentication;
        private Label lblServerName;
        private Panel panel2;
        private Label lblHead;
        private Button btnClose;
        private Button btnTestConnection;
        private ComboBox cmbDatabase;
        private Label lblDatabase;
        private Button button1;
    }
}