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
    public class CN_Participante
    {
        //==============================================================================================
        private CD_Participante objDatos = new CD_Participante();

        public bool RegistrarParticipante(Participante obj, out string mensaje)
        {
            if (string.IsNullOrWhiteSpace(obj.Nombres))
            {
                mensaje = "Debe colocar al menos un nombre";
                return false;
            }
            return objDatos.Registrar(obj, out mensaje);
        }
        //===========================================================================
        public DataTable ListarParticipantesPorEmprendimiento(int idEmprendimiento)
        {
            return objDatos.ListarPorEmprendimiento(idEmprendimiento);
        }
        //===========================================================================
        public bool EditarParticipante(int id, string nombre, string apellido, string cargo, out string Mensaje)
        {
            return objDatos.EditarParticipante(id, nombre, apellido, cargo, out Mensaje);
        }
    }
}
