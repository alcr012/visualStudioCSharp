using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio10_lista2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double valorCompra, valorFinal;
        private void btnDividir_Click(object sender, EventArgs e)
        {
            valorCompra = double.Parse(txtValor.Text);

            valorFinal = valorCompra / 5;
            labelResultado.Text = valorFinal.ToString();
        }
    }
}
