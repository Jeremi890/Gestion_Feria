using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Usuario
    {
        private CD_Conexion conexion = new CD_Conexion();

        public int Login(string usuario, string clave)
        {
            int idUsuario = 0; // 0 significa "No encontrado"

            using (SqlConnection ocon = conexion.LeerCadena())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_ValidarUsuario", ocon);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Usuario", usuario);
                    cmd.Parameters.AddWithValue("@Clave", clave);

                    ocon.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            // Si lee una fila, es que el usuario existe
                            idUsuario = Convert.ToInt32(dr["IdUsuario"]);
                        }
                    }
                }
                catch (Exception)
                {
                    idUsuario = 0;
                }
            }
            return idUsuario;
        }
    }
}