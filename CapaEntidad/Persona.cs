using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Persona
    {
        public int IdPersona { get; set; }
        public string CedulaIdentidad { get; set; }
        public string Nombres { get; set; }
        public string ApellidoP { get; set; }
        public string ApellidoM { get; set; }
        public string FechaNac { get; set; }
        public string Procedencia { get; set; }
        public string NroCelular { get; set; }
    }
}
