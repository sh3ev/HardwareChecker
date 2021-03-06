﻿using System;
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
            ManagementClass mc = new ManagementClass("Win32_VideoController");
            ManagementObjectCollection moc = mc.GetInstances();
            String Name = String.Empty;

            foreach (ManagementObject mo in moc)
            {
                Name = mo.Properties["Name"].Value.ToString();
                break;
            }
            return Name;

        }

        public static String GetDriverVersion()
        {
            ManagementClass mc = new ManagementClass("Win32_VideoController");
            ManagementObjectCollection moc = mc.GetInstances();
            String Version = String.Empty;

            foreach (ManagementObject mo in moc)
            {
                Version = mo.Properties["DriverVersion"].Value.ToString();
                break;
            }
            return Version;

        }

        public static string GetRam()
        {
            ManagementScope oMs = new ManagementScope();
            ObjectQuery oQuery = new ObjectQuery("SELECT AdapterRAM FROM Win32_VideoController");
            ManagementObjectSearcher oSearcher = new ManagementObjectSearcher(oMs, oQuery);
            ManagementObjectCollection oCollection = oSearcher.Get();

            long Size = 0;

            foreach (ManagementObject obj in oCollection)
            {
                Size = Convert.ToInt64(obj["AdapterRAM"]);
            }
            Size = (Size / 1024) /1024 /1024;
            return Size.ToString() + " GB";

        }


    }
}
