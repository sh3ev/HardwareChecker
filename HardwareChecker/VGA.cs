using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace HardwareChecker
{
    class VGA
    {
        public static String GetName()
        {
            ManagementClass mc = new ManagementClass("win32_MotherboardDevice");
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
