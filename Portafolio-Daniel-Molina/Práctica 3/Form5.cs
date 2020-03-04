using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Práctica_3
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            string nombre = @"^(([A-Z[ÁÉÍÓÚ][a-zñ[áéíóú]{2,})(\s)?)*[^\s]$";
            if (!Regex.IsMatch(txtNombre.Text, nombre))
            {
                e.Cancel = true;
                txtNombre.SelectAll();
                err.SetError(txtNombre, "El nombre ingresado no es valido...\nCada nombre ingresado debe iniciar en mayusculas.");
            }

        }

        private void txtNombre_Validated(object sender, EventArgs e)
        {
            err.Clear();
        }

        private void txtHorasTrabajadas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtHorasTrabajadas_Validating(object sender, CancelEventArgs e)
        {
            if (txtHorasTrabajadas.Text == "")
            {
                e.Cancel = true;
                txtHorasTrabajadas.Focus();
                err.SetError(txtHorasTrabajadas, "La cantidad de horas es un campo obligatorio.\nIngrese la cantidad de horas.");
            }
        }

        private void txtHorasTrabajadas_Validated(object sender, EventArgs e)
        {
            err.Clear();
        }

        private void txtValorhora_Validating(object sender, CancelEventArgs e)
        {
            if (txtValorhora.Text == "")
            {
                e.Cancel = true;
                txtValorhora.Focus();
                err.SetError(txtValorhora, "El precio por hora es un campo obligatorio.\nIngrese el precio por hora.");
            }

        }

        private void txtValorhora_Validated(object sender, EventArgs e)
        {
            err.Clear();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            int horas;
            double precio, subtotal, total = 0, impuesto, tn = 0;


            if (nombre != string.Empty && int.TryParse(txtHorasTrabajadas.Text, out horas) && double.TryParse(txtValorhora.Text, out precio))
            {
                subtotal = horas * precio;
                impuesto = (subtotal * 0.10);
                total = subtotal - impuesto;

                dgvPlantilla.Rows.Add(nombre, horas, precio, subtotal, impuesto, total);

            }
            double suma = 0.0;
            for (int i = 0; i < dgvPlantilla.Rows.Count; i++)
            {
                suma = suma + Convert.ToDouble(dgvPlantilla.Rows[i].Cells[5].Value);
            }


            lblTotalplanilla.Text = suma.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtHorasTrabajadas.Clear();
            txtValorhora.Clear();

        }
    }
}

