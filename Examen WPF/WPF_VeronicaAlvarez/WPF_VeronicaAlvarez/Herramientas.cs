using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPF_VeronicaAlvarez
{
    static class Herramientas
    {
        public static Desarrollador ObtenerDesarrolladorPorCodigo(string codigo)
        {
            Parcial2Context db = new Parcial2Context();
            Desarrollador desarrollador = db.Desarrolladores.FirstOrDefault(x => x.Codigo == codigo);
            if (desarrollador != null)
            {
                return desarrollador;
            }
            return null;

        }

        public static Desarrollador ObtenerDesarrolladorPorId(int idDesarrollador)
        {

            Parcial2Context db = new Parcial2Context();
            Desarrollador desarrollador = db.Desarrolladores.FirstOrDefault(x => x.DesarrolladorId == idDesarrollador);
            if (desarrollador != null)
            {
                return desarrollador;
            }
            return null;
        }
    }
}
