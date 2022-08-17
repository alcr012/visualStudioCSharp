using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio2_lista2
{
    public partial class Forms1 : Form
    {
        public Forms1()
        {
            InitializeComponent();
        }
        double N1, N2, soma, multiplicacao, divisao, subtracao;
        private void btnResultado_Click(object sender, EventArgs e)
        {
            N1 = double.Parse(txtN1.Text);
            N2 = double.Parse(txtN2.Text);
            soma = N1 + N2;
            subtracao = N1 - N2;
            multiplicacao = N1 * N2;
            divisao = N1 / N2;
            labelResultadoAdicao.Text = soma.ToString();
            labelResultadoSubtracao.Text = subtracao.ToString();
            labelResultadoMultiplicacao.Text = multiplicacao.ToString();
            labelResultadoDivisao.Text = divisao.ToString();
        }
    }
}
