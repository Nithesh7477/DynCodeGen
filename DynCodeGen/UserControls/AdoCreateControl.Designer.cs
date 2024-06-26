﻿namespace DynCodeGen.UserControls
{
    partial class AdoCreateControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
            pnlLog = new Panel();
            dgTable = new DataGridView();
            txtLog = new RichTextBox();
            dgSP = new DataGridView();
            SPColName = new DataGridViewTextBoxColumn();
            spGet = new DataGridViewCheckBoxColumn();
            spPost = new DataGridViewCheckBoxColumn();
            pnlProgressStatus = new Panel();
            lblProgressStatus = new Label();
            pnlProgressBar = new Panel();
            progressBar = new ProgressBar();
            pnlInputFields = new Panel();
            btnValidate = new Button();
            btnCreate = new Button();
            btnSourcefile = new Button();
            btnProjectLocation = new Button();
            btnAdd = new Button();
            lblValidProjSource = new Label();
            lblValidProjLoc = new Label();
            lblValidProjName = new Label();
            lblvalidConnStr = new Label();
            txtConnectionString = new TextBox();
            txtSourceFilePath = new TextBox();
            txtProjectLocationPath = new TextBox();
            txtProjectName = new TextBox();
            pnlTextLable = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            lblConnectionSting = new Label();
            lblSourceFile = new Label();
            lblProjectLocation = new Label();
            lblProjectName = new Label();
            label2 = new Label();
            tblpnlMain = new TableLayoutPanel();
            openFileDialog = new OpenFileDialog();
            pnlLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgSP).BeginInit();
            pnlProgressStatus.SuspendLayout();
            pnlProgressBar.SuspendLayout();
            pnlInputFields.SuspendLayout();
            pnlTextLable.SuspendLayout();
            tblpnlMain.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLog
            // 
            pnlLog.AutoSize = true;
            pnlLog.BorderStyle = BorderStyle.FixedSingle;
            tblpnlMain.SetColumnSpan(pnlLog, 2);
            pnlLog.Controls.Add(dgTable);
            pnlLog.Controls.Add(txtLog);
            pnlLog.Dock = DockStyle.Fill;
            pnlLog.Location = new Point(3, 286);
            pnlLog.Name = "pnlLog";
            pnlLog.Size = new Size(1008, 213);
            pnlLog.TabIndex = 5;
            // 
            // dgTable
            // 
            dgTable.AllowUserToAddRows = false;
            dgTable.AllowUserToDeleteRows = false;
            dgTable.BackgroundColor = SystemColors.Window;
            dataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = Color.FromArgb(29, 51, 92);
            dataGridViewCellStyle19.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle19.ForeColor = Color.White;
            dataGridViewCellStyle19.SelectionBackColor = Color.FromArgb(107, 125, 157);
            dataGridViewCellStyle19.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = DataGridViewTriState.True;
            dgTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            dgTable.ColumnHeadersHeight = 29;
            dgTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgTable.Cursor = Cursors.Hand;
            dataGridViewCellStyle20.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = SystemColors.Window;
            dataGridViewCellStyle20.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle20.ForeColor = Color.Black;
            dataGridViewCellStyle20.SelectionBackColor = Color.FromArgb(107, 125, 157);
            dataGridViewCellStyle20.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = DataGridViewTriState.False;
            dgTable.DefaultCellStyle = dataGridViewCellStyle20;
            dgTable.Dock = DockStyle.Fill;
            dgTable.EnableHeadersVisualStyles = false;
            dgTable.GridColor = Color.FromArgb(45, 137, 86);
            dgTable.Location = new Point(0, 0);
            dgTable.Name = "dgTable";
            dgTable.RowHeadersVisible = false;
            dgTable.RowHeadersWidth = 51;
            dgTable.RowTemplate.Height = 29;
            dgTable.Size = new Size(1006, 211);
            dgTable.TabIndex = 1;
            dgTable.CellContentClick += dgTable_CellContentClick;
            // 
            // txtLog
            // 
            txtLog.Dock = DockStyle.Fill;
            txtLog.Location = new Point(0, 0);
            txtLog.Name = "txtLog";
            txtLog.Size = new Size(1006, 211);
            txtLog.TabIndex = 0;
            txtLog.Text = "";
            // 
            // dgSP
            // 
            dgSP.AllowUserToDeleteRows = false;
            dgSP.BackgroundColor = SystemColors.Window;
            dgSP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            dgSP.ColumnHeadersHeight = 29;
            dgSP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgSP.Columns.AddRange(new DataGridViewColumn[] { SPColName, spGet, spPost });
            dgSP.Cursor = Cursors.Hand;
            dgSP.DefaultCellStyle = dataGridViewCellStyle20;
            dgSP.EnableHeadersVisualStyles = false;
            dgSP.GridColor = Color.FromArgb(45, 137, 86);
            dgSP.Location = new Point(-1, 0);
            dgSP.Name = "dgSP";
            dgSP.RowHeadersVisible = false;
            dgSP.RowHeadersWidth = 51;
            dgSP.RowTemplate.Height = 29;
            dgSP.Size = new Size(1006, 211);
            dgSP.TabIndex = 1;
            // 
            // SPColName
            // 
            SPColName.HeaderText = "Stored Procedure";
            SPColName.MinimumWidth = 6;
            SPColName.Name = "SPColName";
            SPColName.Width = 125;
            // 
            // spGet
            // 
            spGet.HeaderText = "Get/Get All";
            spGet.MinimumWidth = 6;
            spGet.Name = "spGet";
            spGet.Width = 125;
            // 
            // spPost
            // 
            spPost.HeaderText = "Insert/Update/Delete";
            spPost.MinimumWidth = 6;
            spPost.Name = "spPost";
            spPost.Width = 125;
            // 
            // pnlProgressStatus
            // 
            pnlProgressStatus.BackColor = SystemColors.Window;
            tblpnlMain.SetColumnSpan(pnlProgressStatus, 2);
            pnlProgressStatus.Controls.Add(lblProgressStatus);
            pnlProgressStatus.Dock = DockStyle.Fill;
            pnlProgressStatus.Location = new Point(3, 505);
            pnlProgressStatus.Name = "pnlProgressStatus";
            pnlProgressStatus.Size = new Size(1008, 38);
            pnlProgressStatus.TabIndex = 3;
            // 
            // lblProgressStatus
            // 
            lblProgressStatus.AutoSize = true;
            lblProgressStatus.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblProgressStatus.Location = new Point(3, 8);
            lblProgressStatus.Name = "lblProgressStatus";
            lblProgressStatus.Size = new Size(0, 23);
            lblProgressStatus.TabIndex = 0;
            // 
            // pnlProgressBar
            // 
            tblpnlMain.SetColumnSpan(pnlProgressBar, 2);
            pnlProgressBar.Controls.Add(progressBar);
            pnlProgressBar.Dock = DockStyle.Fill;
            pnlProgressBar.Location = new Point(3, 549);
            pnlProgressBar.Name = "pnlProgressBar";
            pnlProgressBar.Size = new Size(1008, 45);
            pnlProgressBar.TabIndex = 2;
            // 
            // progressBar
            // 
            progressBar.BackColor = Color.White;
            progressBar.Dock = DockStyle.Fill;
            progressBar.Location = new Point(0, 0);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(1008, 45);
            progressBar.TabIndex = 1;
            // 
            // pnlInputFields
            // 
            pnlInputFields.AutoSize = true;
            pnlInputFields.BackColor = SystemColors.Window;
            pnlInputFields.Controls.Add(btnValidate);
            pnlInputFields.Controls.Add(btnCreate);
            pnlInputFields.Controls.Add(btnSourcefile);
            pnlInputFields.Controls.Add(btnProjectLocation);
            pnlInputFields.Controls.Add(btnAdd);
            pnlInputFields.Controls.Add(lblValidProjSource);
            pnlInputFields.Controls.Add(lblValidProjLoc);
            pnlInputFields.Controls.Add(lblValidProjName);
            pnlInputFields.Controls.Add(lblvalidConnStr);
            pnlInputFields.Controls.Add(txtConnectionString);
            pnlInputFields.Controls.Add(txtSourceFilePath);
            pnlInputFields.Controls.Add(txtProjectLocationPath);
            pnlInputFields.Controls.Add(txtProjectName);
            pnlInputFields.Dock = DockStyle.Fill;
            pnlInputFields.Location = new Point(308, 3);
            pnlInputFields.Name = "pnlInputFields";
            pnlInputFields.Size = new Size(703, 277);
            pnlInputFields.TabIndex = 1;
            pnlInputFields.Paint += pnlInputFields_Paint;
            // 
            // btnValidate
            // 
            btnValidate.BackColor = Color.FromArgb(29, 51, 92);
            btnValidate.Cursor = Cursors.Hand;
            btnValidate.FlatStyle = FlatStyle.Flat;
            btnValidate.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnValidate.ForeColor = Color.White;
            btnValidate.Location = new Point(19, 233);
            btnValidate.Name = "btnValidate";
            btnValidate.Size = new Size(127, 43);
            btnValidate.TabIndex = 19;
            btnValidate.Text = "Validate";
            btnValidate.UseVisualStyleBackColor = false;
            btnValidate.Click += btnValidate_Click;
            btnValidate.EnabledChanged += btnValidate_EnabledChanged;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.FromArgb(29, 51, 92);
            btnCreate.Cursor = Cursors.Hand;
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(150, 233);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(127, 43);
            btnCreate.TabIndex = 18;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            btnCreate.EnabledChanged += btnCreate_EnabledChanged;
            // 
            // btnSourcefile
            // 
            btnSourcefile.Cursor = Cursors.Hand;
            btnSourcefile.FlatStyle = FlatStyle.Flat;
            btnSourcefile.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSourcefile.ForeColor = Color.FromArgb(29, 51, 92);
            btnSourcefile.Location = new Point(589, 182);
            btnSourcefile.Name = "btnSourcefile";
            btnSourcefile.Size = new Size(92, 31);
            btnSourcefile.TabIndex = 17;
            btnSourcefile.Text = "Browse";
            btnSourcefile.UseVisualStyleBackColor = true;
            btnSourcefile.Click += btnSourcefile_Click;
            // 
            // btnProjectLocation
            // 
            btnProjectLocation.Cursor = Cursors.Hand;
            btnProjectLocation.FlatStyle = FlatStyle.Flat;
            btnProjectLocation.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnProjectLocation.ForeColor = Color.FromArgb(29, 51, 92);
            btnProjectLocation.Location = new Point(592, 125);
            btnProjectLocation.Name = "btnProjectLocation";
            btnProjectLocation.Size = new Size(92, 31);
            btnProjectLocation.TabIndex = 16;
            btnProjectLocation.Text = "Select";
            btnProjectLocation.UseVisualStyleBackColor = true;
            btnProjectLocation.Click += btnProjectLocation_Click;
            // 
            // btnAdd
            // 
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.FromArgb(29, 51, 92);
            btnAdd.Location = new Point(592, 20);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(92, 31);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Build";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblValidProjSource
            // 
            lblValidProjSource.AutoSize = true;
            lblValidProjSource.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblValidProjSource.ForeColor = Color.Red;
            lblValidProjSource.Location = new Point(21, 213);
            lblValidProjSource.Name = "lblValidProjSource";
            lblValidProjSource.Size = new Size(141, 17);
            lblValidProjSource.TabIndex = 14;
            lblValidProjSource.Text = "Source File is required.";
            lblValidProjSource.Visible = false;
            // 
            // lblValidProjLoc
            // 
            lblValidProjLoc.AutoSize = true;
            lblValidProjLoc.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblValidProjLoc.ForeColor = Color.Red;
            lblValidProjLoc.Location = new Point(21, 158);
            lblValidProjLoc.Name = "lblValidProjLoc";
            lblValidProjLoc.Size = new Size(171, 17);
            lblValidProjLoc.TabIndex = 13;
            lblValidProjLoc.Text = "Project Location is required.";
            lblValidProjLoc.Visible = false;
            // 
            // lblValidProjName
            // 
            lblValidProjName.AutoSize = true;
            lblValidProjName.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblValidProjName.ForeColor = Color.Red;
            lblValidProjName.Location = new Point(21, 104);
            lblValidProjName.Name = "lblValidProjName";
            lblValidProjName.Size = new Size(157, 17);
            lblValidProjName.TabIndex = 12;
            lblValidProjName.Text = "Project Name is required.";
            lblValidProjName.Visible = false;
            // 
            // lblvalidConnStr
            // 
            lblvalidConnStr.AutoSize = true;
            lblvalidConnStr.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblvalidConnStr.ForeColor = Color.Red;
            lblvalidConnStr.Location = new Point(21, 53);
            lblvalidConnStr.Name = "lblvalidConnStr";
            lblvalidConnStr.Size = new Size(181, 17);
            lblvalidConnStr.TabIndex = 8;
            lblvalidConnStr.Text = "Connection String is required.";
            lblvalidConnStr.Visible = false;
            // 
            // txtConnectionString
            // 
            txtConnectionString.Cursor = Cursors.IBeam;
            txtConnectionString.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtConnectionString.Location = new Point(19, 20);
            txtConnectionString.Margin = new Padding(0);
            txtConnectionString.Name = "txtConnectionString";
            txtConnectionString.ReadOnly = true;
            txtConnectionString.Size = new Size(551, 31);
            txtConnectionString.TabIndex = 0;
            // 
            // txtSourceFilePath
            // 
            txtSourceFilePath.Cursor = Cursors.IBeam;
            txtSourceFilePath.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtSourceFilePath.Location = new Point(19, 181);
            txtSourceFilePath.Name = "txtSourceFilePath";
            txtSourceFilePath.ReadOnly = true;
            txtSourceFilePath.Size = new Size(551, 31);
            txtSourceFilePath.TabIndex = 4;
            // 
            // txtProjectLocationPath
            // 
            txtProjectLocationPath.Cursor = Cursors.IBeam;
            txtProjectLocationPath.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtProjectLocationPath.Location = new Point(19, 124);
            txtProjectLocationPath.Name = "txtProjectLocationPath";
            txtProjectLocationPath.ReadOnly = true;
            txtProjectLocationPath.Size = new Size(551, 31);
            txtProjectLocationPath.TabIndex = 3;
            // 
            // txtProjectName
            // 
            txtProjectName.Cursor = Cursors.IBeam;
            txtProjectName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtProjectName.Location = new Point(19, 73);
            txtProjectName.Name = "txtProjectName";
            txtProjectName.Size = new Size(551, 31);
            txtProjectName.TabIndex = 2;
            // 
            // pnlTextLable
            // 
            pnlTextLable.BackColor = SystemColors.Window;
            pnlTextLable.Controls.Add(label5);
            pnlTextLable.Controls.Add(label4);
            pnlTextLable.Controls.Add(label3);
            pnlTextLable.Controls.Add(lblConnectionSting);
            pnlTextLable.Controls.Add(lblSourceFile);
            pnlTextLable.Controls.Add(lblProjectLocation);
            pnlTextLable.Controls.Add(lblProjectName);
            pnlTextLable.Controls.Add(label2);
            pnlTextLable.Dock = DockStyle.Fill;
            pnlTextLable.Location = new Point(3, 3);
            pnlTextLable.Name = "pnlTextLable";
            pnlTextLable.Size = new Size(299, 277);
            pnlTextLable.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(160, 183);
            label5.Name = "label5";
            label5.Size = new Size(16, 20);
            label5.TabIndex = 7;
            label5.Text = "*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(160, 130);
            label4.Name = "label4";
            label4.Size = new Size(16, 20);
            label4.TabIndex = 6;
            label4.Text = "*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(142, 80);
            label3.Name = "label3";
            label3.Size = new Size(16, 20);
            label3.TabIndex = 5;
            label3.Text = "*";
            // 
            // lblConnectionSting
            // 
            lblConnectionSting.AutoSize = true;
            lblConnectionSting.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblConnectionSting.Location = new Point(34, 29);
            lblConnectionSting.Name = "lblConnectionSting";
            lblConnectionSting.Size = new Size(147, 23);
            lblConnectionSting.TabIndex = 3;
            lblConnectionSting.Text = "Connection String";
            // 
            // lblSourceFile
            // 
            lblSourceFile.AutoSize = true;
            lblSourceFile.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblSourceFile.Location = new Point(34, 183);
            lblSourceFile.Name = "lblSourceFile";
            lblSourceFile.Size = new Size(133, 23);
            lblSourceFile.TabIndex = 2;
            lblSourceFile.Text = "Source File(.xlsx)";
            // 
            // lblProjectLocation
            // 
            lblProjectLocation.AutoSize = true;
            lblProjectLocation.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblProjectLocation.Location = new Point(34, 130);
            lblProjectLocation.Name = "lblProjectLocation";
            lblProjectLocation.Size = new Size(133, 23);
            lblProjectLocation.TabIndex = 1;
            lblProjectLocation.Text = "Project Location";
            // 
            // lblProjectName
            // 
            lblProjectName.AutoSize = true;
            lblProjectName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblProjectName.Location = new Point(34, 79);
            lblProjectName.Name = "lblProjectName";
            lblProjectName.Size = new Size(114, 23);
            lblProjectName.TabIndex = 0;
            lblProjectName.Text = "Project Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(176, 31);
            label2.Name = "label2";
            label2.Size = new Size(16, 20);
            label2.TabIndex = 4;
            label2.Text = "*";
            // 
            // tblpnlMain
            // 
            tblpnlMain.BackColor = SystemColors.Window;
            tblpnlMain.ColumnCount = 2;
            tblpnlMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblpnlMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 709F));
            tblpnlMain.Controls.Add(pnlTextLable, 0, 0);
            tblpnlMain.Controls.Add(pnlInputFields, 1, 0);
            tblpnlMain.Controls.Add(pnlProgressBar, 0, 3);
            tblpnlMain.Controls.Add(pnlProgressStatus, 0, 2);
            tblpnlMain.Controls.Add(pnlLog, 0, 1);
            tblpnlMain.Location = new Point(3, 4);
            tblpnlMain.Name = "tblpnlMain";
            tblpnlMain.RowCount = 4;
            tblpnlMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblpnlMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 219F));
            tblpnlMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tblpnlMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 51F));
            tblpnlMain.Size = new Size(1014, 597);
            tblpnlMain.TabIndex = 2;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // AdoCreateControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            Controls.Add(tblpnlMain);
            Name = "AdoCreateControl";
            Size = new Size(1015, 604);
            pnlLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgSP).EndInit();
            pnlProgressStatus.ResumeLayout(false);
            pnlProgressStatus.PerformLayout();
            pnlProgressBar.ResumeLayout(false);
            pnlInputFields.ResumeLayout(false);
            pnlInputFields.PerformLayout();
            pnlTextLable.ResumeLayout(false);
            pnlTextLable.PerformLayout();
            tblpnlMain.ResumeLayout(false);
            tblpnlMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLog;
        private TableLayoutPanel tblpnlMain;
        private Panel pnlTextLable;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label lblConnectionSting;
        private Label lblSourceFile;
        private Label lblProjectLocation;
        private Label lblProjectName;
        private Label label2;
        private Panel pnlInputFields;
        private Label label9;
        private Label label8;
        private Label lblValidProjName;
        private Label lblvalidConnStr;
        public TextBox txtConnectionString;
        private TextBox txtSourceFilePath;
        private TextBox txtProjectLocationPath;
        private TextBox txtProjectName;
        private Panel pnlProgressBar;
        private ProgressBar progressBar;
        private Panel pnlProgressStatus;
        private Label lblProgressStatus;
        private Label lblValidProjSource;
        private Label lblValidProjLoc;
        private Button btnProjectLocation;
        private Button btnAdd;
        private Button btnCreate;
        private Button btnSourcefile;
        private OpenFileDialog openFileDialog;
        private RichTextBox txtLog;
        private DataGridView dgTable;
        private DataGridView dgSP;
        private Button btnValidate;
        private DataGridViewTextBoxColumn SPColName;
        private DataGridViewCheckBoxColumn spGet;
        private DataGridViewCheckBoxColumn spPost;
        private DataGridViewTextBoxColumn ColName;
        private DataGridViewCheckBoxColumn Get;
        private DataGridViewCheckBoxColumn GetAll;
        private DataGridViewCheckBoxColumn Insert;
        private DataGridViewCheckBoxColumn Update;
        private DataGridViewCheckBoxColumn Delete;
    }
}