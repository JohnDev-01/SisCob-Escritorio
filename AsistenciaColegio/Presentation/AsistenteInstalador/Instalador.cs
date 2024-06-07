using AsistenciaColegio.Bases;
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

namespace AsistenciaColegio.Presentation.AsistenteInstalador
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
        private void Instalador_Load(object sender, EventArgs e)
        {
            AjustarPaneles();
        }
        private void Conectar()
        {
            comprobar_servidor_instalado_SQL_EXPRESS();
            if (estadoComprobacionExpress == false)
            {
                comprobar_servidor_instalado_SQL_NORMAL();
            }
        }
        private void comprobar_servidor_instalado_SQL_EXPRESS()
        {
            txtservidor.Text = @".\" + lblnombredeservicio.Text;
            ejecutar_scryt_ELIMINARBase_comprobacion_de_inicio();
            ejecutar_scryt_crearBase_comprobacion_De_inicio();
        }

        private void comprobar_servidor_instalado_SQL_NORMAL()
        {
            txtservidor.Text = ".";
            ejecutar_scryt_ELIMINARBase_comprobacion_de_inicio();
            ejecutar_scryt_crearBase_comprobacion_De_inicio();
        }
        private void ejecutar_scryt_crearBase_comprobacion_De_inicio()
        {
            var conexion = new SqlConnection("Server=" + txtservidor.Text + "; " + "database=master; integrated security=yes");
            string command = "CREATE DATABASE " + TXTbasededatos.Text;
            var ejecutarConsulta = new SqlCommand(command, conexion);
            try
            {
                conexion.Open();
                ejecutarConsulta.ExecuteNonQuery();
                SavetoXML(ClassBases.Encrypt("Data Source=" + txtservidor.Text + ";Initial Catalog=" + TXTbasededatos.Text + ";Integrated Security=True", ClassBases.ClaveSeguridad, int.Parse("256")));
                ejecutar_scryt_crearProcedimientos_almacenados_y_tablas();
                estadoComprobacionExpress = true;

            }
            catch (Exception ex)
            {
                //Ejecutar creacion de servidor
                estadoComprobacionExpress = false;
                CrearConfiguracion_Ini();
                EjecutarConfiguracionIni();
                ejecutar_scryt_ELIMINARBase();
                ejecutar_scryt_crearBase();
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
        }
        private void ejecutar_scryt_ELIMINARBase_comprobacion_de_inicio()
        {
            string str;
            SqlConnection myConn = new SqlConnection("Data Source=" + txtservidor.Text + ";Initial Catalog=master;Integrated Security=True");
            str = txtEliminarBase.Text;
            SqlCommand myCommand = new SqlCommand(str, myConn);
            try
            {
                myConn.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {


            }
            finally
            {
                if ((myConn.State == ConnectionState.Open))
                {
                    myConn.Close();
                }
            }
        }
        private void Reemplazar()
        {
            //Solo modificar este campo
            txtCrear_procedimientos.Text = txtCrear_procedimientos.Text.Replace("BASEADACURSO", TXTbasededatos.Text);
            //********

            txtEliminarBase.Text = txtEliminarBase.Text.Replace("BASEADACURSO", TXTbasededatos.Text);
            txtCrearUsuarioDb.Text = txtCrearUsuarioDb.Text.Replace("ada369", txtusuario.Text);
            txtCrearUsuarioDb.Text = txtCrearUsuarioDb.Text.Replace("BASEADA", TXTbasededatos.Text);
            txtCrearUsuarioDb.Text = txtCrearUsuarioDb.Text.Replace("softwarereal", lblcontraseña.Text);
            //Adjuntando al texbox que contiene los procedimientos almacenados
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
            lblTextoInstalar.Text = "Instalando...";
            pbInstalar.Visible = false;
            pbCargando.Visible = true;
            pbCargando.Dock = DockStyle.Fill;
            txtArgumentosini.Text = txtArgumentosini.Text.Replace("PRUEBAFINAL22", lblnombredeservicio.Text);

            Conectar();




        }
        private void ejecutar_scryt_ELIMINARBase()
        {
            string str;
            SqlConnection myConn = new SqlConnection("Data Source=" + txtservidor.Text + ";Initial Catalog=master;Integrated Security=True");
            str = txtEliminarBase.Text;
            SqlCommand myCommand = new SqlCommand(str, myConn);
            try
            {
                myConn.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                if ((myConn.State == ConnectionState.Open))
                {
                    myConn.Close();
                }
            }
        }
        private void ejecutar_scryt_crearBase()
        {
            var cnn = new SqlConnection("Server=" + txtservidor.Text + "; " + "database=master; integrated security=yes");
            string s = "CREATE DATABASE " + TXTbasededatos.Text;
            var cmd = new SqlCommand(s, cnn);
            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
                SavetoXML(ClassBases.Encrypt("Data Source=" + txtservidor.Text + ";Initial Catalog=" + TXTbasededatos.Text + ";Integrated Security=True", ClassBases.ClaveSeguridad, int.Parse("256")));
                ejecutar_scryt_crearProcedimientos_almacenados_y_tablas();

            }
            catch (Exception ex)
            {
            }

            finally
            {
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
        }
        private void ejecutar_scryt_crearProcedimientos_almacenados_y_tablas()
        {
            ruta = Path.Combine(Directory.GetCurrentDirectory(), txtnombre_scrypt.Text + ".txt");
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
                Pross.StartInfo.Arguments = " -S " + txtservidor.Text + " -i " + txtnombre_scrypt.Text + ".txt";
                Pross.Start();


                ////////Timer1.Enabled = true;
            }
            catch (Exception ex)
            {
                //acaba = False
            }
        }

        public void SavetoXML(object dbcnString)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("ConnectionString.xml");
            XmlElement root = doc.DocumentElement;
            root.Attributes[0].Value = Convert.ToString(dbcnString);
            XmlTextWriter writer = new XmlTextWriter("ConnectionString.xml", null);
            writer.Formatting = Formatting.Indented;
            doc.Save(writer);
            writer.Close();
        }
        private void CrearConfiguracion_Ini()
        {
            string rutaPREPARAR;
            StreamWriter sw;
            rutaPREPARAR = Path.Combine(Directory.GetCurrentDirectory(), @"SQLEXPR_x86_ESN\ConfigurationFile.ini");

            if (File.Exists(rutaPREPARAR) == true)
            {
                //TimerCRARINI.Stop();
            }

            try
            {
                sw = File.CreateText(rutaPREPARAR);
                sw.WriteLine(txtArgumentosini.Text);
                sw.Flush();
                sw.Close();
            }
            catch (Exception ex)
            {

            }
        }
        private void EjecutarConfiguracionIni()
        {
            try
            {
                Process Pross = new Process();
                Pross.StartInfo.FileName = "SQLEXPR_x86_ESN.exe";
                Pross.StartInfo.Arguments = "/ConfigurationFile=ConfigurationFile.ini /ACTION=Install /IACCEPTSQLSERVERLICENSETERMS /SECURITYMODE=SQL /SAPWD=" + lblcontraseña.Text + " /SQLSYSADMINACCOUNTS=" + nombre_del_equipo_usuario;

                Pross.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                Pross.Start();



            }
            catch (Exception ex)
            {

            }
        }
    }
}
