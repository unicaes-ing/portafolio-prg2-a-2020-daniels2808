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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            lstabecedario.Items.Clear();
            for (char letra = 'A'; letra <= 'Z'; letra++)
            {
                lstabecedario.Items.Add(letra);
            }
        }
    }
}
