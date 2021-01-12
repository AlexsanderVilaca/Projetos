using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20201014___Imprime_Caracteres_ASCII
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo = 0;

            do
            {
                Console.WriteLine("{0} {1}", codigo, Convert.ToChar(codigo));
                codigo++;
            }while(codigo <= 255);
            
            Console.ReadKey();
        }
    }
}
