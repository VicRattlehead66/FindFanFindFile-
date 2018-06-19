using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsTry1
{
    public partial class Fan_Control : Form
    {
        private string currentSpeed;
        public Fan_Control(string currentSpeed)
        {
            this.currentSpeed = currentSpeed;
            InitializeComponent();
        }

        private void Fan_Control_Load(object sender, EventArgs e)
        {

        }
    }
}
