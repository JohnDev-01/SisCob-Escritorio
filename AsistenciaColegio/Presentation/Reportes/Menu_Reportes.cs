using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisCob.Presentation.Reportes
{
    public partial class Menu_Reportes : Form
    {
        public Menu_Reportes()
        {
            InitializeComponent();
        }
       
        private void btnConteoAcumulado_Click(object sender, EventArgs e)
        {
            OcultarPanelesBotones();
            pColorAsistencia.Visible = true;
            //Mostrar Panel 
            var page = new Reportes.UserControls.AsistenciaGeneral();
            page.Dock = DockStyle.Fill;
            panelInformacion.Controls.Clear();
            panelInformacion.Controls.Add(page);
        }

        private void btnEstudiantes_Click(object sender, EventArgs e)
        {
            OcultarPanelesBotones();
            pColorEstudiantes.Visible = true;
            //Mostrar Panel 
            var page = new Reportes.UserControls.MostrarEstudiantes();
            page.Dock = DockStyle.Fill;
            panelInformacion.Controls.Clear();
            panelInformacion.Controls.Add(page);
        }

        private void Menu_Reportes_Load(object sender, EventArgs e)
        {
            OcultarPanelesBotones();
        }
        private void OcultarPanelesBotones()
        {
            pColorConteo.Visible = false;
            pColorAsistencia.Visible = false;
            pColorEstudiantes.Visible = false;
            pColorConexion.Visible = false;
            pColorInformeRapido.Visible = false ;
        }
        private void btnConteoGeneral_Click(object sender, EventArgs e)
        {
            
        }

        private void btnConteoGeneral2_Click(object sender, EventArgs e)
        {
            OcultarPanelesBotones();
            pColorConteo.Visible = true;
            //Mostrar Panel 
            var page = new Reportes.UserControls.ConteoGeneral();
            page.Dock = DockStyle.Fill;
            panelInformacion.Controls.Clear();
            panelInformacion.Controls.Add(page);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnConexion_Click(object sender, EventArgs e) 
        {
            OcultarPanelesBotones();
            pColorConexion.Visible = true;

            panelInformacion.Controls.Clear();
            var page = new ConexionesRemotas.GenerarConexion();
            page.Dock = DockStyle.Fill;
            panelInformacion.Controls.Add(page);
        }

        private void Menu_Reportes_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Menu_Reportes_FormClosed(object sender, FormClosedEventArgs e)
        {
            var frm = new Menu.MenuPrincipal();
            this.Dispose();
            frm.ShowDialog();
        }

        private void btnConteoRapido_Click(object sender, EventArgs e)
        {
            OcultarPanelesBotones();
            pColorInformeRapido.Visible = true;

            panelInformacion.Controls.Clear();
            var page = new UserControls.InformeConteo();
            page.Dock = DockStyle.Fill;
            panelInformacion.Controls.Add(page);
        }
    }
}
