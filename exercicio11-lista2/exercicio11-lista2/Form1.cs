using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio11_lista2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double acrescimo, preco, valorTotal;
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            preco = double.Parse(txtPreco.Text);
            acrescimo = double.Parse(txtAcrescimo.Text);

            
            acrescimo = (preco / 100) * acrescimo;
            valorTotal = preco + acrescimo;
           labelResultado.Text = valorTotal.ToString();
        }
    }
}
