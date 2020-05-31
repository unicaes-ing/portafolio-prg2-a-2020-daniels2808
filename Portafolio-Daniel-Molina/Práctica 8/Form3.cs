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
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Práctica_8
{
    public partial class Form3 : Form
    {
        public Form3(Vehiculo vehiculo, List<string> Matriculas)
        {
            InitializeComponent();
            if (vehiculo != null)
            {
                mtxMatricula.Text = vehiculo.Matricula;
                txtMarca.Text = vehiculo.Marca;
                txtModelo.Text = vehiculo.Modelo;
                cboColor.Text = vehiculo.Color;
                nudAño.Value = vehiculo.Year;
                nudPasajeros.Value = vehiculo.NumPasajeros;
            }
            listaMatriculas = Matriculas;
        }
        private Vehiculo nuevoVehiculo = new Vehiculo();
        private List<string> listaMatriculas = new List<string>();

        public Vehiculo getVehiculo()
        {
            return nuevoVehiculo;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool validado = true;
            if (mtxMatricula.Text == "" || txtMarca.Text == "" || txtModelo.Text == "" || cboColor.SelectedIndex == -1 || nudPasajeros.Value == 0)
            {
                MessageBox.Show("Debe ingresar datos de vehículos para poder almacenar");
                validado = false;

            }
            if (mtxMatricula.Text == "")
            {
                MessageBox.Show("La matrícula es un campo obligatorio");
                validado = false;
            }
            if (!mtxMatricula.MaskFull)
            {
                MessageBox.Show("Ingrese la matricula completa");
                validado = false;
            }
            if (txtMarca.Text == "")
            {
                MessageBox.Show("La marca es un campo obligatorio");
                validado = false;
            }
            else
            {
                string Patron = @"^(([A-Z[ÁÉÍÓÚ][a-zñ[áéíóú]{1,})(\s)?)*[^\s]$";
                if (!Regex.IsMatch(txtMarca.Text, Patron))
                {
                    MessageBox.Show("Debe ingresar la marca con la primera letra mayúscula");
                    validado = false;
                }
            }
            if (txtModelo.Text == "")
            {
                MessageBox.Show("El modelo es un campo obligatorio");
                validado = false;
            }
            if (cboColor.SelectedIndex == -1)
            {
                MessageBox.Show("El color es un campo obligatorio\nDebe seleccionar un Color");
                validado = false;
            }
            if (nudPasajeros.Value == 0)
            {
                MessageBox.Show("La cantidad de pasajeros es un campo obligatorio");
                validado = false;

            }
            if (validado)
            {
                DialogResult = DialogResult.OK;
                nuevoVehiculo.Matricula = mtxMatricula.Text;
                nuevoVehiculo.Marca = txtMarca.Text;
                nuevoVehiculo.Modelo = txtModelo.Text;
                nuevoVehiculo.Color = cboColor.Text;
                nuevoVehiculo.Year = Convert.ToInt32(nudAño.Value);
                nuevoVehiculo.NumPasajeros = Convert.ToInt32(nudPasajeros.Value);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

