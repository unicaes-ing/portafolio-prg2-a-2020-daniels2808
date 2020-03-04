using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Práctica_4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    int num = Convert.ToInt32(txtagregar.Text);
                    lstnumero.Items.Add(num);
                    txtagregar.Clear();
                    txtagregar.Focus();
                }
                catch (Exception)
                {

                    MessageBox.Show("Ingrese un número");
                }
            }
        }

        public static int Buscarnumero(int numerobuscar, ListBox lista)
        {
            int cont = 0;
            foreach (int num in lista.Items)
            {
                if (num == numerobuscar) cont++;
            }
            return cont;
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(txtbuscar.Text);
                int c = Buscarnumero(num, lstnumero);
                MessageBox.Show("Se encuentra " + c + " veces");
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese un número a buscar");
            }
        }
    }
    
}

    

