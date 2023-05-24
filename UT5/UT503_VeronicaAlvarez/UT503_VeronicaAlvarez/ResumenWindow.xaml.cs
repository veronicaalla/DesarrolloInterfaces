using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace UT503_VeronicaAlvarez
{
    /// <summary>
    /// Lógica de interacción para ResumenWindow.xaml
    /// </summary>
    public partial class ResumenWindow : Window
    {
        private int i = 1;
        public ResumenWindow()
        {
            InitializeComponent();
        }

        public ResumenWindow(Evento evento) : this()
        {
            txtNombre.Text = evento.Nombre;
            dtpFecha.Text = evento.Fecha.ToShortDateString();
            txtHora.Text = evento.Hora.ToShortTimeString();
            txtAforo.Text = evento.Aforo.ToString();
            txtPromotor.Text = evento.Promotor;

            switch (evento.Tipo)
            {
                case TipoEventoEnum.MENORES_DIEZ:
                    txtTipo.Text = "Menores de 10 años.";
                    break;
                case TipoEventoEnum.MAYORES_DIECISEIS:
                    txtTipo.Text = "Mayores de 16 años.";
                    break;
                case TipoEventoEnum.MAYORES_DIECIOCHO:
                    txtTipo.Text = "Mayores de 18 años.";
                    break;
                default:
                    txtTipo.Text = "Todas las edades.";
                    break;
            }
            txtDescrpción.Text = evento.Descripcion;
            if (evento.Seguridad)
            {
                NuevaLinea("Seguridad");
            }
            if (evento.Montaje)
            {
                NuevaLinea("Montaje");
            }
            if (evento.Bar)
            {
                NuevaLinea("Bar");
            }
            if (evento.Sanitarios)
            {
                NuevaLinea("Sanitarios");
            }
        }

        private void NuevaLinea(string nombre)
        {
            Run linea = new Run(nombre);
            linea.Background = i % 2 == 0 ? Brushes.Aqua : Brushes.LightGreen;
            tbRequisitos.Inlines.Add(linea);
            tbRequisitos.Inlines.Add(new LineBreak());
            i++;
        }

        private void AcceptButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            this.Close();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            this.Close();
        }
    }
}
