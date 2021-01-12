using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _20201013___Salario_e_Reajuste
{
    class Program
    {
        struct Pessoa {
            public string nome;
            public double salario;
        }

        static void Main(string[] args)
        {
            Pessoa[] vetorFuncionarios = new Pessoa[10];
            string[] vetor = new string[10];
            
            vetor = File.ReadAllLines("banco.txt");
            
            for (int i = 0; i < vetor.Length; i++)
            {
                int posicaoSeparador = vetor[i].IndexOf(';');
                vetorFuncionarios[i].nome = vetor[i].Substring(0, posicaoSeparador);
                vetorFuncionarios[i].salario = Convert.ToDouble(vetor[i].Substring(posicaoSeparador+1));

                double salario = vetorFuncionarios[i].salario;

                if (salario < 300)
                    salario *= 1.5;
                else if(salario < 700)
                    salario *= 1.4;
                else
                    salario *= 1.3;

                vetorFuncionarios[i].salario = salario;
            }

            string dataHoraAtual = Convert.ToString(DateTime.Now) + Environment.NewLine;
            File.AppendAllText("novoBanco.txt", dataHoraAtual);
            for (int i = 0; i < vetorFuncionarios.Length; i++)
            {
                string auxiliar = vetorFuncionarios[i].nome + ";" + vetorFuncionarios[i].salario + Environment.NewLine;
                File.AppendAllText("novoBanco.txt", auxiliar);
                //Console.WriteLine("{0} - {1}", teste[i].nome, teste[i].salario);
            }
            File.AppendAllText("novoBanco.txt", "\n");

            Console.ReadKey();
        }
    }
}
