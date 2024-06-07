using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisCob.Presentation.CopiaDeSeguridad
{
    public partial class RestaurarCopia : Form
    {
        public RestaurarCopia()
        {
            InitializeComponent();
        }
        string ruta;
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ruta))
            {
                var result = MessageBox.Show("Estas seguro de querer restaurar la base de datos?", "Confirma:", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    RestaurarBaseDeDatos();
                }
            }
        }
        private void RestaurarBaseDeDatos()
        {
            bool valueRestaure = false;
            SqlConnection cnn = new SqlConnection("Server=.;database=master; integrated security=yes");
            try
            {
                cnn.Open();
                string Proceso = "EXEC msdb.dbo.sp_delete_database_backuphistory @database_name = N'" + "SisCob" +
                    "' USE [master] ALTER DATABASE [" + "SisCob" + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE DROP DATABASE " +
                    "[" + "SisCob" + "] RESTORE DATABASE " + "SisCob" + " FROM DISK = N'" + ruta + "' WITH FILE = 1, NOUNLOAD, REPLACE, STATS = 10";
                SqlCommand BorraRestaura = new SqlCommand(Proceso, cnn);
                BorraRestaura.ExecuteNonQuery();
                valueRestaure = true;
            }
            catch (Exception)
            {
                valueRestaure = false;
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }

            }
            if (valueRestaure == true)
            {
                MessageBox.Show("La base de datos ha sido restaurada satisfactoriamente!", "Restauración de base de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
        }

        private void pbAbrirRuta_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog();
            dlg.InitialDirectory = "";
            dlg.Filter = "Backup SisCob"+"|*.bak";
            dlg.FilterIndex = 2;
            dlg.Title = "Carga tu copia de seguridad";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                ruta = dlg.FileName;
                txtRuta.Text = ruta;
            }
        }
    }
}
