using SisCob.Data;
using SisCob.Models;
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
    public partial class AsistenciaGeneral : UserControl
    {
        public AsistenciaGeneral()
        {
            InitializeComponent();
        }
        private void IdentificarModoReporte()
        {
            //Configuracion de panel general:
            if (rbGeneral.Checked == true)
            {
                panelGeneral.Visible = true;
                checkFiltradoGeneral.Checked = false;
                MostrarReporteHoyGeneral();
                IndetificarCheckFiltradoGeneral();
            }
            else
            {
                panelGeneral.Visible = false;
            }
            //Configuracon de panel Por Grado:
            if (rbPorGrado.Checked == true)
            {
                panelPorGrado.Visible = true;
                
                IdentificarCheckFiltradoGrado();
                CargarGradosCombo();
                try
                {
                    int Idgrado = Convert.ToInt32(cbGrado.SelectedValue);
                    MostrarReporte(Idgrado);
                }
                catch (Exception ex)
                {

                }
                
            }
            else
            {
                panelPorGrado.Visible = false;
            }
        }
        private void rbGeneral_CheckedChanged(object sender, EventArgs e)
        {
            IdentificarModoReporte();
        }

        private void rbPorGrado_CheckedChanged(object sender, EventArgs e)
        {
            IdentificarModoReporte();
        }
        private void IndetificarCheckFiltradoGeneral()
        {
            if (checkFiltradoGeneral.Checked == true)
            {
                panelFiltradoGeneral.Visible = true;
                btnHoyGeneral.Enabled = false;
                MostrarReporteHoyGeneralFecha();
            }
            else
            {
                MostrarReporteHoyGeneral();

                panelFiltradoGeneral.Visible = false;
                btnHoyGeneral.Enabled = true;
            }
        }
        private void checkFiltradoGeneral_CheckedChanged(object sender, EventArgs e)
        {
            IndetificarCheckFiltradoGeneral();
           
        }
        private void IdentificarCheckFiltradoGrado()
        {
            /*if (checkFiltradoGrado.Checked == true)
            {
                panelFiltradoGrado.Visible = true;
                btnHoyGrado.Enabled = false;
            }
            else
            {
                panelFiltradoGrado.Visible = false;
                btnHoyGrado.Enabled = true;
            }
            */
        }
        private void checkFiltradoGrado_CheckedChanged(object sender, EventArgs e)
        {
            IdentificarCheckFiltradoGrado();
        }
        private void CargarGradosCombo()
        {
            var dt = new DataTable();
            Obtener_datos.mostrar_Cursos(ref dt);
            cbGrado.DataSource = dt;
            cbGrado.DisplayMember = "Nombre_Curso";
            cbGrado.ValueMember = "IdCurso";
            
        }
        private void MostrarReporteHoyGeneral()
        {
          
            var clase = new Obtener_datos();
            var dtAsistencia = new DataTable();
            var dtEmpresa = new DataTable();
            var rpt = new DisenoRpt.AsistenciaGeneral();
            int TotalPresentes = 0;
            int TotalAusentes = 0;
            Obtener_datos.ReporteMostrarAsistenciaGeneral(ref dtAsistencia,ref TotalPresentes
                , ref TotalAusentes);
            clase.MostrarInformacionEmpresa(ref dtEmpresa);

            rpt.txtTotalAusentes.Value = TotalAusentes.ToString();
            rpt.txtTotalPresentes.Value = TotalPresentes.ToString();
            rpt.table1.DataSource = dtAsistencia;
            rpt.txtFecha.Value = "";
            rpt.DataSource = dtEmpresa;
            reportViewer1.ReportSource = rpt;
            reportViewer1.RefreshReport();
            
        }
        private void MostrarReporteHoyGeneralFecha()
        {
          
            var clase = new Obtener_datos();
            var dtAsistencia = new DataTable();
            var dtEmpresa = new DataTable();
            var rpt = new DisenoRpt.AsistenciaGeneral();
            var FechaInicial = dtfiGeneral.Value;
            var FechaFinal = dtffGeneral.Value;
            int TotalPresentes = 0;
            int TotalAusentes = 0;
            Obtener_datos.ReporteMostrarAsistenciaGeneralFecha(ref dtAsistencia,ref TotalPresentes
                ,ref TotalAusentes, FechaInicial,FechaFinal);
            clase.MostrarInformacionEmpresa(ref dtEmpresa);
            
            rpt.table1.DataSource = dtAsistencia;
            rpt.txtFecha.Value = "Desde: "+FechaInicial.ToString("dd/MM/yyyy")+" Hasta: "+ FechaFinal.ToString("dd/MM/yyyy");
            rpt.txtTotalAusentes.Value = TotalAusentes.ToString();
            rpt.txtTotalPresentes.Value = TotalPresentes.ToString();
            rpt.DataSource = dtEmpresa;
            reportViewer1.ReportSource = rpt;
            reportViewer1.RefreshReport();
            
        }
        private void btnHoyGeneral_Click(object sender, EventArgs e)
        {
            MostrarReporteHoyGeneral();
        }

        private void ConteoAcumulado_Load(object sender, EventArgs e)
        {
            MostrarGrado();
            rbGeneral.Checked = true;
        }
        private void MostrarGrado()
        {
            var dt = new DataTable();
            Obtener_datos.mostrar_Cursos(ref dt);
            cbGrado.DisplayMember = "Nombre_Curso";
            cbGrado.ValueMember = "IdCurso";
            cbGrado.DataSource = dt;
        }

        private void panelGeneral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtfiGeneral_ValueChanged(object sender, EventArgs e)
        {
            ValidarFecha();
            MostrarReporteHoyGeneralFecha();
        }private void ValidarFecha()
        {
            if (dtfiGeneral.Value > dtffGeneral.Value)
            {
                dtfiGeneral.Value = dtffGeneral.Value;
            }
            if (dtffGeneral.Value < dtfiGeneral.Value)
            {
                dtffGeneral.Value = dtfiGeneral.Value;
            }
        }

        private void dtffGeneral_ValueChanged(object sender, EventArgs e)
        {
            ValidarFecha();
            MostrarReporteHoyGeneralFecha();
        }

        private void cbGrado_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int Idgrado = Convert.ToInt32(cbGrado.SelectedValue);
                MostrarReporte(Idgrado);
            }
            catch (Exception ex)
            {

            }
        }

        private void MostrarReporte(int Idgrado)
        {
            var dtAusentes = new DataTable();
            var dtpresentes = new DataTable();
            var dtInformacionEmpresa = new DataTable();

            int Idasistencia = Obtener_datos.MostrarIdAsistenciaFechaGrado(Idgrado, dtffGrado.Value);
            Obtener_datos.ReporteAsistenciaEstudianteAusentes(Idasistencia,ref dtAusentes);
            Obtener_datos.ReporteAsistenciaEstudiantePresentes(Idasistencia,ref dtpresentes);
            Obtener_datos.MostrarInformacionEmpresReporte(ref dtInformacionEmpresa);

            var models = SumarAusentesYPresentes(new MsumaAusentesPresentes()
            { dtAusentes = dtAusentes, dtPresentes = dtpresentes });



            var page =new DisenoRpt.rptAsistenciaEstudiantes();
            page.DataSource = dtInformacionEmpresa;
            page.table2.DataSource = dtpresentes;
            page.table1.DataSource = dtAusentes;
            page.txtTotalAusentes.Value = models.TotalAusentes.ToString();
            page.txtTotalPresentes.Value = models.TotalPresentes.ToString();
            page.txtFecha.Value = "Fecha: "+dtffGrado.Value.ToString("dd/MM/yyyy");
            page.txtGrado.Value ="Grado: "+ cbGrado.Text;
            reportViewer1.ReportSource = page;
            reportViewer1.RefreshReport();

        }
        private MsumaAusentesPresentes SumarAusentesYPresentes(MsumaAusentesPresentes models)
        {
            var dtPresentes = models.dtPresentes;
            var dtAusentes = models.dtAusentes;
            int TotalPresentes = 0;
            int TotalAusentes = 0;
            foreach (DataRow item in dtPresentes.Rows)
            {
                TotalPresentes++;
            }
            foreach (DataRow item in dtAusentes.Rows)
            {
                TotalAusentes++;
            }

            return new MsumaAusentesPresentes()
            {
                TotalAusentes = TotalAusentes,
                TotalPresentes = TotalPresentes
            };
        }

        private void dtffGrado_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                int Idgrado = Convert.ToInt32(cbGrado.SelectedValue);
                MostrarReporte(Idgrado);
            }
            catch (Exception ex)
            {

            }
            
        }
    }

}
