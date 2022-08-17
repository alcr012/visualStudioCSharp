using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio5_lista2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string nome;
        double N1, N2, N3, media;
        private void btnResultado_Click(object sender, EventArgs e)
        {
            N1 = double.Parse(txtN1.Text);
            N2 = double.Parse(txtN2.Text);
            N3 = double.Parse(txtN3.Text);
            nome = txtNome.Text;
            media = (N1 + N2 + N3) / 3;
            labelResultado.Text = media.ToString();
            labelNomeResultado.Text = nome;


        }
    }
}
