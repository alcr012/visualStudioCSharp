using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio15_lista2
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

            if (n > 100 && n < 200)
            {
                labelResposta.Text = "está entre 100 e 200";
            }
            else
            {
                labelResposta.Text = "não está entre 100 e 200";
            }
        }
    }
}
