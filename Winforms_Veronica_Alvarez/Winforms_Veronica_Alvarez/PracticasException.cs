using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winforms_Veronica_Alvarez
{
    internal class PracticasException: ApplicationException

    {
        public PracticasException() : base() { }

        public PracticasException(string message) : base(message) { }

        public PracticasException(string ExceptionMensaje, Exception inner) : base(ExceptionMensaje, inner) { }

    }
}
