using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class calculadora : Form
    {
        public calculadora()
        {
            InitializeComponent();
        }

        float n1, n2;
        string opcao;

        private void btn1_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + "0";
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            n1 =int.Parse(txtVisor.Text);
            txtVisor.Text = " ";
            opcao = "subtracao";
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            n1 = int.Parse(txtVisor.Text);
            txtVisor.Text = " ";
            opcao = "divisao";
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            n1 = int.Parse(txtVisor.Text);
            txtVisor.Text = " ";
            opcao = "multiplicacao";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            n2=int.Parse(txtVisor.Text);
            switch (opcao)
            {
                case "soma":
                    n1 = n1 + n2;
                    txtVisor.Text = n1.ToString();
                    break;
                case "subtracao":
                    n1 = n1 - n2;
                    txtVisor.Text = n1.ToString();
                    break;
                case "divisao":
                    n1 = n1 / n2;
                    txtVisor.Text = n1.ToString();
                    break;
                case "multiplicacao":
                    n1 = n1 * n2;
                    txtVisor.Text = n1.ToString();
                    break;
                    default:
                    break;

            }
            txtVisor.Text = n1.ToString();

        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            txtVisor.Text = " ";
            n1 = 0;
            n2 = 0;
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            n1 = n1 + int.Parse(txtVisor.Text);
            txtVisor.Text = " ";
            opcao = "soma";
        }

    }
}
    
