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
    public partial class MostrarEstudiantes : UserControl
    {
        public MostrarEstudiantes()
        {
            InitializeComponent();
        }

        private void MostrarEstudiantes_Load(object sender, EventArgs e)
        {
            
            MostrarGrado();
        }
        private void MostrarGrado()
        {
            var dt = new DataTable();
            Obtener_datos.mostrar_Cursos(ref dt);
            cbGrado.DisplayMember = "Nombre_Curso";
            cbGrado.ValueMember = "IdCurso";
            cbGrado.DataSource = dt;
        }

        private void cbGrado_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int Idgrado = Convert.ToInt32(cbGrado.SelectedValue.ToString());
                MostrarReporte(Idgrado);
            }
            catch (Exception ex)
            {

            }
        }
        private void MostrarReporte(int Idgrado)
        {
            
            int CantidadEstudiantes = 0;
            string Grado = "Grado: " + cbGrado.Text;
            var dtInformacionEmpresa = new DataTable();
            var dtEstudiantes = new DataTable();
            Obtener_datos.MostrarInformacionEmpresReporte(ref dtInformacionEmpresa);
            Obtener_datos.MostrarEstudiantesPorGrado(ref dtEstudiantes, Idgrado);
            Obtener_datos.SumarEstudiantesPorGrado(ref CantidadEstudiantes, Idgrado);

            var Page_report = new DisenoRpt.rptMostrarEstudiantes();
            Page_report.DataSource = dtInformacionEmpresa;
            Page_report.table1.DataSource = dtEstudiantes;
            Page_report.txtGrado.Value = Grado;
            Page_report.txtTotal.Value = $"Total:{CantidadEstudiantes}";
            reportViewer1.ReportSource = Page_report;
            reportViewer1.RefreshReport();
        }
    }
}
