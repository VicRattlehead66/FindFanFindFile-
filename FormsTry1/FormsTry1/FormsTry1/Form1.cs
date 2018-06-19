using System;
using System.Windows.Forms;
using System.IO;


namespace FormsTry1
{
    public partial class Form1 : Form
    {
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
            catch(FileNotFoundException)
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
            #endregion
        }
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadCompTab(this, e);
        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.textBox1.Text) || string.IsNullOrEmpty(this.textBox1.Text) ||
                string.IsNullOrWhiteSpace(this.textBox2.Text) || string.IsNullOrEmpty(this.textBox2.Text)) //Make sure that the fields are not empty
            {
                MessageBox.Show("Please enter a path for both fields");
                return;
            }
            // Compare the two files that referenced in the textbox controls.
            switch(FileCompare(this.textBox1.Text, this.textBox2.Text))
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textBox1.Text = openFileDialog1.FileName;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textBox2.Text = openFileDialog1.FileName;
        }

        private void loadCompTab(object sender, EventArgs e)
        {
            string[] item = {"CPU" , HardwareData.GetProcessorName()};
            var listViewItem = new ListViewItem(item);
            listView1.Items.Add(listViewItem);
            listView1.Columns[1].Width = item[1].Length*6;

            item[0] = "System";
            item[1] = HardwareData.GetMachineName();
            listViewItem = new ListViewItem(item);
            listView1.Items.Add(listViewItem);

            item[0] = "?";
            item[1] = HardwareData.GetMachineNameDefault();
            listViewItem = new ListViewItem(item);
            listView1.Items.Add(listViewItem);
        }
    }
}
