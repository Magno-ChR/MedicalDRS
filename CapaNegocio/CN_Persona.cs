using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDato;
using CapaEntidad;

namespace CapaNegocio
{
    
    public class CN_Persona
    {
        private CD_Persona Objcd_persona = new CD_Persona();
        public List<Persona> Listar()
        {

            return Objcd_persona.ListarPersonas();
        }
    }
}
