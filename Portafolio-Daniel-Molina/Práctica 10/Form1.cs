using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Práctica_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void rdoCarro_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCarro.Checked)
            {
                txtPuertas.Visible = true;
                lblPuertas.Visible = true;
            }
            else
            {
                txtPuertas.Visible = false;
                lblPuertas.Visible = false;
            }

        }
        private void rdoCamión_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCamión.Checked)
            {
                txtCapacidad.Visible = true;
                lblCapacidad.Visible = true;
                txtCombustible.Visible = true;
                lblCombustible.Visible = true;
            }
            else
            {
                txtCapacidad.Visible = false;
                lblCapacidad.Visible = false;
                txtCombustible.Visible = false;
                lblCombustible.Visible = false;
            }
        }
        private void rdoMicrobus_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoMicrobus.Checked)
            {
                txtPasajeros.Visible = true;
                lblPasajeros.Visible = true;

            }
            else
            {
                txtPasajeros.Visible = false;
                lblPasajeros.Visible = false;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lblPuertas.Visible = false;
            txtPuertas.Visible = false;
            lblCombustible.Visible = false;
            txtCombustible.Visible = false;
            lblCapacidad.Visible = false;
            txtCapacidad.Visible = false;
            lblPasajeros.Visible = false;
            txtPasajeros.Visible = false;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtMarca.Text == string.Empty && txtModelo.Text == string.Empty && nudPrecio.Value == 0)
            {
                MessageBox.Show("Todos los campos son obligatorios");
            }
            if (txtMarca.Text == string.Empty)
            {
                MessageBox.Show("La marca es un campo obligatorio");
                txtMarca.Focus();
            }
            else if (txtModelo.Text == string.Empty)
            {
                MessageBox.Show("El modelo es un campo obligatorio");
                txtModelo.Focus();
            }
            else if (nudPrecio.Value == 0)
            {
                MessageBox.Show("El Precio es un campo obligatorio");
                nudPrecio.Focus();
            }
            else if (!rdoCarro.Checked && !rdoCamión.Checked && !rdoMicrobus.Checked)
            {
                MessageBox.Show("Debe de elegir el tipo de vehículo");
            }
            else if (rdoCarro.Checked)
            {
                if (txtPuertas.Text == string.Empty)
                {
                    MessageBox.Show("La cantidad de puertas es un campo obligatorio");
                    txtPuertas.Focus();
                }
                else
                {
                    Carro carro = new Carro(txtMarca.Text, Convert.ToInt32(nudMillas.Value), txtModelo.Text, Convert.ToDouble(nudPrecio.Value), Convert.ToInt32(txtPuertas.Text));
                    dataGridView1.Rows.Add(carro.Marca, carro.Modelo, carro.Millaje, carro.Precio.ToString("C2"), rdoCarro.Text, carro.Puertas, "", "", "");
                    txtMarca.Clear();
                    txtModelo.Clear();
                    nudMillas.Value = 0;
                    nudPrecio.Value = 0;
                    txtPuertas.Clear();
                    txtCapacidad.Clear();
                    txtCombustible.Clear();
                    txtPasajeros.Clear();
                    dataGridView1.ClearSelection();
                    txtMarca.Focus();
                }
            }
            else if (rdoCamión.Checked)
            {
                if (txtCapacidad.Text == string.Empty)
                {
                    MessageBox.Show("La capacidad de carga es un campo obligatorio");
                    txtCapacidad.Focus();
                }
                else if (txtCombustible.Text == string.Empty)
                {
                    MessageBox.Show("La capacidad del tanque de combustible es un campo obligatorio");
                }
                else
                {
                    Camión camion = new Camión(txtMarca.Text, Convert.ToInt32(nudMillas.Value), txtModelo.Text, Convert.ToDouble(nudPrecio.Value), Convert.ToInt32(txtCapacidad.Text), Convert.ToInt32(txtCombustible.Text));
                    dataGridView1.Rows.Add(camion.Marca, camion.Modelo, camion.Millaje, camion.Precio.ToString("C2"), rdoCarro.Text, "", camion.CapacidadCarga, camion.TanqueCombustible, "");
                    txtMarca.Clear();
                    txtModelo.Clear();
                    nudMillas.Value = 0;
                    nudPrecio.Value = 0;
                    txtPuertas.Clear();
                    txtCapacidad.Clear();
                    txtCombustible.Clear();
                    txtPasajeros.Clear();
                    dataGridView1.ClearSelection();
                    txtMarca.Focus();
                }
            }
            else if (rdoMicrobus.Checked)
            {
                if (txtPasajeros.Text == string.Empty)
                {
                    MessageBox.Show("El número de pasjeros debe de estar específicado ");
                }
                else
                {
                    Microbus microbus = new Microbus(txtMarca.Text, Convert.ToInt32(nudMillas.Value), txtModelo.Text, Convert.ToDouble(nudPrecio.Value), Convert.ToInt32(txtPasajeros.Text));
                    dataGridView1.Rows.Add(microbus.Marca, microbus.Modelo, microbus.Millaje, microbus.Precio.ToString("C2"), rdoCarro.Text, "", "", "", microbus.Pasajeros);
                    txtMarca.Clear();
                    txtModelo.Clear();
                    nudMillas.Value = 0;
                    nudPrecio.Value = 0;
                    txtPuertas.Clear();
                    txtCapacidad.Clear();
                    txtCombustible.Clear();
                    txtPasajeros.Clear();
                    dataGridView1.ClearSelection();
                    txtMarca.Focus();
                }
            }
        }
        private void txtPuertas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtCapacidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtCombustible_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtPasajeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}