using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Diagnostics;

namespace FormsTry1
{
    class HardwareData
    {
        public String[] GetInfoBasedText(int comp)
        {
            if (comp == 0)
            {
                return GetProcessorInfo();
            }
            else if (comp == 1)
            {
                return GetFanInfo();
            }

            else if (comp == 2)
            {
                return GetGpuInfo();
            }
            else if (comp == 3)
            {
                return GetHarddriveInfo();
            }

            return null;

        }
        /// <summary>
        /// Retrieving Processor Id.
        /// </summary>
        /// <returns></returns>
        /// 
        public static String[] GetProcessorInfo()
        {
            ManagementObjectSearcher temp = new ManagementObjectSearcher("root\\WMI",
    "SELECT * FROM MSAcpi_ThermalZoneTemperature");
            ManagementClass mc = new ManagementClass("win32_processor");
            ManagementObjectCollection moc = mc.GetInstances();
            string[] Id = new string[5];
            Id[0] = "CPU";
            foreach (ManagementObject mo in moc)
            {
                Id[1] = mo.Properties["Name"].Value.ToString();
                Id[2] = mo.Properties["Status"].Value.ToString();
                //Id[4] = (Convert.ToDouble(mo.Properties["CurrentVoltage"].Value) / 10).ToString() + " volts";
                break;
            }
            foreach (ManagementObject obj in temp.Get())
            {
                Double temperature = Convert.ToDouble(obj["CurrentTemperature"].ToString());
                Id[3] = Convert.ToString((temperature - 2732) / 10.0) + " C";
            }
            return Id;

        }

        public static String[] GetFanInfo()
        {
            //Create ManagementClass for the current speed property
            ManagementObjectSearcher cSpeed = new ManagementObjectSearcher("\\\\.\\ROOT\\cimv2:CIM_Tachometer");
            //Create management object searcher for the temperature property 
            ManagementObjectSearcher temp = new ManagementObjectSearcher("root\\WMI",
                "SELECT * FROM MSAcpi_ThermalZoneTemperature");
            //Create a management object searcher for the other properties
            ManagementObjectSearcher mos = new ManagementObjectSearcher("SELECT * FROM Win32_Fan"); 

            string[] Id = new string[8]; //Preparig  a string array in which the results will be returned
            Id[0] = "Fan"; //First value is the category name

            //Get all instances of the class and enumerate them
            foreach (ManagementObject mo in mos.Get()) 
            {
                Id[1] = mo["Name"].ToString(); //Name of the component
                Id[2] = mo["Status"].ToString(); //Component's status
                bool s = Convert.ToBoolean(mo["variableSpeed"]); //Wheater or not variable speed are supported
                Id[5] = s.ToString();
                if(!s) //No reason to search for desired speed if VariableSpeed is unavailable anyway
                {
                    long vel = Convert.ToInt64(mo["DesiredSpeed"]); //Desired speed of the component
                    Id[4] = Convert.ToString(vel);
                }
                break;
            }

            //Fetching the temperature by getting all instances of the class and enumerating them
            foreach (ManagementObject obj in temp.Get()) 
            {
                Double temperature = Convert.ToDouble(obj["CurrentTemperature"].ToString()); 
                Id[3] = Convert.ToString((temperature - 2732) / 10.0) + " C";
            }

            if (Id[5] == "True") //No reason to look for a current reading if VariableSpeed is unavailable anyway
            {
                //Get all instances of the class and enumerate them
                foreach (ManagementObject sObject in cSpeed.Get()) 
                {
                    Id[7] = sObject["CurrentReading"].ToString(); //Getting the current reading
                }
            }
            return Id;
        }

        public static String[] GetGpuInfo()
        {
            ManagementObjectSearcher temp = new ManagementObjectSearcher("root\\WMI",
                "SELECT * FROM MSAcpi_ThermalZoneTemperature");
            ManagementClass mc = new ManagementClass("win32_VideoController");
            ManagementObjectCollection moc = mc.GetInstances();
            string[] Id = new string[5];
            Id[0] = "GPU";
            foreach (ManagementObject mo in moc)
            {

                Id[1] = mo.Properties["Name"].Value.ToString();
                Id[2] = mo.Properties["Status"].Value.ToString();
                //Id[3] = mo.Properties["StatusInfo"].Value.ToString();
                break;
            }
            foreach (ManagementObject obj in temp.Get())
            {
                Double temperature = Convert.ToDouble(obj["CurrentTemperature"].ToString());
                Id[3]= Convert.ToString((temperature - 2732) / 10.0) + " C";
                                
            }   
            return Id;

        }

        public static String[] GetHarddriveInfo()
        {
            ManagementObjectSearcher temp = new ManagementObjectSearcher("root\\WMI",
    "SELECT * FROM MSAcpi_ThermalZoneTemperature");
            ManagementClass mc = new ManagementClass("win32_diskdrive");
            ManagementObjectCollection moc = mc.GetInstances();
            string[] Id = new string[5];
            Id[0] = "Hard disk";
            foreach (ManagementObject mo in moc)
            {
                Id[1] = mo.Properties["Name"].Value.ToString();
                Id[2] = mo.Properties["Status"].Value.ToString();
                //Id[4] = (Convert.ToDouble(mo.Properties["CurrentVoltage"].Value) / 10).ToString() + " volts";
                break;
            }
            foreach (ManagementObject obj in temp.Get())
            {
                Double temperature = Convert.ToDouble(obj["CurrentTemperature"].ToString());
                Id[3] = Convert.ToString((temperature - 2732) / 10.0) + " C";
            }
            return Id;
        }

        public string SetFanSpeed(long dSpeed)
        {
            try
            {
                ManagementObject classInstance =
                                   new ManagementObject("root\\CIMV2",
                                   "Win32_Fan.DeviceID='root\\cimv2 0'",
                                   null);

                // Obtain in-parameters for the method
                ManagementBaseObject inParams =
                    classInstance.GetMethodParameters("SetSpeed");

                // Add the input parameters.
                inParams["DesiredSpeed"] = dSpeed;

                // Execute the method and obtain the return values.
                ManagementBaseObject outParams =
                    classInstance.InvokeMethod("SetSpeed", inParams, null);

                // List outParams
                Console.WriteLine("Out parameters:");
                Console.WriteLine("ReturnValue: " + outParams["ReturnValue"]);
                return "";
            }
            catch (ManagementException err)
            {
                return string.Format("An error occurred while trying to execute the WMI method: " + err.Message);
            }
        }

    }
}
