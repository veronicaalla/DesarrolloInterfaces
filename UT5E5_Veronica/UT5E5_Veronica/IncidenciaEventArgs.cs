using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace UT5E5_Veronica
{
    internal class IncidenciaEventArgs : EventArgs
    {
        private object _dato;

        private object Dato { get; }

        private IncidenciaEventArgs(Incidencia incidencia)
        {

        }

    }
}
