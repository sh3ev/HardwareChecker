using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace HardwareChecker
{
    class DiskDrive
    {
        public static String GetName()
        {
            ManagementClass mc = new ManagementClass("Win32_DiskDrive");
            ManagementObjectCollection moc = mc.GetInstances();
            String Name = String.Empty;

            foreach (ManagementObject mo in moc)
            {
                Name = mo.Properties["Model"].Value.ToString();
                break;
            }
            return Name;
        }

        public static string GetSize()
        {
            ManagementScope oMs = new ManagementScope();
            ObjectQuery oQuery = new ObjectQuery("SELECT Size FROM Win32_DiskDrive");
            ManagementObjectSearcher oSearcher = new ManagementObjectSearcher(oMs, oQuery);
            ManagementObjectCollection oCollection = oSearcher.Get();

            long Size = 0;

            foreach (ManagementObject obj in oCollection)
            {
                Size = Convert.ToInt64(obj["Size"]);
            }
            Size = (Size / 1024) / 1024 / 1024;
            return Size.ToString() + " GB";

        }
    }

}
