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

namespace SisCob.Presentation.Menu
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
       
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            ValidarLicencia();
        }
        private void ValidarLicencia()
        {
            if (Obtener_datos.ValidarLicencia() == false)
            {
                this.Hide();
                var form = new Licencias.ActivarLicencia();
                form.ShowDialog();
            }
        }
        private void btnGrados_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            Courses.Courses_Controls obj = new Courses.Courses_Controls();
            obj.Dock = DockStyle.Fill;
            panel3.Controls.Add(obj);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            Students.Show_students f = new Students.Show_students();
            f.Dock = DockStyle.Fill;
            panel3.Controls.Add(f);
        }

      
        private void btnReportes_Click(object sender, EventArgs e)
        {
            var frm = new Reportes.Menu_Reportes();
            frm.FormClosing += Frm_FormClosing;
            this.Dispose();
            frm.ShowDialog();
            
        }

        private void Frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void btnNiveles_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            var f = new Niveles.admin_niveles();
            f.Dock = DockStyle.Fill;
            panel3.Controls.Add(f);
        }

        private void btnDispositivos_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            var f = new Dispositivos.AdministracionDispositivos();
            f.Dock = DockStyle.Fill;
            panel3.Controls.Add(f);
        }

        private void btnMigrar_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            var f = new Migraciones.MigrarEstudiantes();
            f.Dock = DockStyle.Fill;
            panel3.Controls.Add(f);
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            var page = new Empresa.DefinicionEmpresa();
            page.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            var page = new InicioSesion.Usuarios();
            this.Dispose();
            page.ShowDialog();
        }

        private void btnCopiaSeguridad_Click(object sender, EventArgs e)
        {
            var page = new CopiaDeSeguridad.RealizarCopia();
            page.ShowDialog();
        }

        private void btnRestaurarCopia_Click(object sender, EventArgs e)
        {
            var page = new CopiaDeSeguridad.RestaurarCopia();
            page.ShowDialog();
        }
    }
}
