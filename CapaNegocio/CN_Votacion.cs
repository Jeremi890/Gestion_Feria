using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Votacion
    {
        //==============================================================================
        private CD_Votacion objDatos = new CD_Votacion();

        public bool RegistrarVotacion(Votacion obj, out string mensaje)
        {
            return objDatos.Registrar(obj, out mensaje);
        }

        public DataTable ContarVotaciones()
        {
            // Devuelve la tabla lista para la creación de gráfico
            return objDatos.ContarVotos();
        }
    }
}

