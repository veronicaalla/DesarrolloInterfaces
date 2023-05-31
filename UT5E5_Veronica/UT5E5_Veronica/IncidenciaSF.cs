using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UT5E5_Veronica
{
    internal class IncidenciaSF : Incidencia
    {
        private string Etiqueta { set; get; }
        private bool Instalacion { set; get; }
        private string Programa { set; get; }
        private bool Reconfiguracion { set; get; }
    }
}
