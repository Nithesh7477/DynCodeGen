namespace DynCodeGen
{
    partial class DynCodeGen
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DynCodeGen));
            folderBrowserDialog1 = new FolderBrowserDialog();
            openFileDialogbox = new OpenFileDialog();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnHome = new Button();
            CreateProjectContainer = new FlowLayoutPanel();
            btnCreateProject = new Button();
            btnCPEntityFrameworkCF = new Button();
            btnCP_ADO_SP = new Button();
            existingProjectContainer = new FlowLayoutPanel();
            btnExistingProject = new Button();
            btnEP_EntityFramework_CF = new Button();
            btnEP_EntityFramework_SP = new Button();
            btn_EP_ADO_sp = new Button();
            btnCreateModel = new Button();
            btnCPWithoutEntity = new Button();
            CreateProjectTranstion = new System.Windows.Forms.Timer(components);
            existingProjectTanstion = new System.Windows.Forms.Timer(components);
            btnClose = new Button();
            button2 = new Button();
            panel3 = new Panel();
            pnlHeader = new Panel();
            panel1 = new Panel();
            dexianLogo = new PictureBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            lblHead = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            contentPanel = new Panel();
            flowLayoutPanel1.SuspendLayout();
            CreateProjectContainer.SuspendLayout();
            existingProjectContainer.SuspendLayout();
            pnlHeader.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dexianLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // openFileDialogbox
            // 
            openFileDialogbox.FileName = "openFileDialog";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(29, 51, 92);
            flowLayoutPanel1.Controls.Add(btnHome);
            flowLayoutPanel1.Controls.Add(CreateProjectContainer);
            flowLayoutPanel1.Controls.Add(existingProjectContainer);
            flowLayoutPanel1.Controls.Add(btnCreateModel);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 41);
            flowLayoutPanel1.Margin = new Padding(13, 8, 3, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(270, 497);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // btnHome
            // 
            btnHome.Cursor = Cursors.Hand;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnHome.ForeColor = Color.LightGray;
            btnHome.Location = new Point(0, 15);
            btnHome.Margin = new Padding(0, 15, 0, 0);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(268, 38);
            btnHome.TabIndex = 0;
            btnHome.Text = "Home";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // CreateProjectContainer
            // 
            CreateProjectContainer.BackColor = Color.FromArgb(29, 51, 92);
            CreateProjectContainer.Controls.Add(btnCreateProject);
            CreateProjectContainer.Controls.Add(btnCPEntityFrameworkCF);
            CreateProjectContainer.Controls.Add(btnCP_ADO_SP);
            CreateProjectContainer.Location = new Point(0, 53);
            CreateProjectContainer.Margin = new Padding(0);
            CreateProjectContainer.Name = "CreateProjectContainer";
            CreateProjectContainer.Size = new Size(268, 38);
            CreateProjectContainer.TabIndex = 6;
            // 
            // btnCreateProject
            // 
            btnCreateProject.BackColor = Color.FromArgb(29, 51, 92);
            btnCreateProject.Cursor = Cursors.Hand;
            btnCreateProject.FlatAppearance.BorderSize = 0;
            btnCreateProject.FlatStyle = FlatStyle.Flat;
            btnCreateProject.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreateProject.ForeColor = Color.LightGray;
            btnCreateProject.Location = new Point(0, 0);
            btnCreateProject.Margin = new Padding(0);
            btnCreateProject.Name = "btnCreateProject";
            btnCreateProject.Size = new Size(268, 38);
            btnCreateProject.TabIndex = 1;
            btnCreateProject.Text = "Project Creation";
            btnCreateProject.TextAlign = ContentAlignment.MiddleLeft;
            btnCreateProject.UseVisualStyleBackColor = false;
            btnCreateProject.Click += btnCreateProject_Click;
            // 
            // btnCPEntityFrameworkCF
            // 
            btnCPEntityFrameworkCF.BackColor = Color.FromArgb(29, 51, 92);
            btnCPEntityFrameworkCF.Cursor = Cursors.Hand;
            btnCPEntityFrameworkCF.FlatAppearance.BorderSize = 0;
            btnCPEntityFrameworkCF.FlatStyle = FlatStyle.Flat;
            btnCPEntityFrameworkCF.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCPEntityFrameworkCF.ForeColor = Color.LightGray;
            btnCPEntityFrameworkCF.Location = new Point(0, 38);
            btnCPEntityFrameworkCF.Margin = new Padding(0);
            btnCPEntityFrameworkCF.Name = "btnCPEntityFrameworkCF";
            btnCPEntityFrameworkCF.Padding = new Padding(30, 0, 0, 0);
            btnCPEntityFrameworkCF.Size = new Size(268, 38);
            btnCPEntityFrameworkCF.TabIndex = 0;
            btnCPEntityFrameworkCF.Text = "Entity Framework-Code First";
            btnCPEntityFrameworkCF.TextAlign = ContentAlignment.MiddleLeft;
            btnCPEntityFrameworkCF.UseVisualStyleBackColor = false;
            btnCPEntityFrameworkCF.Click += btnCPEntityFrameworkCF_Click;
            // 
            // btnCP_ADO_SP
            // 
            btnCP_ADO_SP.BackColor = Color.FromArgb(29, 51, 92);
            btnCP_ADO_SP.Cursor = Cursors.Hand;
            btnCP_ADO_SP.FlatAppearance.BorderSize = 0;
            btnCP_ADO_SP.FlatStyle = FlatStyle.Flat;
            btnCP_ADO_SP.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCP_ADO_SP.ForeColor = Color.LightGray;
            btnCP_ADO_SP.Location = new Point(0, 76);
            btnCP_ADO_SP.Margin = new Padding(0);
            btnCP_ADO_SP.Name = "btnCP_ADO_SP";
            btnCP_ADO_SP.Padding = new Padding(30, 0, 0, 0);
            btnCP_ADO_SP.Size = new Size(268, 38);
            btnCP_ADO_SP.TabIndex = 2;
            btnCP_ADO_SP.Text = "ADO.Net - SP";
            btnCP_ADO_SP.TextAlign = ContentAlignment.MiddleLeft;
            btnCP_ADO_SP.UseVisualStyleBackColor = false;
            btnCP_ADO_SP.Click += btnCP_ADO_SP_Click;
            // 
            // existingProjectContainer
            // 
            existingProjectContainer.BackColor = Color.FromArgb(29, 51, 92);
            existingProjectContainer.Controls.Add(btnExistingProject);
            existingProjectContainer.Controls.Add(btnEP_EntityFramework_CF);
            existingProjectContainer.Controls.Add(btnEP_EntityFramework_SP);
            existingProjectContainer.Controls.Add(btn_EP_ADO_sp);
            existingProjectContainer.Location = new Point(0, 91);
            existingProjectContainer.Margin = new Padding(0);
            existingProjectContainer.Name = "existingProjectContainer";
            existingProjectContainer.Size = new Size(268, 38);
            existingProjectContainer.TabIndex = 7;
            // 
            // btnExistingProject
            // 
            btnExistingProject.BackColor = Color.FromArgb(29, 51, 92);
            btnExistingProject.Cursor = Cursors.Hand;
            btnExistingProject.FlatAppearance.BorderSize = 0;
            btnExistingProject.FlatStyle = FlatStyle.Flat;
            btnExistingProject.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnExistingProject.ForeColor = Color.LightGray;
            btnExistingProject.Location = new Point(0, 0);
            btnExistingProject.Margin = new Padding(0);
            btnExistingProject.Name = "btnExistingProject";
            btnExistingProject.Size = new Size(268, 38);
            btnExistingProject.TabIndex = 1;
            btnExistingProject.Text = "Project Enhancement";
            btnExistingProject.TextAlign = ContentAlignment.MiddleLeft;
            btnExistingProject.UseVisualStyleBackColor = false;
            btnExistingProject.Click += btnExistingProject_Click;
            // 
            // btnEP_EntityFramework_CF
            // 
            btnEP_EntityFramework_CF.BackColor = Color.FromArgb(29, 51, 92);
            btnEP_EntityFramework_CF.Cursor = Cursors.Hand;
            btnEP_EntityFramework_CF.FlatAppearance.BorderSize = 0;
            btnEP_EntityFramework_CF.FlatStyle = FlatStyle.Flat;
            btnEP_EntityFramework_CF.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnEP_EntityFramework_CF.ForeColor = Color.LightGray;
            btnEP_EntityFramework_CF.Location = new Point(0, 38);
            btnEP_EntityFramework_CF.Margin = new Padding(0);
            btnEP_EntityFramework_CF.Name = "btnEP_EntityFramework_CF";
            btnEP_EntityFramework_CF.Padding = new Padding(30, 0, 0, 0);
            btnEP_EntityFramework_CF.Size = new Size(268, 38);
            btnEP_EntityFramework_CF.TabIndex = 0;
            btnEP_EntityFramework_CF.Text = "Entity Framework-Code First";
            btnEP_EntityFramework_CF.TextAlign = ContentAlignment.MiddleLeft;
            btnEP_EntityFramework_CF.UseVisualStyleBackColor = false;
            btnEP_EntityFramework_CF.Click += btnEP_EntityFramework_CF_Click;
            // 
            // btnEP_EntityFramework_SP
            // 
            btnEP_EntityFramework_SP.BackColor = Color.FromArgb(29, 51, 92);
            btnEP_EntityFramework_SP.Cursor = Cursors.Hand;
            btnEP_EntityFramework_SP.FlatAppearance.BorderSize = 0;
            btnEP_EntityFramework_SP.FlatStyle = FlatStyle.Flat;
            btnEP_EntityFramework_SP.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnEP_EntityFramework_SP.ForeColor = Color.LightGray;
            btnEP_EntityFramework_SP.Location = new Point(0, 76);
            btnEP_EntityFramework_SP.Margin = new Padding(0);
            btnEP_EntityFramework_SP.Name = "btnEP_EntityFramework_SP";
            btnEP_EntityFramework_SP.Padding = new Padding(30, 0, 0, 0);
            btnEP_EntityFramework_SP.Size = new Size(268, 38);
            btnEP_EntityFramework_SP.TabIndex = 2;
            btnEP_EntityFramework_SP.Text = "Entity Framework- SP";
            btnEP_EntityFramework_SP.TextAlign = ContentAlignment.MiddleLeft;
            btnEP_EntityFramework_SP.UseVisualStyleBackColor = false;
            btnEP_EntityFramework_SP.Click += btnEP_EntityFramework_SP_Click;
            // 
            // btn_EP_ADO_sp
            // 
            btn_EP_ADO_sp.BackColor = Color.FromArgb(29, 51, 92);
            btn_EP_ADO_sp.Cursor = Cursors.Hand;
            btn_EP_ADO_sp.FlatAppearance.BorderSize = 0;
            btn_EP_ADO_sp.FlatStyle = FlatStyle.Flat;
            btn_EP_ADO_sp.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_EP_ADO_sp.ForeColor = Color.LightGray;
            btn_EP_ADO_sp.Location = new Point(0, 114);
            btn_EP_ADO_sp.Margin = new Padding(0);
            btn_EP_ADO_sp.Name = "btn_EP_ADO_sp";
            btn_EP_ADO_sp.Padding = new Padding(30, 0, 0, 0);
            btn_EP_ADO_sp.Size = new Size(268, 38);
            btn_EP_ADO_sp.TabIndex = 3;
            btn_EP_ADO_sp.Text = "ADO.Net - SP";
            btn_EP_ADO_sp.TextAlign = ContentAlignment.MiddleLeft;
            btn_EP_ADO_sp.UseVisualStyleBackColor = false;
            btn_EP_ADO_sp.Click += btn_EP_ADO_sp_Click;
            // 
            // btnCreateModel
            // 
            btnCreateModel.Cursor = Cursors.Hand;
            btnCreateModel.FlatAppearance.BorderSize = 0;
            btnCreateModel.FlatStyle = FlatStyle.Flat;
            btnCreateModel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreateModel.ForeColor = Color.LightGray;
            btnCreateModel.Location = new Point(0, 129);
            btnCreateModel.Margin = new Padding(0);
            btnCreateModel.Name = "btnCreateModel";
            btnCreateModel.Size = new Size(268, 38);
            btnCreateModel.TabIndex = 8;
            btnCreateModel.Text = "Model Creation";
            btnCreateModel.TextAlign = ContentAlignment.MiddleLeft;
            btnCreateModel.UseVisualStyleBackColor = true;
            btnCreateModel.Click += btnCreateModel_Click;
            // 
            // btnCPWithoutEntity
            // 
            btnCPWithoutEntity.Cursor = Cursors.Hand;
            btnCPWithoutEntity.Location = new Point(0, 0);
            btnCPWithoutEntity.Name = "btnCPWithoutEntity";
            btnCPWithoutEntity.Size = new Size(75, 23);
            btnCPWithoutEntity.TabIndex = 0;
            // 
            // CreateProjectTranstion
            // 
            CreateProjectTranstion.Interval = 1;
            CreateProjectTranstion.Tick += CreateProjectTranstion_Tick;
            // 
            // existingProjectTanstion
            // 
            existingProjectTanstion.Interval = 1;
            existingProjectTanstion.Tick += existingProjectTanstion_Tick;
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(1120, 6);
            btnClose.Margin = new Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(32, 30);
            btnClose.TabIndex = 3;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // button2
            // 
            button2.Location = new Point(0, 0);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Location = new Point(0, 59);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(277, 48);
            panel3.TabIndex = 4;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(249, 249, 249);
            pnlHeader.Controls.Add(panel1);
            pnlHeader.Controls.Add(pictureBox1);
            pnlHeader.Controls.Add(panel3);
            pnlHeader.Controls.Add(btnClose);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(3, 2, 3, 2);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1166, 41);
            pnlHeader.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(29, 51, 92);
            panel1.Controls.Add(dexianLogo);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(270, 41);
            panel1.TabIndex = 5;
            // 
            // dexianLogo
            // 
            dexianLogo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dexianLogo.Image = (Image)resources.GetObject("dexianLogo.Image");
            dexianLogo.Location = new Point(71, 0);
            dexianLogo.Margin = new Padding(0);
            dexianLogo.Name = "dexianLogo";
            dexianLogo.Size = new Size(130, 41);
            dexianLogo.TabIndex = 0;
            dexianLogo.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Group_16975;
            pictureBox1.Location = new Point(273, 2);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(158, 37);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(1120, 46);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(31, 33);
            button1.TabIndex = 7;
            button1.UseVisualStyleBackColor = false;
            // 
            // lblHead
            // 
            lblHead.AutoSize = true;
            lblHead.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblHead.ForeColor = Color.FromArgb(29, 51, 92);
            lblHead.Location = new Point(277, 55);
            lblHead.Name = "lblHead";
            lblHead.Size = new Size(49, 19);
            lblHead.TabIndex = 6;
            lblHead.Text = "Home";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // contentPanel
            // 
            contentPanel.BackColor = SystemColors.Window;
            contentPanel.Location = new Point(273, 83);
            contentPanel.Margin = new Padding(3, 2, 0, 2);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(888, 455);
            contentPanel.TabIndex = 3;
            // 
            // DynCodeGen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1166, 538);
            Controls.Add(contentPanel);
            Controls.Add(lblHead);
            Controls.Add(button1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "DynCodeGen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DynCodeGen";
            Load += DynCodeGen_Load;
            flowLayoutPanel1.ResumeLayout(false);
            CreateProjectContainer.ResumeLayout(false);
            existingProjectContainer.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dexianLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FolderBrowserDialog folderBrowserDialog1;
        private OpenFileDialog openFileDialogbox;
        private CheckBox chk;
        private RadioButton radioButton1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnHome;
        private FlowLayoutPanel CreateProjectContainer;
        private Button btnCreateProject;
        private Button btnCPEntityFrameworkCF;
        private Button btnCP_ADO_SP;
        private System.Windows.Forms.Timer CreateProjectTranstion;
        private FlowLayoutPanel existingProjectContainer;
        private Button btnExistingProject;
        private Button btnEP_EntityFramework_SP;
        private Button btnEP_EntityFramework_CF;
        private Button btnCPWithoutEntity;
        private Button btnCPWithEntity;
        private System.Windows.Forms.Timer existingProjectTanstion;
        private Button btnCreateModel;
        private Button btnClose;
        private Panel panel3;
        private Panel pnlHeader;
        private Panel panel1;
        public Label lblHead;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Button button1;
        private Button button2;
        private Panel contentPanel;
        private PictureBox dexianLogo;
        private PictureBox pictureBox1;
        private Button btn_EP_ADO_sp;
    }
}