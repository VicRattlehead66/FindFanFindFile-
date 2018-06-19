using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
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
            ManagementObjectSearcher temp = new ManagementObjectSearcher("root\\WMI",
                "SELECT * FROM MSAcpi_ThermalZoneTemperature");
            ManagementClass mc = new ManagementClass("win32_fan");
            ManagementObjectCollection moc = mc.GetInstances();
            ManagementObjectSearcher speed = new ManagementObjectSearcher("SELECT * FROM Win32_Fan");
            string[] Id = new string[5];
            Id[0] = "Fan";
            foreach (ManagementObject mo in moc)
            {

                Id[1] = mo.Properties["Name"].Value.ToString();
                Id[2] = mo.Properties["Status"].Value.ToString();
                break;
            }
            foreach (ManagementObject obj in temp.Get())
            {
                Double temperature = Convert.ToDouble(obj["CurrentTemperature"].ToString());
                Id[3] = Convert.ToString((temperature - 2732) / 10.0) + " C";
            }
            foreach (ManagementObject obj in speed.Get())
            {
                long vel = Convert.ToInt64(obj["DesiredSpeed"]);
                Id[4] = Convert.ToString(vel);
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

        
    }
}
