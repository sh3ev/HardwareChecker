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
            treeView1.Nodes.Add("Procesor" );

            treeView1.Nodes.Add("Motherboard");
            treeView1.Nodes.Add("BIOS");

            treeView1.Nodes[0].Nodes.Add("Name: " + Cpu.GetName());
            treeView1.Nodes[0].Nodes.Add("Speed: " + Cpu.GetSpeed() + " MHz");

            treeView1.Nodes[1].Nodes.Add("Name: " + VGA.GetName());

            treeView1.Nodes[2].Nodes.Add("Name: " + Bios.GetName());
            treeView1.Nodes[2].Nodes.Add("Serial number: " + Bios.GetSerialNumber());


        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

    }


}
