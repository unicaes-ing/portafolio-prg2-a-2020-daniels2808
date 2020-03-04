using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Práctica_2
{
    public partial class ROMANO : Form
    {
        public ROMANO()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnconvertir_Click(object sender, EventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(txtnumero.Text);
                string rom="";
                if (num==1)
                {
                    rom= "I";
                }
                else if(num==2)
                {
                    rom = "II";
                }
                else if (num == 3)
                {
                    rom = "III";
                }
                else if (num == 4)
                {
                    rom = "IV";
                }
                else if (num == 5)
                {
                    rom = "V";
                }
                else if (num == 6)
                {
                    rom = "VI";
                }
                else if (num == 7)
                {
                    rom = "VII";
                }
                else if (num == 8)
                {
                    rom = "VIII";
                }
                else if (num == 9)
                {
                    rom = "IX";
                }
                else if (num == 10)
                {
                    rom = "X";
                }
                lblromano.Text = "Equivale a " + rom + " en romano";
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese un número entre 1 y 10");
            }
        }
    }
}
