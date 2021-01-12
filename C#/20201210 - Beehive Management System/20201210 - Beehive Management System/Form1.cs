using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _20201210___Beehive_Management_System
{
    public partial class Form1 : Form
    {
        public Queen queen;
        public Form1()
        {
            InitializeComponent();
            Worker[] workers = new Worker[4];
            workers[0] = new Worker(new string[] { "Nectar collector", "Honey manufacturing" });
            workers[1] = new Worker(new string[] { "Egg care", "Baby bee tutoring" });
            workers[2] = new Worker(new string[] { "Hive maintenance", "Sting patrol" });
            workers[3] = new Worker(new string[] { "Nectar collector", "Honey manufacturing",
            "Egg care", "Baby bee tutoring", "Hive maintenance", "Sting patrol" });
            queen = new Queen(workers);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNextShift_Click(object sender, EventArgs e)
        {
            txtReport.Text = queen.WorkTheNextShift();
            //AtualizaReport();
        }

        private void btnAssignJob2Bee_Click(object sender, EventArgs e)
        {
            queen.AssignWork(cbSelectWorkerBee.Text, Convert.ToInt32(npNumberOfShifts.Value));
        }
    }
}
