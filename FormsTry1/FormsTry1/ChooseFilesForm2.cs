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
    public partial class ChooseFilesForm2 : Form
    {
        string folder1;
        string folder2;
        string[][] identicalFiles;
        public ChooseFilesForm2(string folder1, string folder2, string[][] identicalFiles)
        {
            this.folder1 = folder1;
            this.folder2 = folder2;
            this.identicalFiles = identicalFiles;
            InitializeComponent();
        }
        private void chooseFilesForm_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("folder1Col", folder1);
            dataGridView1.Columns.Add("folder2Col", folder2);
            dataGridView1.Columns[0].Width = this.Width / 2;
            dataGridView1.Columns[1].Width = this.Width / 2;
            string[,] data = new string[identicalFiles.Length,2];
            int counter = 0;
            foreach (string[] i in identicalFiles)
            {
                data[counter, 0] = Path.GetFileName(i[0]);
                data[counter, 1] = Path.GetFileName(i[1]);
                //dataGridView1.Rows.Add(Path.GetFileName(i[0]), Path.GetFileName(i(1)));
                dataGridView1.Rows.Add(new string[] { data[counter, 0], data[counter, 1] });
                counter++;
                //resultBox.AppendText( + " = " + Path.GetFileName(i[1]) );
                //resultBox.AppendText(" || ");
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
