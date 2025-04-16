using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOPAL_Ygor
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void BtnAtividade1_Click(object sender, EventArgs e)
        {
            // Mensagem para a primeira atividade

            MessageBox.Show("Executando a Atividade 1.");
        }
        private void BtnAtividade2_Click(object sender, EventArgs e)
        {
            // Mensagem para a segunda Atividade

            MessageBox.Show("Executando a Atividade 2.");
        }
        private void BtnAtividade3_Click(object sender, EventArgs e)
        {
            // Mensagem para a terceira Atividade 3

            MessageBox.Show("Executando a Atividade 3.");
        }
    }
}
