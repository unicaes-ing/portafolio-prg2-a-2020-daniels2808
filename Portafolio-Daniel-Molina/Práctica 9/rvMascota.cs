using Microsoft.Reporting.WinForms;
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
    public partial class rvMascota : Form
    {
        public rvMascota()
        {
            InitializeComponent();
        }
        public List<Mascota> listaMascotas = new List<Mascota>();
        private void rvMascota_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DisplayName = "Reporte de mascotas";
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetMascota", listaMascotas));
            this.reportViewer1.RefreshReport();
        }
    }
}
