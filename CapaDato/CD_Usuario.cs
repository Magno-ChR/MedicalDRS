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
    public class CD_Usuario
    {
        public List<Usuario> ListarUsuarios()
        {
            List<Usuario> Lista = new List<Usuario>();
            using (SqlConnection ObjConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string consulta = "select IdUsuario,Correo,Clave from usuario";

                    SqlCommand comando = new SqlCommand(consulta, ObjConexion);
                    comando.CommandType = CommandType.Text;

                    ObjConexion.Open();

                    using (SqlDataReader lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            Lista.Add(new Usuario() 
                            { 
                                IdUsuario = Convert.ToInt32(lector["IdUsuario"]),
                                Correo = lector["Correo"].ToString(),
                                Clave = lector["Clave"].ToString(),
                            });
                        }
                    }
                }catch(Exception ex)
                {
                    Lista = new List<Usuario>();
                }
            }

            return Lista;
        }
    }
}
