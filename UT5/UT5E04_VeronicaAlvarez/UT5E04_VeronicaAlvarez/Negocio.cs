using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UT5E04_VeronicaAlvarez
{
    internal class Negocio
    {

        private int _reservaId;
        private List<Reserva> reservas;

        public Negocio()
        {
            reservas = new List<Reserva>();
        }

        private int SiguienteReservaId()
        {
            return _reservaId++;
        }

        public Reserva[] ObtenerReservas()
        {
            return reservas.ToArray();
        }

        public Reserva ObtenerReserva(int reservaId)
        {
            return reservas.FirstOrDefault(r => r.ReservaId == reservaId);
        }

        public void CrearReserva(Reserva reserva)
        {
            reserva.ReservaId = SiguienteReservaId();
            reservas.Add(reserva);
        }

        public bool BorrarReserva(int reservaId)
        {
            Reserva reserva = reservas.FirstOrDefault(r => r.ReservaId == reservaId);
            if (reserva != null)
            {
                reservas.Remove(reserva);
                return true;
            }
            return false;
        }
    }
}
