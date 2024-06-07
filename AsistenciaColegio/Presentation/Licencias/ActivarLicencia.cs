using SisCob.Bases;
using SisCob.Data;
using SisCob.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SisCob.Presentation.Licencias
{
    public partial class ActivarLicencia : Form
    {
        public ActivarLicencia()
        {
            InitializeComponent();
        }
        private string Ruta;
        private string Serial;
        private string cadenaConexion;
        string fechaFinLicencia;
        string serialpc;
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Serial);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ActivarLicencia_Load(object sender, EventArgs e)
        {

            ClassBases.Obtener_serialPc(ref Serial);
            txtSerial.Text = Serial;
        }
        private void DescifrarTextoLicencia()
        {
            try
            {
                var xml = new XmlDocument();
                xml.Load(Ruta);
                XmlElement element = xml.DocumentElement;
                var cadenaCifrada = element.Attributes.Item(0).Value;
                cadenaConexion = ClassBases.Decrypt(cadenaCifrada, ClassBases.ClaveSeguridad, int.Parse("256"));

            }
            catch (Exception ex)
            {

            }

        }
        private void btnActivar_Click(object sender, EventArgs e)
        {
            var open = new OpenFileDialog();
            open.Title = "Busca el archivo de licencia";
            open.Filter = "Licencias SisCob|*.xml";
            if (open.ShowDialog() == DialogResult.OK)
            {
                Ruta = open.FileName;
                DescifrarTextoLicencia();
                string cadena = cadenaConexion;
                string[] separadas = cadena.Split('|');
                serialpc = separadas[1];
                fechaFinLicencia = separadas[2];
                var estadoLicencia = separadas[3];
                var NombreSoftware = separadas[4];
                if (NombreSoftware == "SisCob")
                {
                    if (estadoLicencia == "PENDIENTE")
                    {
                        ActivarLicenciaCorrecto();
                    }
                }
            }
        }
        private void ActivarLicenciaCorrecto()
        {
            ClassBases.Obtener_serialPc(ref Serial);
            string fechaFin = ClassBases.Encriptar(fechaFinLicencia);
            string estado = ClassBases.Encriptar("?ACTIVADO PRO?");
            string fechaActivacion = ClassBases.Encriptar(DateTime.Now.ToString("dd/MM/yyyy"));
            ///Definicion de modelos e insercion de datos
            var models = new Mlicencias();
            models.Estado = estado;
            models.FechaActivacion = fechaActivacion;
            models.FechaFin = fechaFin;
            models.Serial = Serial;
            if (Insertar_datos.InsertarLicencias(models) == true)
            {
                MessageBox.Show("Licencia activada, se cerrara el sistema para un nuevo Inicio");
                Application.Exit();
            }
        }
    }
}
