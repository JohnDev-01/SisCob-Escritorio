using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SisCob.Conexion;
using SisCob.Models;

namespace SisCob.Data
{
    public class Eliminar_datos
    {
        public static void Eliminar_usuarios(MUsuarios m)
        {
            
            try
            {
                ConexionClave.abrir();
                var d = new SqlCommand("eliminar_usuario", ConexionClave.conectar);
                d.CommandType = System.Data.CommandType.StoredProcedure;
                d.Parameters.AddWithValue("@idUser", m.Id);
                d.ExecuteNonQuery();
                ConexionClave.cerrar();
                    
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                ConexionClave.cerrar();
            }
        }
        public bool Eliminar_SolicitudConexion(string serial)
        {

            try
            {
                ConexionClave.abrir();
                var d = new SqlCommand("Eliminar_SolicitudConexion", ConexionClave.conectar);
                d.CommandType = System.Data.CommandType.StoredProcedure;
                d.Parameters.AddWithValue("@serial", serial);
                d.ExecuteNonQuery();
                ConexionClave.cerrar();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                ConexionClave.cerrar();
            }
        }
    }
}
