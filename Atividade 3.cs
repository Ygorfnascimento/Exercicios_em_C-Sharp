using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOPAL_Ygor
{
    public partial class Atividade_3 : Form
    {
        public Atividade_3()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            // 1 Passo - Declarar as variáveis
            int gremio, juventude, corinthians, internacional, palmeiras, botafogo, saopaulo, cruzeiro, pontepreta, bahia, flamengo, vasco;

            //  2 Passo - Realizara as entradas

            gremio = int.Parse(TxtR1.Text); juventude = int.Parse(TxtR7.Text); corinthians = int.Parse(TxtR2.Text); internacional = int.Parse(TxtR8.Text); palmeiras = int.Parse(TxtR3.Text); botafogo = int.Parse(TxtR9.Text); saopaulo = int.Parse(TxtR4.Text); cruzeiro = int.Parse(TxtR10.Text); pontepreta = int.Parse(TxtR5.Text); bahia = int.Parse(TxtR11.Text); flamengo = int.Parse(TxtR6.Text); vasco = int.Parse(TxtR12.Text);

           // 3 Passo - Processamento e Saída

            if (gremio > juventude)
            {
                LblResultado1.Text = ("Grêmio");
            }
            else if (juventude > gremio)
            {
                LblResultado1.Text = ("Juventude");
            }
            else
            {
                LblResultado1.Text = ("Empate");
            }
            if (corinthians > internacional)
            {
                LblResultado2.Text = ("Corinthians");
            }
            else if (internacional > corinthians)
            {
                LblResultado2.Text = ("Internacional");
            }
            else
            {
                LblResultado2.Text = ("Empate");
            }
            if (palmeiras > botafogo)
            {
                LblResultado3.Text = ("Palmeiras");
            }
            else if (botafogo > palmeiras)
            {
                LblResultado3.Text = ("Botafogo");
            }
            else
            {
                LblResultado3.Text = ("Empate");
            }
            if (saopaulo > cruzeiro)
            {
                LblResultado4.Text = ("São paulo");
            }
            else if (cruzeiro > saopaulo)
            {
                LblResultado4.Text = ("Cruzeiro");
            }
            else
            {
                LblResultado4.Text = ("Empate");
            }
            if (pontepreta > bahia)
            {
                LblResultado5.Text = ("pontepreta");
            }
            else if (bahia > pontepreta)
            {
                LblResultado5.Text = ("Bahia");
            }
            else
            {
                LblResultado5.Text = ("Empate");
            }
            if (flamengo > vasco)
            {
                LblResultado6.Text = ("Flamengo");
            }
            else if (vasco > flamengo)
            {
                LblResultado6.Text = ("Vasco");
            }
            else
            {
                LblResultado6.Text = ("Empate");
            }
        }
    }
}
