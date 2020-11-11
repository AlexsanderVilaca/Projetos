using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _20201106___Calculadora_usando_Delegates
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double numero1 = 0;
        double numero2 = 0;

        static Calculadora novaCalculadora = new Calculadora();//criando uma instância da classe

        Calcular Somar = new Calcular(novaCalculadora.Somar);
        Calcular Subtrair = new Calcular(novaCalculadora.Subtrair);
        Calcular Multiplicar = new Calcular(novaCalculadora.Multiplicar);
        Calcular Dividir = new Calcular(novaCalculadora.Dividir);


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            try
            {
                numero1 = double.Parse(txtCaixa1.Text);
                numero2 = double.Parse(txtCaixa2.Text);

                txtResultado.Text = Somar(numero1, numero2).ToString();
            }
            catch (Exception mensagem)
            {
                MessageBox.Show(mensagem.ToString());
                btnLimpa.PerformClick();
                return;
            }
        }

        private void btnSubtrai_Click(object sender, EventArgs e)
        {
            try
            {
                numero1 = double.Parse(txtCaixa1.Text);
                numero2 = double.Parse(txtCaixa2.Text);

                txtResultado.Text = Subtrair(numero1, numero2).ToString();
            }
            catch (Exception mensagem)
            {
                MessageBox.Show(mensagem.ToString());
                btnLimpa.PerformClick();
                return;
            }
        }

        private void btnMultiplica_Click(object sender, EventArgs e)
        {
            try
            {
                numero1 = double.Parse(txtCaixa1.Text);
                numero2 = double.Parse(txtCaixa2.Text);

                txtResultado.Text = Multiplicar(numero1, numero2).ToString();
            }
            catch (Exception mensagem)
            {
                MessageBox.Show(mensagem.ToString());
                btnLimpa.PerformClick();
                return;
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            try
            {
                numero1 = double.Parse(txtCaixa1.Text);
                numero2 = double.Parse(txtCaixa2.Text);

                txtResultado.Text = Dividir(numero1, numero2).ToString();
            }
            catch (Exception mensagem)
            {
                MessageBox.Show(mensagem.ToString());
                btnLimpa.PerformClick();
                return;
            }
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            txtCaixa1.Clear();
            txtCaixa2.Clear();
            txtResultado.Clear();
        }
    }
}
