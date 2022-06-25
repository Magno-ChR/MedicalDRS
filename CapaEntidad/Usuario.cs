using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    class Usuario
    {
        public int IdUsuario { get; set; }
        public int IdPersona { get; set; }
        public int CodPermisos { get; set; }
        public string Correo { get; set; }
        public string Clave { get; set; }
    }
}
