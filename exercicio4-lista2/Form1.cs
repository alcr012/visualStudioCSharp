using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio4_lista2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double salarioFixo, comissao, salarioFinal, vendas;
        string nome;
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            salarioFixo = double.Parse(txtSalario.Text);
            vendas = double.Parse(txtComissao.Text);
            comissao = vendas * 15 / 100;
            nome = (txtNome.Text);
            salarioFinal = salarioFixo + comissao;
            labelSalarioFinal.Text = salarioFinal.ToString();
            labelNomeResultado.Text = nome;
            

        }
    }
}
