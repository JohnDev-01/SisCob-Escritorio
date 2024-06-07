using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SisCob.Data;

namespace SisCob.Presentation.Niveles
{
    public partial class admin_niveles : UserControl
    {
        public admin_niveles()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            panelAgregar.Visible = true;
            panelAgregar.Dock = DockStyle.Fill;
            panelMostrarDatos.Visible = false;
            panelMostrarDatos.Dock = DockStyle.None;

        }

        private void admin_niveles_Load(object sender, EventArgs e)
        {
            CargarInicio();
        }
        private void CargarInicio()
        {
            panelAgregar.Visible = false;
            panelAgregar.Dock = DockStyle.None;
            panelMostrarDatos.Visible = true;
            panelMostrarDatos.Dock = DockStyle.Fill;
            MostrarNiveles();
        }
        private void InsertarNivel()
        {
            var classInsert = new Insertar_datos();
            if (classInsert.Insertar_Nivel(txtNombre.Text) == true)
            {
                MessageBox.Show("Nivel insertado correctamente", "Operacion:", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void MostrarNiveles()
        {
            var classe = new Obtener_datos();
            var dt = new DataTable();
            classe.MostrarNiveles(ref dt);
            dgvNiveles.DataSource = dt;
        }
        
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) == false)
            {
                InsertarNivel();
                CargarInicio();
               
            }
        }
    }
}
