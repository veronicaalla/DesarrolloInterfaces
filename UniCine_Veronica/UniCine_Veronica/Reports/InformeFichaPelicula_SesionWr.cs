using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniCine_Veronica.Reports
{
    internal class InformeFichaPelicula_SesionWr
    {
        //Datos de la sesion
        public DateTime Inicio { get; set; }
        public DateTime? Fin { get; set; }
        public string DiaSemana { get; set; }
        public DateTime Comienzo { get; set; }
        public string Sala { get; set; }
        public Single Precio { get; set; }
    }
}
