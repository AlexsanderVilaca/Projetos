using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace _20201125___009_Corrida
{
    public class Guy
    {
        public string Name;
        public Bet MyBet;
        public int Cash;

        public RadioButton MyRadioButton;
        public TextBox MyTextBox;

        public void UpdateLabels()
        {
            if (MyBet != null)
            {
                MyTextBox.Text = MyBet.GetDescription();

                MyRadioButton.Text = Name + " has " + (Cash - MyBet.Amount).ToString() + " bucks";
            }
            else
            {
                MyTextBox.Text = Name + " hasn't placed a bet";
                MyRadioButton.Text = Name + " has " + Cash.ToString() + " bucks";

            }
        }

        public bool PlaceBet(int amount, Greyhound dog)
        {
            if (amount <= Cash)
            {
                MyBet = new Bet();
                MyBet.Amount = amount;
                MyBet.Dog = dog;
                MyBet.Bettor = this;
                UpdateLabels();

                return true;
            }
            else
            {
                return false;
            }
        }

        public void ClearBelt()
        {
            MyBet = null;
            UpdateLabels();
        }

        public void Collect(Greyhound winner)
        {
            if (MyBet != null)
                Cash += MyBet.PayOut(winner);
        }
    }
}
