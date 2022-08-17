using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio14_lista2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int n1, n2;
        private void btnAnalisar_Click(object sender, EventArgs e)
        {
            n1 = int.Parse(txtN1.Text);
            n2 = int.Parse(txtN2.Text);

            if (n1 > n2 )
            {
                labelResposta.Text = "O 1° número é maior";
            }
            else
            {
                labelResposta.Text = "O 2° número é maior";
            }
        }
    }
}
