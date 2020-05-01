using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Práctica_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] vendedores = { "Juán", "José", "María", "Omar", "Alexander", "Mario", "Luis", "Daniel", "Rodrigo", "Melissa" };
        private void btnAZ_Click(object sender, EventArgs e)
        {
            lstVendedores.DataSource = null;
            Array.Sort(vendedores);
            lstVendedores.DataSource = vendedores;
        }

        private void btnZA_Click(object sender, EventArgs e)
        {
            lstVendedores.DataSource = null;
            Array.Sort(vendedores);
            Array.Reverse(vendedores);
            lstVendedores.DataSource = vendedores;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstVendedores.DataSource = vendedores;
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            vendedores = vendedores.Where((item, index) => index != lstVendedores.SelectedIndex).ToArray();
            lstVendedores.DataSource = vendedores;
            lstVendedores.SelectedIndex = -1;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtNombre.TextLength > 0)
            {
                int i = Array.IndexOf(vendedores, txtNombre.Text);
                if (i >= 0)
                {
                    lstVendedores.SelectedIndex = i;
                }
                else
                {
                    MessageBox.Show("El nombre ingresado no se encuentra en la lista");
                }
            }
            else
            {
                MessageBox.Show("Escriba el nombre que desesa buscar");
                txtNombre.Focus();
            }
        }
    }
}
