using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using _20201109___Loja_de_Celulares.Dados;
using System.Web.Script.Serialization;

namespace _20201109___Loja_de_Celulares
{
    public partial class frTelaCadastroVenda : Form
    {
        public frTelaCadastroVenda()
        {
            InitializeComponent();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            string caminho = @"C:\Users\alexsander.rodrigues\Documents\Projetos C#\20201109 - Loja de Celulares\20201109 - Loja de Celulares\Dados\vendas.txt";
            int quantidade;
            double precoFinal;

            Celular cel = new Celular(Convert.ToInt32(txtCodigo.Text), txtMarca.Text, Convert.ToDouble(txtPreco.Text), txtDescricao.Text);

            if (int.TryParse(txtQuantidade.Text, out quantidade))
            {
                quantidade = Convert.ToInt32(txtQuantidade.Text);
            }
            else
            {
                MessageBox.Show("Digite uma quantidade maior que 0");
                txtQuantidade.Clear();
                return;
            }

            precoFinal = Convert.ToDouble(cel.Preco) * Convert.ToDouble(quantidade);

            File.AppendAllText(caminho, cel.Codigo.ToString() + ";" + cel.Marca + ";" + cel.Preco + ";" + precoFinal.ToString() + ";" + cel.Descricao + Environment.NewLine);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string[] dados = File.ReadAllLines(@"C:\Users\alexsander.rodrigues\Documents\Projetos C#\20201109 - Loja de Celulares\20201109 - Loja de Celulares\Dados\celulares.txt");
            string[] linha = new string[dados.Length];
            string[] temp = new string[5];
            bool flagAchou = false;

            for (int i = 0; i < dados.Length; i++)
            {
                linha[i] = dados[i].Split(';')[0];
                if (linha[i] == txtCodigo.Text)
                {
                    temp = dados[i].Split(';');
                    txtCodigo.Text = temp[0];
                    txtMarca.Text = temp[1];
                    txtPreco.Text = temp[2];
                    txtDescricao.Text = temp[3];
                    flagAchou = true;
                    break;
                }
            }
            btnVender.Enabled = flagAchou ? true : false;
                
            if (!flagAchou)
            {
                foreach (Control controle in this.Controls)
                    if (controle.GetType() == typeof(TextBox))
                        controle.Text = "";
                MessageBox.Show("Código não encontrado!");
            }
        }
    }
}
