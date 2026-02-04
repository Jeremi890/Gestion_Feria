using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Participante
    {
        public int IdParticipante { get; set; }
        public int IdEmprendimiento { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Cargo { get; set; }
        public string RutaFoto { get; set; }
        public DateTime FechaRegistro { get; set; }

        public string NombreEmprendimiento { get; set; }
        //================================================================================
        public Participante()
        {
            IdParticipante = 0;
            IdEmprendimiento = 0;
            Nombres = string.Empty;
            Apellidos = string.Empty;
            Cargo = string.Empty;
            RutaFoto = string.Empty;
            FechaRegistro = DateTime.Now;
            NombreEmprendimiento = string.Empty;
        }
        //================================================================================
        public string NombreCompleto
        {
            get { return $"{Nombres} {Apellidos}"; }
        }
    }
}
