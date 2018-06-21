namespace FormsTry1
{
    partial class FileChoiceForm
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.FileInFolder2label = new System.Windows.Forms.Label();
            this.fileInFolder1label = new System.Windows.Forms.Label();
            this.delSelectedFilesButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.FileInFolder2label, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.fileInFolder1label, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(325, 22);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // FileInFolder2label
            // 
            this.FileInFolder2label.AutoSize = true;
            this.FileInFolder2label.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileInFolder2label.Location = new System.Drawing.Point(164, 1);
            this.FileInFolder2label.Name = "FileInFolder2label";
            this.FileInFolder2label.Size = new System.Drawing.Size(153, 19);
            this.FileInFolder2label.TabIndex = 1;
            this.FileInFolder2label.Text = "File in Folder 2";
            // 
            // fileInFolder1label
            // 
            this.fileInFolder1label.AutoSize = true;
            this.fileInFolder1label.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileInFolder1label.Location = new System.Drawing.Point(4, 1);
            this.fileInFolder1label.Name = "fileInFolder1label";
            this.fileInFolder1label.Size = new System.Drawing.Size(153, 19);
            this.fileInFolder1label.TabIndex = 0;
            this.fileInFolder1label.Text = "File in Folder 1";
            // 
            // delSelectedFilesButton
            // 
            this.delSelectedFilesButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.delSelectedFilesButton.Enabled = false;
            this.delSelectedFilesButton.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delSelectedFilesButton.Location = new System.Drawing.Point(0, 150);
            this.delSelectedFilesButton.Name = "delSelectedFilesButton";
            this.delSelectedFilesButton.Size = new System.Drawing.Size(325, 111);
            this.delSelectedFilesButton.TabIndex = 2;
            this.delSelectedFilesButton.Text = "Delete Selcted Files";
            this.delSelectedFilesButton.UseVisualStyleBackColor = true;
            this.delSelectedFilesButton.Click += new System.EventHandler(this.delSelectedFilesButton_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FileChoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(325, 261);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.delSelectedFilesButton);
            this.Name = "FileChoiceForm";
            this.Text = "File Choice";
            this.Load += new System.EventHandler(this.FileChoiceForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label fileInFolder1label;
        private System.Windows.Forms.Label FileInFolder2label;
        private System.Windows.Forms.Button delSelectedFilesButton;
        private System.Windows.Forms.Timer timer1;
    }
}