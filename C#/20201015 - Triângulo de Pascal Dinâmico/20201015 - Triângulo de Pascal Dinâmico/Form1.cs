using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _20201015___Triângulo_de_Pascal_Dinâmico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCirculo_Click(object sender, EventArgs e)
        {
            ApareceLabels();

            foreach (Control c in this.Controls)
            {
                if (c.GetType() == typeof(Panel))
                {
                    foreach (Label a in c.Controls)
                    {
                        var path = new System.Drawing.Drawing2D.GraphicsPath();
                        path.AddEllipse(0, 0, label1.Width, label1.Height);

                        a.Region = new Region(path);
                    }
                }
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnQuadrado_Click(object sender, EventArgs e)
        {
            ValidaEntrada();
            ApareceLabels();

            foreach (Control c in this.Controls)
            {
                if (c.GetType() == typeof(Panel))
                {
                    foreach (Label a in c.Controls)
                    {
                        var path = new System.Drawing.Drawing2D.GraphicsPath();
                        Rectangle retangulo = new Rectangle(0, 0, label1.Width, label1.Height);
                        
                        path.AddRectangle(retangulo);

                        a.Region = new Region(path);
                        //this.label1.Region = new Region(path);
                    }
                }
            }
        }

        public void ApareceLabels()
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;

            int n = int.Parse(textBox1.Text);
            bool[] paineis = new bool[8];

            paineis[0] = panel1.Visible;
            paineis[1] = panel2.Visible;
            paineis[2] = panel3.Visible;
            paineis[3] = panel4.Visible;
            paineis[4] = panel5.Visible;
            paineis[5] = panel6.Visible;
            paineis[6] = panel7.Visible;
            paineis[7] = panel8.Visible;

            for (int i = 0; i < n; i++)
            {
                paineis[i] = true;
            }

            panel1.Visible = paineis[0];
            panel2.Visible = paineis[1];
            panel3.Visible = paineis[2];
            panel4.Visible = paineis[3];
            panel5.Visible = paineis[4];
            panel6.Visible = paineis[5];
            panel7.Visible = paineis[6];
            panel8.Visible = paineis[7];
        }

        public void ValidaEntrada() 
        {
            int a;
            do
            {
                try
                {
                    a = int.Parse(textBox1.Text);
                    return;
                }
                catch
                {
                    MessageBox.Show("Entrada inválida");
                }
            } while (true);
        }
    }
}
