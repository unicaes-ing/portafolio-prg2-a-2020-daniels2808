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
    public partial class Inversiones : Form
    {
        public Inversiones()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double porcentaje1, porcentaje2, porcentaje3, calcular = Convert.ToDouble(txtinversionista1.Text)+Convert.ToDouble(txtinversionista2.Text)+Convert.ToDouble(txtinversionista3.Text);
            txttotalinvesiones.Text = string.Format("{0:N2}", calcular);
            porcentaje1 = Convert.ToDouble(txtinversionista1.Text) / calcular = 100;
            txtporcentaje1.Text = Convert.ToString("{0:N2}%", porcentaje1);
            porcentaje2 = Convert.ToDouble(txtinversionista2.Text) / calcular = 100;
            txtporcentaje2.Text = Convert.ToString("{0:N2}%", porcentaje2);
            porcentaje3 = Convert.ToDouble(txtinversionista3.Text) / calcular = 100;
            txtporcentaje3.Text = Convert.ToString("{0:N2}%", porcentaje3);



        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtinversionista1.Clear();
            txtinversionista2.Clear();
            txtinversionista3.Clear();
            txtporcentaje1.Clear();
            txtporcentaje2.Clear();
            txtporcentaje3.Clear();
            txttotalinvesiones.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
