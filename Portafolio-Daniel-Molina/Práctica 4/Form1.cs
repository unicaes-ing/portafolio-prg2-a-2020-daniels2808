using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Práctica_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static double result(double n1, double n2,double n3, double n4)
            {
            return n1 + n2 + n3 + n4;
            }
        private void button1_Click(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(txtnumero1.Text);
            double numero2 = Convert.ToDouble(txtnumero2.Text);
            double numero3 = Convert.ToDouble(txtnumero3.Text);
            double numero4 = Convert.ToDouble(txtnumero4.Text);
            double result = (numero1 + numero2 + numero3 + numero4);
            lblresultado.Text = Convert.ToString(result);

        }
    }
}
