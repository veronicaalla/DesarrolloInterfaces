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

namespace WPF_VeronicaAlvarez
{
    /// <summary>
    /// Lógica de interacción para ListaDesarrolladoresWindow.xaml
    /// </summary>
    public partial class ListaDesarrolladoresWindow : Window
    {
        private Negocio negocio;
        public ListaDesarrolladoresWindow()
        {
            InitializeComponent();
            negocio = new Negocio();
            CargarDesarrolladores();
        }

        private void cmsNueva_Click(object sender, RoutedEventArgs e)
        {
            Desarrollador desarrolladorNuevo = new Desarrollador();
            if (new FrmDesarrolladorWindow(desarrolladorNuevo).ShowDialog() == true)
            {
                negocio.CrearDesarrollador(desarrolladorNuevo);
                lvDesarrolladores.Items.Clear();
                CargarDesarrolladores();

            }
        }

        private void lvDesarrolladores_ContextMenuOpening(object sender, ContextMenuEventArgs e)
        {
            cmsNueva.IsEnabled = true;
            cmsVer.IsEnabled = false;
            cmsEliminar.IsEnabled = false;

            if (lvDesarrolladores.SelectedItem != null)
            {
                cmsVer.IsEnabled = true;
                cmsEliminar.IsEnabled = true;
                cmsNueva.IsEnabled = false;
            }
        }

        private void cmsVer_Click(object sender, RoutedEventArgs e)
        {
            if (new FrmDesarrolladorWindow((Desarrollador)lvDesarrolladores.SelectedItem).ShowDialog().Value)
            {
                CargarDesarrolladores();
            }
        }

        private void cmsEliminar_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("¿Deseas eliminar al desarrollador ?", "INFORMACION", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                negocio.EliminarDesarrollador(((Desarrollador)lvDesarrolladores.SelectedItem));
                CargarDesarrolladores();
            }
        }

        private void CargarDesarrolladores()
        {
            lvDesarrolladores.Items.Clear();
            foreach (Desarrollador desarrollador in negocio.ObtenerDesarrollades())
            {
                lvDesarrolladores.Items.Add(desarrollador);
            }
        }


    }
}
