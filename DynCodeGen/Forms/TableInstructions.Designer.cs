namespace DynCodeGen.Forms
{
    partial class TableInstructions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableInstructions));
            pnlHeader = new Panel();
            lblInstructions = new Label();
            btnClose = new Button();
            pnlPictureBox = new Panel();
            pictureBox1 = new PictureBox();
            pnlHeader.SuspendLayout();
            pnlPictureBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.BorderStyle = BorderStyle.FixedSingle;
            pnlHeader.Controls.Add(lblInstructions);
            pnlHeader.Controls.Add(btnClose);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(938, 42);
            pnlHeader.TabIndex = 0;
            // 
            // lblInstructions
            // 
            lblInstructions.AutoSize = true;
            lblInstructions.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblInstructions.Location = new Point(3, 9);
            lblInstructions.Name = "lblInstructions";
            lblInstructions.Size = new Size(99, 23);
            lblInstructions.TabIndex = 5;
            lblInstructions.Text = "Instructions";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.White;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(897, 1);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(37, 40);
            btnClose.TabIndex = 4;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // pnlPictureBox
            // 
            pnlPictureBox.BackColor = SystemColors.ButtonHighlight;
            pnlPictureBox.BorderStyle = BorderStyle.FixedSingle;
            pnlPictureBox.Controls.Add(pictureBox1);
            pnlPictureBox.Dock = DockStyle.Fill;
            pnlPictureBox.Location = new Point(0, 42);
            pnlPictureBox.Name = "pnlPictureBox";
            pnlPictureBox.Size = new Size(938, 614);
            pnlPictureBox.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-74, -31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(911, 666);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // TableInstructions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 656);
            Controls.Add(pnlPictureBox);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TableInstructions";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TableInstructions";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlPictureBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Button btnClose;
        private Panel pnlPictureBox;
        private PictureBox pictureBox1;
        private Label lblInstructions;
    }
}