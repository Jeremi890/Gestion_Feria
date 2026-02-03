using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Comentario
    {
        public int IdComentario { get; set; }
        public int IdEmprendimiento { get; set; }
        public string TextoComentario { get; set; }
        public DateTime FechaComentario { get; set; }

        public Comentario()
        {
            IdComentario = 0;
            IdEmprendimiento = 0;
            TextoComentario = string.Empty;
            FechaComentario = DateTime.Now;
        }
    }
}
