namespace FormsTry1
{
    partial class MainForm
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabComp = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.componentHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tempHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabFileCmpr = new System.Windows.Forms.TabPage();
            this.browseBtn2 = new System.Windows.Forms.Button();
            this.browseBtn1 = new System.Windows.Forms.Button();
            this.textBoxSingleFile1 = new System.Windows.Forms.TextBox();
            this.textBoxSingleFile2 = new System.Windows.Forms.TextBox();
            this.dupeCheckBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabFolderComparison = new System.Windows.Forms.TabPage();
            this.folderCheckBtn = new System.Windows.Forms.Button();
            this.buttonFolder2 = new System.Windows.Forms.Button();
            this.buttonFolder1 = new System.Windows.Forms.Button();
            this.textBoxFolder2 = new System.Windows.Forms.TextBox();
            this.textBoxFolder1 = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabComp.SuspendLayout();
            this.tabFileCmpr.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabFolderComparison.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabComp
            // 
            this.tabComp.Controls.Add(this.listView1);
            this.tabComp.Location = new System.Drawing.Point(4, 22);
            this.tabComp.Name = "tabComp";
            this.tabComp.Padding = new System.Windows.Forms.Padding(3);
            this.tabComp.Size = new System.Drawing.Size(481, 254);
            this.tabComp.TabIndex = 1;
            this.tabComp.Text = "Components";
            this.tabComp.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.componentHeader,
            this.nameHeader,
            this.statusHeader,
            this.tempHeader});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(475, 248);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // componentHeader
            // 
            this.componentHeader.Text = "Component";
            this.componentHeader.Width = 70;
            // 
            // nameHeader
            // 
            this.nameHeader.Text = "Name";
            this.nameHeader.Width = 140;
            // 
            // statusHeader
            // 
            this.statusHeader.Text = "Status";
            this.statusHeader.Width = 67;
            // 
            // tempHeader
            // 
            this.tempHeader.Text = "Temperature";
            this.tempHeader.Width = 81;
            // 
            // tabFileCmpr
            // 
            this.tabFileCmpr.Controls.Add(this.browseBtn2);
            this.tabFileCmpr.Controls.Add(this.browseBtn1);
            this.tabFileCmpr.Controls.Add(this.textBoxSingleFile1);
            this.tabFileCmpr.Controls.Add(this.textBoxSingleFile2);
            this.tabFileCmpr.Controls.Add(this.dupeCheckBtn);
            this.tabFileCmpr.Controls.Add(this.label2);
            this.tabFileCmpr.Controls.Add(this.label1);
            this.tabFileCmpr.Location = new System.Drawing.Point(4, 22);
            this.tabFileCmpr.Name = "tabFileCmpr";
            this.tabFileCmpr.Padding = new System.Windows.Forms.Padding(3);
            this.tabFileCmpr.Size = new System.Drawing.Size(481, 276);
            this.tabFileCmpr.TabIndex = 0;
            this.tabFileCmpr.Text = "File Comparison";
            this.tabFileCmpr.UseVisualStyleBackColor = true;
            // 
            // browseBtn2
            // 
            this.browseBtn2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseBtn2.Location = new System.Drawing.Point(394, 42);
            this.browseBtn2.Name = "browseBtn2";
            this.browseBtn2.Size = new System.Drawing.Size(77, 26);
            this.browseBtn2.TabIndex = 6;
            this.browseBtn2.Text = "Browse";
            this.browseBtn2.UseVisualStyleBackColor = true;
            this.browseBtn2.Click += new System.EventHandler(this.browseSingleFile2_Click);
            // 
            // browseBtn1
            // 
            this.browseBtn1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseBtn1.Location = new System.Drawing.Point(394, 7);
            this.browseBtn1.Name = "browseBtn1";
            this.browseBtn1.Size = new System.Drawing.Size(77, 26);
            this.browseBtn1.TabIndex = 5;
            this.browseBtn1.Text = "Browse";
            this.browseBtn1.UseVisualStyleBackColor = true;
            this.browseBtn1.Click += new System.EventHandler(this.browseSingleFile1_Click);
            // 
            // textBoxSingleFile1
            // 
            this.textBoxSingleFile1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSingleFile1.Location = new System.Drawing.Point(75, 7);
            this.textBoxSingleFile1.Name = "textBoxSingleFile1";
            this.textBoxSingleFile1.Size = new System.Drawing.Size(313, 26);
            this.textBoxSingleFile1.TabIndex = 0;
            // 
            // textBoxSingleFile2
            // 
            this.textBoxSingleFile2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSingleFile2.Location = new System.Drawing.Point(75, 42);
            this.textBoxSingleFile2.Name = "textBoxSingleFile2";
            this.textBoxSingleFile2.Size = new System.Drawing.Size(313, 26);
            this.textBoxSingleFile2.TabIndex = 1;
            // 
            // dupeCheckBtn
            // 
            this.dupeCheckBtn.BackColor = System.Drawing.Color.DarkGray;
            this.dupeCheckBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.dupeCheckBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dupeCheckBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dupeCheckBtn.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dupeCheckBtn.ForeColor = System.Drawing.Color.Firebrick;
            this.dupeCheckBtn.Location = new System.Drawing.Point(3, 87);
            this.dupeCheckBtn.Name = "dupeCheckBtn";
            this.dupeCheckBtn.Size = new System.Drawing.Size(475, 186);
            this.dupeCheckBtn.TabIndex = 2;
            this.dupeCheckBtn.Text = "EQUALITY CHECK";
            this.dupeCheckBtn.UseVisualStyleBackColor = false;
            this.dupeCheckBtn.Click += new System.EventHandler(this.dupeCheckBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "File 2:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "File 1:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabComp);
            this.tabControl1.Controls.Add(this.tabFolderComparison);
            this.tabControl1.Controls.Add(this.tabFileCmpr);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(489, 302);
            this.tabControl1.TabIndex = 5;
            // 
            // tabFolderComparison
            // 
            this.tabFolderComparison.Controls.Add(this.folderCheckBtn);
            this.tabFolderComparison.Controls.Add(this.buttonFolder2);
            this.tabFolderComparison.Controls.Add(this.buttonFolder1);
            this.tabFolderComparison.Controls.Add(this.textBoxFolder2);
            this.tabFolderComparison.Controls.Add(this.textBoxFolder1);
            this.tabFolderComparison.Location = new System.Drawing.Point(4, 22);
            this.tabFolderComparison.Name = "tabFolderComparison";
            this.tabFolderComparison.Padding = new System.Windows.Forms.Padding(3);
            this.tabFolderComparison.Size = new System.Drawing.Size(481, 254);
            this.tabFolderComparison.TabIndex = 2;
            this.tabFolderComparison.Text = "Folder Comparison";
            this.tabFolderComparison.UseVisualStyleBackColor = true;
            // 
            // folderCheckBtn
            // 
            this.folderCheckBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.folderCheckBtn.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold);
            this.folderCheckBtn.Location = new System.Drawing.Point(3, 115);
            this.folderCheckBtn.Name = "folderCheckBtn";
            this.folderCheckBtn.Size = new System.Drawing.Size(475, 136);
            this.folderCheckBtn.TabIndex = 4;
            this.folderCheckBtn.Text = "Check Folders";
            this.folderCheckBtn.UseVisualStyleBackColor = true;
            this.folderCheckBtn.Click += new System.EventHandler(this.folderCheckBtn_Click_1);
            // 
            // buttonFolder2
            // 
            this.buttonFolder2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFolder2.Location = new System.Drawing.Point(377, 78);
            this.buttonFolder2.Name = "buttonFolder2";
            this.buttonFolder2.Size = new System.Drawing.Size(96, 29);
            this.buttonFolder2.TabIndex = 3;
            this.buttonFolder2.Text = "Browse";
            this.buttonFolder2.UseVisualStyleBackColor = true;
            this.buttonFolder2.Click += new System.EventHandler(this.browseFolder2_Click);
            // 
            // buttonFolder1
            // 
            this.buttonFolder1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFolder1.Location = new System.Drawing.Point(377, 36);
            this.buttonFolder1.Name = "buttonFolder1";
            this.buttonFolder1.Size = new System.Drawing.Size(96, 29);
            this.buttonFolder1.TabIndex = 2;
            this.buttonFolder1.Text = "Browse";
            this.buttonFolder1.UseVisualStyleBackColor = true;
            this.buttonFolder1.Click += new System.EventHandler(this.browseFolder1_Click);
            // 
            // textBoxFolder2
            // 
            this.textBoxFolder2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFolder2.Location = new System.Drawing.Point(8, 78);
            this.textBoxFolder2.Name = "textBoxFolder2";
            this.textBoxFolder2.Size = new System.Drawing.Size(363, 26);
            this.textBoxFolder2.TabIndex = 1;
            // 
            // textBoxFolder1
            // 
            this.textBoxFolder1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFolder1.Location = new System.Drawing.Point(8, 36);
            this.textBoxFolder1.Name = "textBoxFolder1";
            this.textBoxFolder1.Size = new System.Drawing.Size(363, 26);
            this.textBoxFolder1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 302);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.main_Form_Load);
            this.tabComp.ResumeLayout(false);
            this.tabFileCmpr.ResumeLayout(false);
            this.tabFileCmpr.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabFolderComparison.ResumeLayout(false);
            this.tabFolderComparison.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabPage tabComp;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader componentHeader;
        private System.Windows.Forms.ColumnHeader nameHeader;
        private System.Windows.Forms.ColumnHeader statusHeader;
        private System.Windows.Forms.TabPage tabFileCmpr;
        private System.Windows.Forms.Button browseBtn2;
        private System.Windows.Forms.Button browseBtn1;
        private System.Windows.Forms.TextBox textBoxSingleFile1;
        private System.Windows.Forms.TextBox textBoxSingleFile2;
        private System.Windows.Forms.Button dupeCheckBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ColumnHeader tempHeader;
        private System.Windows.Forms.TabPage tabFolderComparison;
        private System.Windows.Forms.Button buttonFolder2;
        private System.Windows.Forms.Button buttonFolder1;
        private System.Windows.Forms.TextBox textBoxFolder2;
        private System.Windows.Forms.TextBox textBoxFolder1;
        private System.Windows.Forms.Button folderCheckBtn;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Timer timer1;
    }
}

