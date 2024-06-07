using SisCob.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisCob.Presentation.AsistenteInstalador.Views
{
    public partial class DefinicionEmpresa : Form
    {
        public DefinicionEmpresa()
        {
            InitializeComponent();
        }
        private void ValidacionGuardar()
        {
            if (!string.IsNullOrEmpty(txtNombre.Text))
            {
                var ruta = Path.Combine(Directory.GetCurrentDirectory(), "scriptBaseSisCob" + ".txt");
                FileInfo fi = new FileInfo(ruta);
                File.Delete(ruta);
                InsertarEmpresa();
            }
            else
            {
                MessageBox.Show("Datos invalidos", "Verifica");
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
                var page = new CrearUsuarioAdmin();
                this.Hide();
                page.ShowDialog();
            }
            
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ValidacionGuardar();
        }
       
        private void CrearNuevoUsuario_Load(object sender, EventArgs e)
        {
            panelEmpresa.Location = new Point((Width - panelEmpresa.Width) / 2, (Height - panelEmpresa.Height) / 2);
        }
    }
}
