using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Evento
    {
        //==========================================================================================
        private CD_Evento objDatos = new CD_Evento();

        public List<Evento> ListarEventos()
        {
            return objDatos.Listar();
        }

        public bool RegistrarEvento(Evento obj, out string mensaje)
        {
            mensaje = string.Empty;
            if (obj.IdEmprendimiento == 0)
            {
                mensaje = "Seleccione un emprendimiento válido.";
                return false;
            }
            return objDatos.Registrar(obj, out mensaje);
        }
    }
}
