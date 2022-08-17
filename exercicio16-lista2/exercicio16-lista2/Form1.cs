using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio16_lista2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double n1, n2, n3, media;
        string nome;
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            nome = txtNome.Text;
            n1 = double.Parse(txtN1.Text);
            n2 = double.Parse(txtN2.Text);
            n3 = double.Parse(txtN3.Text);

            media = (n1 + n2 + n3) / 3;
            if (media >= 7)
            {
                labelResultado.Text = "foi aprovado";
            }
            else
            {
                if (media >= 5.1 && media <= 6.9)
                {
                    labelResultado.Text = "está de recuperação";
                }
                else
                {
                    labelResultado.Text = "foi reprovado";
                }
            }
            labelNomeFinal.Text = nome;
        }
    }     
}
