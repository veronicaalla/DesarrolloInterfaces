using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UT5E5_Veronica
{
    abstract class Incidencia
    {
        public bool Cerrada { set; get; }
        public string descripcion { set; get; }
        public DateTime Fecha { set; get; }
        public int IncidenciaId { set; get; }
        public string Observaciones { set; get; }
        public TipoIncidenciaEnum Tipo { set; get; }
    }
}
