using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20201014___Sort_Simples
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = ValidaEntrada("Informe quantos números voce quer usar: ", "Número Inválido");
            int[] vetor = new int[numero];

            for (int i = 0; i < numero; i++) 
            {
                string aux = "Informe o no. " + Convert.ToString(i+1) + " Valor:"; 
                vetor[i] = ValidaEntrada(aux, "Número Inválido");
            }
            
            vetor = Ordena(vetor);

            foreach (int valor in vetor) 
            {
                Console.WriteLine(valor);
            }
            Console.ReadKey();


        }

        static int ValidaEntrada(string textoEntrada, string textoErro) 
        {
            while (true)
            {
                try
                {
                    Console.WriteLine(textoEntrada);
                    int entrada = int.Parse(Console.ReadLine());
                    return entrada;
                }
                catch
                {
                    Console.WriteLine(textoErro);
                }
            }
        }

        static int[] Ordena(int[] vetor) 
        {
            int aux;
            for (int i = 0; i < vetor.Length-1; i++)
            {
                for(int j=i+1; j<vetor.Length; j++)
                {
                    if(vetor[i] > vetor[j])
                    {
                        aux = vetor[i];
                        vetor[i] = vetor[j];
                        vetor[j] = aux;
                    }
                }
            }
            return vetor;
        }
    }
}
