using System;
using System.Windows.Forms;

namespace Exercicios_C_
{
    public partial class Atividade2 : Form
    {
        private Form _menuPrincipal;

        public Atividade2(Form menu)
        {
            InitializeComponent();
            _menuPrincipal = menu;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double pesoTerra = double.Parse(textBox1.Text);
                double gravidade = 0;
                string planeta = "";

                if (rbMercurio.Checked) { gravidade = 0.37; planeta = "Mercúrio"; }
                else if (rbVenus.Checked) { gravidade = 0.88; planeta = "Vênus"; }
                else if (rbMarte.Checked) { gravidade = 0.38; planeta = "Marte"; }
                else if (rbJupiter.Checked) { gravidade = 2.64; planeta = "Júpiter"; }
                else if (rbSaturno.Checked) { gravidade = 1.15; planeta = "Saturno"; }
                else if (rbUrano.Checked) { gravidade = 1.17; planeta = "Urano"; }
                else
                {
                    MessageBox.Show("Por favor, selecione um planeta!", "Aviso");
                    return;
                }

                double pesoFinal = (pesoTerra / 10) * gravidade;

                MessageBox.Show($"Seu peso em {planeta} seria: {pesoFinal:N2} kgf", "Resultado");
            }
            catch
            {
                MessageBox.Show("Digite um valor numérico válido para o peso.", "Erro");
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            _menuPrincipal.Show();
            this.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (_menuPrincipal != null) _menuPrincipal.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void Atividade2_Load(object sender, EventArgs e) { }
    }
}