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

namespace SisCob.Presentation.Login
{
    public partial class frmInicioSesion : Form
    {
        public frmInicioSesion()
        {
            InitializeComponent();
        }
        //Declaracion de variables
        int IdUsuario = 0;
        string Rol = "";
        string NombreUsuario = "";
        string Correo = "";
        string Contra = "";
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmInicioSesion_Load(object sender, EventArgs e)
        {
            IdentificarConexion();
        }
        private void IdentificarConexion()
        {
            if(Obtener_datos.IndetificarExisteBaseDatos() == true)
            {
                ValidarLicencia();
                OrganizarControles();
                DibujarUsuarios();
            }
            else
            {
                var page = new AsistenteInstalador.Instalador();
                this.Hide();
                page.Show();
            }
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
        private void OrganizarControles()
        {
            panelUsuarios.Visible = true;
            panelUsuarios.Dock = DockStyle.Fill;
            Pcontra.Visible = false;
        }
        private void DibujarUsuarios()
        {
            flowLayoutPanel1.Controls.Clear();
            var dt = new DataTable();
            Obtener_datos.mostrarUsuarios(ref dt, "");
            foreach (DataRow r in dt.Rows)
            {
                Panel p = new Panel();
                Label L = new Label();
                PictureBox i = new PictureBox();

                p.Size = new Size(221, 194);
                p.BackColor = Color.Transparent;
                p.BorderStyle = BorderStyle.None;

                byte[] b = (Byte[])r["Icono"];
                MemoryStream ms = new MemoryStream(b);
                i.BorderStyle = BorderStyle.None;
                i.Image = Image.FromStream(ms);
                i.Dock = DockStyle.Fill;
                i.SizeMode = PictureBoxSizeMode.Zoom;
                i.Tag = r["IdUsuario"].ToString();
                i.Click += I_Click;

                L.Dock = DockStyle.Bottom;
                L.Text = r["Usuario"].ToString();
                L.AutoSize = false;
                L.TextAlign = ContentAlignment.MiddleCenter;
                L.ForeColor = Color.White;
                L.Font = new Font("Microsoft Sans Serif", 12);
                L.Size = new Size(221, 26);
                L.Tag = r["IdUsuario"].ToString();
                L.Click += L_Click;

                p.Controls.Add(L);
                p.Controls.Add(i);
                i.BringToFront();
                flowLayoutPanel1.Controls.Add(p);
            }
        }

        private void L_Click(object sender, EventArgs e)
        {
            IdUsuario = Convert.ToInt32(((Label)sender).Tag.ToString());
            Obtener_datosLogin();
            OrganizarPanelesParaContra();
        }

        private void I_Click(object sender, EventArgs e)
        {

            IdUsuario = Convert.ToInt32(((PictureBox)sender).Tag.ToString());
            Obtener_datosLogin();
            OrganizarPanelesParaContra();
        }
        private void Obtener_datosLogin()
        {
            var dt = new DataTable();
            Obtener_datos.mostrarUsuarioPorId(ref dt, IdUsuario);
            foreach (DataRow d in dt.Rows)
            {
                Rol = d["Rol"].ToString();
                NombreUsuario = d["Nombre"].ToString();
                Correo = d["Correo"].ToString();
                Contra = d["Pin"].ToString();

                byte[] b = (Byte[])d["Icono"];
                MemoryStream ms = new MemoryStream(b);
                IconoContra.Image = Image.FromStream(ms);
            }
            if (Rol == "ASISTENCIA")
            {
                lblNombreUser.Text = NombreUsuario;
                lblRol.Text = "Rol: Toma de asistencia";
            }
            else
            {
                lblNombreUser.Text = NombreUsuario;
                lblRol.Text = "Rol: " + Rol;
            }

        }
        private void OrganizarPanelesParaContra()
        {
            panelUsuarios.Visible = false;
            Pcontra.Visible = true;
            Pcontra.Dock = DockStyle.Fill;
            PcontenedorContra.Visible = true;
            PcontenedorContra.Location = new Point((Width - PcontenedorContra.Width) / 2, 85);
            txtContra.Focus();
        }
        private void txtContra_TextChanged(object sender, EventArgs e)
        {
            if (txtContra.Text == "")
            {
                lblIngresa.Visible = true;
            }
            else
            {
                lblIngresa.Visible = false;
                VerificarContra_Contra();
            }
        }
        private void VerificarContra_Contra()
        {
            string contra_Encriptada = ClassBases.Encriptar(txtContra.Text);
            if (contra_Encriptada == Contra)
            {
                this.Hide();
                var frm = new Menu.MenuPrincipal();
                frm.ShowDialog();
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtContra.Text += "1";

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtContra.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtContra.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtContra.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtContra.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtContra.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtContra.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtContra.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtContra.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtContra.Text += "0";
        }

        private void btnBorrarUnCaracter_Click(object sender, EventArgs e)
        {
            var Cadena = txtContra.Text;
            var SinCaracter = Cadena.Remove(Cadena.Length - 1);
            txtContra.Text = SinCaracter;
        }

        private void btnborrartodo_Click(object sender, EventArgs e)
        {
            txtContra.Clear();
            txtContra.Focus();
        }

        private void btnDeUsuario_Click(object sender, EventArgs e)
        {
            txtContra.Clear();
            OrganizarControles();
            DibujarUsuarios();
        }
    }
}
