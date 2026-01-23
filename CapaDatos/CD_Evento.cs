using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using System.Data;
using Microsoft.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Evento
    {
        private CD_Conexion conexion = new CD_Conexion();

        public List<Evento> Listar()
        {
            List<Evento> lista = new List<Evento>();

            using (SqlConnection ocon = conexion.LeerCadena())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_ListarEventos", ocon);
                    cmd.CommandType = CommandType.StoredProcedure;
                    ocon.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Evento obj = new Evento();
                            obj.IdEvento = Convert.ToInt32(dr["IdEvento"]);
                            if (dr["FechaExposicion"] != DBNull.Value)
                                obj.FechaExposicion = Convert.ToDateTime(dr["FechaExposicion"]);

                            if (dr["HoraExposicion"] != DBNull.Value)
                            {
                                obj.HoraExposicion = (TimeSpan)dr["HoraExposicion"];
                            }
                            obj.IdEmprendimiento = Convert.ToInt32(dr["IdEmprendimiento"]);
                            obj.Ubicacion = dr["Ubicacion"].ToString();
                            obj.Orden = Convert.ToInt32(dr["Orden"]);
                            // DATOS CRUZADOS
                            obj.EmprendimientoAsociado = new Emprendimiento();
                            obj.EmprendimientoAsociado.IdEmprendimiento = Convert.ToInt32(dr["IdEmprendimiento"]);
                            obj.EmprendimientoAsociado.NombreEmprendimiento = dr["Nombre"].ToString();
                            obj.EmprendimientoAsociado.Facultad = dr["Facultad"].ToString();

                            lista.Add(obj);
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Evento>();
                }
            }
            return lista;
        }

        public bool Registrar(Evento obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            using (SqlConnection ocon = conexion.LeerCadena())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_RegistrarEvento", ocon);
                    cmd.Parameters.AddWithValue("IdEmprendimiento", obj.IdEmprendimiento);
                    cmd.Parameters.AddWithValue("FechaExposicion", obj.FechaExposicion);
                    cmd.Parameters.AddWithValue("HoraExposicion", obj.HoraExposicion);
                    cmd.Parameters.AddWithValue("Ubicacion", obj.Ubicacion);
                    cmd.Parameters.AddWithValue("Orden", obj.Orden);
                    cmd.CommandType = CommandType.StoredProcedure;

                    ocon.Open();
                    if (cmd.ExecuteNonQuery() > 0) respuesta = true;
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
