using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _20201014___Descobre_caracteres
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerifica_Click(object sender, EventArgs e)
        {
            char letra = Convert.ToChar(txtEntrada.Text);
            int codigoAscii = Convert.ToInt32(letra);

            if (codigoAscii >= 65 && codigoAscii <= 90) 
            {
                MessageBox.Show("Maiúscula");
            }
            else if (codigoAscii >= 97 && codigoAscii <= 122) 
            {
                MessageBox.Show("Minúscula");
            }
            else if (codigoAscii >= 48 && codigoAscii <= 57)
            {
                MessageBox.Show("Número");
            }
            else 
            {
                MessageBox.Show("Caractere especial");
            }
        }
    }
}
