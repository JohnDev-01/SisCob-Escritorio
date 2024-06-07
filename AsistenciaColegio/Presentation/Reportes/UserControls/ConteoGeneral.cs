using SisCob.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisCob.Presentation.Reportes.UserControls
{
    public partial class ConteoGeneral : UserControl 
    {
        public ConteoGeneral()
        {
            InitializeComponent();
        }

        private void ConteoGeneral_Load(object sender, EventArgs e)
        {
            MostrarConteo();
        }
        private void MostrarConteo()
        {
            var fi = dtFi.Value;
            var ff = dtFF.Value;
            var dtInicial = new DataTable();
            var dtPrimario = new DataTable();
            var dtSecundario = new DataTable();
            var dtInformacionEmpresa = new DataTable();

            Obtener_datos.MostrarReporteConteoNivelInicial(ref dtInicial, fi, ff);
            Obtener_datos.MostrarReporteConteoNivelPrimaria(ref dtPrimario, fi, ff);
            Obtener_datos.MostrarReporteConteoNivelSecundaria(ref dtSecundario, fi, ff);
            Obtener_datos.MostrarInformacionEmpresReporte(ref dtInformacionEmpresa);

            var fechaIni = fi.ToString("dd/MM/yyyy");
            var fechaFinal = ff.ToString("dd/MM/yyyy");
            var pageReport = new DisenoRpt.ConteoGeneral();
            pageReport.DataSource = dtInformacionEmpresa;
            pageReport.tableInicial.DataSource = dtInicial;
            pageReport.tablePrimario.DataSource = dtPrimario;
            pageReport.tableSecundario.DataSource = dtSecundario;
            pageReport.txtFecha.Value = $"Desde: {fechaIni} Hasta: {fechaFinal}";
            reportViewer1.ReportSource = pageReport;
            reportViewer1.RefreshReport();
        }

        private void dtFi_ValueChanged(object sender, EventArgs e)
        {
            MostrarConteo();
        }

        private void dtFF_ValueChanged(object sender, EventArgs e)
        {
            MostrarConteo();
        }
    }
}
