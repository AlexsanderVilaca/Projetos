using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Linq.Expressions;

namespace _20201109___Loja_de_Celulares
{
    class FuncoesAuxiliares
    {
        public static string[] Buscar(string caminhoDaFonteDeDados, string dadoProcurado, int modoBusca)
        {
            //modoBusca=1 => busca no cadastro de novos aparelhos;
            //modoBusca=2 => busca no cadastro de vendas;
            string[] dados = File.ReadAllLines(caminhoDaFonteDeDados);
            string[] linha = new string[6];
            bool flagAchou = false;

            /*
                    nº da linha = temp[0]
                    Codigo      = temp[1]
                    Marca       = temp[2]
                    Preco       = temp[3]
                    Descricao   = temp[4]
                    PrecoFinal  = temp[5] somente se modoBusca = 2
                     * */
            for (int i = 0; i < dados.Length; i++)
            {
                linha = dados[i].Split(';');
                if (linha[0] == dadoProcurado)
                {
                    if (modoBusca == 1)
                        Array.Resize(ref linha, 5);
                    flagAchou = true;
                    break;
                }
            }

            if (flagAchou) return linha;
            else return null;
        }
    }
}
