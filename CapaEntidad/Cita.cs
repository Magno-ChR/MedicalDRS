using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Cita
    {
        public int IdCita { get; set; }
        public int IdPersona { get; set; }
        public int IdMedico { get; set; }
        public string Fecha { get; set; }
        public int NroTicket { get; set; }
        public int IdRecepcion { get; set; }
    }
}
