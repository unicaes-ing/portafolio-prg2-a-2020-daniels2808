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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtcantidad.Clear();
            txtdescuento.Clear();
            txtprecio.Clear();
            txttotal.Clear();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double precio = Convert.ToDouble(txtprecio.Text), Cantidad = Convert.ToDouble(txtcantidad.Text), subtotal = precio*Cantidad;
            try
            {
                if (rdocero.Checked)
                {
                    double descuento = subtotal * 0.00;
                    txtdescuento.Text = String.Format(Convert.ToString(descuento));
                    txttotal.Text = Convert.ToString(subtotal-descuento);
                }
                else if(rdo5.Checked)
                {
                    double descuento = subtotal * 0.05;
                    txtdescuento.Text = String.Format(Convert.ToString(descuento));
                    txttotal.Text = Convert.ToString(subtotal - descuento);

                }
                else if (rdo10.Checked)
                {
                    double descuento = subtotal * 0.1;
                    txtdescuento.Text = String.Format(Convert.ToString(descuento));
                    txttotal.Text = Convert.ToString(subtotal - descuento);

                }
                else if (rdo15.Checked)
                {
                    double descuento = subtotal * 0.15;
                    txtdescuento.Text = String.Format(Convert.ToString(descuento));
                    txttotal.Text = Convert.ToString(subtotal - descuento);

                }

                else if (rdo20.Checked)
                {
                    double descuento = subtotal * 0.2;
                    txtdescuento.Text = String.Format(Convert.ToString(descuento));
                    txttotal.Text = Convert.ToString(subtotal - descuento);

                }


            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione uno de los descuentos para continuar");
            }
        }
    }
}
