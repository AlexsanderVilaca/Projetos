using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20201125___001_Jogo_de_Digitação
{
    class Stats
    {
        public int Total = 0;
        public int Missed = 0;
        public int Correct = 0;
        public int Accuracy = 0;

        public void Updade(bool correctKey)
        {
            Total++;

            if (!correctKey) Missed++;
            else Correct++;

            Accuracy = 100 * Correct / (Missed + Correct);
        }
    }
}
