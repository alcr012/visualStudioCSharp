using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio7_lista2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double fahrenheit, celsius;


        private void btnConversor_Click(object sender, EventArgs e)
        {
            celsius = double.Parse(txtC.Text);

            fahrenheit = (celsius * 9 + 160) / 5;
            labelResultado.Text = fahrenheit.ToString();
                
        }
    }
}
