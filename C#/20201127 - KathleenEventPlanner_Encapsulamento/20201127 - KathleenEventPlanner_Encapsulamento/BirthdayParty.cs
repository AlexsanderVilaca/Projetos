using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20201127___KathleenEventPlanner_Encapsulamento
{
    class BirthdayParty : Party
    {
        public int CakeSize;
        private string cakeWriting = "";

        //contrutor da festa de aniversário
        //usamos a palavra chave base para fazer referencia ao contrutor base 
        public BirthdayParty(int numberOfPeople, bool fancyOption, string cakeWriting) : base(numberOfPeople, fancyOption)
        {
            CalculateCakeSize();
            this.CakeWriting = cakeWriting;
            CalculateCostOfDecorations(fancyOption);
        }
        /// <summary>
        /// o get pega o valor que está em cakeWriting
        /// o set possui a seguinte lógica:
        /// -se o bolo for de 8", ele comporta no máximo uma inscrição de 16 caracteres
        /// -senão, ou seja, se ele for de 16", comporta até 40 caracteres
        /// </summary>
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
        
        public override int NumberOfPeople
        {
            get 
            {
                return base.NumberOfPeople;
            }
            set
            {
                base.NumberOfPeople = value;
                CalculateCakeSize();
                this.CakeWriting = cakeWriting;
            }
        }

        private void CalculateCakeSize()
        {
            if (NumberOfPeople <= 4)
                CakeSize = 8;
            else
                CakeSize = 16;
        }

        public override decimal CalculateCost()
        {
            decimal CakeCost;

            if (CakeSize == 8)
                CakeCost = 40M + CakeWriting.Length * 0.25M;
            else
                CakeCost = 75M + CakeWriting.Length * 0.25M;

            return base.CalculateCost() + CakeCost;
        }

        public void CalculateCostOfDecorations(bool fancyDecorations)
        {
            if (fancyDecorations)
                CostOfDecorations = (NumberOfPeople * 15.00M) + 50M;
            else
                CostOfDecorations = (NumberOfPeople * 7.50M) + 30M;
        }
    }
}
