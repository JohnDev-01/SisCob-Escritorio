using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SisCob.Models;
using SisCob.Conexion;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace SisCob.Data
{
    public class Insertar_datos
    {
        public static bool Insertar_Usuarios(MUsuarios mdl)
        {
            try
            {
                ConexionClave.abrir();
                SqlCommand cmd = new SqlCommand("InsertarUsuarios", ConexionClave.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
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
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public static bool Insertar_Students(Mstudents s)
        {
            try
            {
                ConexionClave.abrir();
                SqlCommand cmd = new SqlCommand("insertar_Students", ConexionClave.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre_Completo", s.NombreStudents);
                cmd.Parameters.AddWithValue("@Nombre_padre_tutor", s.Nombre_padre);
                cmd.Parameters.AddWithValue("@Nombre_madre", s.Nombre_madre);
                cmd.Parameters.AddWithValue("@Numero_Contacto", s.Numero_contacto);
                cmd.Parameters.AddWithValue("@Numero_Contacto2", s.Numero_contacto2);
                cmd.Parameters.AddWithValue("@Direccion", s.Direccion);
                cmd.Parameters.AddWithValue("@Fecha_Nacimiento", s.Fecha_nac);
                cmd.Parameters.AddWithValue("@Id_curso", s.idCurso);
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
        public static bool Insertar_Cursos(string Nombre_Curso, int IdNivel)
        {
            try
            {
                ConexionClave.abrir();
                SqlCommand cmd = new SqlCommand("insertar_Cursos", ConexionClave.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre_Curso", Nombre_Curso);
                cmd.Parameters.AddWithValue("@IdNivel", IdNivel);
                cmd.ExecuteNonQuery();
                ConexionClave.cerrar();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static bool Insertar_Empresa(Mempresa models)
        {

            try
            {
                ConexionClave.abrir();
                var sql = new SqlCommand("InsertarEmpresaInstalacion", ConexionClave.conectar);
                sql.CommandType = CommandType.StoredProcedure;
                sql.Parameters.AddWithValue("@nombre", models.Nombre);
                sql.Parameters.AddWithValue("@lema", models.Lema);
                sql.Parameters.AddWithValue("@direccion", models.Direccion);
                sql.Parameters.AddWithValue("@telefono", models.Telefono);
                sql.ExecuteNonQuery();
                ConexionClave.cerrar();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }
        public static bool InsertarLicencias(Mlicencias models)
        {

            try
            {
                ConexionClave.abrir();
                var sql = new SqlCommand("EditarActivacion", ConexionClave.conectar);
                sql.CommandType = CommandType.StoredProcedure;
                sql.Parameters.AddWithValue("@e", models.Estado);
                sql.Parameters.AddWithValue("@fa", models.FechaActivacion);
                sql.Parameters.AddWithValue("@ff", models.FechaFin);
                sql.Parameters.AddWithValue("@s", models.Serial);
                sql.ExecuteNonQuery();
                ConexionClave.cerrar();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ";", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }
        public bool Insertar_Nivel(string Nombre_Nivel)
        {
            bool estadoGuardado = false;
            try
            {
                ConexionClave.abrir();
                var sql = new SqlCommand("InsertarNiveles", ConexionClave.conectar);
                sql.CommandType = CommandType.StoredProcedure;
                sql.Parameters.AddWithValue("@Nombre", Nombre_Nivel);
                sql.ExecuteNonQuery();
                estadoGuardado = true;
                ConexionClave.cerrar();
            }
            catch (Exception ex)
            {
                estadoGuardado = false;
                MessageBox.Show(ex.Message, "Registro existente", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return estadoGuardado;
        }
    }
}
