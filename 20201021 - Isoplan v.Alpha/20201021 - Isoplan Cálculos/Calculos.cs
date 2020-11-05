using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20201021___Isoplan_Cálculos
{
    static class Calculos
    {
        public static float Media(this float[] vetor) 
        {
            float soma = Somatorio(vetor);
            return soma/vetor.Length;
        }

        public static float Mediana(this float[] vetor) 
        {
            vetor = Ordena(vetor);

            if (vetor.Length % 2 == 0)
                return (vetor[vetor.Length] + vetor[vetor.Length + 1]) / 2;
            else 
                return vetor[(vetor.Length / 2) + 1];
        }

        public static float[] Moda(float[] vetor)
        {
            int indice = 0, ctrlVetorContador = 0;

            EstruturaModa[] vetorModa = new EstruturaModa[vetor.Length];

            for (int i = 0; i < vetor.Length; i++) 
            {
                vetorModa[ctrlVetorContador].valor = vetor[indice];
                if (vetor[indice] == vetor[i])
                {
                    vetorModa[ctrlVetorContador].repeticao += 1;
                }
                else
                {
                    indice = i;
                    i--;
                    ctrlVetorContador++;
                }
            }


            int posicao = 1;
            for(int i=0; i<vetorModa.Length; i++)
                if(vetorModa[i].valor == 0)
                {
                    posicao = i;
                    break;
                }

            Array.Resize(ref vetorModa, posicao);


            float maiorRepeticao = 0;
            for (int i = 0; i < vetorModa.Length-1; i++)
            {
                if (vetorModa[i].repeticao > vetorModa[i + 1].repeticao)
                    maiorRepeticao = vetorModa[i].repeticao;
            }
            
            int indiceAux = 0;
            float[] vetorAux = new float[vetorModa.Length];

            for (int i = 0; i < vetorModa.Length; i++)
            {
                if (vetorModa[i].repeticao == maiorRepeticao)
                {
                    vetorAux[indiceAux] = vetorModa[i].valor;
                    indiceAux++;
                }
            }

            for (int i = 0; i < vetorAux.Length; i++)
                if (vetorAux[i] == 0)
                {
                    posicao = i;
                    break;
                }
            Array.Resize(ref vetorAux, posicao);

            return vetorAux;

            //esse está certo, não apagar
            //

        }

        public static float Somatorio(float[] vetor)
        {
            float somatorio=0;
            
            for(int i=0; i<vetor.Length; i++)
                somatorio += vetor[i];

            return somatorio;
        }

        public static float[] Ordena(float[] vetor) 
        {
            float auxiliar;
            for (int i = 0; i < vetor.Length - 1; i++)
                for (int j = i+1; j < vetor.Length; j++)
                    if (vetor[i] > vetor[j])
                    {
                        auxiliar = vetor[i];
                        vetor[i] = vetor[j];
                        vetor[j] = auxiliar;
                    }
            return vetor;
        }

        public static double DesvPad(float[] vetor)
        {
            float media = Media(vetor);
            float[] vetorDistancia = new float[vetor.Length];

            for (int i = 0; i < vetor.Length; i++)
            {
                float diferenca = vetor[i] - media;
                vetorDistancia[i] = diferenca * diferenca;
            }

            return Math.Sqrt(Somatorio(vetorDistancia) / (vetorDistancia.Length -1));

        }

        public static double RaizSomaDosQuadrados(float[] vetor) 
        {
            double soma = 0;

            for (int i = 0; i < vetor.Length; i++)
            {
                soma += Math.Pow(vetor[i], 2);
            }

            return Math.Sqrt(soma);
        }

        public static double Interpolacao(double limLow, double limHigh, double engLow, double engHigh)
        {
            double taxa = (engHigh - engLow) / (limHigh - limLow);
            return taxa;
        }

        public static double IncertezaA(float[] vetor, int numeroMedidas)
        {
            double U = Calculos.DesvPad(vetor)/Math.Sqrt(Convert.ToDouble(numeroMedidas));
            return U;
        }

        public static double UCombinada(double u1, double u2, double u3)
        {
            double uCombinada = Math.Sqrt((u1 * u1) + (u2 * u2) + (u3 * u3));
            return uCombinada;
        }

        public static double GrausLiberdade(double uCombinada, double u1, int numeroMedicoes)
        {
            double veff = Math.Pow(uCombinada, 4) / ((Math.Pow(u1, 4)) / (numeroMedicoes - 1));
            return veff;
        }

        public static double FatorK(double grausLiberdade)
        {
            int indice = 0;
            double taxa;
            double[] listaTStudent = new double[28] { 13.97, 4.53, 3.31, 2.87, 2.65, 2.52, 2.43, 2.37, 2.32, 2.28, 2.25, 2.23, 2.21, 2.20, 2.18, 2.17, 2.16, 2.15, 2.14, 2.13, 2.11, 2.09, 2.07, 2.06, 2.06, 2.05, 2.025, 2 };
            double[] vetorGraus = new double[28] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 25, 30, 35, 40, 45, 50, 100, 0};

            int grauLiberdadeInferior = Convert.ToInt32(Math.Floor(grausLiberdade));
            int grauLiberdadeSuperior = Convert.ToInt32(Math.Ceiling(grausLiberdade));

            for (int i = 0; i < vetorGraus.Length; i++)
            {
                indice = i;
                if (grausLiberdade < vetorGraus[i])
                {
                    grauLiberdadeInferior = Convert.ToInt32(vetorGraus[i - 1]);
                    grauLiberdadeSuperior = Convert.ToInt32(vetorGraus[i]);
                    break;
                }
            }

            taxa = Calculos.Interpolacao(grauLiberdadeSuperior, grauLiberdadeInferior, listaTStudent[indice], listaTStudent[indice-1]);

            double K = (taxa*(grausLiberdade - grauLiberdadeInferior)) + listaTStudent[indice-1];

            return K;
        }

        public static double UFinal(double fatorK, double uCombinada)
        {
            return fatorK * uCombinada;
        }
    }
    public struct EstruturaModa
    {
        public float valor;
        public float repeticao;
    }
}
