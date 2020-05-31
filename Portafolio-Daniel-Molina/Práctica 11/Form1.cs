using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Práctica_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtValor1.Visible = false;
            lblValor1.Visible = false;
            txtValor2.Visible = false;
            lblValor2.Visible = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!rdoCirculo.Checked && !rdoCuadrado.Checked && !rdoTriangulo.Checked)
            {
                MessageBox.Show("Debe seleccionar una opción");
            }
            else if (rdoCirculo.Checked)
            {
                if (txtValor1.Text.Length == 0)
                {
                    MessageBox.Show("Ingrese un valor 1");
                }
                else
                {
                    Circulo circulo = new Circulo();
                    circulo.Valor1 = Convert.ToDouble(txtValor1.Text);
                    txtRespuesta.Text = circulo.Area().ToString("N2");
                    txtValor1.Clear();

                }
            }
            else if (rdoCuadrado.Checked)
            {
                if (txtValor1.Text.Length == 0)
                {
                    MessageBox.Show("Ingrese un valor 1");
                }
                else
                {
                    Cuadrado cuadrado = new Cuadrado();
                    cuadrado.Valor1 = Convert.ToDouble(txtValor1.Text);
                    txtRespuesta.Text = cuadrado.Area().ToString("N2");
                    txtValor1.Clear();
                }
            }
            else
            {
                if (txtValor1.Text.Length == 0)
                {
                    MessageBox.Show("Ingrese un valor 1 ");
                }
                else if (txtValor2.Text.Length == 0)
                {
                    MessageBox.Show("Ingrese el valor 2");
                }
                else
                {
                    Triangulo triangulo = new Triangulo();
                    triangulo.Valor1 = Convert.ToDouble(txtValor1.Text);
                    triangulo.Valor2 = Convert.ToDouble(txtValor2.Text);
                    txtRespuesta.Text = triangulo.Area().ToString("N2");
                    txtValor1.Clear();
                    txtValor2.Clear();
                }
            }
        }

        private void txtValor1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtValor2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void rdoCirculo_CheckedChanged(object sender, EventArgs e)
        {
            txtValor1.Focus();
            txtValor1.Visible = true;
            lblValor1.Visible = true;
            txtValor2.Visible = false;
            lblValor2.Visible = false;
        }

        private void rdoCuadrado_CheckedChanged(object sender, EventArgs e)
        {
            txtValor1.Focus();
            txtValor1.Visible = true;
            lblValor1.Visible = true;
            txtValor2.Visible = false;
            lblValor2.Visible = false;
            txtRespuesta.Clear();
        }

        private void rdoTriangulo_CheckedChanged(object sender, EventArgs e)
        {
            txtValor1.Focus();
            txtValor1.Visible = true;
            lblValor1.Visible = true;
            txtValor2.Visible = true;
            lblValor2.Visible = true;
            txtRespuesta.Clear();
        }
    }
}
