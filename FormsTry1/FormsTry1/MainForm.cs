using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Threading;

namespace FormsTry1
{
    public partial class MainForm : Form
    {
        private HardwareData hardware;
        delegate void RefreshListDelegate();
        delegate void AddItemDelegate(object sender, EventArgs e);

        public MainForm()
        {
            hardware = new HardwareData();
            InitializeComponent();
            timer1.Tick += new EventHandler(timer_Tick); // Everytime timer ticks, timer_Tick will be called
            timer1.Interval = (10) * (1);                // Timer will tick evert second
            timer1.Enabled = true;                       // Enable the timer
            
        }

        void timer_Tick(object sender, EventArgs e)
        {
            // update list asynchronously

            RefreshListDelegate refreshList = new RefreshListDelegate(RefreshListview);
            Thread ulist = new Thread(() => listView1.BeginInvoke(refreshList));
            ulist.Name = "YOU ARE MINE";
            ulist.Start();
            

        }

        #region File comparison
        private int FileCompare(string file1, string file2)
        {
            int file1byte;
            int file2byte;
            FileStream fs1;
            FileStream fs2;

            // Determine if the same file was referenced two times.
            if (file1 == file2) { return 5; }
            try
            {
                FileStream f1 = new FileStream(file1, FileMode.Open);
                f1.Close();
            }
            catch (FileNotFoundException)
            {
                try
                {
                    FileStream f2 = new FileStream(file2, FileMode.Open);
                    f2.Close();
                }
                catch (FileNotFoundException) { return 4; }
                catch (IOException) { return 7; }
                return 2;
            }
            catch (IOException) { return 6; }
            try
            {
                FileStream f2 = new FileStream(file2, FileMode.Open);
                f2.Close();
            }
            catch (FileNotFoundException) { return 3; }
            catch (IOException) { return 7; }

            fs1 = new FileStream(file1, FileMode.Open);
            fs2 = new FileStream(file2, FileMode.Open);
            // Check the file sizes. If they are not the same, the files 
            // are not the same.
            if (fs1.Length != fs2.Length)
            {
                // Close the file
                fs1.Close();
                fs2.Close();

                // Return false to indicate files are different
                return 0;
            }

            // Read and compare a byte from each file until either a
            // non-matching set of bytes is found or until the end of
            // file1 is reached.
            do
            {
                // Read one byte from each file.

                file1byte = fs1.ReadByte();
                file2byte = fs2.ReadByte();
            }
            while ((file1byte == file2byte) && (file1byte != -1));

            // Close the files.
            fs1.Close();
            fs2.Close();

            // Return the success of the comparison. "file1byte" is 
            // equal to "file2byte" at this point only if the files are 
            // the same.
            if ((file1byte - file2byte) == 0) { return 1; }
            else { return 0; }
        }
        #endregion
        #region Folder comparison
        private List<string[]> folderCompare(string folder1, string folder2)

