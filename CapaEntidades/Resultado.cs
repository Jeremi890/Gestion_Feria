using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Resultado
    {
        public int IdResultado { get; set; }
        public int IdEmprendimiento { get; set; }
        public string CategoriaPremio { get; set; }
        public int Posicion { get; set; }

        public string NombreEmprendimiento { get; set; }
        public string Facultad { get; set; }

        public Resultado()
        {
            IdResultado = 0;
            IdEmprendimiento = 0;
            CategoriaPremio = string.Empty;
            Posicion = 0;
            NombreEmprendimiento = string.Empty;
            Facultad = string.Empty;
        }
    }
}
