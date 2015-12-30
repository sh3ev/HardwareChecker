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
            return speed + " Mhz";

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

        public static String GetArchitecture()
        {
            ManagementClass mc = new ManagementClass("win32_processor");
            ManagementObjectCollection moc = mc.GetInstances();
            String Arch = String.Empty;
            String a = "x86", b = "MIPS", c = "Alpha", d = "PowerPC", e = "ARM", f = "ia64", g ="x64", h = "UNKNOWN";

            foreach (ManagementObject mo in moc)
            {
                Arch = mo.Properties["Architecture"].Value.ToString();
                break;
            }
           
            int archInt = int.Parse(Arch);

            if (archInt == 0)
            {
                return a ;
            }
            if (archInt == 1)
            {
                return b;
            }
            if (archInt == 2)
            {
                return c;
            }
            if (archInt == 3)
            {
                return d;
            }
            if (archInt == 5)
            {
                return e;
            }
            if (archInt == 6)
            {
                return f;
            }
            if (archInt == 9)
            {
                return g;
            }
            else
            {
                return h;
            }

        }
            

        }
    }