        {
            int file1byte;
            int file2byte;
            string[] folder1Files = Directory.GetFiles(folder1);
            string[] folder2Files = Directory.GetFiles(folder2);
            List<string[]> identicalFiles = new List<string[]> { };
            FileStream fs1;
            FileStream fs2;

            // Determine if the same file was referenced two times.
            if (folder1 == folder2)
            {
                MessageBox.Show("The same folder was entered twice (so, yes, they are identical).");
                return null;
            }
            foreach (string file1 in folder1Files)
            {
                try
                {
                    FileStream f1 = new FileStream(file1, FileMode.Open);
                    f1.Close();
                }
                catch (IOException)
                {
                    MessageBox.Show("File 1 (" + file1 + ") is being used by another application");
                    return null;
                }

                foreach (string file2 in folder2Files)
                {
                    try
                    {
                        FileStream f2 = new FileStream(file2, FileMode.Open);
                        f2.Close();
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("File 2 (" + file2 + ") is being used by another application");
                        return null;
                    }


                    fs1 = new FileStream(file1, FileMode.Open);
                    fs2 = new FileStream(file2, FileMode.Open);
                    // Check the file sizes. If they are not the same, the files 
                    // are not the same.
                    if (fs1.Length != fs2.Length)
                    {
                        // Close the file
                        fs1.Close();
                        fs2.Close();

                        // Return false to indicate files are different
                        //MessageBox.Show("The files " + file1 + " and " + file2 + "are not identical.");
                        continue;
                    }

                    // Read and compare a byte from each file until either a
                    // non-matching set of bytes is found or until the end of
                    // file1 is reached.
                    do
                    {
                        // Read one byte from each file.

                        file1byte = fs1.ReadByte();
                        file2byte = fs2.ReadByte();
                    }
                    while ((file1byte == file2byte) && (file1byte != -1));

                    // Close the files.
                    fs1.Close();
                    fs2.Close();

                    // Return the success of the comparison. "file1byte" is 
                    // equal to "file2byte" at this point only if the files are 
                    // the same.
                    if ((file1byte - file2byte) == 0)
                    {
                        identicalFiles.Add(new string[] { file1, file2 });
                    }
                    else
                    {
                        MessageBox.Show("The files " + file1 + " and " + file2 + "are not identical.");
                    }
                }
            }
            if (identicalFiles.ToArray().Length == 0)
            {
                MessageBox.Show("The folders " + folder1 + "and " + folder2 + " have no common files.");
            }
            return identicalFiles;

        }
        #endregion
        #region Single file comparison button
        private void dupeCheckBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.textBoxSingleFile1.Text) || string.IsNullOrEmpty(this.textBoxSingleFile1.Text) ||
                string.IsNullOrWhiteSpace(this.textBoxSingleFile2.Text) || string.IsNullOrEmpty(this.textBoxSingleFile2.Text)) //Make sure that the fields are not empty
            {
                MessageBox.Show("Please enter a path for both fields");
                return;
            }
            // Compare the two files that referenced in the textbox controls.
            switch (FileCompare(this.textBoxSingleFile1.Text, this.textBoxSingleFile2.Text))
            {
                case 0:
                    MessageBox.Show("The files are not identical.");
                    break;
                case 1:
                    MessageBox.Show("The files are identical.");
                    break;
                case 2:
                    MessageBox.Show("File 1 could not be found");
                    break;
                case 3:
                    MessageBox.Show("File 2 could not be found");
                    break;
                case 4:
                    MessageBox.Show("Both files could not be found");
                    break;
                case 5:
                    MessageBox.Show("The same file was entered twice (so, yeah, they are identical).");
                    break;
                case 6:
                    MessageBox.Show("File 1 is being used by another application");
                    break;
                case 7:
                    MessageBox.Show("File 2 is being used by another application");
                    break;
            }
        }
        #endregion
        #region Browsing files functions
        private void browseSingleFile1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textBoxSingleFile1.Text = openFileDialog1.FileName;
        }

        private void browseSingleFile2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textBoxSingleFile2.Text = openFileDialog1.FileName;
        }
        #endregion
        #region Folder browser functions
        private void browseFolder1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            textBoxFolder1.Text = folderBrowserDialog1.SelectedPath;
        }

        private void browseFolder2_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            textBoxFolder2.Text = folderBrowserDialog1.SelectedPath;
        }
        #endregion
        #region Folder comparison button function
        private void folderCheckBtn_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.textBoxFolder1.Text) || string.IsNullOrEmpty(this.textBoxFolder1.Text) ||
                string.IsNullOrWhiteSpace(this.textBoxFolder2.Text) || string.IsNullOrEmpty(this.textBoxFolder2.Text)) //Make sure that the fields are not empty
            {
                MessageBox.Show("Please enter a path for both fields");
                return;
            }
            // Compare the two files that referenced in the textbox controls.
            string[][] identicalFiles = folderCompare(textBoxFolder1.Text, textBoxFolder2.Text).ToArray();
            FileChoiceForm choiceForm = new FileChoiceForm(textBoxFolder1.Text, textBoxFolder2.Text, identicalFiles);
            choiceForm.Show();
            foreach (string[] i in identicalFiles)
            {

                //resultBox.AppendText(Path.GetFileName(i[0]) + " = " + Path.GetFileName(i[1]) );
                //resultBox.AppendText(" || ");


            }

        }
        #endregion
        #region List view fan entry clicked function
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                Fan_Control chosenFan = new Fan_Control("@");
                chosenFan.Text = item.Text;
                chosenFan.Show();
            }

        }
        #endregion


        private void RefreshListMethod()
        {
            
        }

        private void RefreshListview()
        {
            int count = 1;
            foreach (ListViewItem item in listView1.Items)
            {
                item.SubItems[2].Text = hardware.GetInfoBasedText(item.Index)[2];
                item.SubItems[3].Text = count++.ToString(); //hardware.GetInfoBasedText(item.Index)[3];
            }
        }
        

        #region Main form load
        private void main_Form_Load(object sender, EventArgs e)
        {
            AddItemDelegate addItem= new AddItemDelegate(loadCompTab);
            
            Thread ulist = new Thread(() => listView1.BeginInvoke(addItem, new object[] { this, e }));
            ulist.Name = "YOU ARE MINE";
            ulist.Start();
            textBoxFolder1.Text = "C:\\Users\\Itai Bieber\\Desktop\\1";
            textBoxFolder2.Text = "C:\\Users\\Itai Bieber\\Desktop\\2";

        }
        #endregion


        #region Components tab load
        private void loadCompTab(object sender, EventArgs e)
        {

            listView1.Items.Add(new ListViewItem(HardwareData.GetProcessorInfo()));
            //listView1.Columns[1].Width = TextRenderer.MeasureText(row[1], Font).Width; //Gets length of the "name" column
            listView1.Items.Add(new ListViewItem(HardwareData.GetFanInfo()));
            listView1.Items.Add(new ListViewItem(HardwareData.GetGpuInfo()));
            timer1.Start();                              // Start the timer

        }
        #endregion
    }
}