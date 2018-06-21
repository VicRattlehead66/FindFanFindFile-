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
        private string currentDesiredSpeed;
        private string variableSpeed;
        private string currentSpeed;
        private HardwareData hardware;
        public Fan_Control(string currentDesiredSpeed, string variableSpeed, string currentSpeed)
        {
            this.variableSpeed = variableSpeed;
            this.currentDesiredSpeed = currentDesiredSpeed;
            this.currentSpeed = currentSpeed;
            hardware = new HardwareData();
            InitializeComponent();
        }

        private void Fan_Control_Load(object sender, EventArgs e)
        {
            if (variableSpeed == "False")
            {
                //Disabling all controls that were there to show the properties
                changeSpeedButton.Enabled = false;
                rpmSelect.Enabled = false;
                currentSpeedLabel.Visible = false;
                desiredSpeedLabel.Visible = false;

                //Showing the message explaining that this function is unavaliable
                vSpeedDisabled.Visible = true;
            }
            else
            {
                desiredSpeedLabel.Text = string.Format("Desired Speed: {0}", currentDesiredSpeed);
                currentSpeedLabel.Text = string.Format("Desired Speed: {0}", currentSpeed);
            }   
        }

        private void changeSpeedButton_Click(object sender, EventArgs e)
        {
            string sucess = hardware.SetFanSpeed(Convert.ToInt64(rpmSelect.Value));
            if (hardware.SetFanSpeed(Convert.ToInt64(rpmSelect.Value)) != "") { MessageBox.Show(sucess); }
            else { MessageBox.Show("Success!"); }
        }
    }
}
