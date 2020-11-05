using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20201019___Cálculo_Incerteza
{
    static class  Calculos
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

    }
    public struct EstruturaModa
    {
        public float valor;
        public float repeticao;
    }

}
