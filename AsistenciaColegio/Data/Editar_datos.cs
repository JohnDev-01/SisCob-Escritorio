using SisCob.Conexion;
using SisCob.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisCob.Data
{
    public class Editar_datos
    {
        public static bool Editar_Usuarios(MUsuarios mdl)
        {
            try
            {
                ConexionClave.abrir();
                SqlCommand cmd = new SqlCommand("EditarUsuarios", ConexionClave.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@iduser", mdl.Id);
                cmd.Parameters.AddWithValue("@nombre", mdl.Nombre);
                cmd.Parameters.AddWithValue("@usuario", mdl.Usuario);
                cmd.Parameters.AddWithValue("@pin", mdl.Pin);
                cmd.Parameters.AddWithValue("@correo", mdl.Correo);
                cmd.Parameters.AddWithValue("@rol", mdl.Rol);
                cmd.Parameters.AddWithValue("@imagen", mdl.ICONOms.GetBuffer());
                cmd.ExecuteNonQuery();
                ConexionClave.cerrar();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static bool Editar_Cursos(int idGrado , string name,int IdNivel)
        {
            try
            {
                ConexionClave.abrir();
                SqlCommand cmd = new SqlCommand("editar_Cursos", ConexionClave.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdCurso", idGrado);
                cmd.Parameters.AddWithValue("@Nombre_Curso", name);
                cmd.Parameters.AddWithValue("@IdNivel", IdNivel);
                cmd.ExecuteNonQuery();
                ConexionClave.cerrar();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public static bool Editar_Students(Mstudents mdl)
        {
            try
            {
                ConexionClave.abrir();
                SqlCommand cmd = new SqlCommand("editar_Students", ConexionClave.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Estudiante", mdl.IdStudents);
                cmd.Parameters.AddWithValue("@Nombre_Completo", mdl.NombreStudents);
                cmd.Parameters.AddWithValue("@Nombre_padre_tutor", mdl.Nombre_padre);
                cmd.Parameters.AddWithValue("@Nombre_madre", mdl.Nombre_madre);
                cmd.Parameters.AddWithValue("@Numero_Contacto", mdl.Numero_contacto);
                cmd.Parameters.AddWithValue("@Numero_Contacto2", mdl.Numero_contacto2);
                cmd.Parameters.AddWithValue("@Direccion", mdl.Direccion);
                cmd.Parameters.AddWithValue("@Fecha_Nacimiento", mdl.Fecha_nac);
                cmd.Parameters.AddWithValue("@Id_curso", mdl.idCurso);
                cmd.ExecuteNonQuery();
                ConexionClave.cerrar();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool AceptarSolicitudConexion(string serial)
        {
            try
            {
                ConexionClave.abrir();
                SqlCommand cmd = new SqlCommand("AceptarSolicitudConexion", ConexionClave.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@serial", serial);
                cmd.ExecuteNonQuery();
                ConexionClave.cerrar();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static bool MigrarEstudiante(int Idestudiante,int Idgrado)
        {
            try
            {
                ConexionClave.abrir();
                SqlCommand cmd = new SqlCommand("MigrarEstudiante", ConexionClave.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Idgrado", Idgrado);
                cmd.Parameters.AddWithValue("@Idestudiante", Idestudiante);
                cmd.ExecuteNonQuery();
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
