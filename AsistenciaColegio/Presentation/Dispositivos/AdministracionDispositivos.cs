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

namespace SisCob.Presentation.Dispositivos
{
    public partial class AdministracionDispositivos : UserControl
    {
        public AdministracionDispositivos()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void DibujarDispositivosEspera()
        {
            //Variables
            flowLayoutPanelEspera.Controls.Clear();
            var dt = new DataTable();
            var clase = new Obtener_datos();

            clase.MostrarDispositivosEspera(ref dt);
            foreach (DataRow item in dt.Rows)
            {
                string name = "";

                var panelPrincipal = new Panel();
                var pbIcono = new PictureBox();
                var lblDescripcion = new Label();
                var panelboton = new Panel();
                var btnAceptar = new Button();
                var btnRechazar = new Button();

                panelPrincipal.BackColor = Color.Transparent;
                panelPrincipal.BorderStyle = BorderStyle.None;
                panelPrincipal.Size = new Size(225, 200);

                pbIcono.Dock = DockStyle.Fill;
                pbIcono.Size = new Size(205, 90);
                pbIcono.Image = SisCob.Properties.Resources.esperar;
                pbIcono.SizeMode = PictureBoxSizeMode.Zoom;
                //pbIcono.BackColor = Color.Black;

                lblDescripcion.Text = item["Informacion"].ToString();
                lblDescripcion.AutoSize = false;
                lblDescripcion.Dock = DockStyle.Fill;
                lblDescripcion.TextAlign = ContentAlignment.TopCenter;
                lblDescripcion.Font = new Font("Microsoft Tai Le", 10);
                lblDescripcion.ForeColor = Color.Black;
                lblDescripcion.Visible = true;
                lblDescripcion.BringToFront();

                panelboton.Dock = DockStyle.Bottom;
                panelboton.Size = new Size(205, 39);
                panelboton.BackColor = Color.Transparent;
                panelboton.BorderStyle = BorderStyle.None;
                //panelboton.BackColor = Color.Black;

                btnAceptar.Text = "Aceptar";
                btnAceptar.BackgroundImage = SisCob.Properties.Resources.azul;
                btnAceptar.Dock = DockStyle.Right;
                btnAceptar.FlatStyle = FlatStyle.Flat;
                btnAceptar.FlatAppearance.BorderSize = 0;
                btnAceptar.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
                btnAceptar.Size = new Size(77, 39);
                btnAceptar.BackgroundImageLayout = ImageLayout.Stretch;
                btnAceptar.ForeColor = Color.White;
                btnAceptar.Click += BtnAceptarEspera_Click;
                btnAceptar.Tag = item["Serial"].ToString();

                btnRechazar.Text = "Rechazar";
                btnRechazar.BackgroundImage = Properties.Resources.Rojo;
                btnRechazar.BackgroundImageLayout = ImageLayout.Stretch;
                btnRechazar.Dock = DockStyle.Right;
                btnRechazar.FlatStyle = FlatStyle.Flat;
                btnRechazar.FlatAppearance.BorderSize = 0;
                btnRechazar.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
                btnRechazar.ForeColor = Color.White;
                btnRechazar.Size = new Size(87, 39);
                btnRechazar.Click += BtnRechazar_Click;
                btnRechazar.Tag = item["Serial"].ToString();

                var panelImagen = new Panel();
                panelImagen.Dock = DockStyle.Top;
                panelImagen.BringToFront();
                panelImagen.Size = new Size(100, 115);
                panelImagen.Controls.Add(pbIcono);

                panelboton.Controls.Add(btnRechazar);
                panelboton.Controls.Add(btnAceptar);

                panelPrincipal.Controls.Add(panelImagen);
                panelPrincipal.Controls.Add(panelboton);

            

                panelPrincipal.Controls.Add(lblDescripcion);
                panelPrincipal.Controls.Add(panelImagen);

                flowLayoutPanelEspera.Controls.Add(panelPrincipal);


            }

        }
        private void DibujarDispositivosAceptados()
        {
            //Variables
            flowLayoutPanelConectados.Controls.Clear();
            var dt = new DataTable();
            var clase = new Obtener_datos();

            clase.MostrarDispositivosConectados(ref dt);
            foreach (DataRow item in dt.Rows)
            {
                string name = "";

                var panelPrincipal = new Panel();
                var pbIcono = new PictureBox();
                var lblDescripcion = new Label();
                var panelboton = new Panel();
                var btnAceptar = new Button();
                var btnRechazar = new Button();
                


                panelPrincipal.BackColor = Color.Transparent;
                panelPrincipal.BorderStyle = BorderStyle.None;
                panelPrincipal.Size = new Size(225, 200);

                pbIcono.Dock = DockStyle.Fill;
                pbIcono.Size = new Size(205, 90);
                pbIcono.Image = SisCob.Properties.Resources.conectar;
                pbIcono.SizeMode = PictureBoxSizeMode.Zoom;
               
                panelboton.Dock = DockStyle.Bottom;
                panelboton.Size = new Size(210, 39);
                panelboton.BackColor = Color.Transparent;
                panelboton.BorderStyle = BorderStyle.None;

                btnRechazar.Text = "Desvincular";
                btnRechazar.BackgroundImage = SisCob.Properties.Resources.Rojo;
                btnRechazar.BackgroundImageLayout = ImageLayout.Stretch;
                btnRechazar.Dock = DockStyle.Right;
                btnRechazar.FlatStyle = FlatStyle.Flat;
                btnRechazar.FlatAppearance.BorderSize = 0;
                btnRechazar.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
                btnRechazar.ForeColor = Color.White;
                btnRechazar.Size = new Size(110, 39);
                btnRechazar.Click += BtnRechazar_Click;
                btnRechazar.Tag = item["Serial"].ToString();

                lblDescripcion.Text = item["Informacion"].ToString();
                lblDescripcion.AutoSize = false;
                lblDescripcion.Dock = DockStyle.Fill;
                lblDescripcion.TextAlign = ContentAlignment.TopCenter;
                lblDescripcion.Font = new Font("Microsoft Tai Le", 10);
                lblDescripcion.ForeColor = Color.Black;
                lblDescripcion.Visible = true;
                lblDescripcion.BringToFront();


                var panelImagen = new Panel();
                panelImagen.Dock = DockStyle.Top;
                panelImagen.BringToFront();
                panelImagen.Size = new Size(100, 115);
                panelImagen.Controls.Add(pbIcono);

                panelboton.Controls.Add(btnRechazar);
                panelPrincipal.Controls.Add(panelboton);

                panelPrincipal.Controls.Add(lblDescripcion);
                panelPrincipal.Controls.Add(panelImagen);
                flowLayoutPanelConectados.Controls.Add(panelPrincipal);


            }

        }
        private void BtnRechazar_Click(object sender, EventArgs e)
        {
            string serial = ((Button)sender).Tag.ToString();
            var clase = new Eliminar_datos();
            if (clase.Eliminar_SolicitudConexion(serial) == true)
            {
                DibujarDispositivosAceptados();
                DibujarDispositivosEspera();
            }
        }

        private void BtnAceptarEspera_Click(object sender, EventArgs e)
        {
            string serial = ((Button)sender).Tag.ToString();
            var clase = new Editar_datos();
            if (clase.AceptarSolicitudConexion(serial) == true)
            {
                DibujarDispositivosEspera();
                DibujarDispositivosAceptados();
            }
        }

        private void AdministracionDispositivos_Load(object sender, EventArgs e)
        {
            DibujarDispositivosEspera();
            DibujarDispositivosAceptados();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            DibujarDispositivosEspera();
            DibujarDispositivosAceptados();
        }
    }
}
