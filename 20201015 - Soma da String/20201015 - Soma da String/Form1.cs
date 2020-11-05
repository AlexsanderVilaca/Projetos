using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _20201015___Soma_da_String
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtEntrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            int soma = 0;
            string entrada = txtEntrada.Text;

            foreach (char letra in entrada)
                soma += int.Parse(Convert.ToString(letra));

            //for(int i=0; i<entrada.Length; i++)
             //   soma += int.Parse(Convert.ToString(entrada[i]));

            MessageBox.Show(Convert.ToString(soma));
        }
    }
}
