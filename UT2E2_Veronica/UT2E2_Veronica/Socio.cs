using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UT2E2_Veronica
{
    public class Socio
    {
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Sexo { get; set; }
        public string Aficiones { get; set; }
        public string OtrasAficiones { get; set; }
        public string Situación { get; set; }

        public Socio() { }

        public Socio (string nombre, DateTime fechaNacimiento, string sexo, string aficiones, string otrasAficiones, string situación)
        {
            Nombre = nombre;
            FechaNacimiento = fechaNacimiento;
            Sexo = sexo;
            Aficiones = aficiones;
            OtrasAficiones = otrasAficiones;
            Situación = situación;
        }
    }
}
