using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace _20201105___Threads
{
    public partial class Form1 : Form
    {
        //PerformanceCounter cpuCounter = new PerformanceCounter("% tempo processador", "tempoTotal");
        private PerformanceCounter cpuCounter;
        public Form1()
        {
            InitializeComponent();
            InitialiseCPUCounter();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            float tmp = cpuCounter.NextValue();
            label1.Text = String.Format("{0} %", tmp);
        }

        private void InitialiseCPUCounter()
        {
            cpuCounter = new PerformanceCounter("Processor Information", "% Processor Time", "_Total");
        }
    }
}
