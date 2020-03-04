using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Práctica_3
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int n;
            n = Convert.ToInt32(txtNumeroABuscar.Text);
            for (int f = 0; f < 10; f++)
            {
                for (int c = 0; c < 10; c++)
                {
                    if (dgvMostrarNumero.Rows[f].Cells[c].Value.Equals(n))
                    {
                        dgvMostrarNumero.Rows[f].Cells[c].Style.BackColor = Color.Yellow;
                    }

                }
            }


        }

        private void Form4_Load(object sender, EventArgs e)
        {
           dgvMostrarNumero.Size = new Size(210, 220);
            dgvMostrarNumero.AllowUserToAddRows = false;
            dgvMostrarNumero.ScrollBars = ScrollBars.Both;
            dgvMostrarNumero.ColumnCount = 10;
            dgvMostrarNumero.ColumnHeadersVisible = false;
            dgvMostrarNumero.RowHeadersVisible = false;
            dgvMostrarNumero.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells;
            Random r = new Random();
            for (int f = 0; f < 10; f++)
            {
                dgvMostrarNumero.Rows.Add();
                for (int c = 0; c < 10; c++)
                {
                    dgvMostrarNumero.Rows[f].Cells[c].Value = r.Next(10, 100);
                }
            }
            dgvMostrarNumero.ClearSelection();

        }
    }
}
