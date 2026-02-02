using System;
using System.Windows.Forms;

namespace Exercicios_C_
{
    public partial class Atividade1 : Form
    {
        private Form _menuPrincipal;

        public Atividade1(Form menu)
        {
            InitializeComponent();
            _menuPrincipal = menu;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double v1 = double.Parse(Txt_valor01.Text);
                double v2 = double.Parse(Txt_valor02.Text);
                double v3 = double.Parse(textBox3.Text);

                double maior = v1;
                if (v2 > maior) maior = v2;
                if (v3 > maior) maior = v3;

                double menor = v1;
                if (v2 < menor) menor = v2;
                if (v3 < menor) menor = v3;

                label5.Text = "Maior Número: " + maior;
                label6.Text = "Menor Número: " + menor;
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor, insira valores numéricos válidos nos três campos.", "Erro de Entrada");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _menuPrincipal.Show();
            this.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            _menuPrincipal.Show();
        }

        private void Txt_valor02_TextChanged(object sender, EventArgs e)
        {
        }
    }
}