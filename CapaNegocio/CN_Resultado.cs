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
    public class CN_Resultado
    {
        //============================================================================================
        private CD_Resultado objDatos = new CD_Resultado();

        public bool RegistrarResultado(Resultado obj, out string mensaje)
        {
            if (obj.IdEmprendimiento == 0)
            {
                mensaje = "Seleccione un emprendimiento";
                return false;
            }
            return objDatos.Registrar(obj, out mensaje);
        }

        public DataTable ListarResultados()
        {
            // Devuelve la tabla lista desde SQL para consvertirlo en PDF
            return objDatos.Listar();
        }
    }

}
