using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using Microsoft.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CD_Votacion
    {
        private CD_Conexion conexion = new CD_Conexion();

        public bool Registrar(Votacion obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            using (SqlConnection ocon = conexion.LeerCadena())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_RegistrarVoto", ocon);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("IdEmprendimiento", obj.IdEmprendimiento);
                    ocon.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex) { Mensaje = ex.Message; return false; }
            }
        }

        public DataTable ContarVotos()
        {
            DataTable tabla = new DataTable();
            using (SqlConnection ocon = conexion.LeerCadena())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_ContarVotaciones", ocon);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(tabla);
                }
                catch { }
            }
            return tabla;
        }
    }
}
