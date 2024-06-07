using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisCob.Models
{
    public class MsumaAusentesPresentes
    {
        public DataTable dtAusentes { get; set; }
        public DataTable dtPresentes { get; set; }
        public int TotalPresentes { get; set; }
        public int TotalAusentes { get; set; }
    }
}
