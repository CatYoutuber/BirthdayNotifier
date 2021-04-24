namespace BirthdayNotifier
{
    partial class DateSelectorForm
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
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.AutorunBtn = new System.Windows.Forms.Button();
            this.FireworkCB = new System.Windows.Forms.CheckBox();
            this.tipTimeLabel = new System.Windows.Forms.Label();
            this.tipShowTimeUD = new System.Windows.Forms.NumericUpDown();
            this.tipTimeTestBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tipShowTimeUD)).BeginInit();
            this.SuspendLayout();
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(12, 134);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(240, 20);
            this.datePicker.TabIndex = 0;
            this.datePicker.Value = new System.DateTime(2021, 4, 22, 0, 0, 0, 0);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(12, 12);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(117, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(135, 12);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(117, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AutorunBtn
            // 
            this.AutorunBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.AutorunBtn.Location = new System.Drawing.Point(13, 42);
            this.AutorunBtn.Name = "AutorunBtn";
            this.AutorunBtn.Size = new System.Drawing.Size(239, 22);
            this.AutorunBtn.TabIndex = 2;
            this.AutorunBtn.Text = "Enable AUTORUN";
            this.AutorunBtn.UseVisualStyleBackColor = true;
            this.AutorunBtn.Click += new System.EventHandler(this.AutorunBtn_Click);
            // 
            // FireworkCB
            // 
            this.FireworkCB.AutoSize = true;
            this.FireworkCB.Location = new System.Drawing.Point(13, 71);
            this.FireworkCB.Name = "FireworkCB";
            this.FireworkCB.Size = new System.Drawing.Size(148, 17);
            this.FireworkCB.TabIndex = 3;
            this.FireworkCB.Text = "Show firework on birthady";
            this.FireworkCB.UseVisualStyleBackColor = true;
            // 
            // tipTimeLabel
            // 
            this.tipTimeLabel.AutoSize = true;
            this.tipTimeLabel.Location = new System.Drawing.Point(12, 91);
            this.tipTimeLabel.Name = "tipTimeLabel";
            this.tipTimeLabel.Size = new System.Drawing.Size(180, 13);
            this.tipTimeLabel.TabIndex = 4;
            this.tipTimeLabel.Text = "Baloon tip show time (in milliseconds)";
            this.tipTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tipShowTimeUD
            // 
            this.tipShowTimeUD.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.tipShowTimeUD.Location = new System.Drawing.Point(12, 108);
            this.tipShowTimeUD.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.tipShowTimeUD.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.tipShowTimeUD.Name = "tipShowTimeUD";
            this.tipShowTimeUD.Size = new System.Drawing.Size(130, 20);
            this.tipShowTimeUD.TabIndex = 5;
            this.tipShowTimeUD.ThousandsSeparator = true;
            this.tipShowTimeUD.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // tipTimeTestBtn
            // 
            this.tipTimeTestBtn.Location = new System.Drawing.Point(148, 108);
            this.tipTimeTestBtn.Name = "tipTimeTestBtn";
            this.tipTimeTestBtn.Size = new System.Drawing.Size(57, 20);
            this.tipTimeTestBtn.TabIndex = 6;
            this.tipTimeTestBtn.Text = "Test";
            this.tipTimeTestBtn.UseVisualStyleBackColor = true;
            this.tipTimeTestBtn.Click += new System.EventHandler(this.TipTimeTestBtn_Click);
            // 
            // DateSelectorForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(264, 166);
            this.Controls.Add(this.tipTimeTestBtn);
            this.Controls.Add(this.tipShowTimeUD);
            this.Controls.Add(this.tipTimeLabel);
            this.Controls.Add(this.FireworkCB);
            this.Controls.Add(this.AutorunBtn);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.datePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DateSelectorForm";
            this.ShowIcon = false;
            this.Text = "Date Selector";
            this.Load += new System.EventHandler(this.DateSelectorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tipShowTimeUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button AutorunBtn;
        private System.Windows.Forms.CheckBox FireworkCB;
        private System.Windows.Forms.Label tipTimeLabel;
        private System.Windows.Forms.NumericUpDown tipShowTimeUD;
        private System.Windows.Forms.Button tipTimeTestBtn;
    }
}