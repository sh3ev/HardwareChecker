using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;


namespace HardwareChecker
{
    class Cpu
    {
        public static String GetId()
        {
            ManagementClass mc = new ManagementClass("win32_processor");
            ManagementObjectCollection moc = mc.GetInstances();
            String Id = String.Empty;

            foreach (ManagementObject mo in moc)
            {
                Id = mo.Properties["processorID"].Value.ToString();
                break;
            }
            return Id;

        }

        public static String GetSpeed()
        {
            ManagementClass mc = new ManagementClass("win32_processor");
            ManagementObjectCollection moc = mc.GetInstances();
            String speed = String.Empty;

            foreach (ManagementObject mo in moc)
            {
                speed = mo.Properties["MaxClockSpeed"].Value.ToString();
                break;
            }
            return speed;

        }

        public static String GetName()
        {
            ManagementClass mc = new ManagementClass("win32_processor");
            ManagementObjectCollection moc = mc.GetInstances();
            String Name = String.Empty;

            foreach (ManagementObject mo in moc)
            {
                Name = mo.Properties["Name"].Value.ToString();
                break;
            }
            return Name;


        }
    }

}