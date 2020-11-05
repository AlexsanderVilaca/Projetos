using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20201014___Matriz_Identidade
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            
            while (true) 
            {
                try
                {
                    Console.WriteLine("Digite um numero");
                    n = int.Parse(Console.ReadLine());
                    break;
                }
                catch 
                {
                    Console.WriteLine("Número inválido");
                }
            }

            for (int i = 0; i <n; i++) 
            {
                Console.Write("|");
                for (int j = 0; j < n; j++) 
                {
                    if (i == j)
                        Console.Write(" 1 ");
                    else
                        Console.Write(" 0 ");
                }
                Console.Write("|");
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
