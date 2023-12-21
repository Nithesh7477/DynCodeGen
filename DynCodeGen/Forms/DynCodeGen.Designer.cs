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
            btnCPWithEntity = new Button();
            btnCPWithoutEntity = new Button();
            existingProjectContainer = new FlowLayoutPanel();
            btnExistingProject = new Button();
            btnEPWithEntity = new Button();
            btnEPWithoutEntity = new Button();
            btnCreateModal = new Button();
            CreateProjectTranstion = new System.Windows.Forms.Timer(components);
            existingProjectTanstion = new System.Windows.Forms.Timer(components);
            btnClose = new Button();
            panel3 = new Panel();
            pnlHeader = new Panel();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            panel1 = new Panel();
            dexianLogo = new PictureBox();
            lblHead = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            contentPanel = new Panel();
            flowLayoutPanel1.SuspendLayout();
            CreateProjectContainer.SuspendLayout();
            existingProjectContainer.SuspendLayout();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dexianLogo).BeginInit();
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
            flowLayoutPanel1.Controls.Add(btnCreateModal);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 55);
            flowLayoutPanel1.Margin = new Padding(15, 10, 3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(309, 662);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // btnHome
            // 
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnHome.ForeColor = Color.LightGray;
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(0, 20);
            btnHome.Margin = new Padding(0, 20, 0, 0);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(306, 50);
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
            CreateProjectContainer.Controls.Add(btnCPWithEntity);
            CreateProjectContainer.Controls.Add(btnCPWithoutEntity);
            CreateProjectContainer.Location = new Point(0, 70);
            CreateProjectContainer.Margin = new Padding(0);
            CreateProjectContainer.Name = "CreateProjectContainer";
            CreateProjectContainer.Size = new Size(306, 50);
            CreateProjectContainer.TabIndex = 6;
            // 
            // btnCreateProject
            // 
            btnCreateProject.BackColor = Color.FromArgb(29, 51, 92);
            btnCreateProject.FlatAppearance.BorderSize = 0;
            btnCreateProject.FlatStyle = FlatStyle.Flat;
            btnCreateProject.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreateProject.ForeColor = Color.LightGray;
            btnCreateProject.Location = new Point(0, 0);
            btnCreateProject.Margin = new Padding(0);
            btnCreateProject.Name = "btnCreateProject";
            btnCreateProject.Size = new Size(306, 50);
            btnCreateProject.TabIndex = 1;
            btnCreateProject.Text = "Create Project";
            btnCreateProject.TextAlign = ContentAlignment.MiddleLeft;
            btnCreateProject.UseVisualStyleBackColor = false;
            btnCreateProject.Click += btnCreateProject_Click;
            // 
            // btnCPWithEntity
            // 
            btnCPWithEntity.BackColor = Color.FromArgb(29, 51, 92);
            btnCPWithEntity.FlatAppearance.BorderSize = 0;
            btnCPWithEntity.FlatStyle = FlatStyle.Flat;
            btnCPWithEntity.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnCPWithEntity.ForeColor = Color.LightGray;
            btnCPWithEntity.Location = new Point(0, 50);
            btnCPWithEntity.Margin = new Padding(0);
            btnCPWithEntity.Name = "btnCPWithEntity";
            btnCPWithEntity.Padding = new Padding(34, 0, 0, 0);
            btnCPWithEntity.Size = new Size(306, 50);
            btnCPWithEntity.TabIndex = 0;
            btnCPWithEntity.Text = "With Entity";
            btnCPWithEntity.TextAlign = ContentAlignment.MiddleLeft;
            btnCPWithEntity.UseVisualStyleBackColor = false;
            btnCPWithEntity.Click += btnCPWithEntity_Click;
            // 
            // btnCPWithoutEntity
            // 
            btnCPWithoutEntity.BackColor = Color.FromArgb(29, 51, 92);
            btnCPWithoutEntity.FlatAppearance.BorderSize = 0;
            btnCPWithoutEntity.FlatStyle = FlatStyle.Flat;
            btnCPWithoutEntity.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnCPWithoutEntity.ForeColor = Color.LightGray;
            btnCPWithoutEntity.Location = new Point(0, 100);
            btnCPWithoutEntity.Margin = new Padding(0);
            btnCPWithoutEntity.Name = "btnCPWithoutEntity";
            btnCPWithoutEntity.Padding = new Padding(34, 0, 0, 0);
            btnCPWithoutEntity.Size = new Size(306, 50);
            btnCPWithoutEntity.TabIndex = 2;
            btnCPWithoutEntity.Text = "Without Entity";
            btnCPWithoutEntity.TextAlign = ContentAlignment.MiddleLeft;
            btnCPWithoutEntity.UseVisualStyleBackColor = false;
            btnCPWithoutEntity.Click += btnCPWithoutEntity_Click;
            // 
            // existingProjectContainer
            // 
            existingProjectContainer.BackColor = Color.FromArgb(29, 51, 92);
            existingProjectContainer.Controls.Add(btnExistingProject);
            existingProjectContainer.Controls.Add(btnEPWithEntity);
            existingProjectContainer.Controls.Add(btnEPWithoutEntity);
            existingProjectContainer.Location = new Point(0, 120);
            existingProjectContainer.Margin = new Padding(0);
            existingProjectContainer.Name = "existingProjectContainer";
            existingProjectContainer.Size = new Size(306, 50);
            existingProjectContainer.TabIndex = 7;
            // 
            // btnExistingProject
            // 
            btnExistingProject.BackColor = Color.FromArgb(29, 51, 92);
            btnExistingProject.FlatAppearance.BorderSize = 0;
            btnExistingProject.FlatStyle = FlatStyle.Flat;
            btnExistingProject.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnExistingProject.ForeColor = Color.LightGray;
            btnExistingProject.Location = new Point(0, 0);
            btnExistingProject.Margin = new Padding(0);
            btnExistingProject.Name = "btnExistingProject";
            btnExistingProject.Size = new Size(306, 50);
            btnExistingProject.TabIndex = 1;
            btnExistingProject.Text = "Enhance Project";
            btnExistingProject.TextAlign = ContentAlignment.MiddleLeft;
            btnExistingProject.UseVisualStyleBackColor = false;
            btnExistingProject.Click += btnExistingProject_Click;
            // 
            // btnEPWithEntity
            // 
            btnEPWithEntity.BackColor = Color.FromArgb(29, 51, 92);
            btnEPWithEntity.FlatAppearance.BorderSize = 0;
            btnEPWithEntity.FlatStyle = FlatStyle.Flat;
            btnEPWithEntity.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnEPWithEntity.ForeColor = Color.LightGray;
            btnEPWithEntity.Location = new Point(0, 50);
            btnEPWithEntity.Margin = new Padding(0);
            btnEPWithEntity.Name = "btnEPWithEntity";
            btnEPWithEntity.Padding = new Padding(34, 0, 0, 0);
            btnEPWithEntity.Size = new Size(306, 50);
            btnEPWithEntity.TabIndex = 0;
            btnEPWithEntity.Text = "With Entity";
            btnEPWithEntity.TextAlign = ContentAlignment.MiddleLeft;
            btnEPWithEntity.UseVisualStyleBackColor = false;
            btnEPWithEntity.Click += btnEPWithEntity_Click;
            // 
            // btnEPWithoutEntity
            // 
            btnEPWithoutEntity.BackColor = Color.FromArgb(29, 51, 92);
            btnEPWithoutEntity.FlatAppearance.BorderSize = 0;
            btnEPWithoutEntity.FlatStyle = FlatStyle.Flat;
            btnEPWithoutEntity.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnEPWithoutEntity.ForeColor = Color.LightGray;
            btnEPWithoutEntity.Location = new Point(0, 100);
            btnEPWithoutEntity.Margin = new Padding(0);
            btnEPWithoutEntity.Name = "btnEPWithoutEntity";
            btnEPWithoutEntity.Padding = new Padding(34, 0, 0, 0);
            btnEPWithoutEntity.Size = new Size(306, 50);
            btnEPWithoutEntity.TabIndex = 2;
            btnEPWithoutEntity.Text = "Without Entity";
            btnEPWithoutEntity.TextAlign = ContentAlignment.MiddleLeft;
            btnEPWithoutEntity.UseVisualStyleBackColor = false;
            // 
            // btnCreateModal
            // 
            btnCreateModal.FlatAppearance.BorderSize = 0;
            btnCreateModal.FlatStyle = FlatStyle.Flat;
            btnCreateModal.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreateModal.ForeColor = Color.LightGray;
            btnCreateModal.Location = new Point(0, 170);
            btnCreateModal.Margin = new Padding(0);
            btnCreateModal.Name = "btnCreateModal";
            btnCreateModal.Size = new Size(306, 50);
            btnCreateModal.TabIndex = 8;
            btnCreateModal.Text = "Create Model";
            btnCreateModal.TextAlign = ContentAlignment.MiddleLeft;
            btnCreateModal.UseVisualStyleBackColor = true;
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
            btnClose.Location = new Point(1294, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(30, 30);
            btnClose.TabIndex = 3;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // panel3
            // 
            panel3.Location = new Point(0, 79);
            panel3.Name = "panel3";
            panel3.Size = new Size(317, 64);
            panel3.TabIndex = 4;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(249, 249, 249);
            pnlHeader.Controls.Add(panel1);
            pnlHeader.Controls.Add(pictureBox1);
            pnlHeader.Controls.Add(button1);
            pnlHeader.Controls.Add(panel3);
            pnlHeader.Controls.Add(btnClose);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1332, 55);
            pnlHeader.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Group_16975;
            pictureBox1.Location = new Point(312, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(198, 49);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(1247, 12);
            button1.Name = "button1";
            button1.Size = new Size(35, 31);
            button1.TabIndex = 7;
            button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(29, 51, 92);
            panel1.Controls.Add(dexianLogo);
            panel1.Location = new Point(-1, 3);
            panel1.Margin = new Padding(0, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(311, 55);
            panel1.TabIndex = 5;
            // 
            // dexianLogo
            // 
            dexianLogo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dexianLogo.Image = (Image)resources.GetObject("dexianLogo.Image");
            dexianLogo.Location = new Point(81, 0);
            dexianLogo.Margin = new Padding(0);
            dexianLogo.Name = "dexianLogo";
            dexianLogo.Size = new Size(151, 55);
            dexianLogo.TabIndex = 0;
            dexianLogo.TabStop = false;
            // 
            // lblHead
            // 
            lblHead.AutoSize = true;
            lblHead.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblHead.ForeColor = Color.Black;
            lblHead.Location = new Point(317, 73);
            lblHead.Name = "lblHead";
            lblHead.Size = new Size(59, 23);
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
            contentPanel.Location = new Point(312, 111);
            contentPanel.Margin = new Padding(3, 3, 0, 3);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(1015, 607);
            contentPanel.TabIndex = 3;
            contentPanel.Paint += contentPanel_Paint;
            // 
            // DynCodeGen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1332, 717);
            Controls.Add(contentPanel);
            Controls.Add(lblHead);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "DynCodeGen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DynCodeGen";
            Load += DynCodeGen_Load;
            flowLayoutPanel1.ResumeLayout(false);
            CreateProjectContainer.ResumeLayout(false);
            existingProjectContainer.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dexianLogo).EndInit();
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
        private Button btnCPWithEntity;
        private Button btnCPWithoutEntity;
        private System.Windows.Forms.Timer CreateProjectTranstion;
        private FlowLayoutPanel existingProjectContainer;
        private Button btnExistingProject;
        private Button btnEPWithoutEntity;
        private Button btnEPWithEntity;
        private System.Windows.Forms.Timer existingProjectTanstion;
        private Button btnCreateModal;
        private Button btnClose;
        private Panel panel3;
        private Panel pnlHeader;
        private Panel panel1;
        private Label lblHead;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Button button1;
        private Panel contentPanel;
        private PictureBox dexianLogo;
        private PictureBox pictureBox1;
    }
}