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

namespace UT5E04_VeronicaAlvarez
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Negocio negocio;
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

        private void btnNueva_Click(object sender, RoutedEventArgs e)
        {
            Reserva reserva = new Reserva();
           if (new ReservaWindow(reserva).ShowDialog() == true)
            {
                negocio.CrearReserva(reserva);
                registros++;
                CargarReservas();
                ActualizarRegistros();
            }
        }
        private void Ctm_Opening(object sender, ContextMenuEventArgs e)
        {
            cmiVer.IsEnabled = false;
            cmiEliminar.IsEnabled = false;
            cmiConfirmar.IsEnabled = false;

            if (lvwReservas.SelectedItem != null)
            {
                cmiVer.IsEnabled = true;
                cmiEliminar.IsEnabled = true;
                cmiConfirmar.IsEnabled = true;
                cmiConfirmar.IsChecked = ((Reserva)lvwReservas.SelectedItem).Asiste;
            }
        }

        private void CargarReservas()
        {
            lvwReservas.Items.Clear();
            foreach (Reserva r in negocio.ObtenerReservas())
            {
                lvwReservas.Items.Add(r);
            }
        }
        private void btnVer_Click(object sender, RoutedEventArgs e)
        {
           if (new ReservaWindow((Reserva)lvwReservas.SelectedItem).ShowDialog().Value)
            {
                CargarReservas();
            }
        }
        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("¿Deseas eliminar la reserva?", "Aviso", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                negocio.BorrarReserva(((Reserva)lvwReservas.SelectedItem).ReservaId);
                registros--;
                CargarReservas();
                ActualizarRegistros();
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

        private void btnConfirmar_Click(object sender, RoutedEventArgs e)
        {
            cmiConfirmar.IsChecked = !cmiConfirmar.IsChecked;
            ((Reserva)lvwReservas.SelectedItem).Asiste = !cmiConfirmar.IsChecked;
            CargarReservas();
        }

        private void SeleccionarFiltro(object sender, RoutedEventArgs e)
        {
            CollectionView vista = (CollectionView)CollectionViewSource.GetDefaultView(lvwReservas.Items);
            vista.Filter = FiltrarLista;
        }

        private bool FiltrarLista(object item)
        {
            string filtro = txtFiltro.Text;
            if (string.IsNullOrEmpty(filtro))
            {
                tbFiltro.Text = "Sin filtro";
                return true;
            }
            Reserva reserva = (Reserva)item;
            tbFiltro.Text = $"Filtrado por '{filtro}'";

            return reserva.Nombre.Contains(filtro) || reserva.Fecha.ToShortDateString().Contains(filtro);
        }

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
            this.lvwReservas.Items.SortDescriptions.Clear();
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
                lvwReservas.Items.SortDescriptions.Add(new
                SortDescription(ordenadoPor, sentidoOrden));
            }
            else
            {
                //al pulsar en otra columna desaparecen los criterios de ordenación existentes
                columnaOrdenada = null;
            }
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (e.WidthChanged)
            {
                colNombre.Width = e.NewSize.Width - 600;
            }
        }
    }
}
