﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisCob.Models
{
    public class MUsuarios
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Usuario { get; set; }
        public string Pin { get; set; }
        public string Correo { get; set; }
        public string Rol { get; set; }
        public MemoryStream ICONOms { get; set; }

    }
}
