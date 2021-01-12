using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _20201109___Exemplo_Lambda_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma palavra para pesquisar: ");
            string dado = Console.ReadLine().ToUpper();

            string[] estados = { "SÃO PAULO", "MATO GROSSO", "RIO DE JANEIRO", "MINAS GERAIS", "PARANÁ", "CEARÁ"};

            string pesquisa = (from estado in estados where estado.Contains(dado) select estado).First();

            Console.WriteLine(pesquisa);

            Console.ReadKey();

        }
    }
}
