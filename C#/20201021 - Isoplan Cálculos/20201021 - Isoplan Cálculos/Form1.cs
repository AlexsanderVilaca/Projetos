using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _20201021___Isoplan_Cálculos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {
            float[] vetorDados = new float[3];

            try
            {
                vetorDados[0] = float.Parse(txtLeitura1.Text);
                vetorDados[1] = float.Parse(txtLeitura2.Text);
                vetorDados[2] = float.Parse(txtLeitura3.Text);
            }
            catch
            {
                
            }

            double media = Calculos.Media(vetorDados);
            double devioPadrao = Calculos.DesvPad(vetorDados);
            double u1 = Calculos.IncertezaA(vetorDados, vetorDados.Length);
            double u2 = double.Parse(txtIncerteza2.Text);
            double u3 = double.Parse(txtIncerteza3.Text);
            double uCombinada = Calculos.UCombinada(u1, u2, u3);
            double veff = Calculos.GrausLiberdade(uCombinada, u1, vetorDados.Length);
            double fatorK = Calculos.FatorK(veff);
            double uFinal = Calculos.UFinal(fatorK, uCombinada);

            txtMedia.Text = media.ToString();
            txtDesvPad.Text = devioPadrao.ToString();
            txtIncerteza1.Text = u1.ToString();
            txtIncerteza4.Text = uCombinada.ToString();
            txtVeff.Text = veff.ToString();
            txtK.Text = fatorK.ToString();
            txtIncertezaFinal.Text = uFinal.ToString();

        }
    }
}
