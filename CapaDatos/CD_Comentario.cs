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

        // 1. GUARDAR (Adaptado a tu SP: @Texto)
        public bool Registrar(int idEmprendimiento, string texto, out string Mensaje)
        {
            Mensaje = string.Empty;
            using (SqlConnection ocon = conexion.LeerCadena())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_RegistrarComentario", ocon);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // IMPORTANTE: Aquí usamos los nombres exactos de TU base de datos
                    cmd.Parameters.AddWithValue("@IdEmprendimiento", idEmprendimiento);
                    cmd.Parameters.AddWithValue("@Texto", texto);

                    ocon.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    Mensaje = ex.Message;
                    return false;
                }
            }
        }

        // 2. LISTAR (Adaptado a tu tabla: columna 'Texto')
        public List<string> Listar(int idEmprendimiento)
        {
            List<string> lista = new List<string>();
            using (SqlConnection ocon = conexion.LeerCadena())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_ListarComentarios", ocon);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdEmprendimiento", idEmprendimiento);

                    ocon.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            // Leemos la columna "Fecha" y "Texto" de tu tabla
                            string fecha = Convert.ToDateTime(dr["Fecha"]).ToString("dd/MM/yy HH:mm");
                            string textoDB = dr["Texto"].ToString();

                            lista.Add($"[{fecha}] Anónimo: {textoDB}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista.Add("Error: " + ex.Message);
                }
            }
            return lista;
        }
    }
}