using SisCob.Bases;
using SisCob.Conexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SisCob.Presentation.AsistenteInstalador
{
    public partial class Instalador : Form
    {
        public Instalador()
        {
            InitializeComponent();
        }
        string ruta;
        bool estadoComprobacionExpress;
        string nombre_del_equipo_usuario;
        string NombreDeServicio = "SQLEXPRESS";
        private void Instalador_Load(object sender, EventArgs e)
        {
            Reemplazar();
            AjustarPaneles();
        }
        private void Conectar()
        {
            
            //comprobar_servidor_instalado_SQL_EXPRESS();
            //if (estadoComprobacionExpress == false)
            //{
                comprobar_servidor_instalado_SQL_NORMAL();
            //}


        }
        private void comprobar_servidor_instalado_SQL_EXPRESS()
        {
            txtservidor.Text = @".\" + NombreDeServicio;
            EliminarBaseDatos();
            CrearBaseDatos();
        }

        private void comprobar_servidor_instalado_SQL_NORMAL()
        {
            txtservidor.Text = ".";
            EliminarBaseDatos();
            CrearBaseDatos();
        }
        private void CrearBaseDatos()
        {
            var connection = new SqlConnection("Server=" + txtservidor.Text + "; " + "database=master; integrated security=yes");
            string command = "CREATE DATABASE " + TXTbasededatos.Text;
            var Execute_command = new SqlCommand(command, connection);
            try
            {
                connection.Open();
                Execute_command.ExecuteNonQuery();
                GuardarConexion(ClassBases.Encrypt("Data Source=" + txtservidor.Text + ";Initial Catalog=" + TXTbasededatos.Text + ";Integrated Security=True", ClassBases.ClaveSeguridad, int.Parse("256")));
                ejecutar_scryt_crearProcedimientos_almacenados_y_tablas();
                estadoComprobacionExpress = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ejecuta el sistema en modo administrador ");
                Dispose();
                //Sin Motor de base datos instalado
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }
        private void EliminarBaseDatos()
        {

            SqlConnection conection = new SqlConnection("Data Source=" + txtservidor.Text + ";Initial Catalog=master;Integrated Security=True");
            var consulta = txtEliminarBase.Text;
            SqlCommand command = new SqlCommand(consulta, conection);
            try
            {
                conection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {


            }
            finally
            {
                if ((conection.State == ConnectionState.Open))
                {
                    conection.Close();
                }
            }
        }
        private void Reemplazar()
        {
            txtCrearUsuarioDb.Text = txtCrearUsuarioDb.Text.Replace("ada369", "siscob");
            txtCrearUsuarioDb.Text = txtCrearUsuarioDb.Text.Replace("BASEADA", "SisCob");
            txtCrearUsuarioDb.Text = txtCrearUsuarioDb.Text.Replace("softwarereal", "2121");
            txtCrear_procedimientos.Text = txtCrear_procedimientos.Text + Environment.NewLine + txtCrearUsuarioDb.Text;
        }
        private void AjustarPaneles()
        {
            nombre_del_equipo_usuario = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            pbInstalar.Visible = true;
            pbCargando.Visible = false;
            pbInstalar.Dock = DockStyle.Fill;
            panelInstalar.Location = new Point((Width - panelInstalar.Width) / 2, (Height - panelInstalar.Height) / 2);
        }
        private void btnInstalar_Click(object sender, EventArgs e)
        {
            Reemplazar();
            lblTextoInstalar.Text = "Instalando...";
            pbInstalar.Visible = false;
            pbCargando.Visible = true;
            pbCargando.Dock = DockStyle.Fill;
            Conectar();
        }
      
        private void ejecutar_scryt_crearProcedimientos_almacenados_y_tablas()
        {
            
            var ruta = Path.Combine(Directory.GetCurrentDirectory(), "scriptBaseSisCob" + ".txt");
            FileInfo fi = new FileInfo(ruta);
            StreamWriter sw;

            try
            {
                if (File.Exists(ruta) == false)
                {
                    sw = File.CreateText(ruta);
                    sw.WriteLine(txtCrear_procedimientos.Text);
                    sw.Flush();
                    sw.Close();

                }
                else if (File.Exists(ruta) == true)
                {
                    File.Delete(ruta);
                    sw = File.CreateText(ruta);
                    sw.WriteLine(txtCrear_procedimientos.Text);
                    sw.Flush();
                    sw.Close();
                }
            }
            catch (Exception ex)
            {
            }

            try
            {
                Process Pross = new Process();
                Pross.StartInfo.FileName = "sqlcmd";
                Pross.StartInfo.Arguments = " -S " + txtservidor.Text + " -i " + "scriptBaseSisCob" + ".txt";
                Pross.Start();
                PasarDefinirEmpresa();
            }
            catch (Exception ex)
            {

            }
           
        }
        private void PasarDefinirEmpresa()
        {
            var page = new Views.DefinicionEmpresa();
            this.Hide();
            page.ShowDialog();
        }
        public void GuardarConexion(object dbcnString)
        {
            XmlDocument document = new XmlDocument();
            document.Load("ConnectionString.xml");

            XmlElement Element = document.DocumentElement;
            Element.Attributes[0].Value = Convert.ToString(dbcnString);

            XmlTextWriter writer = new XmlTextWriter("ConnectionString.xml", null);
            writer.Formatting = Formatting.Indented;
            document.Save(writer);
            writer.Close();
        }
        
    }
}
