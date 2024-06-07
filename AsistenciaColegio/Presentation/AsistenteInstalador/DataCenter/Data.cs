using SisCob.Conexion;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisCob.Presentation.AsistenteInstalador
{
    public  class Data
    {
        public void InsertarNivelesPredeterminados()
        {
            try
            {
                ConexionClave.abrir();
                var sql = new SqlCommand("InsertarNivelesPorDefectos", ConexionClave.conectar);
                sql.ExecuteNonQuery();
                ConexionClave.cerrar();

            }
            catch (Exception ex)
            {

            }
        }
        public bool InsertarUsuarioAdmin(string pin,MemoryStream ms)
        {
            try
            {
                ConexionClave.abrir();
                var sql = new SqlCommand("InsertarUsuarioAdmin", ConexionClave.conectar);
                sql.CommandType = System.Data.CommandType.StoredProcedure;
                sql.Parameters.AddWithValue("@pin",Bases.ClassBases.Encriptar(pin));
                sql.Parameters.AddWithValue("@icono", ms.GetBuffer());
                sql.ExecuteNonQuery();
                ConexionClave.cerrar();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
