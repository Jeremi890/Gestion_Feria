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
    public class CD_Comentario
    {
        private CD_Conexion conexion = new CD_Conexion();

        public bool Registrar(Comentario obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            using (SqlConnection ocon = conexion.LeerCadena())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_RegistrarComentario", ocon);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("Texto", obj.TextoComentario);
                    cmd.Parameters.AddWithValue("IdEmprendimiento", obj.IdEmprendimiento);
                    ocon.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex) { Mensaje = ex.Message; return false; }
            }
        }

        public List<Comentario> Listar(int idEmprendimiento)
        {
            List<Comentario> lista = new List<Comentario>();
            using (SqlConnection ocon = conexion.LeerCadena())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_ListarComentarios", ocon);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("IdEmprendimiento", idEmprendimiento);
                    ocon.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Comentario
                            {
                                TextoComentario = dr["TextoComentario"].ToString(),
                                FechaComentario = Convert.ToDateTime(dr["FechaComentario"])
                            });
                        }
                    }
                }
                catch { }
            }
            return lista;
        }
    }
}
