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
    public partial class InformeConteo : UserControl
    {
        public InformeConteo()
        {
            InitializeComponent();
        }

        private void InformeConteo_Load(object sender, EventArgs e)
        {
            MostrarReporte();
        }
        private void MostrarReporte()
        {
            DataTable dtInformacionEmpresa = new DataTable();
            
            Obtener_datos.MostrarInformacionEmpresReporte(ref dtInformacionEmpresa);

            var pageReport = new DisenoRpt.rptInformeRapido();
            pageReport.DataSource = dtInformacionEmpresa;
            pageReport.txtFecha.Value = dtFecha.Value.ToString("dd/MM/yyyy");
            pageReport.tableInformacion.DataSource = Obtener_datos.GetInforme(dtFecha.Value);
            reportViewer1.ReportSource = pageReport;
            reportViewer1.RefreshReport();
        }

        private void dtFecha_ValueChanged(object sender, EventArgs e)
        {
            MostrarReporte();

        }
    }
}
