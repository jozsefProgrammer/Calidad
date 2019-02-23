using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        public string id { get; set; }
        public string Nombre { get; set; }
        public int idPerfil { get; set; }
        public string contrasenna { get; set; }
        public int Estado { get; set; }
    }
}
