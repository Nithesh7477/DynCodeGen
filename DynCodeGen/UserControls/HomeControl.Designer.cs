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
            label7 = new Label();
            lblSPInstructions = new LinkLabel();
            label6 = new Label();
            label5 = new Label();
            lblTableInstructions = new LinkLabel();
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
            panel1.Controls.Add(label7);
            panel1.Controls.Add(lblSPInstructions);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(lblTableInstructions);
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(29, 51, 92);
            label7.Location = new Point(105, 125);
            label7.Name = "label7";
            label7.Size = new Size(815, 20);
            label7.TabIndex = 10;
            label7.Text = "Develop APIs with Property tables, execute SPs, and integrate seamlessly in a single project for enhanced functionality";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblSPInstructions
            // 
            lblSPInstructions.AutoSize = true;
            lblSPInstructions.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSPInstructions.LinkColor = Color.Navy;
            lblSPInstructions.Location = new Point(615, 291);
            lblSPInstructions.Name = "lblSPInstructions";
            lblSPInstructions.Size = new Size(88, 20);
            lblSPInstructions.TabIndex = 9;
            lblSPInstructions.TabStop = true;
            lblSPInstructions.Text = "Instructions";
            lblSPInstructions.LinkClicked += lblSPInstructions_LinkClicked;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(29, 51, 92);
            label6.Location = new Point(699, 291);
            label6.Name = "label6";
            label6.Size = new Size(138, 20);
            label6.TabIndex = 8;
            label6.Text = "to fill the template.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(29, 51, 92);
            label5.Location = new Point(193, 291);
            label5.Name = "label5";
            label5.Size = new Size(424, 20);
            label5.TabIndex = 7;
            label5.Text = "to download the Stored Proc Format template, ang follow the";
            // 
            // lblTableInstructions
            // 
            lblTableInstructions.AutoSize = true;
            lblTableInstructions.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTableInstructions.LinkColor = Color.Navy;
            lblTableInstructions.Location = new Point(573, 247);
            lblTableInstructions.Name = "lblTableInstructions";
            lblTableInstructions.Size = new Size(88, 20);
            lblTableInstructions.TabIndex = 6;
            lblTableInstructions.TabStop = true;
            lblTableInstructions.Text = "Instructions";
            lblTableInstructions.LinkClicked += LinkLabel1_LinkClicked;
            // 
            // SPTemplate
            // 
            SPTemplate.AutoSize = true;
            SPTemplate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SPTemplate.LinkColor = Color.Navy;
            SPTemplate.Location = new Point(116, 291);
            SPTemplate.Name = "SPTemplate";
            SPTemplate.Size = new Size(78, 20);
            SPTemplate.TabIndex = 5;
            SPTemplate.TabStop = true;
            SPTemplate.Text = "Click Here";
            SPTemplate.LinkClicked += SPTemplate_LinkClicked;
            // 
            // tableTemplate
            // 
            tableTemplate.AutoSize = true;
            tableTemplate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tableTemplate.LinkColor = Color.Navy;
            tableTemplate.Location = new Point(116, 247);
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
            label4.ForeColor = Color.FromArgb(29, 51, 92);
            label4.Location = new Point(657, 247);
            label4.Name = "label4";
            label4.Size = new Size(138, 20);
            label4.TabIndex = 3;
            label4.Text = "to fill the template.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(29, 51, 92);
            label3.Location = new Point(193, 247);
            label3.Name = "label3";
            label3.Size = new Size(384, 20);
            label3.TabIndex = 2;
            label3.Text = "to download the Table Format template, ang follow the";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(29, 51, 92);
            label2.Location = new Point(107, 200);
            label2.Name = "label2";
            label2.Size = new Size(91, 23);
            label2.TabIndex = 1;
            label2.Text = "Templates";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(29, 51, 92);
            label1.Location = new Point(107, 79);
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
        private LinkLabel lblSPInstructions;
        private Label label6;
        private Label label5;
        private LinkLabel lblTableInstructions;
        private Label label7;
    }
}
