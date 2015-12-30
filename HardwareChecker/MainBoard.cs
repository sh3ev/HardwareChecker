using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace HardwareChecker
{
    class MainBoard
    {
        public static String GetName()
        {
            ManagementClass mc = new ManagementClass("Win32_BaseBoard");
            ManagementObjectCollection moc = mc.GetInstances();
            String Name = String.Empty;

            foreach (ManagementObject mo in moc)
            {
                Name = mo.Properties["Name"].Value.ToString();
                break;
            }
            return Name;
        }

        public static String GetSerialNumber()
        {
            ManagementClass mc = new ManagementClass("Win32_BaseBoard");
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
