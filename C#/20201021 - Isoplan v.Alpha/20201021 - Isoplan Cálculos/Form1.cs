using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace _20201021___Isoplan_Cálculos
{
    public partial class Form1 : Form
    {
        public bool botaoAcionado = false;
        public bool botaoAcionado2 = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!botaoAcionado)
            {
                int numeroPontos = 0;

                while (true)
                {
                    try
                    {
                        numeroPontos = int.Parse(txtNumeroPontos.Text);
                        break;
                    }
                    catch
                    {
                        MessageBox.Show("Número inválido");
                        return;
                    }
                }

                tabelapontos.BorderStyle = BorderStyle.None;
                tabelapontos.Columns.Add("ponto", "Ponto");
                tabelapontos.Columns.Add("referencia", "Referência");
                tabelapontos.Columns.Add("leitura1", "Leitura 1");
                tabelapontos.Columns.Add("media", "Média");
                tabelapontos.Columns.Add("erro", "Erro");
                tabelapontos.Columns.Add("incerteza", "U");
                tabelapontos.Columns.Add("fatorK", "K");
                tabelapontos.Columns.Add("criterioAceitacao", "Crit. Aceit.");

                for (int i = 0; i < numeroPontos; i++)
                {
                    DataGridViewRow linhas = new DataGridViewRow();
                    linhas.CreateCells(tabelapontos);
                    tabelapontos.Rows.Add(linhas);
                }

                tabelaFinal.Columns.Add("ponto", "Ponto");
                tabelaFinal.Columns.Add("referencia", "Referência");
                tabelaFinal.Columns.Add("leitura1", "Leitura 1");
                tabelaFinal.Columns.Add("leitura2", "Leitura 2");
                tabelaFinal.Columns.Add("leitura3", "Leitura 3");
                tabelaFinal.Columns.Add("media", "Média");
                tabelaFinal.Columns.Add("erro","Erro");
                tabelaFinal.Columns.Add("incerteza", "U");
                tabelaFinal.Columns.Add("fatorK","K");
                tabelaFinal.Columns.Add("criterioAceitacao", "Crit. Aceit.");

                for (int i = 0; i < numeroPontos; i++)
                {
                    DataGridViewRow linhas = new DataGridViewRow();
                    linhas.CreateCells(tabelaFinal);
                    tabelaFinal.Rows.Add(linhas);
                    tabelaFinal.Rows[i].Cells[0].Style.BackColor = Color.LightGray;
                    tabelaFinal.Rows[i].Cells[1].Style.BackColor = Color.LightGray;
                    tabelaFinal.Rows[i].Cells[9].Style.BackColor = Color.LightGray;
                }

                float[,] dados = new float[tabelaFinal.Rows.Count, tabelaFinal.Columns.Count];

                tabelapontos.AllowUserToAddRows = false;
                tabelaFinal.AllowUserToAddRows = false;
                tabelaFinal.Columns["ponto"].ReadOnly = true;
                tabelaFinal.Columns["referencia"].ReadOnly = true;
            }
            botaoAcionado = true;
        }

        private void btnCalculos_Click(object sender, EventArgs e)
        {
            int numeroPontos = int.Parse(txtNumeroPontos.Text);
            float[] vetorDados = new float[1];
            txtIncerteza2.Text = "0";
            txtIncerteza3.Text = "0,005688585";

            for (int i = 0; i < numeroPontos; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    tabelaFinal.Rows[i].Cells[j].Value = tabelapontos.Rows[i].Cells[j].Value;
                }
            }
            botaoAcionado2 = true;

            for (int i = 0; i < numeroPontos; i++)
            {
                vetorDados[0] = Convert.ToSingle(tabelapontos.Rows[i].Cells[2].Value);

                double media = Calculos.Media(vetorDados);
                double erro = media - Convert.ToSingle(tabelapontos.Rows[i].Cells[1].Value);

                tabelapontos.Rows[i].Cells[3].Value = Math.Round(media, 4);
                tabelapontos.Rows[i].Cells[4].Value = Math.Round(erro, 4);
                tabelapontos.Rows[i].Cells[5].Value = 0.0114;
                tabelapontos.Rows[i].Cells[6].Value = String.Format("{0:F4}", 2);
                tabelaFinal.Rows[i].Cells[9].Value = Math.Round(Convert.ToDouble(tabelapontos.Rows[i].Cells[7].Value), 4);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int numeroPontos = int.Parse(txtNumeroPontos.Text);
            float[] vetorDados = new float[3];

            for (int i = 0; i < numeroPontos; i++)
            {
                vetorDados[0] = Convert.ToSingle(tabelaFinal.Rows[i].Cells[2].Value);
                vetorDados[1] = Convert.ToSingle(tabelaFinal.Rows[i].Cells[3].Value);
                vetorDados[2] = Convert.ToSingle(tabelaFinal.Rows[i].Cells[4].Value);

                double media = Calculos.Media(vetorDados);
                double erro = media - Convert.ToSingle(tabelaFinal.Rows[i].Cells[1].Value);
                double desvioPadrao = Calculos.DesvPad(vetorDados);
                double u1 = Calculos.IncertezaA(vetorDados, vetorDados.Length);
                double u2 = double.Parse(txtIncerteza2.Text);
                double u3 = double.Parse(txtIncerteza3.Text);
                double uCombinada = Calculos.UCombinada(u1, u2, u3);
                double veff = Calculos.GrausLiberdade(uCombinada, u1, vetorDados.Length);
                double fatorK = Calculos.FatorK(veff);
                double uFinal = Calculos.UFinal(fatorK, uCombinada);

                tabelaFinal.Rows[i].Cells[5].Value = Math.Round(media, 4);
                tabelaFinal.Rows[i].Cells[6].Value = Math.Round(erro, 4);
                tabelaFinal.Rows[i].Cells[7].Value = Math.Round(uFinal, 4);
                tabelaFinal.Rows[i].Cells[8].Value = Math.Round(fatorK, 3);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            int numeroPontos = int.Parse(txtNumeroPontos.Text);
            string texto = "";

            for (int i = 0; i < numeroPontos; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    texto += Convert.ToString(tabelapontos.Rows[i].Cells[j].Value) + ";";
                }
                texto += Environment.NewLine;
            }

            for (int i = 0; i < numeroPontos; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    texto += Convert.ToString(tabelaFinal.Rows[i].Cells[j].Value) + ";";
                }
                texto += Environment.NewLine;
            }
            File.AppendAllText("dados.txt", texto);
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            string[] vetor;
            int numeroPontos = int.Parse(txtNumeroPontos.Text);

            vetor = File.ReadAllLines("dados.txt");

            for (int i = 0; i < numeroPontos; i++)
            {
                string[] linha = vetor[i].Split(';');
                for (int j = 0; j < 8; j++)
                {
                    tabelapontos.Rows[i].Cells[j].Value = linha[j];
                }
            }

            int indice = vetor.Length / 2;
            for (int i = 0; i < numeroPontos; i++)
            {
                string[] linha = vetor[indice].Split(';');
                for (int j = 0; j < 10; j++)
                {
                    tabelaFinal.Rows[i].Cells[j].Value = linha[j];
                }
                indice++;
            }
        }
    }
}
