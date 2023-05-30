using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using static System.Collections.Specialized.BitVector32;

// FALTA ORDENAR COLUMNAS 
namespace UT5E4_Veronica
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Negocio negocio;
        private int registros;
        private GridViewColumnHeader columnaOrdenada = null;
        private ListSortDirection sentidoOrden;

        public MainWindow()
        {
            InitializeComponent();
            negocio = new Negocio();
            registros = negocio.ObtenerReservas().Length;

            CargarReservas();
        }
        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (e.WidthChanged)
            {
                colNombre.Width = e.NewSize.Width - 600;
            }
        }

        // ---- BOTONES ---------

        private void btnFiltrar_Click(object sender, RoutedEventArgs e)
        {
            SeleccionarFiltro();
        }

        private void btnNuevaReserva_Click(object sender, RoutedEventArgs e)
        {
            NuevaReserva();
        }



        //------------ MENU CONTEXTUAL --------------

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
            NuevaReserva();
        }

        private void cmsVer_Click(object sender, RoutedEventArgs e)
        {
            VerReserva();
        }

        private void cmsEliminar_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("¿Deseas eliminar la reserva?", "Aviso", MessageBoxButton.YesNoCancel) == MessageBoxResult.Yes)
            {
                negocio.BorrarReserva(((Reserva)lvReservas.SelectedItem).ReservaId);
                registros--;
                CargarReservas();
                ActualizarRegistros();
            }
        }

        private void cmsConfirmar_Click(object sender, RoutedEventArgs e)
        {
            cmsConfirmar.IsChecked = !cmsConfirmar.IsChecked;
            ((Reserva)lvReservas.SelectedItem).Asiste = !cmsConfirmar.IsChecked;
            CargarReservas();
        }

        private void lvReservas_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            VerReserva();
        }

        //ORDENAR COLUMNAS 
        private void ColumnHeader_Click(object sender, RoutedEventArgs e)
        {
            GridViewColumnHeader columnaClick = (sender as GridViewColumnHeader);
            string ordenadoPor = columnaClick.Content.ToString();
            if (columnaOrdenada == null)
            {
                columnaOrdenada = columnaClick;
                sentidoOrden = ListSortDirection.Descending;
            }
            //limpiamos los criterios actuales
            this.lvReservas.Items.SortDescriptions.Clear();
            //cambiamos el sentido de la columna actual
            if (columnaOrdenada == columnaClick)
            {
                if (sentidoOrden == ListSortDirection.Ascending)
                {
                    sentidoOrden = ListSortDirection.Descending;
                }
                else
                {
                    sentidoOrden = ListSortDirection.Ascending;
                }
                lvReservas.Items.SortDescriptions.Add(new
                SortDescription(ordenadoPor, sentidoOrden));
            }
            else
            {
                //Si pulsamos otra columna, desaparece lo anterior 
                columnaOrdenada = null;
            }
        }


        //------ METODOS AUXILIARES -------------
        private void CargarReservas()
        {
            lvReservas.Items.Clear();
            foreach (Reserva r in negocio.ObtenerReservas())
            {
                lvReservas.Items.Add(r);
            }
        }

        private void NuevaReserva()
        {
            Reserva reserva = new Reserva();
            if (new ReservaWindow(reserva).ShowDialog() == true)
            {
                negocio.CrearReserva(reserva);
                registros++;
                CargarReservas();
                //Actualizamos el tapControl
                ActualizarRegistros();
            }
        }


        private void VerReserva()
        {
            Reserva reserva = ((Reserva)lvReservas.SelectedItem);
            if (new ReservaWindow(reserva).ShowDialog().Value)
            {
                CargarReservas();
            }
        }

        private void ActualizarRegistros()
        {
            if (registros == 1)
            {
                tbRegistros.Text = "1 registro";
                return;
            }
            tbRegistros.Text = $"{registros} registros";
        }

        private void txtFiltrado_TextChanged(object sender, TextChangedEventArgs e)
        {
            SeleccionarFiltro();
        }

        private void SeleccionarFiltro()
        {
            CollectionView vista = (CollectionView)CollectionViewSource.GetDefaultView(lvReservas.Items);
            vista.Filter = FiltrarLista;
        }

        private bool FiltrarLista(object item)
        {
            string filtro = txtFiltrado.Text;
            if (string.IsNullOrEmpty(filtro))
            {
                tbFiltro.Text = "Sin filtro";
                return true;
            }
            Reserva reserva = (Reserva)item;
            tbFiltro.Text = $"Filtrado por '{filtro}'";

            return reserva.Nombre.Contains(filtro) || reserva.Fecha.ToShortDateString().Contains(filtro);
        }
    }
}
