using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _20201125___009_Corrida
{
    public class Bet
    {
        public int Amount;
        public Greyhound Dog;
        public Guy Bettor;

        public string GetDescription()
        {
            if(Amount != 0)
                return Bettor.Name + " bets " + Amount + " on " + Dog.Name;
            else
                return Bettor.Name + " hasn't placed a bet ";
            
        }

        public int PayOut(Greyhound winner)
        {
            if (winner == Dog)
                return Amount;
            else
                return Amount * -1;
        }
    }
}
