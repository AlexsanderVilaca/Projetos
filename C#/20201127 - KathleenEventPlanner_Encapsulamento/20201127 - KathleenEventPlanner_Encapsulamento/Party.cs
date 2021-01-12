using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20201127___KathleenEventPlanner_Encapsulamento
{
    public class Party
    {
        public const int CostOfFoodPerPearson = 25;
        public const int FeeLotOfPeople = 100;

        private int numberOfPeople;
        public virtual int NumberOfPeople
        {
            get 
            { 
                return numberOfPeople; 
            }
            set
            {
                numberOfPeople = value;
                CalculateCostOfDecorations(fancyOption);
            }
        }

        public decimal CostOfDecorations = 0;
        public bool fancyOption;

        public Party(int numberOfPeople, bool fancyOption)
        {
            this.NumberOfPeople = numberOfPeople;
            this.fancyOption = fancyOption;
        }

        public void CalculateCostOfDecorations(bool fancyOption)
        {
            this.fancyOption = fancyOption;
            if (this.fancyOption)
                CostOfDecorations = (NumberOfPeople * 15.0M) + 50.0M;
            else
                CostOfDecorations = (NumberOfPeople * 7.5M) + 30.0M;
        }

        public virtual decimal CalculateCost()
        {
            decimal TotalCost = CostOfDecorations + (NumberOfPeople * CostOfFoodPerPearson);

            if (NumberOfPeople > 12)
                return TotalCost += FeeLotOfPeople;
            else
                return TotalCost;
        }
    }
}
