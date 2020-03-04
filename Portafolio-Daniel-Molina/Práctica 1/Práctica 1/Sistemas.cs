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
    public partial class Sistemas : Form
    {
        public Sistemas()
        {
            InitializeComponent();
        }

      
        private void btncalcular_Click(object sender, EventArgs e)
        {
            txtbinario.Text = Convert.ToString(Convert.ToInt32(txtdecimal.Text), 2);
            txtoctal.Text = Convert.ToString(Convert.ToInt32(txtdecimal.Text), 8);
            txthexadecimal.Text = Convert.ToString(Convert.ToInt32(txtdecimal.Text), 16);
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtbinario.Clear();
            txtdecimal.Clear();
            txtoctal.Clear();
            txthexadecimal.Clear();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
