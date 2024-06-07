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
    public partial class CrearUsuarioAdmin : Form
    {
        public CrearUsuarioAdmin()
        {
            InitializeComponent();
        }
        MemoryStream _imagenStream;
        private void EmpresaInicial_Load(object sender, EventArgs e)
        {
            ControlesInicio();
        }
        private void ControlesInicio()
        {
            btnContinuar.Enabled = false;
            panelIconoMostrar.Visible = false;
            panelICONO.Visible = true;
            panelUsuarios.Location = new Point((Width - panelUsuarios.Width) / 2, (Height - panelUsuarios.Height) / 2);

        }
        private void AsignarImagen(PictureBox pb)
        {
            _imagenStream = new MemoryStream();
            pb.Image.Save(_imagenStream, pb.Image.RawFormat);
            pbIcono.Image = pb.Image;
            panelIconoMostrar.Visible = true;
            panelVisorIcono.Visible = false;
            btnContinuar.Enabled = true;
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            AsignarImagen(pictureBox3);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            AsignarImagen(pictureBox4);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            AsignarImagen(pictureBox5);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            AsignarImagen(pictureBox6);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            AsignarImagen(pictureBox10);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            AsignarImagen(pictureBox9);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            AsignarImagen(pictureBox8);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            AsignarImagen(pictureBox7);
        }
        private void ValidarGuardado()
        {
            if (!string.IsNullOrEmpty(txtPin.Text))
            {
                if (_imagenStream != null)
                {
                    InsertarUsuario();
                }
                else
                {
                    MessageBox.Show("Datos invalidos", "Verifica");

                }
            }
            else
            {
                MessageBox.Show("Datos invalidos", "Verifica");
            }
        }
        private void InsertarUsuario()
        {
            var clase = new Data();
            if (clase.InsertarUsuarioAdmin(txtPin.Text, _imagenStream) == true)
            {
                clase.InsertarNivelesPredeterminados();
                var page = new Login.frmInicioSesion();
                this.Hide();
                page.ShowDialog();
            }
        }
        private void btnContinuar_Click(object sender, EventArgs e)
        {
            ValidarGuardado();
        }

        private void lblCambiar_Click(object sender, EventArgs e)
        {
            panelIconoMostrar.Visible = false;
            panelVisorIcono.Visible = true;
        }
    }
}
