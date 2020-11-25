using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace _20201125___009_Corrida
{
    public class Guy
    {
        public string Name;
        public Bet MyBet;
        public int Cash;

        public RadioButton MyRadioButton;
        public Label MyLabel;

        public void UpdateLabel()
        {
            MyLabel.Text = "{0} bets {1} bucks {2} on dog #{3}", Name, MyBet, MyBet;
            MyRadioButton.Text = Name + " has " + Cash + " bucks";
        }

        public void ClearBet()
        {

        }

        public bool PlaceBet(int amount, int Dog)
        {

        }

        public void Collect(int winner)
        {

        }
    }
}
