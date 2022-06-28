using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDato
{
    public class CD_Persona
    {
        public List<Persona> ListarPersonas()
        {
            List<Persona> Lista = new List<Persona>();
            using (SqlConnection ObjConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {

                    string consulta = "select * from persona";

                    SqlCommand comando = new SqlCommand(consulta, ObjConexion);
                    comando.CommandType = CommandType.Text;

                    ObjConexion.Open();

                    using (SqlDataReader lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            Lista.Add(new Persona()
                            {
                                IdPersona = Convert.ToInt32(lector["IdPersona"]),
                                CedulaIdentidad = lector["CedulaIdentidad"].ToString(),
                                Nombres = lector["Nombres"].ToString(),
                                ApellidoP = lector["ApellidoP"].ToString(),
                                ApellidoM = lector["ApellidoM"].ToString(),
                                FechaNac = lector["FechaNac"].ToString(),
                                NroCelular = lector["NroCelular"].ToString(),
                                Procedencia = lector["Procedencia"].ToString(),
                            });
                        }
                    }

                }
                catch(Exception ex)
                {
                    Lista = new List<Persona>();
                }
            }

            return Lista;

        }
    }
}
