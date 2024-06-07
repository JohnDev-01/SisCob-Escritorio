using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisCob.Models
{
    public class MreporteAsistencia
    {
        public string Grado { get; set; }
        public int Idasistencia { get; set; }
        public int SumaAsistio { get; set; }
        public int SumaNoAsistio { get; set; }
        public string Fecha { get; set; }
    }
}
