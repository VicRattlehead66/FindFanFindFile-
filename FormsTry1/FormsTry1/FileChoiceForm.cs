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
        string folder1;
        string folder2;
        string[][] identicalFiles;
        public FileChoiceForm(string folder1, string folder2, string[][] identicalFiles)
        {
            this.folder1 = folder1;
            this.folder2 = folder2;
            this.identicalFiles = identicalFiles;
            InitializeComponent();
            timer1.Tick += new EventHandler(timer_Tick); // Everytime timer ticks, timer_Tick will be called
            timer1.Interval = (10) * (1);                // Timer will tick evert second
            timer1.Enabled = true;                       // Enable the timer
            timer1.Start();                              // Start the timer
        }

        void timer_Tick(object sender, EventArgs e)
        {
            //bool waschecked = (tableLayoutPanel1.Controls[string.Format("cbox_1_{0}", i)] as CheckBox).Checked;
            for (int i = 1; i < tableLayoutPanel1.RowCount; i++)
            {
               
                
                if ((tableLayoutPanel1.Controls[string.Format("cbox_1_{0}", i)] as CheckBox).Checked)
                {
                    checkbox1_CheckedChanged(tableLayoutPanel1.Controls[string.Format("cbox_1_{0}", i)] as CheckBox, tableLayoutPanel1.Controls[string.Format("cbox_0_{0}", i)] as CheckBox, sender, e);
                }
                

            }

            for (int i = 1; i < tableLayoutPanel1.RowCount; i++)
            {
            
                if ((tableLayoutPanel1.Controls[string.Format("cbox_0_{0}", i)] as CheckBox).Checked)
                {
                    checkbox2_CheckedChanged(tableLayoutPanel1.Controls[string.Format("cbox_1_{0}", i)] as CheckBox, tableLayoutPanel1.Controls[string.Format("cbox_0_{0}", i)] as CheckBox, sender, e);
                }

            }

        }

        private void FileChoiceForm_Load(object sender, EventArgs e)
        {
            fileInFolder1label.Text = "File in " + folder1;
            FileInFolder2label.Text = "File in " + folder2;
            
            //set the table's amount of rows to the amount of identical files + one row for the header 
            tableLayoutPanel1.RowCount = identicalFiles[0].Length+1;
            tableLayoutPanel1.ColumnCount = 2;

            for (int i = 1; i < tableLayoutPanel1.RowCount; i++)
            {
                for (int j = 1; j < tableLayoutPanel1.ColumnCount; j++)
                {
                    // Create a CheckBox (or you can test for i or j to create a different control type)
                    // you might want to have a label for the first column right?

                    //Places a check box and filename in the first column
                    CheckBox cbox1 = new CheckBox(); 
                    cbox1.Text = Path.GetFileName(identicalFiles[i - 1][0]);
                    tableLayoutPanel1.Controls.Add(cbox1, 0, i);
                    cbox1.Name = string.Format("cbox_0_{0}", i);

                    //Places a check box and filename in the second column
                    CheckBox cbox2 = new CheckBox(); 
                    cbox2.Text = Path.GetFileName(identicalFiles[i - 1][1]);
                    tableLayoutPanel1.Controls.Add(cbox2, 1, i);
                    cbox2.Name = string.Format("cbox_1_{0}", i);
                }

            }


            //And you can test the value in a specific cell like this: Code Snippet
            // this is a way to test the value in a specific location

            
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

        }
        private void checkbox1_CheckedChanged(CheckBox c1, CheckBox c2, object sender, EventArgs e)
        {
            c2.Checked = (c1.Checked) ? false : c2.Checked ;
        }

        private void checkbox2_CheckedChanged(CheckBox c1, CheckBox c2, object sender, EventArgs e)
        {
            c1.Checked = (c2.Checked) ? false : c1.Checked;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }
    }
}
