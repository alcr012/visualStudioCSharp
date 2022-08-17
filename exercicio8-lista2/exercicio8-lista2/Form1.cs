using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio8_lista2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
                
        }
        double dolar, valorDolar, reais;


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            dolar = double.Parse(txtDolar.Text);
            valorDolar = double.Parse(txtValorDolar.Text);

            reais = (valorDolar * dolar);
            labelResultado.Text = reais.ToString();
        }
    }
}
