using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;

namespace _20201125___009_Corrida
{
    public class Greyhound
    {
        public int StartingPoint;
        public int RaceTrackLength;
        public PictureBox MyPictureBox = null;
        public int Location = 0;
        public Random Randomizer;
        public string Name;

        public bool Run()
        {
            int distance;
            distance = Randomizer.Next(5, 15);

            MyPictureBox.Location = new Point(MyPictureBox.Location.X + distance, MyPictureBox.Location.Y);

            if (MyPictureBox.Location.X > RaceTrackLength)
                return true;
            else
                return false;

        }

        public void TakeStartPosition()
        {
            MyPictureBox.Location = new Point(20, MyPictureBox.Location.Y);
        }
    }
}
