using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtcantidad.Clear();
            txtimpuesto.Clear();
            txtprecio.Clear();
            txtsubtotal.Clear();
            txttotalapagar.Clear();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double subtotal= Convert.ToDouble(Convert.ToDouble(txtprecio.Text)*Convert.ToDouble(txtcantidad.Text));
            txtsubtotal.Text = Convert.ToString(subtotal);
            double impuesto = subtotal * 0.13;
            txtimpuesto.Text = Convert.ToString(impuesto);
            txttotalapagar.Text = Convert.ToString(subtotal + impuesto);
        }
    }
}
