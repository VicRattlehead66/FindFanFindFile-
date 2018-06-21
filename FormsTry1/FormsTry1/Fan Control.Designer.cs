namespace FormsTry1
{
    partial class Fan_Control
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
            this.desiredSpeedLabel = new System.Windows.Forms.Label();
            this.currentSpeedLabel = new System.Windows.Forms.Label();
            this.changeSpeedButton = new System.Windows.Forms.Button();
            this.rpmSelect = new System.Windows.Forms.NumericUpDown();
            this.vSpeedDisabled = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rpmSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // desiredSpeedLabel
            // 
            this.desiredSpeedLabel.AutoSize = true;
            this.desiredSpeedLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desiredSpeedLabel.Location = new System.Drawing.Point(12, 33);
            this.desiredSpeedLabel.Name = "desiredSpeedLabel";
            this.desiredSpeedLabel.Size = new System.Drawing.Size(98, 15);
            this.desiredSpeedLabel.TabIndex = 5;
            this.desiredSpeedLabel.Text = "Desired Speed";
            // 
            // currentSpeedLabel
            // 
            this.currentSpeedLabel.AutoSize = true;
            this.currentSpeedLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentSpeedLabel.Location = new System.Drawing.Point(12, 9);
            this.currentSpeedLabel.Name = "currentSpeedLabel";
            this.currentSpeedLabel.Size = new System.Drawing.Size(98, 15);
            this.currentSpeedLabel.TabIndex = 4;
            this.currentSpeedLabel.Text = "Current Speed";
            // 
            // changeSpeedButton
            // 
            this.changeSpeedButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeSpeedButton.Location = new System.Drawing.Point(12, 59);
            this.changeSpeedButton.Name = "changeSpeedButton";
            this.changeSpeedButton.Size = new System.Drawing.Size(165, 23);
            this.changeSpeedButton.TabIndex = 3;
            this.changeSpeedButton.Text = "Change Speed";
            this.changeSpeedButton.UseVisualStyleBackColor = true;
            this.changeSpeedButton.Click += new System.EventHandler(this.changeSpeedButton_Click);
            // 
            // rpmSelect
            // 
            this.rpmSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rpmSelect.Location = new System.Drawing.Point(194, 60);
            this.rpmSelect.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.rpmSelect.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.rpmSelect.Name = "rpmSelect";
            this.rpmSelect.Size = new System.Drawing.Size(66, 23);
            this.rpmSelect.TabIndex = 7;
            this.rpmSelect.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // vSpeedDisabled
            // 
            this.vSpeedDisabled.AutoSize = true;
            this.vSpeedDisabled.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.vSpeedDisabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.vSpeedDisabled.Location = new System.Drawing.Point(35, 9);
            this.vSpeedDisabled.Name = "vSpeedDisabled";
            this.vSpeedDisabled.Size = new System.Drawing.Size(200, 44);
            this.vSpeedDisabled.TabIndex = 8;
            this.vSpeedDisabled.Text = "Speed settings are \r\nunavailable";
            this.vSpeedDisabled.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.vSpeedDisabled.Visible = false;
            // 
            // Fan_Control
            // 
            this.AcceptButton = this.changeSpeedButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 94);
            this.Controls.Add(this.vSpeedDisabled);
            this.Controls.Add(this.rpmSelect);
            this.Controls.Add(this.desiredSpeedLabel);
            this.Controls.Add(this.currentSpeedLabel);
            this.Controls.Add(this.changeSpeedButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Fan_Control";
            this.Text = "Fan_Control";
            this.Load += new System.EventHandler(this.Fan_Control_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rpmSelect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label desiredSpeedLabel;
        private System.Windows.Forms.Label currentSpeedLabel;
        private System.Windows.Forms.Button changeSpeedButton;
        private System.Windows.Forms.NumericUpDown rpmSelect;
        private System.Windows.Forms.Label vSpeedDisabled;
    }
}