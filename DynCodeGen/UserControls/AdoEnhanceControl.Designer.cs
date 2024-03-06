namespace DynCodeGen.UserControls
{
    partial class AdoEnhanceControl
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
            DataGridViewCellStyle dataGridViewCellStyle21 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle22 = new DataGridViewCellStyle();
            tblpnlMain = new TableLayoutPanel();
            pnlTextLable = new Panel();
            label5 = new Label();
            label4 = new Label();
            lblSourceFile = new Label();
            lblProjectLocation = new Label();
            pnlInputFields = new Panel();
            btnValidate = new Button();
            btnCreate = new Button();
            btnSourcefile = new Button();
            btnProjectLocation = new Button();
            lblValidProjSource = new Label();
            lblValidProjLoc = new Label();
            txtSourceFilePath = new TextBox();
            txtProjectLocationPath = new TextBox();
            pnlProgressBar = new Panel();
            progressBar = new ProgressBar();
            pnlProgressStatus = new Panel();
            lblProgressStatus = new Label();
            pnlLog = new Panel();
            dgTable = new DataGridView();
            txtLog = new RichTextBox();
            openFileDialog = new OpenFileDialog();
            tblpnlMain.SuspendLayout();
            pnlTextLable.SuspendLayout();
            pnlInputFields.SuspendLayout();
            pnlProgressBar.SuspendLayout();
            pnlProgressStatus.SuspendLayout();
            pnlLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgTable).BeginInit();
            SuspendLayout();
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
            tblpnlMain.Location = new Point(0, 4);
            tblpnlMain.Name = "tblpnlMain";
            tblpnlMain.RowCount = 4;
            tblpnlMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblpnlMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 219F));
            tblpnlMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tblpnlMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 51F));
            tblpnlMain.Size = new Size(1014, 597);
            tblpnlMain.TabIndex = 3;
            // 
            // pnlTextLable
            // 
            pnlTextLable.BackColor = SystemColors.Window;
            pnlTextLable.Controls.Add(label5);
            pnlTextLable.Controls.Add(label4);
            pnlTextLable.Controls.Add(lblSourceFile);
            pnlTextLable.Controls.Add(lblProjectLocation);
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
            label5.Location = new Point(154, 143);
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
            label4.Location = new Point(153, 50);
            label4.Name = "label4";
            label4.Size = new Size(16, 20);
            label4.TabIndex = 6;
            label4.Text = "*";
            // 
            // lblSourceFile
            // 
            lblSourceFile.AutoSize = true;
            lblSourceFile.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblSourceFile.Location = new Point(25, 146);
            lblSourceFile.Name = "lblSourceFile";
            lblSourceFile.Size = new Size(133, 23);
            lblSourceFile.TabIndex = 2;
            lblSourceFile.Text = "Source File(.xlsx)";
            // 
            // lblProjectLocation
            // 
            lblProjectLocation.AutoSize = true;
            lblProjectLocation.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblProjectLocation.Location = new Point(25, 51);
            lblProjectLocation.Name = "lblProjectLocation";
            lblProjectLocation.Size = new Size(133, 23);
            lblProjectLocation.TabIndex = 1;
            lblProjectLocation.Text = "Project Location";
            // 
            // pnlInputFields
            // 
            pnlInputFields.AutoSize = true;
            pnlInputFields.BackColor = SystemColors.Window;
            pnlInputFields.Controls.Add(btnValidate);
            pnlInputFields.Controls.Add(btnCreate);
            pnlInputFields.Controls.Add(btnSourcefile);
            pnlInputFields.Controls.Add(btnProjectLocation);
            pnlInputFields.Controls.Add(lblValidProjSource);
            pnlInputFields.Controls.Add(lblValidProjLoc);
            pnlInputFields.Controls.Add(txtSourceFilePath);
            pnlInputFields.Controls.Add(txtProjectLocationPath);
            pnlInputFields.Dock = DockStyle.Fill;
            pnlInputFields.Location = new Point(308, 3);
            pnlInputFields.Name = "pnlInputFields";
            pnlInputFields.Size = new Size(703, 277);
            pnlInputFields.TabIndex = 1;
            // 
            // btnValidate
            // 
            btnValidate.BackColor = Color.FromArgb(29, 51, 92);
            btnValidate.Cursor = Cursors.Hand;
            btnValidate.FlatStyle = FlatStyle.Flat;
            btnValidate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnValidate.ForeColor = Color.White;
            btnValidate.Location = new Point(12, 231);
            btnValidate.Name = "btnValidate";
            btnValidate.Size = new Size(127, 43);
            btnValidate.TabIndex = 19;
            btnValidate.Text = "Validate";
            btnValidate.UseVisualStyleBackColor = false;
            btnValidate.Click += btnValidate_Click;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.FromArgb(29, 51, 92);
            btnCreate.Cursor = Cursors.Hand;
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(143, 231);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(127, 43);
            btnCreate.TabIndex = 18;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnSourcefile
            // 
            btnSourcefile.Cursor = Cursors.Hand;
            btnSourcefile.FlatStyle = FlatStyle.Flat;
            btnSourcefile.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSourcefile.ForeColor = Color.FromArgb(29, 51, 92);
            btnSourcefile.Location = new Point(580, 141);
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
            btnProjectLocation.Location = new Point(580, 46);
            btnProjectLocation.Name = "btnProjectLocation";
            btnProjectLocation.Size = new Size(92, 31);
            btnProjectLocation.TabIndex = 16;
            btnProjectLocation.Text = "Select";
            btnProjectLocation.UseVisualStyleBackColor = true;
            btnProjectLocation.Click += btnProjectLocation_Click;
            // 
            // lblValidProjSource
            // 
            lblValidProjSource.AutoSize = true;
            lblValidProjSource.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblValidProjSource.ForeColor = Color.Red;
            lblValidProjSource.Location = new Point(13, 182);
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
            lblValidProjLoc.Location = new Point(13, 87);
            lblValidProjLoc.Name = "lblValidProjLoc";
            lblValidProjLoc.Size = new Size(171, 17);
            lblValidProjLoc.TabIndex = 13;
            lblValidProjLoc.Text = "Project Location is required.";
            lblValidProjLoc.Visible = false;
            // 
            // txtSourceFilePath
            // 
            txtSourceFilePath.Cursor = Cursors.IBeam;
            txtSourceFilePath.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtSourceFilePath.Location = new Point(12, 141);
            txtSourceFilePath.Name = "txtSourceFilePath";
            txtSourceFilePath.ReadOnly = true;
            txtSourceFilePath.Size = new Size(551, 31);
            txtSourceFilePath.TabIndex = 4;
            // 
            // txtProjectLocationPath
            // 
            txtProjectLocationPath.Cursor = Cursors.IBeam;
            txtProjectLocationPath.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtProjectLocationPath.Location = new Point(12, 46);
            txtProjectLocationPath.Name = "txtProjectLocationPath";
            txtProjectLocationPath.ReadOnly = true;
            txtProjectLocationPath.Size = new Size(551, 31);
            txtProjectLocationPath.TabIndex = 3;
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
            dataGridViewCellStyle21.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = Color.FromArgb(29, 51, 92);
            dataGridViewCellStyle21.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle21.ForeColor = Color.White;
            dataGridViewCellStyle21.SelectionBackColor = Color.FromArgb(107, 125, 157);
            dataGridViewCellStyle21.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = DataGridViewTriState.True;
            dgTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            dgTable.ColumnHeadersHeight = 29;
            dgTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgTable.Cursor = Cursors.Hand;
            dataGridViewCellStyle22.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = SystemColors.Window;
            dataGridViewCellStyle22.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle22.ForeColor = Color.Black;
            dataGridViewCellStyle22.SelectionBackColor = Color.FromArgb(107, 125, 157);
            dataGridViewCellStyle22.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = DataGridViewTriState.False;
            dgTable.DefaultCellStyle = dataGridViewCellStyle22;
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
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // AdoEnhanceControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tblpnlMain);
            Name = "AdoEnhanceControl";
            Size = new Size(1015, 604);
            tblpnlMain.ResumeLayout(false);
            tblpnlMain.PerformLayout();
            pnlTextLable.ResumeLayout(false);
            pnlTextLable.PerformLayout();
            pnlInputFields.ResumeLayout(false);
            pnlInputFields.PerformLayout();
            pnlProgressBar.ResumeLayout(false);
            pnlProgressStatus.ResumeLayout(false);
            pnlProgressStatus.PerformLayout();
            pnlLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblpnlMain;
        private Panel pnlTextLable;
        private Label label5;
        private Label label4;
        private Label lblConnectionSting;
        private Label lblSourceFile;
        private Label lblProjectLocation;
        private Label label2;
        private Panel pnlInputFields;
        private Button btnValidate;
        private Button btnCreate;
        private Button btnSourcefile;
        private Button btnProjectLocation;
        private Button btnAdd;
        private Label lblValidProjSource;
        private Label lblValidProjLoc;
        private Label lblvalidConnStr;
        public TextBox txtConnectionString;
        private TextBox txtSourceFilePath;
        private TextBox txtProjectLocationPath;
        private Panel pnlProgressBar;
        private ProgressBar progressBar;
        private Panel pnlProgressStatus;
        private Label lblProgressStatus;
        private Panel pnlLog;
        private DataGridView dgTable;
        private RichTextBox txtLog;
        private OpenFileDialog openFileDialog;
    }
}