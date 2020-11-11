using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;


namespace _20201109___Loja_de_Celulares
{
    public partial class Form1 : Form
    {   
        public Form1()
        {
            InitializeComponent();
        }

        private void CadastrarAparelho_Click(object sender, EventArgs e)
        {
            frTelaCadastroAparelho telaCadatro = new frTelaCadastroAparelho();
            this.Hide();
            telaCadatro.ShowDialog();
            this.Show();
        }

        private void CadastrarVenda_Click(object sender, EventArgs e)
        {
            frTelaCadastroVenda telaVendas = new frTelaCadastroVenda();
            this.Hide();
            telaVendas.ShowDialog();
            this.Show();
        }

        private void ExibirVendas_Click(object sender, EventArgs e)
        {
            ftTelaExibirVendas telaExibirVendas = new ftTelaExibirVendas();
            this.Hide();
            telaExibirVendas.ShowDialog();
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
