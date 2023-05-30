using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UT5E4_Veronica
{
    public class Negocio
    {

        private int _reservaId;
        private List<Reserva> reservas;

        //Métodos 
        public Negocio()
        {
            reservas = new List<Reserva>();
        }

        private int SiguienteReservaId()
        {
            //++_reservaId -> suma y despues devuelve resultado
            //_reservaId++ -> devuelve el resultado y despues suma
            return ++_reservaId;
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
