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
using SisCob.Bases;
using SisCob.Data;
using SisCob.Models;

namespace SisCob.Presentation.InicioSesion
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }
        //Declaracion de variables :
        int IdUsuario = 0;
        bool estadoValidar = false;
        private void lblRecuperarConCorreo_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Hacer las validaciones de insertado:
            ValidarCampos();
            if (estadoValidar == false)
            {
                MessageBox.Show("Hay campos vacios o te hace falta asignar un icono, por favor completa.", "Validacion:", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                InsertarUser();
                btnVolver_Click(sender, e);
            }

        }
        private void InsertarUser()
        {
            MemoryStream ms = new MemoryStream();
            try
            {
                ICONO.Image.Save(ms, ICONO.Image.RawFormat);
            }
            catch (Exception ex)
            {

            }
            var Models = new MUsuarios
            {
                Nombre = txtnombre.Text,
                Usuario = txtlogin.Text,
                Pin = ClassBases.Encriptar(txtPassword.Text),
                Rol = txtrol.Text,
                Correo = "-",
                ICONOms = ms
            };
            if (Insertar_datos.Insertar_Usuarios(Models) == true)
            {
                LimpiarParaVolver();
            }

        }

        private void txtcorreo_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void LimpiarTxt()
        {
            txtnombre.Clear();
            txtlogin.Clear();
            txtPassword.Clear();
            txtrol.Text = "";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dgvUsuarios.Visible = false;
            panelAgregarUsuarios.Visible = true;
            LimpiarTxt();
            btnGuardarCambios.Visible = false;
            panelAgregarUsuarios.Dock = DockStyle.Fill;
            ICONO.Image = null;
            LblAnuncioIcono.Visible = true;
            txtrol.Text = "";
            lblCambiar.Visible = false;
            btnGuardar.Visible = true;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            LimpiarParaVolver();
        }
        private void LimpiarParaVolver()
        {
            dgvUsuarios.Visible = true;
            LimpiarTxt();
            panelAgregarUsuarios.Visible = false;
            MostrarUsuarios();
        }
        private void MostrarUsuarios()
        {
            var dt = new DataTable();
            Obtener_datos.mostrarUsuarios(ref dt, txtbuscar.Text);
            dgvUsuarios.DataSource = dt;
            dgvUsuarios.Dock = DockStyle.Fill;
            dgvUsuarios.BringToFront();
            dgvUsuarios.Visible = true;
            Bases.ClassBases.MultilineaTemaOscuro(ref dgvUsuarios);
            dgvUsuarios.Columns[2].Visible = false;
            dgvUsuarios.Columns[8].Visible = false;
        }
        private void Usuarios_Load(object sender, EventArgs e)
        {
            MostrarUsuarios();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtbuscar.Text == "")
            {
                lblBuscarEtiqueta.Visible = true;
            }
            else
            {
                lblBuscarEtiqueta.Visible = false;
            }

            MostrarUsuarios();
        }

        private void LblAnuncioIcono_Click(object sender, EventArgs e)
        {
            panelICONO.Visible = true;
            panelICONO.Dock = DockStyle.Fill;
            panelICONO.BringToFront();

        }
        private void AsignarIcono(ref PictureBox p)
        {
            ICONO.Image = p.Image;
            panelICONO.Visible = false;
            lblCambiar.Visible = true;
            LblAnuncioIcono.Visible = false;
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            AsignarIcono(ref pictureBox3);
        }

        private void lblCambiar_Click(object sender, EventArgs e)
        {
            LblAnuncioIcono_Click(sender, e);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            AsignarIcono(ref pictureBox4);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            AsignarIcono(ref pictureBox5);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            AsignarIcono(ref pictureBox6);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            AsignarIcono(ref pictureBox7);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            AsignarIcono(ref pictureBox8);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            AsignarIcono(ref pictureBox9);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            AsignarIcono(ref pictureBox10);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            OpenFileDialog _open = new OpenFileDialog();
            _open.Filter = "Imagenes(.JPG & .PNG)|*.png;*.jpg";
            _open.Title = "Selecciona una imagen de tu ordenador";
            if (_open.ShowDialog() == DialogResult.OK)
            {
                string ruta = _open.FileName;
                ICONO.Image = Image.FromFile(ruta);
                panelICONO.Visible = false;
                lblCambiar.Visible = true;
                LblAnuncioIcono.Visible = false;
            }
        }
        private void EliminarUsuarios()
        {
            DialogResult r = MessageBox.Show("¿Estas seguro de querer eliminar este usuario?", "Confirma:", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                MUsuarios u = new MUsuarios();
                u.Id = IdUsuario;
                Eliminar_datos.Eliminar_usuarios(u);
                MostrarUsuarios();
            }

        }
        private void PrepararEditarUsuarios()
        {
            dgvUsuarios.Visible = false;
            panelAgregarUsuarios.Visible = true;
            btnGuardarCambios.Visible = true;
            btnGuardar.Visible = false;
            panelAgregarUsuarios.Dock = DockStyle.Fill;
        }
        private void ObtenerDatosPorUsuario()
        {
            var dt = new DataTable();
            Obtener_datos.mostrarUsuarioPorId(ref dt, IdUsuario);
            foreach (DataRow lst in dt.Rows)
            {
                txtnombre.Text = lst["Nombre"].ToString();
                txtlogin.Text = lst["Usuario"].ToString();
                txtPassword.Text = Bases.ClassBases.Desencriptar(lst["Pin"].ToString());
                txtrol.Text = lst["Rol"].ToString();
                byte[] b = (Byte[])lst["Icono"];
                MemoryStream ms = new MemoryStream(b);
                ICONO.Image = Image.FromStream(ms);
                panelICONO.Visible = false;
                lblCambiar.Visible = true;
                LblAnuncioIcono.Visible = false;
            }
            if (txtlogin.Text == "admin")
            {
                txtlogin.Enabled = false;
            }
            else
            {
                txtlogin.Enabled = true;
            }
            PrepararEditarUsuarios();
        }
        private void ValidarCampos()
        {

            estadoValidar = true;
            if (txtnombre.Text == "")
            {
                estadoValidar = false;
            }
            if (txtlogin.Text == "")
            {
                estadoValidar = false;
            }


            if (txtPassword.Text == "")
            {
                estadoValidar = false;
            }

            if (txtrol.Text == "")
            {
                estadoValidar = false;
            }

            if (ICONO.Image == null)
            {
                estadoValidar = false;
            }
        }
        private void GuardarEditado()
        {

            //Hacer las validaciones de insertado:
            ValidarCampos();
            if (estadoValidar == false)
            {

                MessageBox.Show("Hay campos vacios o te hace falta asignar un icono, por favor completa.", "Validacion:", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                UpdateUser();
            }
        }
        private void UpdateUser()
        {
            //Procesamiento de la imagen en el icono:
            MemoryStream ms = new MemoryStream();
            ICONO.Image.Save(ms, ICONO.Image.RawFormat);

            MUsuarios m = new MUsuarios();
            m.Id = IdUsuario;
            m.Nombre = txtnombre.Text;
            m.Usuario = txtlogin.Text;
            m.Pin = ClassBases.Encriptar(txtPassword.Text);
            m.Correo = "-";
            m.Rol = txtrol.Text;
            m.ICONOms = ms;
            if (Editar_datos.Editar_Usuarios(m) == true)
            {
                MessageBox.Show("Usuario actualizado correctamente.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarParaVolver();
            }
        }
        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                IdUsuario = Convert.ToInt32(dgvUsuarios.SelectedCells[2].Value);
            }
            catch (Exception ex)
            {
            }

            if (e.ColumnIndex == dgvUsuarios.Columns["eli"].Index)
            {
                //Solo tengo que continuar con editar y luego agregar la columna de imagen
                //Para luego validar los campo |  
                EliminarUsuarios();
            }
            if (e.ColumnIndex == dgvUsuarios.Columns["edi"].Index)
            {
                ObtenerDatosPorUsuario();
            }
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            GuardarEditado();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtbuscar.Clear();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Usuarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            var page = new Menu.MenuPrincipal();
            this.Dispose();
            page.ShowDialog();

        }
    }
}
