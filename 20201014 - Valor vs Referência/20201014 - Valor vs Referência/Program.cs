using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20201014___Valor_vs_Referência
{
    class Program
    {
        static void Main(string[] args)
        {
            string variavelTeste = "Valor inicial não alterado";

            Console.Write("Passagem por valor: ");
            TestePorValor(variavelTeste);
            Console.WriteLine(variavelTeste);

            Console.Write("Passagem por referência: ");
            TestePorRef(ref variavelTeste);
            Console.WriteLine(variavelTeste);
            
            Console.ReadKey();
        }

        static void TestePorValor(string argumento) 
        {
            argumento = "Valor foi alterado";
        }

        static void TestePorRef(ref string argumento)
        {
            argumento = "Valor foi alterado";
        }
    }
}
