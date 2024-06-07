using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisCob.Models
{
    public class Mstudents
    {
        public int IdStudents { get; set; }
        public string NombreStudents { get; set; }
        public string Nombre_padre { get; set; }
        public string Nombre_madre { get; set; }
        public string Numero_contacto { get; set; }
        public string Numero_contacto2 { get; set; }
        public string Direccion { get; set; }
        public DateTime Fecha_nac { get; set; }
        public int idCurso { get; set; }
    }
}
