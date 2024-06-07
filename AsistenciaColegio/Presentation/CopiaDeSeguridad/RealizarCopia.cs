using SisCob.Conexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisCob.Presentation.CopiaDeSeguridad
{
    public partial class RealizarCopia : Form
    {
        public RealizarCopia()
        {
            InitializeComponent();
        }
        string ruta;
        private void pbAbrirRuta_Click(object sender, EventArgs e)
        {
            var folder = new FolderBrowserDialog();
            if (folder.ShowDialog() == DialogResult.OK)
            {
                ruta = folder.SelectedPath;
                txtRuta.Text = ruta;
            }
        }
        private async void GuardarCopiaSeguridad()
        {
            if (!string.IsNullOrEmpty(ruta))
            {
                if (!ruta.Contains("C:\\"))
                { await Task.Run(() => Ejecucion()); }
                else
                {
                    MessageBox.Show("Selecciona un disco diferente a 'C:\\'");
                }



            }
            else
            {
                MessageBox.Show("Selecciona una Ruta donde Guardar las Copias de Seguridad", "Seleccione Ruta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRuta.Focus();

            }
        }
        private void Ejecucion()
        {
            string miCarpeta = "Copias_de_Seguridad_de_SisCob";
            string ruta_completa = txtRuta.Text + miCarpeta;
            string SubCarpeta = ruta_completa + @"\Respaldo_al_" + DateTime.Now.Day + "_" + (DateTime.Now.Month) + "_" + DateTime.Now.Year + "-" + DateTime.Now.ToString("hh") + "_" + DateTime.Now.Minute + "_" + DateTime.Now.Second;

            if (!System.IO.Directory.Exists(ruta_completa))
            {
                System.IO.Directory.CreateDirectory(txtRuta.Text + miCarpeta);
            }
            try
            {
                System.IO.Directory.CreateDirectory(SubCarpeta);

            }
            catch (Exception EX)
            {

            }
            try
            {
                string v_nombre_respaldo = "SisCob.bak";
                ConexionClave.abrir();
                SqlCommand cmd = new SqlCommand("BACKUP DATABASE SisCob TO DISK = '" + SubCarpeta + @"\" + v_nombre_respaldo + "'", ConexionClave.conectar);
                cmd.ExecuteNonQuery();
                ConexionClave.cerrar();

                var message = SubCarpeta + @"\" + v_nombre_respaldo;
                MessageBox.Show("Copia de seguridad guardada correctamente, se guardo en: " + message, "Realizado:", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnRealizar_Click(object sender, EventArgs e)
        {
            GuardarCopiaSeguridad();
        }
    }
}
