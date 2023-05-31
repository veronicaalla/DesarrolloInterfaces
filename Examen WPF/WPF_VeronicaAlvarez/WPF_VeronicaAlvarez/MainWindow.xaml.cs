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

namespace WPF_VeronicaAlvarez
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Negocio negocio;
       

        public MainWindow()
        {
            InitializeComponent();
            negocio = new Negocio();
            CargarTareas();
        }

        //Crea una nueva tarea
        private void mnNuevo_Click(object sender, RoutedEventArgs e)
        {
            NuevaTarea();
        }

        //Sale de la aplicacion 
        private void mnSalir_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        //Lanza la ventana de manteninimiento de desarrolladores
        private void mnDesarrolladores_Click(object sender, RoutedEventArgs e)
        {
            ListaDesarrolladoresWindow mantenimientoDesarrolladores = new ListaDesarrolladoresWindow();
            mantenimientoDesarrolladores.Show();
        }

        //Nos obtiene el filtrado
        private void btnFiltrar_Click(object sender, RoutedEventArgs e)
        {
           
        }

        

        //Determinamos el funcionamiento del mnu contextual
        private void lvTareas_ContextMenuOpening(object sender, ContextMenuEventArgs e)
        {
            cmsNueva.IsEnabled = true;
            cmsVer.IsEnabled = false;
            cmsEliminar.IsEnabled = false;

            if (lvTareas.SelectedItem != null)
            {
                cmsVer.IsEnabled = true;
                cmsEliminar.IsEnabled = true;
                cmsNueva.IsEnabled = false;
            }
        }

        //Creamos una nueva tarea
        private void cmsNueva_Click(object sender, RoutedEventArgs e)
        {
            NuevaTarea();
        }


        //Vemos la tarea
        private void cmsVer_Click(object sender, RoutedEventArgs e)
        {
            if (new FrmTareaWindow((Tarea)lvTareas.SelectedItem).ShowDialog().Value)
            {
                CargarTareas();
            }
        }

        //Eliminamos dicha tarea
        private void cmsEliminar_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("¿Deseas eliminar la reserva?", "INFORMACION", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                negocio.EliminarTarea(((Tarea)lvTareas.SelectedItem));
                CargarTareas();
            }
        }

        //Método para realizar el filtrado por columnas
        private void ColumnHeader_Click(object sender, RoutedEventArgs e)
        {

        }

        //-------------- Métodos auxiliares -------

        private void CargarTareas()
        {
            lvTareas.Items.Clear();
            foreach (Tarea tarea in negocio.ObtenerTareas())
            {
                lvTareas.Items.Add(tarea);
            }
        }

        private void NuevaTarea()
        {
            Tarea tareaNueva = new Tarea();
            if (new FrmTareaWindow(tareaNueva).ShowDialog() == true)
            {
                negocio.CrearTarea(tareaNueva);
                lvTareas.Items.Clear();
                CargarTareas();

            }

        }


    }
}
