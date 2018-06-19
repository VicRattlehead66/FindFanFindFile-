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
        /// <summary>
        /// Retrieving Processor Id.
        /// </summary>
        /// <returns></returns>
        /// 
        public static String GetProcessorName()
        {
            ManagementClass mc = new ManagementClass("win32_processor");
            ManagementObjectCollection moc = mc.GetInstances();
            String Id = String.Empty;
            foreach (ManagementObject mo in moc)
            {

                Id = mo.Properties["Name"].Value.ToString();
                break;
            }
            return Id;

        }

        public static String GetMachineName()
        {
            ManagementClass mc = new ManagementClass("win32_ComputerSystem");
            ManagementObjectCollection moc = mc.GetInstances();
            String Id = String.Empty;
            foreach (ManagementObject mo in moc)
            {

                Id = mo.Properties["Name"].Value.ToString();
                break;
            }
            return Id;

        }

        public static String GetMachineNameDefault()
        {
            ManagementClass mc = new ManagementClass("win32_ComputerSystem");
            ManagementObjectCollection moc = mc.GetInstances();
            String Id = String.Empty;
            foreach (ManagementObject mo in moc)
            {

                Id = mo.Properties["Model"].Value.ToString();
                break;
            }
            return Id;

        }
    }
}
