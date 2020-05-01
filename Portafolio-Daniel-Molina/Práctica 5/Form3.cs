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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        string[][] ventas = new string[7][];

        private void Form3_Load(object sender, EventArgs e)
        {
            ventas[0] = new string[4] { "4", "2", "8", "1" };
            ventas[1] = new string[8] { "9", "2", "1", "4", "9", "5", "3", "8" };
            ventas[2] = new string[4] { "1", "8", "6", "7" };
            ventas[3] = new string[7] { "4", "2", "3", "1", "9", "7", "8" };
            ventas[4] = new string[9] { "8", "5", "7", "4", "3", "2", "3", "1", "6" };
            ventas[5] = new string[5] { "5", "3", "1", "9", "7" };
            ventas[6] = new string[6] { "6", "4", "2", "9", "5", "11" };
            lstSucrsales.Items.Clear();
            for (int i = 0; i < ventas.GetLength(0); i++)
            {
                lstSucrsales.Items.Add("Sucursal #" + (i + 1));
            }
        }

        private void lstSucrsales_SelectedIndexChanged(object sender, EventArgs e)
        {
            int suma = 0;
            if (lstSucrsales.SelectedIndex >= 0)
            {
                lstVentas.Items.Clear();
                foreach (string ventas in ventas[lstSucrsales.SelectedIndex])
                {
                    lstVentas.Items.Add(ventas);
                    suma = suma + Convert.ToInt32(ventas);
                }
            }
            lblTotal.Text = suma.ToString("C2");
        }
    }
}
