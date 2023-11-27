namespace DynCodeGen.UserControls
{
    partial class HomeControl
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
            tblpnlMain = new TableLayoutPanel();
            panel1 = new Panel();
            SPTemplate = new LinkLabel();
            tableTemplate = new LinkLabel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tblpnlMain.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tblpnlMain
            // 
            tblpnlMain.BackColor = SystemColors.Window;
            tblpnlMain.ColumnCount = 1;
            tblpnlMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblpnlMain.Controls.Add(panel1, 0, 0);
            tblpnlMain.Location = new Point(3, 3);
            tblpnlMain.Name = "tblpnlMain";
            tblpnlMain.RowCount = 1;
            tblpnlMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblpnlMain.Size = new Size(1014, 597);
            tblpnlMain.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Controls.Add(SPTemplate);
            panel1.Controls.Add(tableTemplate);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1008, 591);
            panel1.TabIndex = 0;
            // 
            // SPTemplate
            // 
            SPTemplate.AutoSize = true;
            SPTemplate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SPTemplate.LinkColor = Color.Navy;
            SPTemplate.Location = new Point(412, 450);
            SPTemplate.Name = "SPTemplate";
            SPTemplate.Size = new Size(78, 20);
            SPTemplate.TabIndex = 5;
            SPTemplate.TabStop = true;
            SPTemplate.Text = "Click Here";
            // 
            // tableTemplate
            // 
            tableTemplate.AutoSize = true;
            tableTemplate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tableTemplate.LinkColor = Color.Navy;
            tableTemplate.Location = new Point(412, 408);
            tableTemplate.Name = "tableTemplate";
            tableTemplate.Size = new Size(78, 20);
            tableTemplate.TabIndex = 4;
            tableTemplate.TabStop = true;
            tableTemplate.Text = "Click Here";
            tableTemplate.LinkClicked += tableTemplate_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(1, 107, 1);
            label4.Location = new Point(251, 450);
            label4.Name = "label4";
            label4.Size = new Size(127, 20);
            label4.TabIndex = 3;
            label4.Text = "Stored Procedure";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(1, 107, 1);
            label3.Location = new Point(251, 408);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 2;
            label3.Text = "Table Format";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(1, 107, 1);
            label2.Location = new Point(167, 365);
            label2.Name = "label2";
            label2.Size = new Size(91, 23);
            label2.TabIndex = 1;
            label2.Text = "Templates";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(1, 107, 1);
            label1.Location = new Point(166, 88);
            label1.Name = "label1";
            label1.Size = new Size(630, 25);
            label1.TabIndex = 0;
            label1.Text = "DynCodeGen automates the traditionally manual process of API creation";
            // 
            // HomeControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            Controls.Add(tblpnlMain);
            Name = "HomeControl";
            Size = new Size(1021, 604);
            Load += HomeControl_Load;
            tblpnlMain.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblpnlMain;
        private Panel panel1;
        private Label label1;
        private LinkLabel tableTemplate;
        private Label label4;
        private Label label3;
        private Label label2;
        private LinkLabel SPTemplate;
    }
}
