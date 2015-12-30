using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace HardwareChecker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            treeView1.Nodes.Add(Cpu.GetName());
            treeView1.Nodes.Add(VGA.GetName());
            treeView1.Nodes.Add("Disk Drive");
            treeView1.Nodes.Add(MainBoard.GetName());
           // treeView1.Nodes.Add("SystemDirectory: {0}", Environment.SystemDirectory);
            treeView1.Nodes.Add(Ram.GetDescription());



            //Processor specifiaction
            treeView1.Nodes[0].Nodes.Add("Speed: " + Cpu.GetSpeed());
            treeView1.Nodes[0].Nodes.Add("Architecture: " + Cpu.GetArchitecture());
            
            //Video controller specification
            treeView1.Nodes[1].Nodes.Add("Driver version: " + VGA.GetDriverVersion());
            treeView1.Nodes[1].Nodes.Add("RAM: " + VGA.GetRam());

            //HDD specification

            treeView1.Nodes[2].Nodes.Add("Name: " + DiskDrive.GetName());
            treeView1.Nodes[2].Nodes.Add("Size: " + DiskDrive.GetSize());

            //Main Board specification

            treeView1.Nodes[3].Nodes.Add("Serial number: " + MainBoard.GetSerialNumber());

            //Ram specification
            treeView1.Nodes[4].Nodes.Add("Physical Memory: " + Ram.GetPhysicalMemory());
            treeView1.Nodes[4].Nodes.Add("Memory speed: " + Ram.GetSpeed());
            treeView1.Nodes[4].Nodes.Add("Serial number: " + Ram.GetSerialNumber());



        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

    }


}
