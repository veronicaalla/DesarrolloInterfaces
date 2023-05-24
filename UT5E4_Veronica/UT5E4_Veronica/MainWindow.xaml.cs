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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UT5E4_Veronica
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Negocio negocio;
        public MainWindow()
        {
            InitializeComponent();
            negocio = new Negocio();
            CargarReservas();
        }

        private void btnFiltrar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnNuevaReserva_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {

        }

        private void lvReservas_ContextMenuOpening(object sender, ContextMenuEventArgs e)
        {
            cmsVer.IsEnabled = false;
            cmsEliminar.IsEnabled = false;
            cmsConfirmar.IsEnabled = false;

            if (lvReservas.SelectedItem != null)
            {
                cmsVer.IsEnabled = true;
                cmsEliminar.IsEnabled = true;
                cmsConfirmar.IsEnabled = true;
                cmsConfirmar.IsChecked = ((Reserva)lvReservas.SelectedItem).Asiste;
            }
        }

     

        private void cmsNueva_Click(object sender, RoutedEventArgs e)
        {

        }

        private void cmsVer_Click(object sender, RoutedEventArgs e)
        {
            if (new ReservaWindow((Reserva)lvReservas.SelectedItem).ShowDialog().Value)
            {
                CargarReservas();
            }
        }

        private void cmsEliminar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void cmsConfirmar_Click(object sender, RoutedEventArgs e)
        {

        }

 

        private void ColumnHeader_Click(object sender, RoutedEventArgs e)
        {

        }


        private void CargarReservas()
        {
            lvReservas.Items.Clear();
            foreach (Reserva r in negocio.ObtenerReservas())
            {
                lvReservas.Items.Add(r);
            }
        }

    }
}
