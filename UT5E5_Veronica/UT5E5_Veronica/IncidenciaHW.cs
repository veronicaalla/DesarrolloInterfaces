using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UT5E5_Veronica
{
    internal class IncidenciaHW:Incidencia
    {
        private TipoHardwareEnum Clase { set; get; }
        private bool Enciende { set; get; }
        private string Etiqueta { set; get; }
    }
}
