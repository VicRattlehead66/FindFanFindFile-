using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FormsTry1
{
    public partial class FileChoiceForm : Form
    {
        string folder0;
        string folder1;
        string[][] identicalFiles;
        bool done;
        public FileChoiceForm(string folder0, string folder1, string[][] identicalFiles)
        {
            this.folder0 = folder0;
            this.folder1 = folder1;
            this.identicalFiles = identicalFiles;
            InitializeComponent();
        }

        private void FileChoiceForm_Load(object sender, EventArgs e)
        {
            fileInFolder1label.Text = "File in " + folder0;
            FileInFolder2label.Text = "File in " + folder1;
            
            //set the table's amount of rows to the amount of identical files + one row for the header 
            tableLayoutPanel1.RowCount = identicalFiles[0].Length+1;
            tableLayoutPanel1.ColumnCount = 2;
            bool flag = false;

            for (int i = 1; i < tableLayoutPanel1.RowCount; i++) //Iterating through rows
            {
                for (int j = 1; j < tableLayoutPanel1.ColumnCount; j++) //Iterating through columns
                {
                    // Creating checkboxes

                    if (identicalFiles[0][i-1] != "na") //Skipping files which have been already deleted.
                    {
                        flag = true;
                        //Places a check box and filename in the first column
                        CheckBox cbox1 = new CheckBox();
                        cbox1.Text = Path.GetFileName(identicalFiles[0][i-1]);
                        cbox1.Font = new Font("Consolas", 10);
                        tableLayoutPanel1.Controls.Add(cbox1, 0, i);
                        cbox1.Name = string.Format("cbox_0_{0}", i);

                        //Places a check box and filename in the second column
                        CheckBox cbox2 = new CheckBox();
                        cbox2.Font = new Font("Consolas", 10);
                        cbox2.Text = Path.GetFileName(identicalFiles[1][i - 1]);
                        tableLayoutPanel1.Controls.Add(cbox2, 1, i);
                        cbox2.Name = string.Format("cbox_1_{0}", i);
                    }                    
                }
            }
            if (!flag)
            {
                Close();
            }
            
            foreach (RowStyle i in tableLayoutPanel1.RowStyles)
            {
                i.SizeType = SizeType.AutoSize;
            }
            int windowWidth = 0;

            for (int i = 0; i < tableLayoutPanel1.ColumnCount; i++) //Sets the forms width to the total width of the table columns
            {
                windowWidth += tableLayoutPanel1.GetColumnWidths()[i];
            }
            Width = windowWidth;
            timer1.Start();
        }

        /// <summary>
        /// A method which deletes the files with checked boxes
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void DeleteCheckedFiles(object sender, EventArgs e)
        {
            List<string> deathRow = new List<string> { };
            for (int i = 1; i < tableLayoutPanel1.RowCount; i++)
            {
                if((tableLayoutPanel1.Controls[string.Format("cbox_0_{0}", i)] as CheckBox).Checked)
                {
                    deathRow.Add(string.Format(folder0 + "\\" + (tableLayoutPanel1.Controls[string.Format("cbox_0_{0}", i)] as CheckBox).Text));
                }
            }
            for (int i = 1; i < tableLayoutPanel1.RowCount; i++)
            {
                if ((tableLayoutPanel1.Controls[string.Format("cbox_1_{0}", i)] as CheckBox).Checked)
                {
                    deathRow.Add(string.Format(folder1 + "\\" + (tableLayoutPanel1.Controls[string.Format("cbox_1_{0}", i)] as CheckBox).Text));
                }
            }
            var confirmDeletion = MessageBox.Show("Are you sure to permanently delete the seleceted files from your system? \nIt cannot be undone!",
                                     "Delete Confirmation!", MessageBoxButtons.YesNo);
            if (confirmDeletion == DialogResult.Yes)
            {
                done = true;
                foreach (string filePath in deathRow) 
                {
                    File.Delete(filePath);
                    string toShow = "";
                    toShow = string.Format(toShow + " " + filePath + "\n");
                    MessageBox.Show(string.Format("The files with the following paths has been deleted:\n" + toShow ));
                    for (int i = 0; i < identicalFiles[0].Length; i++)
                    {
                        if (identicalFiles[0][i] == filePath)
                        {
                            identicalFiles[0][i] = "na";
                            identicalFiles[1][i] = "na";
                        }
                    }  
                }
                Close();
            }
        }

        private void delSelectedFilesButton_Click(object sender, EventArgs e)
        {
            DeleteCheckedFiles(this, e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 1; i < tableLayoutPanel1.RowCount; i++)
            {
                if (!done
                    && ((tableLayoutPanel1.Controls[string.Format("cbox_0_{0}", i)] as CheckBox).Checked 
                    || (tableLayoutPanel1.Controls[string.Format("cbox_1_{0}", i)] as CheckBox).Checked))
                {
                    delSelectedFilesButton.Enabled = true;
                    return;
                }
            }
            if (delSelectedFilesButton.Enabled == true)
            {
                delSelectedFilesButton.Enabled = false;
            }

        }
    }
}
