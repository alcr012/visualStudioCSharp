using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio9_lista2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double deposito, rendimento;
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            deposito = double.Parse(txtDeposito.Text);

            rendimento = deposito + ((deposito * 0.70) / 100);

            labelResultado.Text = rendimento.ToString();
            
        }
    }
}
