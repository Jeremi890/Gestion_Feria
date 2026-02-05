using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Usuario
    {
        private CD_Usuario objDatos = new CD_Usuario();

        public bool ValidarUsuario(string usuario, string clave)
        {
            // Retorna TRUE si el ID es mayor a 0 (login exitoso)
            return objDatos.Login(usuario, clave) != 0;
        }
    }
}
