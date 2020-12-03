using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20201127___KathleenEventPlanner_Encapsulamento
{
    class BirthdayParty
    {
        public const int CostOfFoodPerPearson = 25;

        public decimal CostOfDecorations = 0;
        public bool fancyDecorations;
        public int CakeSize;
        private string cakeWriting = "";
        private int numberOfPeople;

        public string CakeWriting
        {
            get 
            {
                return this.cakeWriting;
            }
            set
            {
                int maxLength;
                if (CakeSize == 8)
                    maxLength = 16;
                else
                    maxLength = 40;

                if (value.Length > maxLength)
                {
                    if (value.Length > this.cakeWriting.Length)
                        maxLength = this.cakeWriting.Length;
                    this.cakeWriting = cakeWriting.Substring(0, maxLength);
                }
                else
                    this.cakeWriting = value;
            }
        }
        
        public int NumberOfPeople
        {
            get 
            { 
                return numberOfPeople; 
            }
            set
            {
                numberOfPeople = value;
                CalculateCostOfDecorations(fancyDecorations);
                CalculateCakeSize();
                this.CakeWriting = cakeWriting;
            }
        }

        public BirthdayParty(int numberOfPeople, bool fancyDecorations, string cakeWriting)
        {
            this.NumberOfPeople = numberOfPeople;
            this.fancyDecorations = fancyDecorations;
            CalculateCakeSize();
            this.CakeWriting = cakeWriting;
            CalculateCostOfDecorations(fancyDecorations);
        }

        private void CalculateCakeSize()
        {
            if (NumberOfPeople <= 4)
                CakeSize = 8;
            else
                CakeSize = 16;
        }

        public decimal CalculateCost()
        {
            decimal TotalCost = CostOfDecorations + (CostOfFoodPerPearson * NumberOfPeople);
            decimal CakeCost;
            if (CakeSize == 8)
                CakeCost = 40M + CakeWriting.Length * 0.25M;
            else
                CakeCost = 75M + CakeWriting.Length * 0.25M;

            return TotalCost + CakeCost;
        }

        public void CalculateCostOfDecorations(bool fancyDecorations)
        {
            this.fancyDecorations = fancyDecorations;
            if (fancyDecorations)
                CostOfDecorations = (NumberOfPeople * 15.00M) + 50M;
            else
                CostOfDecorations = (NumberOfPeople * 7.50M) + 30M;
        }
    }
}
