namespace BirthdayNotifier
{
    partial class FireworkForm
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
            this.FireworkPictureBox = new System.Windows.Forms.PictureBox();
            this.EscLabel1 = new System.Windows.Forms.Label();
            this.EscLabel2 = new System.Windows.Forms.Label();
            this.EscLabel3 = new System.Windows.Forms.Label();
            this.EscLabel4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FireworkPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // FireworkPictureBox
            // 
            this.FireworkPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FireworkPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FireworkPictureBox.Location = new System.Drawing.Point(0, 0);
            this.FireworkPictureBox.Name = "FireworkPictureBox";
            this.FireworkPictureBox.Size = new System.Drawing.Size(419, 327);
            this.FireworkPictureBox.TabIndex = 0;
            this.FireworkPictureBox.TabStop = false;
            this.FireworkPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox1_Paint);
            // 
            // EscLabel1
            // 
            this.EscLabel1.AutoSize = true;
            this.EscLabel1.Location = new System.Drawing.Point(12, 9);
            this.EscLabel1.Name = "EscLabel1";
            this.EscLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EscLabel1.Size = new System.Drawing.Size(85, 13);
            this.EscLabel1.TabIndex = 1;
            this.EscLabel1.Text = "Press Esc to exit";
            this.EscLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EscLabel2
            // 
            this.EscLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EscLabel2.AutoSize = true;
            this.EscLabel2.Location = new System.Drawing.Point(322, 9);
            this.EscLabel2.Name = "EscLabel2";
            this.EscLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EscLabel2.Size = new System.Drawing.Size(85, 13);
            this.EscLabel2.TabIndex = 1;
            this.EscLabel2.Text = "Press Esc to exit";
            this.EscLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EscLabel3
            // 
            this.EscLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EscLabel3.AutoSize = true;
            this.EscLabel3.Location = new System.Drawing.Point(12, 305);
            this.EscLabel3.Name = "EscLabel3";
            this.EscLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EscLabel3.Size = new System.Drawing.Size(85, 13);
            this.EscLabel3.TabIndex = 1;
            this.EscLabel3.Text = "Press Esc to exit";
            this.EscLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EscLabel4
            // 
            this.EscLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EscLabel4.AutoSize = true;
            this.EscLabel4.Location = new System.Drawing.Point(322, 305);
            this.EscLabel4.Name = "EscLabel4";
            this.EscLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EscLabel4.Size = new System.Drawing.Size(85, 13);
            this.EscLabel4.TabIndex = 1;
            this.EscLabel4.Text = "Press Esc to exit";
            this.EscLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FireworkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(419, 327);
            this.ControlBox = false;
            this.Controls.Add(this.EscLabel4);
            this.Controls.Add(this.EscLabel2);
            this.Controls.Add(this.EscLabel3);
            this.Controls.Add(this.EscLabel1);
            this.Controls.Add(this.FireworkPictureBox);
            this.Name = "FireworkForm";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FireworkForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.FireworkPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox FireworkPictureBox;
        private System.Windows.Forms.Label EscLabel1;
        private System.Windows.Forms.Label EscLabel2;
        private System.Windows.Forms.Label EscLabel3;
        private System.Windows.Forms.Label EscLabel4;
    }
}