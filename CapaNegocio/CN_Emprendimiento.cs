using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Emprendimiento
    {
        //======================================================================
        private CD_Emprendimiento objDatos = new CD_Emprendimiento();

        public List<Emprendimiento> ListarEmprendimientos()
        {
            // LLAMADO A SQL - DEVOLVER LISTA
            return objDatos.Listar();
        }
        //=======================================================================================
        public bool RegistrarEmprendimiento(Emprendimiento obj, out string mensaje)
        {
            if (string.IsNullOrEmpty(obj.NombreEmprendimiento))
            {
                mensaje = "El nombre del emprendimiento debe ser colocado";
                return false;
            }
            return objDatos.Registrar(obj, out mensaje);
            }
        //=======================================================================================
        public List<Emprendimiento> BuscarEmprendimiento(string busqueda)
        {
            //FILTRADO A TRAVÉS DE DATOS DE SQL
            List<Emprendimiento> lista = objDatos.Listar();

            return lista.Where(e =>
                e.NombreEmprendimiento.ToUpper().Contains(busqueda.ToUpper()) ||
                e.Rubro.ToUpper().Contains(busqueda.ToUpper())
            ).ToList();
        }
    }
}

