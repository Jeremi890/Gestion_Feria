using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Votacion
    {
        public int IdVotacion { get; set; }
        public int IdEmprendimiento { get; set; }
        public string ComentarioSugerencia { get; set; }
        public DateTime FechaVotacion { get; set; }

        public string NombreEmprendimiento { get; set; }
        //================================================================================
        public Votacion()
        {
            IdVotacion = 0;
            IdEmprendimiento = 0;
            ComentarioSugerencia = string.Empty;
            FechaVotacion = DateTime.Now;
            NombreEmprendimiento = string.Empty;
        }
    }
}
