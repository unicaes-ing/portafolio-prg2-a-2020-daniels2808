using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Promedio : Form
    {
        public Promedio()
        {
            InitializeComponent();
        }      

    
      

        private void btn_cal_Click(object sender, EventArgs e)
        {
            double exa1, exa2, exa3,prom;
            exa1 = Convert.ToDouble(txt_exa1.Text);
            exa2 = Convert.ToDouble(txt_exa2.Text);
            exa3 = Convert.ToDouble(txt_exa3.Text);
            prom = (exa1 + exa2 + exa3) / 3.0;//Se estaban dividiendo valores double entre un decimal y eso hace una perdida de decimales, por eso se pone .0)
            txt_prom.Text = prom.ToString("N2"); //Se pone . string para cambiarlo a ese tipo de varibale ya que la variable prom era double
        }

        private void btn_limp_Click(object sender, EventArgs e)
        {
            txt_exa1.Clear();
            txt_exa2.Clear();
            txt_exa3.Clear();
            txt_prom.Clear();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
