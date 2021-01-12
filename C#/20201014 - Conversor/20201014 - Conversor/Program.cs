using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20201014___Conversor
{
    class Program
    {
        static void Main(string[] args)
        {
            char teclaPressionada;
            double valor;

            
            do
            {
            Console.Clear();
            do
            {
                try 
                {
                    Console.WriteLine("Informe um valor inteiro para converter: ");
                    valor = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch 
                {
                    Console.WriteLine("Número inválido\n");
                }
            } while (true);

            Console.WriteLine("\nPressione uma das opções dadas:\n" +
                              "P -> converte de Polegadas para Centímetros.\n" +
                              "G -> converte de Galões para Litros.\n"+
                              "M -> converte de Milhas para Kilômetros.");

            teclaPressionada = LeEValidaTecla();

            Console.Write("\n");

            switch (teclaPressionada) 
            {
                case 'P':
                    Console.WriteLine("{0} polegadas[pol] são {1} centímetros[cm]", valor, valor*2.54);
                    break;
                case 'G':
                    Console.WriteLine("{0} galões[gal] são {1} litros[l]", valor, valor * 3.786);
                    break;
                case 'M':
                    Console.WriteLine("{0} milhas[mi] são {1} kilômetros[km]", valor, valor * 1.609);
                    break;
            }
            
            }while(VerificaDeNovo());
        }

        static bool VerificaDeNovo() 
        {
            char teste;
            do
            {
                Console.WriteLine("Tentar novamente?(S/N)");
                teste = Char.ToUpper(Console.ReadKey().KeyChar);
            } while (teste != 'S' && teste != 'N');

            if (teste == 'S')
                return true;
            else
                return false;
        }

        static char LeEValidaTecla() 
        {
            char tecla;
            do
            {
                tecla = Console.ReadKey().KeyChar;
                tecla = Char.ToUpper(tecla);
            } while (tecla != 'P' && tecla != 'G' && tecla != 'M');

            return tecla;
        }
    }
}
