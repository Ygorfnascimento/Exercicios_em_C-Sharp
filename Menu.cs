using System;
using System.Windows.Forms;

namespace Exercicios_C_
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Atividade1 tela1 = new Atividade1(this);
            tela1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Atividade2 tela2 = new Atividade2(this);
            tela2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Corrigido para abrir a Atividade 3
            Atividade3 tela3 = new Atividade3(this);
            tela3.Show();
            this.Hide();
        }
    }
}