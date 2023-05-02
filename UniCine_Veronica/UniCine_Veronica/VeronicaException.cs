using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniCine_Veronica
{
    public class VeronicaException : ApplicationException
    {
        public VeronicaException():base() { }

        public  VeronicaException(string message) : base(message) { }
        
        public VeronicaException(string ExceptionMensaje, Exception inner) : base(ExceptionMensaje, inner) { }
    }
}
