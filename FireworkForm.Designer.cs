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
            this.EscLabel = new System.Windows.Forms.Label();
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
            // EscLabel
            // 
            this.EscLabel.AutoSize = true;
            this.EscLabel.Location = new System.Drawing.Point(12, 9);
            this.EscLabel.Name = "EscLabel";
            this.EscLabel.Size = new System.Drawing.Size(85, 13);
            this.EscLabel.TabIndex = 1;
            this.EscLabel.Text = "Press Esc to exit";
            // 
            // FireworkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(419, 327);
            this.ControlBox = false;
            this.Controls.Add(this.EscLabel);
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
        private System.Windows.Forms.Label EscLabel;
    }
}