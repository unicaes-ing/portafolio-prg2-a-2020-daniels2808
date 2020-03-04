using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Práctica_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btngenerar_Click(object sender, EventArgs e)
        {

            lstTabla.Items.Clear();
            int numero;
            int resultado;
            if (int.TryParse(txtnumero.Text, out numero))
            {
                for (int i = 1; i <= 10; i++)
                {
                    resultado = numero * i;
                    lstTabla.Items.Add(numero + " x " + i + " = " + resultado);
                }

            }
            else
            {
                MessageBox.Show("Ingrese un número");
            }


        }

        private void txtnumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
