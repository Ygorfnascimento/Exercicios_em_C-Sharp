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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            // 1 Passo - Declarar as Variáveis

            int num1, num2, num3, maior, menor;

            // 2 Passo - Realizar as Entradas

            num1 = int.Parse(TxtValor01.Text);
            num2 = int.Parse(TxtValor02.Text);
            num3 = int.Parse(TxtValor03.Text);

            // 3 Passo - Processamento do MAIOR valor

            if (num1 > num2 && num1 > num3)
            {
                maior = num1;
            }
            else if (num2 > num1 && num2 > num3)
            {
                maior = num2;
            }
            else
            {
                maior = num3;
            }

            // 4 Passo - Processamento do MENOR valor

            if (num1 < num2 && num1 < num3)
            {
                menor = num1;
            }
            else if (num2 < num1 && num2 < num3)
            {
                menor = num2;
            }
            else
            {
                menor = num3;
            }

            // 5 Passo - Saída

            LblMaior.Text = "Maior: " + maior.ToString();
            LblMenor.Text = "Menor: " + menor.ToString();
        }
    }
}
