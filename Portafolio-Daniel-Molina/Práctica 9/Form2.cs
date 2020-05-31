using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Práctica_9
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Archivo archivo = new Archivo("Vehiculos.dat");
        Vehiculo vehiculo = new Vehiculo();
        List<string> listaVehiculos;
        Dictionary<string, Vehiculo> diccionarioVehiculo = new Dictionary<string, Vehiculo>();

        private void ActualizarGrid(ref DataGridView grid)
        {
            grid.Rows.Clear();
            foreach (Vehiculo vehiculo in diccionarioVehiculo.Values)
            {
                grid.Rows.Add(vehiculo.Matricula, vehiculo.Marca, vehiculo.Modelo, vehiculo.Color, vehiculo.Year, vehiculo.NumPasajeros, "Eliminar");
            }
            grid.ClearSelection();
        }

        private void btnAgregarNuevoVehiculo_Click(object sender, EventArgs e)
        {
            //vehiculo = null;
            //listaVehiculos = diccionarioVehiculo.Select(Matriculas => Matriculas.Key).ToList();
            //Form3 f3 = new Form3(null, listaVehiculos);
            //if (f3.ShowDialog() == DialogResult.OK)
            //{
            //    Vehiculo vehiculo = f3.getVehiculo();
            //    if (vehiculo != null)
            //    {
            //        if (!diccionarioVehiculo.ContainsKey(vehiculo.Matricula))
            //        {
            //            diccionarioVehiculo.Add(vehiculo.Matricula, vehiculo);
            //            archivo.GuardarArchivo(diccionarioVehiculo);

            //            ActualizarGrid(ref dgvVehiculo);
            //            MessageBox.Show("El nuevo vehículo fue almacenado");
            //        }
            //        else
            //        {
            //            MessageBox.Show("Esta matrícula ya fue almacenada.");
            //        }

            //    }
            //}
            //f3.Dispose();
        }

        private void dgvVehiculo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvVehiculo.Rows.Count > 0 && dgvVehiculo.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                string matricula = dgvVehiculo.CurrentRow.Cells[0].Value.ToString();
                DialogResult result = MessageBox.Show("¿Está seguro de eliminar este vehículo?", "Vehículo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                if (result == DialogResult.Yes)
                {
                    diccionarioVehiculo.Remove(dgvVehiculo.CurrentRow.Cells[0].Value.ToString());
                    archivo.GuardarArchivo(diccionarioVehiculo);
                    dgvVehiculo.Rows.Remove(dgvVehiculo.CurrentRow);
                    dgvVehiculo.ClearSelection();
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            diccionarioVehiculo = (Dictionary<string, Vehiculo>)archivo.LeerArchivo();
            if (diccionarioVehiculo != null)
            {
                ActualizarGrid(ref dgvVehiculo);
            }
            else
            {
                diccionarioVehiculo = new Dictionary<string, Vehiculo>();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
