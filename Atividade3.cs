using System;
using System.Windows.Forms;

namespace Exercicios_C_
{
    public partial class Atividade3 : Form
    {
        Form menuOriginal;

        public Atividade3(Form menu)
        {
            InitializeComponent();
            menuOriginal = menu;
        }

        // --- BOTÃO CALCULAR ---
        private void btn_calcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Entradas (conforme os nomes no seu Designer)
                int gremio = int.Parse(Rgre.Text);
                int juventude = int.Parse(Rjuv.Text);
                int corinthians = int.Parse(Rcor.Text);
                int internacional = int.Parse(Rint.Text);
                int palmeiras = int.Parse(Rpal.Text);
                int botafogo = int.Parse(Rbot.Text);
                int saopaulo = int.Parse(Rsp.Text);
                int cruzeiro = int.Parse(Rcru.Text);
                int pontepreta = int.Parse(Rpp.Text);
                int bahia = int.Parse(Rbah.Text);
                int flamengo = int.Parse(Rfla.Text);
                int vasco = int.Parse(Rvas.Text);

                // Lógica de Resultados nos Labels
                label21.Text = gremio > juventude ? "Grêmio" : (juventude > gremio ? "Juventude" : "Empate");
                label20.Text = corinthians > internacional ? "Corinthians" : (internacional > corinthians ? "Internacional" : "Empate");
                label22.Text = palmeiras > botafogo ? "Palmeiras" : (botafogo > palmeiras ? "Botafogo" : "Empate");
                label23.Text = saopaulo > cruzeiro ? "São Paulo" : (cruzeiro > saopaulo ? "Cruzeiro" : "Empate");
                label24.Text = pontepreta > bahia ? "Ponte Preta" : (bahia > pontepreta ? "Bahia" : "Empate");
                label26.Text = flamengo > vasco ? "Flamengo" : (vasco > flamengo ? "Vasco" : "Empate");
            }
            catch
            {
                MessageBox.Show("Por favor, preencha todos os campos com números!", "Aviso");
            }
        }

        // --- BOTÃO VOLTAR ---
        private void btn_voltar_atv3_Click(object sender, EventArgs e)
        {
            menuOriginal.Show();
            this.Close();
        }

        private void Atividade3_Load(object sender, EventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }
    }
}