using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOPAL_Ygor
{
    public partial class Atividade_2 : Form
    {
        public Atividade_2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1 Passo - Declarar as variáveis

            double p_mercurio, p_jupiter, p_marte, p_saturno, p_urano, p_venus, p_terra, resultado;

            // 2 Passo - Realizar as Entradas

            p_terra = 0;
            resultado = double.Parse(TxtPeso.Text);

            // 3 Passo - Processamento e Saída

            if (RbMercúrio.Checked)
            {
                p_mercurio = p_terra * 0.37;
                MessageBox.Show("O seu peso em Mercúrio é: " + resultado);
            }
            else if (RbMarte.Checked)
            {
                p_marte = p_terra * 0.38;
                MessageBox.Show("O seu peso em Marte é: " + resultado);
            }
            else if (RbUrano.Checked)
            {
                p_urano = p_terra * 1.17;
                MessageBox.Show("O seu peso em Urano é: " + resultado);
            }
            else if (RbVênus.Checked)
            {
                p_venus = p_terra * 0.88;
                MessageBox.Show("O seu peso em Vênus  é: " + resultado);
            }
            else if (RbSaturno.Checked)
            {
                p_saturno = p_terra * 1.15;
                MessageBox.Show("O seu peso em Saturno é: " + resultado);
            }
            else if (RbJúpiter.Checked)
            {
                p_jupiter = p_terra * 2.64;
                MessageBox.Show("O seu peso em Júpiter é: " + resultado);
            }
        }     
    }
}
