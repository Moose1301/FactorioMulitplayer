using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factorio_Multiplayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            startInfo.FileName = "steam://run/427520";
            process.StartInfo = startInfo;
            process.Start();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            startInfo.FileName = "steam://run/427520//--mp-connect%20bhmm.net:9004/";
            process.StartInfo = startInfo;
            process.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            startInfo.FileName = "steam://run/427520//--mp-connect%20bhmm.net:9001/";
            process.StartInfo = startInfo;
            process.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            startInfo.FileName = "steam://run/427520//--mp-connect%20bhmm.net:9000/";
            process.StartInfo = startInfo;
            process.Start();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            startInfo.FileName = "steam://run/427520//--mp-connect%20bhmm.net:9002/";
            process.StartInfo = startInfo;
            process.Start();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            startInfo.FileName = "steam://run/427520//--mp-connect%20bhmm.net:9003/";
            process.StartInfo = startInfo;
            process.Start();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            startInfo.FileName = "steam://run/427520//--mp-connect%20bhmm.net:9005/";
            process.StartInfo = startInfo;
            process.Start();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            startInfo.FileName = "steam://run/427520//--mp-connect%20bhmm.net:9005/";
            process.StartInfo = startInfo;
            process.Start();
        }
    }
}
