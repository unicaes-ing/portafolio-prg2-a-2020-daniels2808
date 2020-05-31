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

namespace Práctica_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Mascota NuevaMascota = new Mascota();
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) && !Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool validado = true;
            errorProvider1.Clear();
            if (txtNombre.Text == "")
            {
                errorProvider1.SetError(txtNombre, "No puede dejarlo en blanco");
                validado = false;
            }
            else
            {
                string patronNombre = @"^(([A-Z[ÁÉÍÓÚ][a-zñ[áéíóú]{1,})(\s)?)*[^\s]$";
                if (!Regex.IsMatch(txtNombre.Text, patronNombre))
                {
                    errorProvider1.SetError(txtNombre, "Ingrese correctamente su nombre\n(con inicial mayúscula en nombres y apellidos");
                    validado = false;
                }
            }
            if (cboTipo.SelectedIndex == -1)
            {
                errorProvider1.SetError(cboTipo, "Debe seleccionar un tipo");
                validado = false;
            }
            if (txtEdad.Text == "")
            {
                errorProvider1.SetError(txtEdad, "No puede dejar este espacio en blanco");
            }
            else if (Convert.ToInt32(txtEdad.Text) == 0)
            {
                errorProvider1.SetError(txtEdad, "La edad no puede ser igual a 0");
            }
            if (validado)
            {
                NuevaMascota.Nombre = txtNombre.Text;
                NuevaMascota.Tipo = cboTipo.Text;

                if (rdoM.Checked)
                {
                    NuevaMascota.Sexo = rdoM.Text;
                }
                else
                {
                    NuevaMascota.Sexo = rdoH.Text;
                }
                NuevaMascota.Edad  = Convert.ToInt32(txtEdad.Text);
                string Nombre = NuevaMascota.Nombre;
                string Tipo = NuevaMascota.Tipo;
                string Sexo = NuevaMascota.Sexo;
                int Edad = NuevaMascota.Edad;
                dgvNuevaMascota.Rows.Add(Nombre, Tipo, Sexo, Edad);

                MessageBox.Show("¡Los datos se han guardado exitosamente!");
                txtNombre.Clear();
                cboTipo.SelectedIndex = -1;
                txtEdad.Clear();
                rdoM.Checked = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                rvMascota reporte = new rvMascota();
                for (int i = 0; i < dgvNuevaMascota.RowCount; i++)
                {
                    Mascota mascota = new Mascota
                    {
                        Nombre = dgvNuevaMascota.Rows[i].Cells[0].Value.ToString(),
                        Tipo = dgvNuevaMascota.Rows[i].Cells[1].Value.ToString(),
                        Sexo = dgvNuevaMascota.Rows[i].Cells[2].Value.ToString(),
                        Edad = Convert.ToInt32(dgvNuevaMascota.Rows[i].Cells[3].Value)

                    };
                    reporte.listaMascotas.Add(mascota);
                }

                reporte.ShowDialog(this);
            }
            catch (Exception)
            {
                MessageBox.Show("Existe un problema con el reporte de empleados", "",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
