using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicios1_lista2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double N1, N2, soma;
       

        private void btnSomar_Click(object sender, EventArgs e)
        {
            N1 = double.Parse(txtN1.Text);
            N2= double.Parse(txtN2.Text);
            soma = N1 + N2;
            txtResultado.Text = soma.ToString();


        }

        private void labelResultado_Click(object sender, EventArgs e)
        {

        }
    }
}
