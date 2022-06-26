using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Diagnostico
    {
        public int IdDiagnostico { get; set; }
        public int IdCita { get; set; }
        public string MotivoConsulta { get; set; }
        public string Descripcion { get; set;  }
        public string Tratamiento { get; set; }
    }
}
