using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20201210___Beehive_Management_System
{
    public class Worker
    {
        public string CurrentJob;
        
        private string[] jobsICanDo;
        private int shiftsToWork;
        private int shiftsWorked;

        public Worker(string[] jobsICanDo)
        {
            this.jobsICanDo = jobsICanDo;
            shiftsWorked = shiftsToWork = 0;
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
            if(!String.IsNullOrEmpty(CurrentJob))
                return false;

            foreach (string work in jobsICanDo)
            {
                if (work == job)
                {
                    CurrentJob = job;
                    shiftsToWork = shifts;
                    return true;
                }
            }

            return false;
        }

        public void WorkOneShift()
        {
            if (ShiftsLeft != 0)
            {
                shiftsWorked++;
            }
            else
            {
                CurrentJob = null;
                shiftsWorked = 0;
            }

        }
    }
}
