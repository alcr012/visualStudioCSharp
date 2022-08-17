using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio12_lista2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double valorFabrica, valorVenda;
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            valorFabrica = double.Parse(txtValorFabrica.Text);

            valorFabrica = valorFabrica + (valorFabrica * 45) / 100;
            valorVenda = valorFabrica + (valorFabrica * 28) / 100;
            labelResultado.Text = valorVenda.ToString();
        }
    }
}
