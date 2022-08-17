using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio13_lista2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int n;
        private void btnAnalisar_Click(object sender, EventArgs e)
        {
            n = int.Parse(txtN.Text);

            if (n > 10)
            {
                labelResposta.Text = "O número é maior que 10";
            }
            else
            {
                labelResposta.Text = "O número é menor que 10";
            }
                if (n == 10)
                {
                    labelResposta.Text = "O número é igual a 10";
                }
                
           

        }
    }
}
