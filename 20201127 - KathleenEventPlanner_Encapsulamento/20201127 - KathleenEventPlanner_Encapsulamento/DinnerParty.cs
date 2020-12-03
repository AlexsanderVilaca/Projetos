using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _20201127___KathleenEventPlanner_Encapsulamento
{
    class DinnerParty
    {
        public const int CostOfFoodPerPerson = 25;//constante do custo de comida

        private int numberOfPeople;//private indica que a variavel só pode ser acessada de dentro da classe
        public int NumberOfPeople
        {
            get 
            { 
                return numberOfPeople;//pode ser lida por qualquer outra classe
            }
            set 
            {
                numberOfPeople = value;//pode ser alterada por qualquer outra classe
                CalculateCostOfDecorations(fancyDecorations);//toda vez que a variável for setada haverá a execução do método que calcula o custo das decorações
            }
        }
        
        private bool fancyDecorations;

        public decimal CostOfBeveragesPerPerson;
        public decimal CostOfDecorations = 0;

        //construtores criam e inicializam objetos
        //construtores são métodos, e como todo método ele pode ser sobrecarregado
        public DinnerParty(int numberOfPeople, bool healthlyOption, bool fancyDecorations)//isto é um construtor, obs.:construtores devem receber o mesmo nome da classe
        {
            NumberOfPeople = numberOfPeople;
            //this serve para informar que a atribuição será na variável da classe e não do parâmetro
            //Ou seja será a variável da declarada na linha 27 recebe o valor do parametro do construtor
            this.fancyDecorations = fancyDecorations;
            SetHealthyOption(healthlyOption);
            CalculateCostOfDecorations(fancyDecorations);
        }

        public void SetPartyOptions(int people, bool fancy)
        {
            NumberOfPeople = people;
            CalculateCostOfDecorations(fancy);
        }
        
        public void SetHealthyOption(bool healtlyOption)
        {
            if (healtlyOption)
                CostOfBeveragesPerPerson = 5.00M;
            else
                CostOfBeveragesPerPerson = 20.00M;
        }

        public void CalculateCostOfDecorations(bool fancyOption)
        {
            fancyDecorations = fancyOption;
            if (fancyOption)
                CostOfDecorations = (Convert.ToDecimal(NumberOfPeople) * 15.00M) + 50M;
            else
                CostOfDecorations = (Convert.ToDecimal(NumberOfPeople) * 7.50M) + 30M;
        }

        public decimal CalculateCost(bool healthyOption)
        {
            decimal totalCost = CostOfDecorations + ((CostOfBeveragesPerPerson + Convert.ToDecimal(CostOfFoodPerPerson)) * NumberOfPeople);

            if (healthyOption)
                return totalCost;
            else
                return totalCost;
        }
    }
}
