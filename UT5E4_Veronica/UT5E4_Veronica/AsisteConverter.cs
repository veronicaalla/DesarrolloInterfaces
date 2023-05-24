using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace UT5E4_Veronica
{
    //Nos realiza las conversiones de manera inmediata sin necesidad de andar con
    //métodos auxiliares en la propia clase
    internal class AsisteConverter : IValueConverter

    {
        private string ReservaAtendida = "Presente";
        private string ReservaNoAtendida = "No";

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch (value)
            {
                case true: return ReservaAtendida;

                case false: return ReservaNoAtendida;

            }
            return ReservaNoAtendida;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string)
            {
                switch (value)
                {
                    case "Presente": return true;
                    case "No": return false;
                }
            }
            return false;
        }

    }
}
