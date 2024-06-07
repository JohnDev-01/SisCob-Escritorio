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

namespace SisCob.Presentation.Empresa
{
    public partial class DefinicionEmpresa : Form
    {
        public DefinicionEmpresa()
        {
            InitializeComponent();
        }

        private void DefinicionEmpresa_Load(object sender, EventArgs e)
        {
            //Crear procesos para mostrar y actualizar datos 
            MostrarEmpresa();
        }
        private void MostrarEmpresa()
        {
            var dt = new DataTable();
            Obtener_datos.MostrarEmpresa(ref dt);
            foreach (DataRow item in dt.Rows)
            {
                txtNombre.Text = item["Nombre"].ToString();
                txtLema.Text = item["Lema"].ToString();
                txtDireccion.Text = item["Direccion"].ToString();
                txtTelefono.Text = item["Telefono"].ToString();

            }
        }
        private void InsertarEmpresa()
        {
            var models = new Models.Mempresa()
            {
                Nombre = txtNombre.Text,
                Lema = txtLema.Text,
                Direccion = txtDireccion.Text,
                Telefono = txtTelefono.Text
            };
            if(Insertar_datos.Insertar_Empresa(models)== true)
            {
                MessageBox.Show("Informacion Actualizada Correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
        }
        private void ValidacionGuardar()
        {
            if (!string.IsNullOrEmpty(txtNombre.Text))
            {
                InsertarEmpresa();
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ValidacionGuardar();
        }
    }
}
