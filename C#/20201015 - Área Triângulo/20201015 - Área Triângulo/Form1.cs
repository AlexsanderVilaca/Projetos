using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _20201015___Área_Triângulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[3];
            double area;
            int perimetro;
            
            vetor[0] = int.Parse(txtA.Text);
            vetor[1] = int.Parse(txtB.Text);
            vetor[2] = int.Parse(txtC.Text);

            vetor = Ordena(vetor);

            int A = vetor[2];
            int B = vetor[1];
            int C = vetor[0];

            if (A > B + C)
                MessageBox.Show("Triângulo não existe");
            else
            {
                perimetro = A + B + C;
                area = Math.Sqrt(perimetro * (perimetro - A) * (perimetro - B) * (perimetro - C));
                area = Math.Round(area, 2);
                MessageBox.Show(Convert.ToString(area) + " u.a.");
            }

            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = "";
            
        }

        static int[] Ordena(int[] vetor)
        {
            int aux;
            for (int i = 0; i < vetor.Length - 1; i++)
            {
                for (int j = i + 1; j < vetor.Length; j++)
                {
                    if (vetor[i] > vetor[j])
                    {
                        aux = vetor[i];
                        vetor[i] = vetor[j];
                        vetor[j] = aux;
                    }
                }
            }
            return vetor;
        }
    }
}
