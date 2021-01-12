using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _20201015___Calcula_Rendimento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            if (radioModoAporte.Checked)
            {
                label1.Text = "VF";
                label3.Text = "VP";
                label2.Text = "PMT";
            }
            else
            {
                label1.Text = "VP";
                label3.Text = "PMT";
                label2.Text = "VF";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (radioModoRendimento.Checked)
            {

                double VF;
                double VP = double.Parse(txtVP.Text);
                double PMT = double.Parse(txtPMT.Text);
                double i = double.Parse(txtTaxa.Text) / 100;
                double n = double.Parse(txtTempo.Text);

                if (selecionaTaxa.Text == "% a.a.")
                    i = (Math.Pow((1 + i), (1.0 / 12.0))) - 1;

                if (selecionaTempo.Text == "ano")
                    n = n * 12;

                VF = ((PMT * ((Math.Pow(1 + i, n) - 1)) / i)) + VP * Math.Pow(1 + i, n);
                
                txtSaida.Text = String.Format("R$ {0:F2}", VF);
            }

            if (radioModoAporte.Checked)
            {
                double PMT;
                double VP = double.Parse(txtVP.Text);
                double VF = double.Parse(txtPMT.Text);
                double i = double.Parse(txtTaxa.Text) / 100;
                double n = double.Parse(txtTempo.Text);

                if (selecionaTaxa.Text == "% a.a.")
                    i = (Math.Pow((1 + i), (1.0 / 12.0))) - 1;

                if (selecionaTempo.Text == "ano")
                    n = n * 12;

                PMT = ((VF - (VP * Math.Pow(1 + i, n))) * i) / (Math.Pow(1 + i, n) - 1);
                txtSaida.Text = txtSaida.Text = String.Format("R$ {0:F2} por mês", PMT);
            }
            
        }
    }
}
