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
    public class CD_Participante
    {
        private CD_Conexion conexion = new CD_Conexion();
        //==================================================================================
        public bool Registrar(Participante obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            using (SqlConnection ocon = conexion.LeerCadena())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_RegistrarParticipante", ocon);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombres", obj.Nombres);
                    cmd.Parameters.AddWithValue("@Apellidos", obj.Apellidos);
                    cmd.Parameters.AddWithValue("@Cargo", obj.Cargo);
                    cmd.Parameters.AddWithValue("@RutaFoto", obj.RutaFoto ?? "");
                    cmd.Parameters.AddWithValue("@IdEmprendimiento", obj.IdEmprendimiento);
                    ocon.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex) { Mensaje = ex.Message; return false; }
            }
        }
        //==================================================================================
        // Método para EDITAR los cambios hechos en la tabla
        public bool EditarParticipante(int id, string nombre, string apellido, string cargo, out string Mensaje)
        {
            Mensaje = string.Empty;
            using (SqlConnection ocon = conexion.LeerCadena())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_EditarParticipante", ocon);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@IdParticipante", id);
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Apellido", apellido);
                    cmd.Parameters.AddWithValue("@Cargo", cargo);

                    ocon.Open();
                    int filas = cmd.ExecuteNonQuery();
                    return filas > 0;
                }
                catch (Exception ex)
                {
                    Mensaje = ex.Message;
                    return false;
                }
            }
        }
        //==================================================================================
        public DataTable ListarPorEmprendimiento(int idEmprendimiento)
        {
            DataTable tabla = new DataTable();
            using (SqlConnection ocon = conexion.LeerCadena())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_ListarParticipantesPorEmprendimiento", ocon);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdEmprendimiento", idEmprendimiento);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(tabla);
                }
                catch { }
            }
            return tabla;
        }
    }
}
