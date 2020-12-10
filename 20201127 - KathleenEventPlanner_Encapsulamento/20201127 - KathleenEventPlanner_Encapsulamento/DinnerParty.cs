using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _20201127___KathleenEventPlanner_Encapsulamento
{
    class DinnerParty : Party
    {
        public decimal CostOfBeveragesPerPerson;
        
        /*
        construtores criam e inicializam objetos
        obrigatoriamente um construtor deve ter o mesmo nome da classe
        construtores geralmente são usados para garantir que um objeto seja instanciado com determinados atributos 'setados'
        construtores são métodos, e como todo método ele pode ser sobrecarregado
         * */
        public DinnerParty(int numberOfPeople, bool healthlyOption, bool fancyDecorations) : base(numberOfPeople, fancyDecorations)
        {
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
            if (fancyOption)
                CostOfDecorations = (Convert.ToDecimal(NumberOfPeople) * 15.00M) + 50M;
            else
                CostOfDecorations = (Convert.ToDecimal(NumberOfPeople) * 7.50M) + 30M;
        }
        /* No trecho abaixo temos um problema:
         * Temos dois métodos com o mesmo nome, mas que não fazem a mesma coisa
         * para alguém desavisado que for dar manutenção ao código, pode acabar chamando
         * o método errado e obter um resultado não esperado
         * */
        public decimal CalculateCost(bool healthyOption)
        {
            //a palavra-chave 'base' é usada para acessar membros da classe base
            decimal totalCost = base.CalculateCost() + (CostOfBeveragesPerPerson * NumberOfPeople);
            
            if (healthyOption)
                return totalCost *= 0.95M;
            else
                return totalCost;
        }
    }
}
