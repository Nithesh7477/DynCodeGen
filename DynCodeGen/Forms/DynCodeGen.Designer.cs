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
            button1 = new Button();
            lblHead = new Label();
            panel1 = new Panel();
            label1 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            contentPanel = new Panel();
            flowLayoutPanel1.SuspendLayout();
            CreateProjectContainer.SuspendLayout();
            existingProjectContainer.SuspendLayout();
            pnlHeader.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialogbox
            // 
            openFileDialogbox.FileName = "openFileDialog1";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(197, 227, 205);
            flowLayoutPanel1.Controls.Add(btnHome);
            flowLayoutPanel1.Controls.Add(CreateProjectContainer);
            flowLayoutPanel1.Controls.Add(existingProjectContainer);
            flowLayoutPanel1.Controls.Add(btnCreateModal);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 55);
            flowLayoutPanel1.Margin = new Padding(15, 10, 3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(309, 604);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // btnHome
            // 
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnHome.ForeColor = Color.FromArgb(1, 107, 1);
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
            CreateProjectContainer.BackColor = Color.FromArgb(197, 227, 205);
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
            btnCreateProject.BackColor = Color.FromArgb(197, 227, 205);
            btnCreateProject.FlatAppearance.BorderSize = 0;
            btnCreateProject.FlatStyle = FlatStyle.Flat;
            btnCreateProject.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreateProject.ForeColor = Color.FromArgb(1, 107, 1);
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
            btnCPWithEntity.BackColor = Color.FromArgb(197, 227, 205);
            btnCPWithEntity.FlatAppearance.BorderSize = 0;
            btnCPWithEntity.FlatStyle = FlatStyle.Flat;
            btnCPWithEntity.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnCPWithEntity.ForeColor = Color.FromArgb(1, 107, 1);
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
            btnCPWithoutEntity.BackColor = Color.FromArgb(197, 227, 205);
            btnCPWithoutEntity.FlatAppearance.BorderSize = 0;
            btnCPWithoutEntity.FlatStyle = FlatStyle.Flat;
            btnCPWithoutEntity.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnCPWithoutEntity.ForeColor = Color.FromArgb(1, 107, 1);
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
            existingProjectContainer.BackColor = Color.FromArgb(197, 227, 205);
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
            btnExistingProject.BackColor = Color.FromArgb(197, 227, 205);
            btnExistingProject.FlatAppearance.BorderSize = 0;
            btnExistingProject.FlatStyle = FlatStyle.Flat;
            btnExistingProject.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnExistingProject.ForeColor = Color.FromArgb(1, 107, 1);
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
            btnEPWithEntity.BackColor = Color.FromArgb(197, 227, 205);
            btnEPWithEntity.FlatAppearance.BorderSize = 0;
            btnEPWithEntity.FlatStyle = FlatStyle.Flat;
            btnEPWithEntity.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnEPWithEntity.ForeColor = Color.FromArgb(1, 107, 1);
            btnEPWithEntity.Location = new Point(0, 50);
            btnEPWithEntity.Margin = new Padding(0);
            btnEPWithEntity.Name = "btnEPWithEntity";
            btnEPWithEntity.Padding = new Padding(34, 0, 0, 0);
            btnEPWithEntity.Size = new Size(306, 50);
            btnEPWithEntity.TabIndex = 0;
            btnEPWithEntity.Text = "With Entity";
            btnEPWithEntity.TextAlign = ContentAlignment.MiddleLeft;
            btnEPWithEntity.UseVisualStyleBackColor = false;
            // 
            // btnEPWithoutEntity
            // 
            btnEPWithoutEntity.BackColor = Color.FromArgb(197, 227, 205);
            btnEPWithoutEntity.FlatAppearance.BorderSize = 0;
            btnEPWithoutEntity.FlatStyle = FlatStyle.Flat;
            btnEPWithoutEntity.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnEPWithoutEntity.ForeColor = Color.FromArgb(1, 107, 1);
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
            btnCreateModal.ForeColor = Color.FromArgb(1, 107, 1);
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
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(button1);
            pnlHeader.Controls.Add(lblHead);
            pnlHeader.Controls.Add(panel1);
            pnlHeader.Controls.Add(panel3);
            pnlHeader.Controls.Add(btnClose);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1328, 55);
            pnlHeader.TabIndex = 1;
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
            // lblHead
            // 
            lblHead.AutoSize = true;
            lblHead.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblHead.ForeColor = Color.SeaGreen;
            lblHead.Location = new Point(333, 16);
            lblHead.Name = "lblHead";
            lblHead.Size = new Size(59, 23);
            lblHead.TabIndex = 6;
            lblHead.Text = "Home";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(197, 227, 205);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(311, 55);
            panel1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(1, 107, 1);
            label1.Location = new Point(46, 2);
            label1.Name = "label1";
            label1.Size = new Size(206, 41);
            label1.TabIndex = 0;
            label1.Text = "DynCodeGen";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // contentPanel
            // 
            contentPanel.BackColor = SystemColors.Window;
            contentPanel.Location = new Point(309, 55);
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
            ClientSize = new Size(1328, 659);
            Controls.Add(contentPanel);
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
            pnlHeader.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
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
        private Label label1;
        private Button button1;
        private Panel contentPanel;
    }
}