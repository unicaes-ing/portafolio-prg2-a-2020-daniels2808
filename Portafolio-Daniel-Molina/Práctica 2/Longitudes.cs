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
    public partial class form3 : Form
    {
        public form3()
        {
            InitializeComponent();
        }

        private void btnconvertir_Click(object sender, EventArgs e)
        {
            double longitud = Convert.ToDouble(txtlongitud.Text);
            double cantidad = 0;
            if (lstlongitudes1.SelectedItem.Equals("Pulgadas"))
            {
                if (lstlongitudes2.SelectedItem.Equals("Pulgadas"))
                {
                    longitud = longitud;
                }
                else if (lstlongitudes2.SelectedItem.Equals("Pies"))
                {
                    cantidad = longitud / 12;
                }
                else if (lstlongitudes2.SelectedItem.Equals("Yardas"))
                {
                    cantidad = longitud / 36;
                }
                txtresultado.Text = Convert.ToString(cantidad);
            }
               else if (lstlongitudes1.SelectedItem.Equals("Pies"))
                {
                    if (lstlongitudes2.SelectedItem.Equals("Pies"))
                    {
                        longitud = longitud;
                    }
                    else if (lstlongitudes2.SelectedItem.Equals("Pulgadas"))    
                    {
                        cantidad = longitud * 12;
                    }
                    else if (lstlongitudes2.SelectedItem.Equals("Yardas"))
                    {
                        cantidad = longitud / 3;
                    }
                txtresultado.Text = Convert.ToString(cantidad);


            }
            else if (lstlongitudes1.SelectedItem.Equals("Yardas"))
            {
                if (lstlongitudes2.SelectedItem.Equals("Yardas"))
                {
                    longitud = longitud;
                }
                else if (lstlongitudes2.SelectedItem.Equals("Pulgadas"))
                {
                    cantidad = longitud * 36;
                }
                else if (lstlongitudes2.SelectedItem.Equals("Pies"))
                {
                    cantidad = longitud * 3;
                    
                }
                txtresultado.Text = Convert.ToString(cantidad);


            }
            else
            {
                MessageBox.Show ("Seleccione las longitudes que desea convertir");
            }



        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtlongitud_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar !='.' )
                {
                e.Handled = true;
            }
        }
    }
    
}
