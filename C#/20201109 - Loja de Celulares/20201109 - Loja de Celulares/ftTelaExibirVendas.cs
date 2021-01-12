using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace _20201109___Loja_de_Celulares
{
    public partial class ftTelaExibirVendas : Form
    {
        public ftTelaExibirVendas()
        {
            InitializeComponent();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            string caminho = @"C:\Users\alexsander.rodrigues\Documents\Projetos C#\20201109 - Loja de Celulares\20201109 - Loja de Celulares\Dados\vendas.txt";
            string[] dados = File.ReadAllLines(caminho);
            int linhas = File.ReadAllLines(caminho).Count();

            tabelaDados.Columns.Add("codigo", "Código");
            tabelaDados.Columns.Add("marca", "Marca");
            tabelaDados.Columns.Add("preco", "Preço Unitário");
            tabelaDados.Columns.Add("precoFinal", "Preco Final");
            tabelaDados.Columns.Add("descricao", "Descrição");

            tabelaDados.Rows.Add(linhas);

            for (int linha = 0; linha < linhas; linha++)
            {
                string[] temp = dados[linha].Split(';');
                for (int coluna = 0; coluna < 5; coluna++)
                    tabelaDados.Rows[linha].Cells[coluna].Value = temp[coluna];
            }
            tabelaDados.AllowUserToAddRows = false;


        }
    }
}
