using SisCob.Bases;
using SisCob.Conexion;
using SisCob.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisCob.Data
{
    public class Obtener_datos
    {
        public static void mostrarUsuarios(ref DataTable dt, string letra)
        {
            try
            {
                ConexionClave.abrir();
                SqlDataAdapter da = new SqlDataAdapter("mostrar_Usuarios", ConexionClave.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@letra", letra);
                da.Fill(dt);
                ConexionClave.cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public static void mostrarUsuarioPorId(ref DataTable dt, int IdUser)
        {
            try
            {
                ConexionClave.abrir();
                SqlDataAdapter da = new SqlDataAdapter("MostrarUsuarioPorId", ConexionClave.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@id", IdUser);
                da.Fill(dt);
                ConexionClave.cerrar();
            }
            catch (Exception ex)
            {

            }

        }
        public static void mostrar_Cursos(ref DataTable dt)
        {
            try
            {
                ConexionClave.abrir();
                SqlDataAdapter da = new SqlDataAdapter("mostrar_Cursos", ConexionClave.conectar);
                da.Fill(dt);
                ConexionClave.cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public static void MostrarEmpresa(ref DataTable dt)
        {
            try
            {
                ConexionClave.abrir();
                SqlDataAdapter da = new SqlDataAdapter("MostrarEmpresa", ConexionClave.conectar);
                da.Fill(dt);
                ConexionClave.cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public static void Show_Students(ref DataTable dt, string letra)
        {
            try
            {
                ConexionClave.abrir();
                SqlDataAdapter da = new SqlDataAdapter("mostrar_Students", ConexionClave.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@letra", letra);
                da.Fill(dt);
                ConexionClave.cerrar();
            }
            catch (Exception ex)
            {

            }

        }
        public static void MostrarEstudiantesPorGrado(ref DataTable dt, int Idgrado)
        {
            try
            {
                ConexionClave.abrir();
                SqlDataAdapter da = new SqlDataAdapter("MostrarEstudiantesPorGrado", ConexionClave.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Idgrado", Idgrado);
                da.Fill(dt);
                ConexionClave.cerrar();
            }
            catch (Exception ex)
            {

            }

        }
        public void MostrarInformacionEmpresa(ref DataTable dt)
        {
            try
            {
                ConexionClave.abrir();
                SqlDataAdapter da = new SqlDataAdapter("MostrarInformacionEmpresa", ConexionClave.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dt);
                ConexionClave.cerrar();
            }
            catch (Exception ex)
            {

            }
        }
        public void MostrarConteoGeneral(ref DataTable dt)
        {
            try
            {
                ConexionClave.abrir();
                SqlDataAdapter da = new SqlDataAdapter("MostrarConteoGeneral", ConexionClave.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dt);
                ConexionClave.cerrar();
            }
            catch (Exception ex)
            {

            }
        }
        public void MostrarNiveles(ref DataTable dt)
        {
            try
            {
                ConexionClave.abrir();
                var sql = new SqlDataAdapter("select * from Niveles", ConexionClave.conectar);
                sql.Fill(dt);
                ConexionClave.cerrar();
            }
            catch (Exception ex)
            {

            }
        }
        public void MostrarDispositivosEspera(ref DataTable dt)
        {
            try
            {
                ConexionClave.abrir();
                var sql = new SqlDataAdapter("MostrarDispositivosEspera", ConexionClave.conectar);
                sql.Fill(dt);
                ConexionClave.cerrar();
            }
            catch (Exception ex)
            {

            }
        }
        public void MostrarDispositivosConectados(ref DataTable dt)
        {
            try
            {
                ConexionClave.abrir();
                var sql = new SqlDataAdapter("MostrarDispositivosConectados", ConexionClave.conectar);
                sql.Fill(dt);
                ConexionClave.cerrar();
            }
            catch (Exception ex)
            {

            }
        }
        public static void MostrarEstudiantesPorGrado(int Idgrado, ref DataTable dt)
        {
            try
            {
                ConexionClave.abrir();
                var sql = new SqlDataAdapter("MostrarEstudiantesPorGrado", ConexionClave.conectar);
                sql.SelectCommand.CommandType = CommandType.StoredProcedure;
                sql.SelectCommand.Parameters.AddWithValue("@Idgrado", Idgrado);
                sql.Fill(dt);
                ConexionClave.cerrar();
            }
            catch (Exception ex)
            {

            }
        }
        public static void MostrarInformacionEmpresReporte(ref DataTable dt)
        {
            try
            {
                ConexionClave.abrir();
                var sql = new SqlDataAdapter("Reporte_MostrarInformacionEmpresa", ConexionClave.conectar);
                sql.SelectCommand.CommandType = CommandType.StoredProcedure;
                sql.Fill(dt);
                ConexionClave.cerrar();
            }
            catch (Exception ex)
            {

            }
        }
        public static void SumarEstudiantesPorGrado(ref int Cantidad, int Idgrado)
        {
            try
            {
                ConexionClave.abrir();
                var sql = new SqlCommand("Reporte_SumarEstudiantesGrado", ConexionClave.conectar);
                sql.CommandType = CommandType.StoredProcedure;
                sql.Parameters.AddWithValue("@Idgrado", Idgrado);
                Cantidad = Convert.ToInt32(sql.ExecuteScalar());
                ConexionClave.cerrar();
            }
            catch (Exception ex)
            {
                Cantidad = 0;
            }
        }
        public static void Reporte_MostrarEstudiantesGrado(ref DataTable dt, int Idgrado)
        {
            try
            {
                ConexionClave.abrir();
                var sql = new SqlDataAdapter("Reporte_MostrarEstudiantesGrado", ConexionClave.conectar);
                sql.SelectCommand.CommandType = CommandType.StoredProcedure;
                sql.SelectCommand.Parameters.AddWithValue("@Idgrado", Idgrado);
                sql.Fill(dt);
                ConexionClave.cerrar();
            }
            catch (Exception ex)
            {

            }
        }
        private static void MostrarDatosLicencia(ref DataTable dt)
        {
            try
            {
                ConexionClave.abrir();
                var sql = new SqlDataAdapter("MostrarDatosLicencia", ConexionClave.conectar);
                sql.SelectCommand.CommandType = CommandType.StoredProcedure;
                sql.Fill(dt);
                ConexionClave.cerrar();
            }
            catch (Exception)
            {
                ConexionClave.cerrar();
            }
        }
        private static void ActualizarEstadoLicencia()
        {
            try
            {
                ConexionClave.abrir();
                var sql = new SqlCommand("ActualizarEstadoLicencia", ConexionClave.conectar);
                sql.CommandType = CommandType.StoredProcedure;
                sql.Parameters.AddWithValue("@estado", ClassBases.Encriptar("VENCIDA"));
                sql.ExecuteNonQuery();
                ConexionClave.cerrar();
            }
            catch (Exception)
            {
                ConexionClave.cerrar();
            }
        }
        public static bool ValidarLicencia()
        {
            var dt = new DataTable();
            var models = new Models.Mlicencias();
            bool estadoValidacion = false;
            //Asignacion de valores 
            MostrarDatosLicencia(ref dt);
            foreach (DataRow item in dt.Rows)
            {
                models.Serial = ClassBases.Desencriptar(item["SERIAL"].ToString());
                models.Estado = ClassBases.Desencriptar(item["E"].ToString());
                models.FechaActivacion = ClassBases.Desencriptar(item["FA"].ToString());
                models.FechaFin = ClassBases.Desencriptar(item["FF"].ToString());
            }
            var fechaActivacionDate = Convert.ToDateTime(models.FechaActivacion);
            var fechaVencimientoDate = Convert.ToDateTime(models.FechaFin);

            //Vaidacion ::::

            if (models.Estado == "?ACTIVADO PRO?")
            {
                if (DateTime.Now >= fechaActivacionDate)
                {
                    if (DateTime.Now <= fechaVencimientoDate)
                    {
                        estadoValidacion = true;
                    }
                    else
                    {
                        ActualizarEstadoLicencia();
                        estadoValidacion = false;
                    }
                }
                else
                {
                    ActualizarEstadoLicencia();
                    estadoValidacion = false;
                }
            }
            else
            {
                estadoValidacion = false;
            }

            return estadoValidacion;
        }

        //Reporte de conteo general
        private static void MostrarInformeGeneral(DateTime fecha, ref DataTable dt)
        {
            try
            {
                ConexionClave.abrir();
                var sql = new SqlDataAdapter("MostrarInformeActividad", ConexionClave.conectar);
                sql.SelectCommand.CommandType = CommandType.StoredProcedure;
                sql.SelectCommand.Parameters.AddWithValue("@fi", fecha.ToString("dd/MM/yyyy"));
                sql.Fill(dt);
                ConexionClave.cerrar();
            }
            catch (Exception ex)
            {

            }
        }
        public static ObservableCollection<Minforme> GetInforme(DateTime fecha)
        {
            var dt = new DataTable();
            var listaInforme = new ObservableCollection<Minforme>();
            MostrarInformeGeneral(fecha, ref dt);
            foreach (DataRow item in dt.Rows)
            {
                var modelo = new Minforme();

                modelo = new Minforme()
                {
                    NombrePropiedad = "Inscritos Nivel Inicial:",
                    ValorPropiedad = item["Inscritos Nivel Inicial"].ToString()
                };
                listaInforme.Add(modelo);

                //Cantidad Si Asitieron Asistencia Detallada
                modelo = new Minforme()
                {
                    NombrePropiedad = "Inscritos Nivel Primario:",
                    ValorPropiedad = item["Inscritos Nivel Primario"].ToString()
                };
                listaInforme.Add(modelo);
                //Cantidad No Asistieron Asistencia Detallada
                modelo = new Minforme()
                {
                    NombrePropiedad = "Inscritos Nivel Secundario:",
                    ValorPropiedad = item["Inscritos Nivel Secundario"].ToString()
                };
                listaInforme.Add(modelo);
                //Cantidad De Excusas 
                modelo = new Minforme()
                {
                    NombrePropiedad = "Total Inscritos:",
                    ValorPropiedad = item["Total Inscritos"].ToString()
                };
                listaInforme.Add(modelo);

                modelo = new Minforme()
                {
                    NombrePropiedad = "Presentes Nivel Inicial:",
                    ValorPropiedad = item["Presentes Nivel Inicial"].ToString()
                };
                listaInforme.Add(modelo);

                modelo = new Minforme()
                {
                    NombrePropiedad = "Presentes Nivel Primario:",
                    ValorPropiedad = item["Presentes Nivel Primario"].ToString()
                };
                listaInforme.Add(modelo);

                modelo = new Minforme()
                {
                    NombrePropiedad = "Presentes Nivel Secundario:",
                    ValorPropiedad = item["Presentes Nivel Secundario"].ToString()
                };
                listaInforme.Add(modelo);

                modelo = new Minforme()
                {
                    NombrePropiedad = "Total Presentes:",
                    ValorPropiedad = item["Total Presentes"].ToString()
                };
                listaInforme.Add(modelo);
                modelo = new Minforme()
                {
                    NombrePropiedad = "Ausentes Nivel Inicial:",
                    ValorPropiedad = item["Ausentes Nivel Inicial"].ToString()
                };
                listaInforme.Add(modelo);
                modelo = new Minforme()
                {
                    NombrePropiedad = "Ausentes Nivel Primario:",
                    ValorPropiedad = item["Ausentes Nivel Primario"].ToString()
                };
                listaInforme.Add(modelo);
                modelo = new Minforme()
                {
                    NombrePropiedad = "Ausentes Nivel Secundario:",
                    ValorPropiedad = item["Ausentes Nivel Secundario"].ToString()
                };
                listaInforme.Add(modelo);
                modelo = new Minforme()
                {
                    NombrePropiedad = "Total Ausentes:",
                    ValorPropiedad = item["Total Ausetes"].ToString()
                };
                listaInforme.Add(modelo);

            }
            return listaInforme;
        }
        public static void MostrarReporteConteoNivelInicial(ref DataTable dt, DateTime fi, DateTime ff)
        {
            try
            {
                ConexionClave.abrir();
                SqlDataAdapter da = new SqlDataAdapter("MostrarReporteConteoNivelInicial", ConexionClave.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@fi", fi);
                da.SelectCommand.Parameters.AddWithValue("@ff", ff);
                da.Fill(dt);
                ConexionClave.cerrar();
            }
            catch (Exception ex)
            {

            }

        }
        public static void MostrarReporteConteoNivelPrimaria(ref DataTable dt, DateTime fi, DateTime ff)
        {
            try
            {
                ConexionClave.abrir();
                SqlDataAdapter da = new SqlDataAdapter("MostrarReporteConteoNivelPrimaria", ConexionClave.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@fi", fi);
                da.SelectCommand.Parameters.AddWithValue("@ff", ff);
                da.Fill(dt);
                ConexionClave.cerrar();
            }
            catch (Exception ex)
            {

            }

        }
        public static void MostrarReporteConteoNivelSecundaria(ref DataTable dt, DateTime fi, DateTime ff)
        {
            try
            {
                ConexionClave.abrir();
                SqlDataAdapter da = new SqlDataAdapter("MostrarReporteConteoNivelSecundaria", ConexionClave.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@fi", fi);
                da.SelectCommand.Parameters.AddWithValue("@ff", ff);
                da.Fill(dt);
                ConexionClave.cerrar();
            }
            catch (Exception ex)
            {

            }

        }
        //Reportes de asistencia general 
        public static void ReporteMostrarAsistenciaGeneral(ref DataTable dtReporte,
           ref int Presentes, ref int Ausentes)
        {
            var dtAsistencia = new DataTable();
            dtReporte.Columns.Add("Grado");
            dtReporte.Columns.Add("Presentes");
            dtReporte.Columns.Add("Ausentes");
            dtReporte.Columns.Add("Fecha");

            MostrarAsistencia(ref dtAsistencia);
            foreach (DataRow item in dtAsistencia.Rows)
            {
                var Idasistencia = Convert.ToInt32(item["IdAsistencia"].ToString());
                var Idgrado = Convert.ToInt32(item["Idgrado"].ToString());
                DateTime _Fecha = Convert.ToDateTime(item["Fecha"]);
                var Fecha = _Fecha.ToString("dd/MM/yyyy");
                int CantAsistio = 0;
                int CantNoAsistio = 0;
                string NameGrado = MostrarNombreCursoPorId(Idgrado);
                MostrarDetalleSiAsistio(Idasistencia, ref CantAsistio);
                MostrarDetalleNoAsistio(Idasistencia, ref CantNoAsistio);
                Ausentes = Ausentes + CantNoAsistio;
                Presentes = Presentes + CantAsistio;
                var models = new MreporteAsistencia()
                {
                    Idasistencia = Idasistencia,
                    Fecha = Fecha,
                    Grado = NameGrado,
                    SumaAsistio = CantAsistio,
                    SumaNoAsistio = CantNoAsistio
                };
                ProcesarDatosAsistencia(ref dtReporte, models);
            }

        }
        private static string MostrarNombreCursoPorId(int Idgrado)
        {
            string Name = "";
            try
            {
                ConexionClave.abrir();
                var sqlcommand = new SqlCommand("mostrar_Curso_por_id", ConexionClave.conectar);
                sqlcommand.CommandType = CommandType.StoredProcedure;
                sqlcommand.Parameters.AddWithValue("@id", Idgrado);
                Name = sqlcommand.ExecuteScalar().ToString();

                ConexionClave.cerrar();
            }
            catch (Exception ex)
            {

            }
            return Name;
        }
        private static void ProcesarDatosAsistencia(ref DataTable dt, MreporteAsistencia models)
        {
            DataRow rows = dt.NewRow();
            rows["Grado"] = models.Grado;
            rows["Presentes"] = models.SumaAsistio;
            rows["Ausentes"] = models.SumaNoAsistio;
            rows["Fecha"] = models.Fecha;
            dt.Rows.Add(rows);
        }
        private static void MostrarAsistencia(ref DataTable dt)
        {
            try
            {
                ConexionClave.abrir();
                var sql = new SqlDataAdapter("MostrarTodasAsistencias", ConexionClave.conectar);
                sql.SelectCommand.CommandType = CommandType.StoredProcedure;
                sql.Fill(dt);
                ConexionClave.cerrar();
            }
            catch (Exception ex)
            {

            }
        } 
        private static void MostrarAsistenciaFecha(ref DataTable dt,DateTime fi, DateTime ff)
        {
            try
            {
                ConexionClave.abrir();
                var sql = new SqlDataAdapter("MostrarTodasAsistenciasFecha", ConexionClave.conectar);
                sql.SelectCommand.CommandType = CommandType.StoredProcedure;
                sql.SelectCommand.Parameters.AddWithValue("@fi", fi.ToString("dd/MM/yyyy"));
                sql.SelectCommand.Parameters.AddWithValue("@ff", ff.ToString("dd/MM/yyyy"));
                sql.Fill(dt);
                ConexionClave.cerrar();
            }
            catch (Exception ex)
            {

            }
        }
        private static void MostrarDetalleNoAsistio(int Idasistencia, ref int value)
        {
            try
            {
                ConexionClave.abrir();
                var sql = new SqlCommand("MostrarDetalleNoAsistio", ConexionClave.conectar);
                sql.CommandType = CommandType.StoredProcedure;
                sql.Parameters.AddWithValue("@Idasistencia", Idasistencia);
                value = Convert.ToInt32(sql.ExecuteScalar());
                ConexionClave.cerrar();

            }
            catch (Exception ex)
            {

            }
        }
        private static void MostrarDetalleSiAsistio(int Idasistencia, ref int value)
        {
            try
            {
                ConexionClave.abrir();
                var sql = new SqlCommand("MostrarDetalleSiAsistio", ConexionClave.conectar);
                sql.CommandType = CommandType.StoredProcedure;
                sql.Parameters.AddWithValue("@Idasistencia", Idasistencia);
                value = Convert.ToInt32(sql.ExecuteScalar());
                ConexionClave.cerrar();
            }
            catch (Exception ex)
            {

            }
        }

        public static void ReporteMostrarAsistenciaGeneralFecha(ref DataTable dtReporte, 
           ref int Presentes,ref int Ausentes, DateTime fi, DateTime ff)
        {
            var dtAsistencia = new DataTable();
            dtReporte.Columns.Add("Grado");
            dtReporte.Columns.Add("Presentes");
            dtReporte.Columns.Add("Ausentes");
            dtReporte.Columns.Add("Fecha");

            MostrarAsistenciaFecha(ref dtAsistencia,fi,ff);

            
            foreach (DataRow item in dtAsistencia.Rows)
            {
                var Idasistencia = Convert.ToInt32(item["IdAsistencia"].ToString());
                var Idgrado = Convert.ToInt32(item["Idgrado"].ToString());
                DateTime fecha_ = Convert.ToDateTime(item["Fecha"]);
                var Fecha = fecha_.ToString("dd/MM/yyyy");
                int CantAsistio = 0;
                int CantNoAsistio = 0;
                string NameGrado = MostrarNombreCursoPorId(Idgrado);
                MostrarDetalleSiAsistio(Idasistencia, ref CantAsistio);
                MostrarDetalleNoAsistio(Idasistencia, ref CantNoAsistio);

                Ausentes = Ausentes + CantNoAsistio;
                Presentes = Presentes + CantAsistio;

                var models = new MreporteAsistencia()
                {
                    Idasistencia = Idasistencia,
                    Fecha = Fecha,
                    Grado = NameGrado,
                    SumaAsistio = CantAsistio,
                    SumaNoAsistio = CantNoAsistio
                };
                ProcesarDatosAsistencia(ref dtReporte, models);
            }
        }
        public static int MostrarIdAsistenciaFechaGrado(int Idgrado, DateTime fecha)
        {
            int number = 0;
            try
            {
                ConexionClave.abrir();
                var sql = new SqlCommand("MostrarIdAsistenciaFechaGrado", ConexionClave.conectar);
                sql.CommandType = CommandType.StoredProcedure;
                sql.Parameters.AddWithValue("@Idgrado", Idgrado);
                sql.Parameters.AddWithValue("@fecha", fecha.ToString("dd/MM/yyyy"));
                number =  Convert.ToInt32(sql.ExecuteScalar());
                ConexionClave.cerrar();
            }
            catch (Exception ex)
            {
                number =  0;
            }
            return number;
        }
        public static void ReporteAsistenciaEstudianteAusentes(int Idasistencia,ref DataTable dtAusentes)
        {
            try
            {
                ConexionClave.abrir();
                var sql = new SqlDataAdapter("ReporteAsistenciaEstudianteAusentes", ConexionClave.conectar);
                sql.SelectCommand.CommandType = CommandType.StoredProcedure;
                sql.SelectCommand.Parameters.AddWithValue("@Idasistencia", Idasistencia);
                sql.Fill(dtAusentes);
                ConexionClave.cerrar();
            }
            catch (Exception ex)
            {

            }
        }
        public static void ReporteAsistenciaEstudiantePresentes(int Idasistencia, ref DataTable dtPresentes)
        {
            try
            {
                ConexionClave.abrir();
                var sql = new SqlDataAdapter("ReporteAsistenciaEstudiantePresente", ConexionClave.conectar);
                sql.SelectCommand.CommandType = CommandType.StoredProcedure;
                sql.SelectCommand.Parameters.AddWithValue("@Idasistencia", Idasistencia);
                sql.Fill(dtPresentes);
                ConexionClave.cerrar();
            }
            catch (Exception ex)
            {

            }
        }
        //Indentificar conexion base de datos 
        public static bool IndetificarExisteBaseDatos()
        {
            
            try
            {
                ConexionClave.abrir();
                var sql = new SqlCommand("IndetificarExisteBaseDatos", ConexionClave.conectar);
                sql.CommandType = CommandType.StoredProcedure;
                int Cantidad = Convert.ToInt32(sql.ExecuteScalar());
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
