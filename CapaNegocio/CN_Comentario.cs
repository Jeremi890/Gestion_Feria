using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Comentario
    {
        private CD_Comentario objDatos = new CD_Comentario();

        public bool RegistrarComentario(Comentario obj, out string mensaje)
        {
            if (string.IsNullOrWhiteSpace(obj.TextoComentario))
            {
                mensaje = "El comentario no puede estar vacío";
                return false;
            }
            return objDatos.Registrar(obj, out mensaje);
        }

        public List<Comentario> ListarComentariosPorEmprendimiento(int idEmprendimiento)
        {
            return objDatos.Listar(idEmprendimiento);
        }
    }
}
