namespace DynCodeGen.Forms
{
    partial class SPInstructions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SPInstructions));
            pnlPictureBox = new Panel();
            pictureBox1 = new PictureBox();
            pnlHeader = new Panel();
            lblInstructions = new Label();
            btnClose = new Button();
            pnlPictureBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlPictureBox
            // 
            pnlPictureBox.BackColor = SystemColors.ButtonHighlight;
            pnlPictureBox.BorderStyle = BorderStyle.FixedSingle;
            pnlPictureBox.Controls.Add(pictureBox1);
            pnlPictureBox.Dock = DockStyle.Fill;
            pnlPictureBox.Location = new Point(0, 42);
            pnlPictureBox.Name = "pnlPictureBox";
            pnlPictureBox.Size = new Size(938, 656);
            pnlPictureBox.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-73, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(993, 648);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
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
            pnlHeader.TabIndex = 2;
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
            // SPInstructions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 698);
            Controls.Add(pnlPictureBox);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SPInstructions";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SPInstructions";
            pnlPictureBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlPictureBox;
        private PictureBox pictureBox1;
        private Panel pnlHeader;
        private Label lblInstructions;
        private Button btnClose;
    }
}