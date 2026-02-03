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
    public class CD_Emprendimiento
    {
        private CD_Conexion conexion = new CD_Conexion();
        public List<Emprendimiento> Listar()
        {
            List<Emprendimiento> lista = new List<Emprendimiento>();

            using (SqlConnection ocon = conexion.LeerCadena())
            {
                try
                {
                    // LLAMADO AL PROCEDIMIENTO ALMACENADO POR SQL
                    SqlCommand cmd = new SqlCommand("sp_ListarEmprendimientos", ocon);
                    cmd.CommandType = CommandType.StoredProcedure;
                    ocon.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            // SE CREA UN OBJETO EMPRENDIMIENTO POR CADA FILA DE SQL
                            lista.Add(new Emprendimiento()
                            {
                                IdEmprendimiento = Convert.ToInt32(dr["IdEmprendimiento"]),
                                NombreEmprendimiento = dr["Nombre"].ToString(),
                                Descripcion = dr["Descripcion"].ToString(),
                                Rubro = dr["Rubro"].ToString(),
                                Facultad = dr["Facultad"].ToString(),
                                RutaFoto = dr["RutaFoto"].ToString()
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    // SE RETORNA A UNA LISTA VACIA EN CASO DE ERROR
                    lista = new List<Emprendimiento>();
                    Console.WriteLine(ex.Message);
                }
            }
            return lista;
        }

        // MÉTODO REGISTRAR: Manda los datos a SQL
        public bool Registrar(Emprendimiento obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            using (SqlConnection ocon = conexion.LeerCadena())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_RegistrarEmprendimiento", ocon);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("Nombre", obj.NombreEmprendimiento);
                    cmd.Parameters.AddWithValue("Descripcion", obj.Descripcion);
                    cmd.Parameters.AddWithValue("Rubro", obj.Rubro);
                    cmd.Parameters.AddWithValue("Facultad", obj.Facultad);
                    cmd.Parameters.AddWithValue("RutaFoto", obj.RutaFoto);

                    ocon.Open();
                    int filas = cmd.ExecuteNonQuery();
                    if (filas > 0) respuesta = true;
                }
                catch (Exception ex)
                {
                    respuesta = false;
                    Mensaje = ex.Message;
                }
            }
            return respuesta;
        }
    }
}
