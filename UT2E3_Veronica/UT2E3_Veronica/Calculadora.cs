using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UT2E3_Veronica
{
    public class Calculadora
    {
        //Almacena el primer operador
        private float _cache;
        //Almacena el segundo operador
        private float _visor;
        //Almacena el tipo de operación
        private OperacionesEnun _operacion;

        public float Memoria { get; set; }

        //Propiedad de respaldo de  _operacion
        public OperacionesEnun Operacion
        {
            get { return _operacion; }
            set
            {
                if (value != OperacionesEnun.SinOperacion)
                {
                    Calcular();
                }
                _cache = _visor;
                _operacion = value;
            }
        }

        //Propiedad de respaldo de _visor
        public float Visor
        {
            get { return _visor; }
            set { _visor = value; }
        }

        //Método que no devuelve nada
        public void Calcular()
        {
            switch (Operacion)
            {
                case OperacionesEnun.Suma:
                    { _visor = _cache + _visor; }
                    break;

                case OperacionesEnun.Resta:
                    { _visor = _cache - _visor; }
                    break;

                case OperacionesEnun.Multiplicacion:
                    { _visor = _cache * _visor; }
                    break;

                case OperacionesEnun.Disvision:
                    {
                        if (_visor != 0)
                        {
                            _visor = _cache / _visor;
                        }
                        else
                        {
                            MessageBox.Show("No se puede dividir entre 0");
                        }

                    }
                    break;
                case OperacionesEnun.SinOperacion: return;

            }
            _operacion = OperacionesEnun.SinOperacion;
        }

        public void Borrar()
        {
            _cache = 0;
            _operacion = OperacionesEnun.SinOperacion;
        }
    }
}
