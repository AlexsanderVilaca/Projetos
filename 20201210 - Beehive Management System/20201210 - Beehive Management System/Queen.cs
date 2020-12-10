using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20201210___Beehive_Management_System
{
    class Queen
    {
        private Worker[] workers;
        private int shiftNumber = 1;

        public Queen(Worker[] workers)
        {
            this.workers = workers;
        }

        public bool AssignWork(string jobToBePerformed, int numberOfShifts)
        {
            foreach (Worker worker in workers)
            {
                if (worker.DoThisJob(jobToBePerformed, numberOfShifts))
                    return true;
            }
            return false;
        }

        public string WorkTheNextShift()
        {
            string texto = null;
            texto += "Report for shift #" + shiftNumber;

            shiftNumber++;
            /*
            int index = 1;
            foreach (Worker worker in workers)
            {
                index++;
                worker.WorkOneShift();
                texto += "Worker #" + index + " is doing " + worker.Curr
            }
             * */

            for(int i=0; i<5; i++)
            {
                workers[i].WorkOneShift();

                texto += "Worker #" + i;

                if (String.IsNullOrEmpty(workers[i].CurrentJob))
                    texto += " is not working";
                else
                    texto += " is doing " + workers[i].CurrentJob + " for more " + workers[i].ShiftsLeft;
            }
            
            
        }
    }
}
