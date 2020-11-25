using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace _20201125___009_Corrida
{
    public class Greyhound
    {
        public int StartingPosition;
        public int RacetrackLength;
        public PictureBox MyPictureBox = null;
        public int Location = 0;
        public Random Randomizer;

        
        public bool Run()
        {
            Randomizer = new Random();
            int passo = Randomizer.Next(1, 4);

            MyPictureBox.Location.X += passo;

            if (MyPictureBox.Location.X > 815)
                return true;
            else
                return false;
        }

        public void TakeStartingPosition(int y)
        {
            MyPictureBox.Location = new Point(32, y);
        }
    }
}
