using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace HardwareChecker
{
    class Ram
    {

        public static string GetDescription()
        {
            ManagementClass mc = new ManagementClass("Win32_PhysicalMemory");
            ManagementObjectCollection moc = mc.GetInstances();
            String Description = String.Empty;

            foreach (ManagementObject mo in moc)
            {
                Description = mo.Properties["Description"].Value.ToString();
                break;
            }
            return Description;

        }

        public static string GetPhysicalMemory()
        {
            ManagementScope oMs = new ManagementScope();
            ObjectQuery oQuery = new ObjectQuery("SELECT Capacity FROM Win32_PhysicalMemory");
            ManagementObjectSearcher oSearcher = new ManagementObjectSearcher(oMs, oQuery);
            ManagementObjectCollection oCollection = oSearcher.Get();

            long MemSize = 0;
            long mCap = 0;

            foreach (ManagementObject obj in oCollection)
            {
                mCap = Convert.ToInt64(obj["Capacity"]);
                MemSize += mCap;
            }
            MemSize = (MemSize / 1024) / 1024;
            return MemSize.ToString() + " MB";

        }

        public static string GetSpeed()
        {
            ManagementClass mc = new ManagementClass("Win32_PhysicalMemory");
            ManagementObjectCollection moc = mc.GetInstances();
            String Speed = String.Empty;

            foreach (ManagementObject mo in moc)
            {
                Speed = mo.Properties["Speed"].Value.ToString();
                break;
            }
            return Speed + " Mhz";

        }


        public static string GetSerialNumber()
        {
            ManagementClass mc = new ManagementClass("Win32_PhysicalMemory");
            ManagementObjectCollection moc = mc.GetInstances();
            String Serial = String.Empty;

            foreach (ManagementObject mo in moc)
            {
                Serial = mo.Properties["SerialNumber"].Value.ToString();
                break;
            }
            return Serial;

        }




    }
}
