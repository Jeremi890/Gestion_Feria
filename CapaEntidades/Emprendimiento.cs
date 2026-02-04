using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Emprendimiento
    {
        public int IdEmprendimiento { get; set; }
        public string NombreEmprendimiento { get; set; }
        public string Facultad { get; set; }
        public string Rubro { get; set; }
        public string Descripcion { get; set; }
        public string RutaFoto { get; set; }
        public DateTime FechaRegistro { get; set; }
        public bool Estado { get; set; }
        //================================================================================
        public Emprendimiento()
        {
            IdEmprendimiento = 0;
            NombreEmprendimiento = string.Empty;
            Facultad = string.Empty;
            Rubro = string.Empty;
            Descripcion = string.Empty;
            RutaFoto = string.Empty;
            FechaRegistro = DateTime.Now;
            Estado = true;
        }
    }
}

