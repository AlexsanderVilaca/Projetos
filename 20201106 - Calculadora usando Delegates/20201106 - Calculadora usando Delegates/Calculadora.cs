using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20201106___Calculadora_usando_Delegates
{
    public delegate double Calcular(double numero1, double numero2);//definindo o delegate
    class Calculadora
    {
        public double Somar(double numero1, double numero2)
        {
            return numero1 + numero2;
        }

        public double Subtrair(double numero1, double numero2)
        {
            return numero1 - numero2;
        }

        public double Multiplicar(double numero1, double numero2)
        {
            return numero1 * numero2;
        }

        public double Dividir(double numero1, double numero2)
        {
            return numero1 / numero2;
        }
    }
}
