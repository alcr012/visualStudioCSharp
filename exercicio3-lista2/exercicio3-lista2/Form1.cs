using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio3_lista2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double distancia, combustivel, media;


        private void btnCalculo_Click(object sender, EventArgs e)
        {
            distancia = double.Parse(txtDistancia.Text);
            combustivel = double.Parse(txtCombustivel.Text);

            media = (distancia + combustivel) / 2;
            labelResultado.Text = media.ToString();
        }
    }
}
