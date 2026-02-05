using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class CN_Comentario
    {
        private CD_Comentario objDatos = new CD_Comentario();

        public bool RegistrarComentario(int idEmprendimiento, string texto, out string mensaje)
        {
            mensaje = string.Empty;

            if (string.IsNullOrWhiteSpace(texto))
            {
                mensaje = "El comentario no puede estar vacío";
                return false;
            }

            return objDatos.Registrar(idEmprendimiento, texto, out mensaje);
        }

        public List<string> ListarComentariosPorEmprendimiento(int idEmprendimiento)
        {
            return objDatos.Listar(idEmprendimiento);
        }
    }
}