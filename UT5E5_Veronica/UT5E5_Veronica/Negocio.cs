using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UT5E5_Veronica
{
    internal class Negocio
    {
        private int _incidenciaId;
        private List<Incidencia> incidencias;

        public Negocio() { }

        private int SigIncidenciaId()
        {
            return ++_incidenciaId;
        }

        public void BorrarIncidencia(int incidenciaId)
        {
            Incidencia incidencia = incidencias.FirstOrDefault(r => r.IncidenciaId == incidenciaId);
            if (incidencia != null)
            {
                incidencias.Remove(incidencia);

            }
        }

        public void CrearIndicendiaHW(IncidenciaHW incidenciaHW)
        {
            incidenciaHW.IncidenciaId = SigIncidenciaId();
            incidencias.Add(incidenciaHW);
        }

        public void CrearIncidenciaOtros(IncidenciaOtros incidenciaOtro)
        {
            incidenciaOtro.IncidenciaId = SigIncidenciaId();
            incidencias.Add(incidenciaOtro);
        }

        public void CrearIncidenciaSF(IncidenciaSF incidenciaSF)
        {
            incidenciaSF.IncidenciaId = SigIncidenciaId();
            incidencias.Add(incidenciaSF);
        }

        public Incidencia ObtenerIncidencia(int incidenciaId)
        {
            return incidencias.FirstOrDefault(i => i.IncidenciaId == incidenciaId);
        }

        public Incidencia[] ObtenerIndicencias(TipoIncidenciaEnum tipo, bool? estado = null)
        {
            return
        }

    }
}
