using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20201013___Par_ou_Impar
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;

            do{
                do
                {
                    try
                    {
                        Console.Write("Digite um número: ");
                        numero = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Número inválido!");
                    }
                } while (true);

                if (VerificaParidade(numero))
                    Console.WriteLine("É par");
                else
                    Console.WriteLine("É ímpar");
            }while(true);
        }

        static bool VerificaParidade(int numero)
        {
            if (numero % 2 == 0)
                return true;
            else
                return false;
        }
    }
}
