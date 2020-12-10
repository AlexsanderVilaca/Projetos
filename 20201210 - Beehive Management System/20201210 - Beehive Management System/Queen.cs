using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20201210___Beehive_Management_System
{
    class Queen
    {
        private Worker[] workers;
        private int shuftNumber;

        public bool AssignWork(Worker worker)
        {
            
        }

        public void WorkTheNextShift()
        {
            foreach (Worker worker in workers)
                worker.WorkOneShift();
        }
    }
}
