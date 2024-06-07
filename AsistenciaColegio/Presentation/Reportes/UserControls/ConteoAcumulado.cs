using AsistenciaColegio.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsistenciaColegio.Presentation.Reportes.UserControls
{
    public partial class ConteoAcumulado : UserControl
    {
        public ConteoAcumulado()
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
                checkFiltradoGrado.Checked = false;
                IdentificarCheckFiltradoGrado();
                CargarGradosCombo();
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
            }
            else
            {
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
            if (checkFiltradoGrado.Checked == true)
            {
                panelFiltradoGrado.Visible = true;
                btnHoyGrado.Enabled = false;
            }
            else
            {
                panelFiltradoGrado.Visible = false;
                btnHoyGrado.Enabled = true;
            }

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
            var dtConteo = new DataTable();
            var dtEmpresa = new DataTable();
            var rpt = new DisenoRpt.rptConteoGeneral();
            
            clase.MostrarConteoGeneral(ref dtConteo);
            clase.MostrarInformacionEmpresa(ref dtEmpresa);
            foreach (DataRow item in dtEmpresa.Rows)
            {
                rpt.txtNombre.Value = item["Nombre"].ToString();
                rpt.txtLema.Value = item["Lema"].ToString();
                rpt.txtDireccion.Value = item["Direccion"].ToString();
                rpt.txtTelefono.Value = item["Telefono"].ToString();
            }
            rpt.table1.DataSource = dtConteo;

            rpt.DataSource = dtConteo;
            reportViewer1.ReportSource = rpt;
            reportViewer1.RefreshReport();

        }
        private void btnHoyGeneral_Click(object sender, EventArgs e)
        {
            MostrarReporteHoyGeneral();
        }
    }
}
