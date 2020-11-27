using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace _20201125___009_Corrida
{
    public partial class Form1 : Form
    {
        Guy[] jogadores = new Guy[3];
        Greyhound[] cachorro = new Greyhound[4];
        RadioButton[] radios = new RadioButton[3];


        Random random = new Random();

        public Form1()
        {
            InitializeComponent();

            radios[0] = rbJoe;
            radios[1] = rbBob;
            radios[2] = rbAl;

            jogadores[0] = new Guy();
            jogadores[0].Name = "Joe";
            jogadores[0].MyTextBox = txtJoe;
            jogadores[0].MyRadioButton = rbJoe;
            jogadores[0].Cash = 50;

            jogadores[1] = new Guy();
            jogadores[1].Name = "Bob";
            jogadores[1].MyTextBox = txtBob;
            jogadores[1].MyRadioButton = rbBob;
            jogadores[1].Cash = 75;

            jogadores[2] = new Guy();
            jogadores[2].Name = "Al";
            jogadores[2].MyTextBox = txtAl;
            jogadores[2].MyRadioButton = rbAl;
            jogadores[2].Cash = 45;

            jogadores[0].UpdateLabels();
            jogadores[1].UpdateLabels();
            jogadores[2].UpdateLabels();

            cachorro[0] = new Greyhound();
            cachorro[0].Name = "Bistequinha";
            cachorro[0].MyPictureBox = dog1;
            cachorro[0].Randomizer = random;
            cachorro[0].StartingPoint = 20;

            cachorro[1] = new Greyhound();
            cachorro[1].Name = "Dogão";
            cachorro[1].MyPictureBox = dog2;
            cachorro[1].Randomizer = random;
            cachorro[1].StartingPoint = 20;

            cachorro[2] = new Greyhound();
            cachorro[2].Name = "Lobo";
            cachorro[2].MyPictureBox = dog3;
            cachorro[2].Randomizer = random;
            cachorro[2].StartingPoint = 20;

            cachorro[3] = new Greyhound();
            cachorro[3].Name = "Scooby-Doo";
            cachorro[3].MyPictureBox = dog4;
            cachorro[3].Randomizer = random;
            cachorro[3].StartingPoint = 20;

            cachorro[0].RaceTrackLength = 650;
            cachorro[1].RaceTrackLength = 650;
            cachorro[2].RaceTrackLength = 650;
            cachorro[3].RaceTrackLength = 650;

            npValorAposta.Minimum = 5;
            int apostaMinima = 5;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnApostar_Click(object sender, EventArgs e)
        {
            if (rbJoe.Checked)
                jogadores[0].PlaceBet(Convert.ToInt32(npValorAposta.Value), cachorro[Convert.ToInt32(npNumeroCachorro.Value)]);

            if (rbBob.Checked)
                jogadores[1].PlaceBet(Convert.ToInt32(npValorAposta.Value), cachorro[Convert.ToInt32(npNumeroCachorro.Value)]);

            if (rbAl.Checked)
                jogadores[2].PlaceBet(Convert.ToInt32(npValorAposta.Value), cachorro[Convert.ToInt32(npNumeroCachorro.Value)]);
        }

        private void btnIniciarCorrida_Click(object sender, EventArgs e)
        {
            btnIniciarCorrida.Enabled = false;
            timerPasso.Enabled = true;
            timerPasso.Start();
        }

        private void timerPasso_Tick(object sender, EventArgs e)
        {
            foreach (Greyhound g in cachorro)
            {
                if (g.Run() == false)
                    g.Run();
                else
                {
                    timerPasso.Stop();
                    cachorro[0].StartingPoint = 20;
                    cachorro[1].StartingPoint = 20;
                    cachorro[2].StartingPoint = 20;
                    cachorro[3].StartingPoint = 20;

                    foreach (Guy c in jogadores)
                    {
                        c.Collect(g);
                        c.UpdateLabels();
                    }

                    foreach (Greyhound d in cachorro)
                        d.StartingPoint = 20;

                    btnIniciarCorrida.Enabled = true;
                    MessageBox.Show(g.Name);
                    break;
                }
            }
        }
    }
}
