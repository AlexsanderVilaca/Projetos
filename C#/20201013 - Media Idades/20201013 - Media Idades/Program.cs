using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20201013___Media_Idades
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] idades = new int[5];
            for (int i = 0; i < 5; i++)
            {
                do
                {
                    try
                    {
                        Console.Write("Digite a idade {0}: ", i + 1);
                        idades[i] = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch 
                    {
                        Console.WriteLine("Idade inválida");
                    }
                } while (true);
            }
            
            Console.WriteLine("A média é: {0}", media(idades));
            
            Console.ReadKey();

            
        }
        static float media(int[] vetor)
        {
            float somatorio = 0;
            for (int i = 0; i < vetor.Length; i++)
            {
                somatorio += vetor[i];
            }
            return somatorio/vetor.Length;
        }
    }
}
