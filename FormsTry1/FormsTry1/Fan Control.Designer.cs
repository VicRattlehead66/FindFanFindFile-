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
            this.SuspendLayout();
            // 
            // desiredSpeedLabel
            // 
            this.desiredSpeedLabel.AutoSize = true;
            this.desiredSpeedLabel.Location = new System.Drawing.Point(12, 33);
            this.desiredSpeedLabel.Name = "desiredSpeedLabel";
            this.desiredSpeedLabel.Size = new System.Drawing.Size(77, 13);
            this.desiredSpeedLabel.TabIndex = 5;
            this.desiredSpeedLabel.Text = "Desired Speed";
            // 
            // currentSpeedLabel
            // 
            this.currentSpeedLabel.AutoSize = true;
            this.currentSpeedLabel.Location = new System.Drawing.Point(12, 9);
            this.currentSpeedLabel.Name = "currentSpeedLabel";
            this.currentSpeedLabel.Size = new System.Drawing.Size(75, 13);
            this.currentSpeedLabel.TabIndex = 4;
            this.currentSpeedLabel.Text = "Current Speed";
            // 
            // changeSpeedButton
            // 
            this.changeSpeedButton.Location = new System.Drawing.Point(79, 226);
            this.changeSpeedButton.Name = "changeSpeedButton";
            this.changeSpeedButton.Size = new System.Drawing.Size(116, 23);
            this.changeSpeedButton.TabIndex = 3;
            this.changeSpeedButton.Text = "Change Speed";
            this.changeSpeedButton.UseVisualStyleBackColor = true;
            // 
            // Fan_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.desiredSpeedLabel);
            this.Controls.Add(this.currentSpeedLabel);
            this.Controls.Add(this.changeSpeedButton);
            this.Name = "Fan_Control";
            this.Text = "Fan_Control";
            this.Load += new System.EventHandler(this.Fan_Control_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label desiredSpeedLabel;
        private System.Windows.Forms.Label currentSpeedLabel;
        private System.Windows.Forms.Button changeSpeedButton;
    }
}