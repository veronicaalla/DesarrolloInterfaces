using Microsoft.Win32;
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
using UT5E02_VeronicaAlvarez.Properties;

namespace UT5E02_VeronicaAlvarez
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //Sirve para el contador de imagenes (si queremos eliminar una imagen que ha sido abierta muchas veces, que se controle)
        private int aux = 0;
        //Ruta de la imagen  // UriKind -> tipo de ruta de la imagen
        private readonly BitmapImage cruzImg = new BitmapImage(new Uri("/Resources/cruz.png", UriKind.Relative));

        private void mnSalir_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void mnAbrir_Click(object sender, RoutedEventArgs e)
        {
            //Abrimos el explorador de archivos

            OpenFileDialog seleccionarImagen = new OpenFileDialog
            {
                Filter = "archivo jpg (*.jpg)|*.jpg|archivo jpeg (*.jpeg)|*.jpeg|" +
                "archivo png (*.png)|*.png|archivo gif (*.gif)|*.gif|todos los archivos (*.*)|*.*",
                Multiselect = false
            };

            if (seleccionarImagen.ShowDialog() == true)
            {
                string fileName = seleccionarImagen.FileName;
                //Creamos el tabItem con el nombre de la imagen
                TabItem item = CrearTabItem();

                //Creamos la cabecera de la pestaña (TabItem)
                CrearCabecera(item, fileName);
                CrearVista(item, fileName);
                CrearMenu(fileName);

                tbImagenes.Items.Clear();
                tbImagenes.Items.Add(item);
                tbImagenes.SelectedItem = item;

                //Sumamos uno a la varible para el siguiente valor
                aux++;


            }

        }

        private void cmbToolBar_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (tbImagenes != null && tbImagenes.SelectedItem != null)
            {
                Image visor = (Image)FindName((string)((TabItem)tbImagenes.SelectedItem).Tag);
                visor.Stretch = DarEstiloImagen();
            }
        }



        //Funcionalidad de la imagen del TabItem
        private void OnImageMouseDown(object sender, MouseButtonEventArgs e)
        {
            //Se realiza tantas veces (VisualTreeHelper.GetParent...) como controles haya hasta llegar al TabItem
            //En este caso...
            //Partimos desde la imagen, por lo tanto...    image -> StackPanelContent -> StackPanel -> TabItemContent -> TabItem
            TabItem tbImagen = (TabItem)VisualTreeHelper.GetParent(VisualTreeHelper.GetParent(VisualTreeHelper.GetParent(VisualTreeHelper.GetParent((Image)sender))));
            foreach (object item in miImagen.Items)
            {
                if (((TabItem)FindName((string)((MenuItem)item).Tag)).Equals(tbImagen))
                {
                    //Eliminamos la imagen y el tabItem (pestaña)
                    tbImagenes.Items.Remove(tbImagen);
                    miImagen.Items.Remove(item);
                    break;
                }
            }
        }




        //Métodos auxiliares

        private TabItem CrearTabItem()
        {
            //Creamos el item 
            TabItem item = new TabItem();
            //Le registramos el nombre, para ello, le añadimos el valor auxiliar
            //Se le añade el auxiliar, por si se abre una misma imagen varias veces, se pueda diferenciar una de otra
            RegisterName($"item{aux}", item);

            return item;
        }
        private void CrearCabecera(TabItem item, string fileName)
        {
            //throw new NotImplementedException();
            //Creamos StackPanel con un textBlock y una imagen (teoria)

            StackPanel cabecera = new StackPanel
            {
                Orientation = Orientation.Horizontal
            };

            //Creamos el nombre
            TextBlock nombre = new TextBlock
            {
                //Text = Path.GetFileName(fileName);
                Text = System.IO.Path.GetFileName(fileName)
            };

            //Creamos la imagen
            Image cruz = new Image
            {
                Source = cruzImg
            };

            //Le asignamos el funcionamiento a la imagen
            cruz.MouseDown += OnImageMouseDown;

            //A la cabecera, debemos añadir el nombre y la  imagen
            cabecera.Children.Add(nombre);
            cabecera.Children.Add(cruz);

            //Al item que hemos pasado por parametro, le asignamos el header
            item.Header = cabecera;
        }

        private void CrearVista(TabItem item, string fileName)
        {
            //Creamos el ScrollViewer para poder movernos si la imagen es mas grande
            ScrollViewer scrollViewer = new ScrollViewer();

            //Creamos la imagen con el formato determinado 
            Image visor = new Image
            {
                //Valores dentro del ComboBox -> determina de que forma se va ajustar la imagen
                Stretch = DarEstiloImagen()
            };

            Uri img = new Uri(fileName);
            BitmapImage resultado = new BitmapImage(img);

            //Le asignamos el nombre
            RegisterName($"imagen{aux}", resultado);

            visor.Source = resultado;
            RegisterName($"visor{aux}", visor);
            visor.Tag = $"imagen{aux}";

            //Le asignamos al StatusBar los valores
            txtRuta.Text = img.AbsolutePath;
            txtTamaño.Text = $"Ancho: {resultado.PixelWidth}px, Alto: {resultado.PixelHeight}px";
            scrollViewer.Content = visor;

            //Asociamos al TabItem el scroll
            item.Content = scrollViewer;
            item.Tag = $"visor{aux}";
        }



        private Stretch DarEstiloImagen()
        {
            switch (((ComboBoxItem)cmbToolBar.SelectedItem).Content)
            {
                case "Uniforme":
                    return Stretch.Uniform;
                case "Nada":
                    return Stretch.None;
                case "Rellenar":
                    return Stretch.Fill;
                default:
                    return Stretch.UniformToFill;
            }
        }

        private void CrearMenu(string fileName)
        {
            MenuItem entrada = new MenuItem
            {
                Header = System.IO.Path.GetFileName(fileName),
                Tag = $"item{aux}"

            };

            entrada.Click += (object s, RoutedEventArgs ev) =>
            {
                TabItem pantalla = (TabItem)FindName((string)entrada.Tag);
                tbImagenes.SelectedItem = pantalla;
                TabSelectionChanged();
            };
            miImagen.Items.Add(entrada);
        }

        private void TabSelectionChanged()
        {
            Image visor = (Image)FindName((string)((TabItem)tbImagenes.SelectedItem).Tag);
            BitmapImage resultado = (BitmapImage)FindName((string)visor.Tag);
            txtRuta.Text = resultado.UriSource.AbsolutePath;
            txtTamaño.Text = $"Ancho: {resultado.PixelWidth}px, Alto: {resultado.PixelHeight}px";
            visor.Stretch = DarEstiloImagen();
        }


    }


}

/*
 * Para cuando creamos un método pero no le hemos dado funcionalidad 
 * throw new NotImplementedException();
 */

