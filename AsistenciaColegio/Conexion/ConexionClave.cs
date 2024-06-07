using SisCob.Bases;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SisCob.Conexion
{
    public  class ConexionClave
    {
        //private static string cadCN = "server = localhost; DataBase = SisCob; Integrated Security = true";
        public static string conexion = Convert.ToString(ObtenerCadenaConexion());
        public static SqlConnection conectar = new SqlConnection(conexion);

        public static void abrir()
        {
            if (conectar.State == System.Data.ConnectionState.Closed)
                conectar.Open();
        }
        public static void cerrar()
        {
            if (conectar.State == System.Data.ConnectionState.Open)
                conectar.Close();
        }
        public static object ObtenerCadenaConexion()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("ConnectionString.xml");
            XmlElement root = doc.DocumentElement;
            var valueElement = root.Attributes[0].Value;
            var conection = (ClassBases.Decrypt(valueElement, ClassBases.ClaveSeguridad, int.Parse("256")));
            return conection;

        }
    }
}
