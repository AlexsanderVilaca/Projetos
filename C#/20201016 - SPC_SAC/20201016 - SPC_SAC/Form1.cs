using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace _20201016___SPC_SAC
{
    public partial class Form1 : Form
    {
        struct Resultados 
        {
            public double pagamentos;
            public double pagamentosAcumulados;
            public double juros;
            public double amortizacao;
            public double saldoDevedor;
            public double jurosAcumulados;
            public double amortizacaoAcumulada;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double auxTaxa = double.Parse(txtTaxa.Text) / 100;

            if (selecionaTaxa.Text == "% a.a.")
                auxTaxa = (Math.Pow((1 + auxTaxa), (1.0 / 12.0))) - 1;

            if (radioSPC.Checked)
            {
                int auxPrestacoes = int.Parse(txtPrestacoes.Text);

                Resultados[] vetorSPC = new Resultados[auxPrestacoes + 2];

                vetorSPC[0].pagamentos = 0;
                vetorSPC[0].juros = 0;
                vetorSPC[0].amortizacao = 0;
                vetorSPC[0].saldoDevedor = double.Parse(txtSaldo.Text) - double.Parse(txtEntrada.Text);
                vetorSPC[0].jurosAcumulados = 0;
                vetorSPC[0].amortizacaoAcumulada = 0;
                vetorSPC[0].pagamentosAcumulados = 0;

                double auxN = double.Parse(txtPrestacoes.Text);
                double auxSaldo = vetorSPC[0].saldoDevedor;
                double auxPagamentos = auxSaldo * (((Math.Pow((1 + auxTaxa), auxN)) * auxTaxa) / ((Math.Pow((1 + auxTaxa), auxN)) - 1));

                for (int i = 1; i < auxPrestacoes + 1; i++)
                {
                    vetorSPC[i].juros = vetorSPC[i - 1].saldoDevedor * auxTaxa;

                    if (i == 1)
                        vetorSPC[1].jurosAcumulados = vetorSPC[i].juros;


                    vetorSPC[i].amortizacao = auxPagamentos - vetorSPC[i].juros;
                    vetorSPC[i].saldoDevedor = vetorSPC[i - 1].saldoDevedor - vetorSPC[i].amortizacao;
                    vetorSPC[i].jurosAcumulados = vetorSPC[i].juros + vetorSPC[i - 1].jurosAcumulados;
                    vetorSPC[i].amortizacaoAcumulada = vetorSPC[i].amortizacao + vetorSPC[i - 1].amortizacaoAcumulada;

                    vetorSPC[i].pagamentos = auxPagamentos;
                    vetorSPC[i].pagamentosAcumulados = vetorSPC[i].pagamentos + vetorSPC[i - 1].pagamentosAcumulados;
                }

                for (int j = 0; j <= auxPrestacoes + 1; j++)
                {
                    if (j == auxPrestacoes)
                    {
                        vetorSPC[j + 1].pagamentos = vetorSPC[j].pagamentosAcumulados;
                        vetorSPC[j + 1].juros = vetorSPC[j].jurosAcumulados;
                        vetorSPC[j + 1].amortizacao = vetorSPC[j].amortizacaoAcumulada;
                    }

                    string dados = (j).ToString() + ";" +
                                   (Math.Round(vetorSPC[j].pagamentos, 2)).ToString() + ";" +
                                   (Math.Round(vetorSPC[j].juros, 2)).ToString() + ";" +
                                   (Math.Round(vetorSPC[j].amortizacao, 2)).ToString() + ";" +
                                   (Math.Round(vetorSPC[j].saldoDevedor, 2)).ToString() + ";" +
                                   (Math.Round(vetorSPC[j].jurosAcumulados, 2)).ToString() + ";" +
                                   (Math.Round(vetorSPC[j].amortizacaoAcumulada, 2)).ToString() + Environment.NewLine;
                    File.AppendAllText("banco.txt", dados);
                }

            }
            else 
            {
                int auxPrestacoes = int.Parse(txtPrestacoes.Text);

                Resultados[] vetorSAC = new Resultados[auxPrestacoes + 2];

                vetorSAC[0].pagamentos = 0;
                vetorSAC[0].juros = 0;
                vetorSAC[0].amortizacao = 0;
                vetorSAC[0].saldoDevedor = double.Parse(txtSaldo.Text) - double.Parse(txtEntrada.Text);
                vetorSAC[0].jurosAcumulados = 0;
                vetorSAC[0].amortizacaoAcumulada = 0;

                vetorSAC[0].saldoDevedor = vetorSAC[0].saldoDevedor;

                double auxN = double.Parse(txtPrestacoes.Text);
                double auxSaldo = vetorSAC[0].saldoDevedor;
                double auxAmortizacao = auxSaldo/auxN;

                for(int i=1; i<=auxPrestacoes; i++)
                {
                    vetorSAC[i].juros = vetorSAC[i - 1].saldoDevedor * auxTaxa;
                    vetorSAC[i].pagamentos = vetorSAC[i].juros + auxAmortizacao;
                    vetorSAC[i].saldoDevedor = vetorSAC[i - 1].saldoDevedor - auxAmortizacao;
                    vetorSAC[i].amortizacao = auxAmortizacao;
                    vetorSAC[i].amortizacaoAcumulada = auxAmortizacao + vetorSAC[i - 1].amortizacaoAcumulada;
                    vetorSAC[i].jurosAcumulados = vetorSAC[i].juros + vetorSAC[i - 1].jurosAcumulados;
                }

                for (int j = 0; j <= auxPrestacoes + 1; j++)
                {
                    if (j == auxPrestacoes)
                    {
                        vetorSAC[j + 1].pagamentos = vetorSAC[j].pagamentosAcumulados;
                        vetorSAC[j + 1].juros = vetorSAC[j].jurosAcumulados;
                        vetorSAC[j + 1].amortizacao = vetorSAC[j].amortizacaoAcumulada;
                    }

                    string dados = (j).ToString() + ";" +
                                   (Math.Round(vetorSAC[j].pagamentos, 2)).ToString() + ";" +
                                   (Math.Round(vetorSAC[j].juros, 2)).ToString() + ";" +
                                   (Math.Round(vetorSAC[j].amortizacao, 2)).ToString() + ";" +
                                   (Math.Round(vetorSAC[j].saldoDevedor, 2)).ToString() + ";" +
                                   (Math.Round(vetorSAC[j].jurosAcumulados, 2)).ToString() + ";" +
                                   (Math.Round(vetorSAC[j].amortizacaoAcumulada, 2)).ToString() + Environment.NewLine;
                    File.AppendAllText("banco.txt", dados);
                }
            }
        }
    }
}
