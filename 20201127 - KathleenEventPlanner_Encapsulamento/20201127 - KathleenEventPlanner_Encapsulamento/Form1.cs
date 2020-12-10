using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _20201127___KathleenEventPlanner_Encapsulamento
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;
        BirthdayParty birthdayParty;
        public Form1()
        {
            InitializeComponent();

            //instanciando um objeto birthdayParty
            birthdayParty = new BirthdayParty((int)npNumberOfBirthday.Value,
                                               ckbFancyBirthday.Checked,
                                               txtStringName.Text);

            //instanciando um objeto dinnerParty
            dinnerParty = new DinnerParty((int)npNumberOfPeople.Value,
                                           ckbHealthyOption.Checked,
                                           ckbFancyDecorations.Checked);
            DisplayDinnerPartyCost();
            DisplayBirthdayPartyCost();
        }
        /// <summary>
        /// calcula e atualiza o custo conforme a seleção da opção Healthy
        /// </summary>
        private void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerParty.CalculateCost(ckbHealthyOption.Checked);
            txtCost.Text = Cost.ToString("c");//a letra "c" indica que o formato é uma moeda, e por padrão com duas casas decimais
        }

        //toda vez que o valor de algum controle é alterado, o método DisplayDinnerParty refaz os cálculos e atualiza o resultado
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void npNumberOfBirthday_ValueChanged(object sender, EventArgs e)
        {
            birthdayParty.NumberOfPeople = (int)npNumberOfBirthday.Value;
            DisplayBirthdayPartyCost();
        }

        private void ckbFancyBirthday_CheckedChanged(object sender, EventArgs e)
        {
            birthdayParty.CalculateCostOfDecorations(ckbFancyBirthday.Checked);
            DisplayBirthdayPartyCost();
        }

        private void txtStringName_TextChanged(object sender, EventArgs e)
        {
            birthdayParty.CakeWriting = txtStringName.Text;
            DisplayBirthdayPartyCost();
        }

        private void DisplayBirthdayPartyCost()
        {
            txtStringName.Text = birthdayParty.CakeWriting;
            decimal Cost = birthdayParty.CalculateCost();
            txtCostBirthday.Text = Cost.ToString("c");
        }

        private void npNumberOfPeople_ValueChanged_1(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)npNumberOfPeople.Value;
            DisplayDinnerPartyCost();
        }

        private void ckbFancyDecorations_CheckedChanged_1(object sender, EventArgs e)
        {
            dinnerParty.CalculateCostOfDecorations(ckbFancyDecorations.Checked);
            DisplayDinnerPartyCost();
        }

        private void ckbHealthyOption_CheckedChanged_1(object sender, EventArgs e)
        {
            dinnerParty.SetHealthyOption(ckbHealthyOption.Checked);
            DisplayDinnerPartyCost();
        }

    }
}
