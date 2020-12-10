using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20201210___Beehive_Management_System
{
    class Worker
    {
        public string CurrentJob;
        
        private string[] jobsICanDo;
        private int shiftsToWork;
        private int shiftsWorked;

        public Worker(string[] jobsICanDo)
        {
            this.jobsICanDo = jobsICanDo;
            ShiftsWorked = ShiftsToWork = 0;
        }

        public int ShiftsLeft
        {
            get { return ShiftsToWork - ShiftsWorked; }
        }

        public int ShiftsToWork
        {
            get
            {
                return shiftsToWork;
            }
        }

        public int ShiftsWorked
        {
            get { return shiftsWorked; }

        }

        

        public bool DoThisJob(string job, int shifts)
        {
            if (String.IsNullOrEmpty(CurrentJob) && (from x in jobsICanDo where x.Equals(job) select x))
            {
                CurrentJob = job;
                return true;
            }
            else
                return false;
        }

        public void WorkOneShift()
        {
            if (ShiftsLeft != 0)
            {
                ShiftsWorked++;
            }
            else
            {
                CurrentJob = null;
                ShiftsWorked = 0;
            }

        }
    }
}
