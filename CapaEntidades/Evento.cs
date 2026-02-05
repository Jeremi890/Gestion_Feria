using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Evento
    {
        public int IdEvento { get; set; }
        public int IdEmprendimiento { get; set; }
        // ------------------------------------------------------

        public DateTime FechaExposicion { get; set; }
        public TimeSpan HoraExposicion { get; set; }
        public string Ubicacion { get; set; }
        public int Orden { get; set; }

        // Objeto para guardar nombre y facultad
        public Emprendimiento EmprendimientoAsociado { get; set; } = new Emprendimiento();
        //===================================================================================
        public string NombreDelEmprendimiento
        {
            get { return EmprendimientoAsociado.NombreEmprendimiento; }
        }
    }
}

