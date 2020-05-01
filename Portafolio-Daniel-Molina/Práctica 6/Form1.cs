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

namespace Práctica_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> Empleados = new List<string>();

        string patronNombre = @"^(([A-Z[ÁÉÍÓÚ][a-zñ[áéíóú]{2,})(\s)?)*[^\s]$";

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            lstLista.DataSource = null;
            if (rdoAgregar.Checked)
            {
                if (txtEmpleado.Text != "" && Regex.IsMatch(txtEmpleado.Text, patronNombre))
                {
                    Empleados.Add(txtEmpleado.Text);
                    lstLista.Items.Clear();
                    foreach (string emplead in Empleados)
                    {
                        lstLista.Items.Add(emplead);
                    }
                    txtEmpleado.Clear();
                    txtEmpleado.Focus();
                }
                else
                {
                    MessageBox.Show("Debe ingresar un nombre de un empleado válido\nEl nombre ingresado debe iniciar en mayúsculas");
                    txtEmpleado.Focus();
                }
            }
            else if (rdoBuscar.Checked)
            {
                if (txtEmpleado.Text != "" && Regex.IsMatch(txtEmpleado.Text, patronNombre))
                {

                    foreach (string emplead in Empleados)
                    {

                        if (txtEmpleado.Text == emplead)
                        {
                            lstLista.SelectedItem = emplead;
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Ese empleado no existe");
                    txtEmpleado.Focus();
                }
            }
            else if (rdoInsertar.Checked)
            {
                if (txtEmpleado.Text != "" && Regex.IsMatch(txtEmpleado.Text, patronNombre) && lstLista.Items.Count >= 0)
                {
                    Empleados.Insert(lstLista.SelectedIndex, txtEmpleado.Text);
                    lstLista.Items.Insert(lstLista.SelectedIndex, txtEmpleado.Text);
                }
            }
            else if (rdoQuitar.Checked)
            {
                if (lstLista.Items.Count >= 0 && lstLista.SelectedIndex != -1)
                {
                    Empleados.RemoveAt(lstLista.SelectedIndex);
                    lstLista.Items.RemoveAt(lstLista.SelectedIndex);
                }
                else
                {
                    MessageBox.Show("Error al quitar el nombre\nDebe seleccionar un nombre para eliminarlo");
                }
            }
            else if (rdoOrdenar.Checked)
            {
                Empleados.Sort();
                if (lstLista.Items.Count > 1 && lstLista.Items.Count >= 0)
                {
                    lstLista.DataSource = Empleados;

                }
            }
            else if (rdoLimpiar.Checked)
            {
                lstLista.Items.Clear();
                Empleados.Clear();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}