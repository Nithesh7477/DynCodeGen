namespace DynCodeGen.UserControls
{
    partial class CreateControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateControl));
            pnlLog = new Panel();
            txtLog = new RichTextBox();
            pnlProgressStatus = new Panel();
            lblProgressStatus = new Label();
            pnlProgressBar = new Panel();
            progressBar = new ProgressBar();
            pnlInputFields = new Panel();
            lblValidProjSource = new Label();
            lblValidProjLoc = new Label();
            lblValidProjName = new Label();
            lblvalidConnStr = new Label();
            btnCreate = new Bunifu.Framework.UI.BunifuFlatButton();
            btnSourcefile = new Bunifu.Framework.UI.BunifuThinButton2();
            btnProjectLocation = new Bunifu.Framework.UI.BunifuThinButton2();
            btnAdd = new Bunifu.Framework.UI.BunifuThinButton2();
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
            openFileDialogbox = new OpenFileDialog();
            pnlLog.SuspendLayout();
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
            pnlLog.Controls.Add(txtLog);
            pnlLog.Dock = DockStyle.Fill;
            pnlLog.Location = new Point(3, 286);
            pnlLog.Name = "pnlLog";
            pnlLog.Size = new Size(1008, 213);
            pnlLog.TabIndex = 5;
            // 
            // txtLog
            // 
            txtLog.BorderStyle = BorderStyle.None;
            txtLog.Dock = DockStyle.Fill;
            txtLog.Location = new Point(0, 0);
            txtLog.Name = "txtLog";
            txtLog.Size = new Size(1006, 211);
            txtLog.TabIndex = 0;
            txtLog.Text = "";
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
            pnlInputFields.Controls.Add(lblValidProjSource);
            pnlInputFields.Controls.Add(lblValidProjLoc);
            pnlInputFields.Controls.Add(lblValidProjName);
            pnlInputFields.Controls.Add(lblvalidConnStr);
            pnlInputFields.Controls.Add(btnCreate);
            pnlInputFields.Controls.Add(btnSourcefile);
            pnlInputFields.Controls.Add(btnProjectLocation);
            pnlInputFields.Controls.Add(btnAdd);
            pnlInputFields.Controls.Add(txtConnectionString);
            pnlInputFields.Controls.Add(txtSourceFilePath);
            pnlInputFields.Controls.Add(txtProjectLocationPath);
            pnlInputFields.Controls.Add(txtProjectName);
            pnlInputFields.Dock = DockStyle.Fill;
            pnlInputFields.Location = new Point(308, 3);
            pnlInputFields.Name = "pnlInputFields";
            pnlInputFields.Size = new Size(703, 277);
            pnlInputFields.TabIndex = 1;
            // 
            // lblValidProjSource
            // 
            lblValidProjSource.AutoSize = true;
            lblValidProjSource.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblValidProjSource.ForeColor = Color.Red;
            lblValidProjSource.Location = new Point(45, 214);
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
            lblValidProjLoc.Location = new Point(45, 158);
            lblValidProjLoc.Name = "lblValidProjLoc";
            lblValidProjLoc.Size = new Size(171, 17);
            lblValidProjLoc.TabIndex = 13;
            lblValidProjLoc.Text = "Project Location is required.";
            lblValidProjLoc.Visible = false;
            lblValidProjLoc.Click += lblValidProjLoc_Click;
            // 
            // lblValidProjName
            // 
            lblValidProjName.AutoSize = true;
            lblValidProjName.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblValidProjName.ForeColor = Color.Red;
            lblValidProjName.Location = new Point(45, 104);
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
            lblvalidConnStr.Location = new Point(45, 51);
            lblvalidConnStr.Name = "lblvalidConnStr";
            lblvalidConnStr.Size = new Size(181, 17);
            lblvalidConnStr.TabIndex = 8;
            lblvalidConnStr.Text = "Connection String is required.";
            lblvalidConnStr.Visible = false;
            // 
            // btnCreate
            // 
            btnCreate.Active = false;
            btnCreate.Activecolor = Color.FromArgb(46, 139, 87);
            btnCreate.BackColor = Color.FromArgb(46, 139, 87);
            btnCreate.BackgroundImageLayout = ImageLayout.Stretch;
            btnCreate.BorderRadius = 6;
            btnCreate.ButtonText = "Create";
            btnCreate.DisabledColor = Color.Gray;
            btnCreate.Iconcolor = Color.Transparent;
            btnCreate.Iconimage = (Image)resources.GetObject("btnCreate.Iconimage");
            btnCreate.Iconimage_right = null;
            btnCreate.Iconimage_right_Selected = null;
            btnCreate.Iconimage_Selected = null;
            btnCreate.IconMarginLeft = 0;
            btnCreate.IconMarginRight = 0;
            btnCreate.IconRightVisible = true;
            btnCreate.IconRightZoom = 0D;
            btnCreate.IconVisible = true;
            btnCreate.IconZoom = 90D;
            btnCreate.IsTab = false;
            btnCreate.Location = new Point(256, 232);
            btnCreate.Margin = new Padding(5, 4, 5, 4);
            btnCreate.Name = "btnCreate";
            btnCreate.Normalcolor = Color.FromArgb(46, 139, 87);
            btnCreate.OnHovercolor = Color.FromArgb(36, 129, 77);
            btnCreate.OnHoverTextColor = Color.White;
            btnCreate.selected = false;
            btnCreate.Size = new Size(138, 39);
            btnCreate.TabIndex = 5;
            btnCreate.Text = "Create";
            btnCreate.TextAlign = ContentAlignment.MiddleLeft;
            btnCreate.Textcolor = Color.White;
            btnCreate.TextFont = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreate.Click += btnCreate_Click;
            // 
            // btnSourcefile
            // 
            btnSourcefile.ActiveBorderThickness = 1;
            btnSourcefile.ActiveCornerRadius = 20;
            btnSourcefile.ActiveFillColor = Color.SeaGreen;
            btnSourcefile.ActiveForecolor = Color.White;
            btnSourcefile.ActiveLineColor = Color.SeaGreen;
            btnSourcefile.BackColor = SystemColors.Window;
            btnSourcefile.BackgroundImage = (Image)resources.GetObject("btnSourcefile.BackgroundImage");
            btnSourcefile.ButtonText = "Browse";
            btnSourcefile.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnSourcefile.ForeColor = Color.SeaGreen;
            btnSourcefile.IdleBorderThickness = 1;
            btnSourcefile.IdleCornerRadius = 20;
            btnSourcefile.IdleFillColor = Color.White;
            btnSourcefile.IdleForecolor = Color.SeaGreen;
            btnSourcefile.IdleLineColor = Color.SeaGreen;
            btnSourcefile.Location = new Point(559, 175);
            btnSourcefile.Margin = new Padding(5);
            btnSourcefile.Name = "btnSourcefile";
            btnSourcefile.Size = new Size(87, 43);
            btnSourcefile.TabIndex = 4;
            btnSourcefile.TextAlign = ContentAlignment.MiddleCenter;
            btnSourcefile.Click += btnSourcefile_Click;
            // 
            // btnProjectLocation
            // 
            btnProjectLocation.ActiveBorderThickness = 1;
            btnProjectLocation.ActiveCornerRadius = 20;
            btnProjectLocation.ActiveFillColor = Color.SeaGreen;
            btnProjectLocation.ActiveForecolor = Color.White;
            btnProjectLocation.ActiveLineColor = Color.SeaGreen;
            btnProjectLocation.BackColor = SystemColors.Window;
            btnProjectLocation.BackgroundImage = (Image)resources.GetObject("btnProjectLocation.BackgroundImage");
            btnProjectLocation.ButtonText = "Select";
            btnProjectLocation.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnProjectLocation.ForeColor = Color.SeaGreen;
            btnProjectLocation.IdleBorderThickness = 1;
            btnProjectLocation.IdleCornerRadius = 20;
            btnProjectLocation.IdleFillColor = Color.White;
            btnProjectLocation.IdleForecolor = Color.SeaGreen;
            btnProjectLocation.IdleLineColor = Color.SeaGreen;
            btnProjectLocation.Location = new Point(559, 119);
            btnProjectLocation.Margin = new Padding(5);
            btnProjectLocation.Name = "btnProjectLocation";
            btnProjectLocation.Size = new Size(87, 41);
            btnProjectLocation.TabIndex = 3;
            btnProjectLocation.TextAlign = ContentAlignment.MiddleCenter;
            btnProjectLocation.Click += btnProjectLocation_Click;
            // 
            // btnAdd
            // 
            btnAdd.ActiveBorderThickness = 1;
            btnAdd.ActiveCornerRadius = 20;
            btnAdd.ActiveFillColor = Color.SeaGreen;
            btnAdd.ActiveForecolor = Color.White;
            btnAdd.ActiveLineColor = Color.SeaGreen;
            btnAdd.BackColor = SystemColors.Window;
            btnAdd.BackgroundImage = (Image)resources.GetObject("btnAdd.BackgroundImage");
            btnAdd.ButtonText = "Build";
            btnAdd.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.SeaGreen;
            btnAdd.IdleBorderThickness = 1;
            btnAdd.IdleCornerRadius = 20;
            btnAdd.IdleFillColor = Color.White;
            btnAdd.IdleForecolor = Color.SeaGreen;
            btnAdd.IdleLineColor = Color.SeaGreen;
            btnAdd.Location = new Point(559, 13);
            btnAdd.Margin = new Padding(5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(87, 43);
            btnAdd.TabIndex = 1;
            btnAdd.TextAlign = ContentAlignment.MiddleCenter;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtConnectionString
            // 
            txtConnectionString.Cursor = Cursors.IBeam;
            txtConnectionString.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtConnectionString.Location = new Point(45, 20);
            txtConnectionString.Margin = new Padding(0);
            txtConnectionString.Name = "txtConnectionString";
            txtConnectionString.ReadOnly = true;
            txtConnectionString.Size = new Size(494, 31);
            txtConnectionString.TabIndex = 0;
            // 
            // txtSourceFilePath
            // 
            txtSourceFilePath.Cursor = Cursors.IBeam;
            txtSourceFilePath.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtSourceFilePath.Location = new Point(45, 181);
            txtSourceFilePath.Name = "txtSourceFilePath";
            txtSourceFilePath.ReadOnly = true;
            txtSourceFilePath.Size = new Size(494, 31);
            txtSourceFilePath.TabIndex = 4;
            // 
            // txtProjectLocationPath
            // 
            txtProjectLocationPath.Cursor = Cursors.IBeam;
            txtProjectLocationPath.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtProjectLocationPath.Location = new Point(45, 125);
            txtProjectLocationPath.Name = "txtProjectLocationPath";
            txtProjectLocationPath.ReadOnly = true;
            txtProjectLocationPath.Size = new Size(494, 31);
            txtProjectLocationPath.TabIndex = 3;
            // 
            // txtProjectName
            // 
            txtProjectName.Cursor = Cursors.IBeam;
            txtProjectName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtProjectName.Location = new Point(45, 73);
            txtProjectName.Name = "txtProjectName";
            txtProjectName.Size = new Size(494, 31);
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
            // openFileDialogbox
            // 
            openFileDialogbox.FileName = "openFileDialog";
            // 
            // CreateControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            Controls.Add(tblpnlMain);
            Name = "CreateControl";
            Size = new Size(1015, 604);
            pnlLog.ResumeLayout(false);
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
        private Bunifu.Framework.UI.BunifuFlatButton btnCreate;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSourcefile;
        private Bunifu.Framework.UI.BunifuThinButton2 btnProjectLocation;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAdd;
        public TextBox txtConnectionString;
        private TextBox txtSourceFilePath;
        private TextBox txtProjectLocationPath;
        private TextBox txtProjectName;
        private Panel pnlProgressBar;
        private ProgressBar progressBar;
        private Panel pnlProgressStatus;
        private Label lblProgressStatus;
        private RichTextBox txtLog;
        private Label lblValidProjSource;
        private Label lblValidProjLoc;
        private OpenFileDialog openFileDialogbox;
    }
}
