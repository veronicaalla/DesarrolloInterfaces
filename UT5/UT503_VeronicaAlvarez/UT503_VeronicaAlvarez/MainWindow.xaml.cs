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

namespace UT503_VeronicaAlvarez
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private TipoEventoEnum tipoEvento = TipoEventoEnum.TODOS;

        private bool validarHora = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (ValidarDatos())
            {
                Evento ev = new Evento();
                ev.Nombre = txtNombre.Text;
                ev.Fecha = dtpFecha.DisplayDate;
                ev.Hora = DateTime.Parse(txtHora.Text);

                //ev.Promotor = ((ComboBoxItem)(cmbPromotor.SelectedItem)).ToString(); //.Split(' ');
                string[] promotor = ((ComboBoxItem)(cmbPromotor.SelectedItem)).ToString().Split(' ');
                ev.Promotor = promotor[1];

                ev.Aforo = Convert.ToInt32(txtAforo.Text);
                ev.Descripcion = txtDescripcion.Text;
                ev.Bar = (bool)cbBar.IsChecked;
                ev.Seguridad = (bool)cbSeguridad.IsChecked;
                ev.Montaje = (bool)cbMontaje.IsChecked;
                ev.Sanitarios = (bool)cbSanitarios.IsChecked;

                //Opc seleccionada en el radio button
                ev.Tipo = tipoEvento;

                //Abrimos el otro panel
                string mensaje;
                if (new ResumenWindow(ev).ShowDialog().Value)
                {
                    mensaje = "Datos confirmados.";
                }
                else
                {
                    mensaje = "Datos rechazados.";
                }
                //Mostramos un MessageBox con la decicion
                MessageBox.Show(mensaje, "Resultado", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }


        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            switch (rb.Tag)
            {
                case "10":
                    tipoEvento = TipoEventoEnum.MENORES_DIEZ;
                    break;
                case ">16":
                    tipoEvento = TipoEventoEnum.MAYORES_DIECISEIS;
                    break;
                case ">18":
                    tipoEvento = TipoEventoEnum.MAYORES_DIECIOCHO;
                    break;
                default:
                    tipoEvento = TipoEventoEnum.TODOS;
                    break;
            }
        }

        private void txtHora_KeyDown(object sender, KeyEventArgs e)
        {
            Key[] teclas = { Key.D0, Key.NumPad0, Key.D1, Key.NumPad1, Key.D2, Key.NumPad2, Key.D3, Key.NumPad3, Key.D4, Key.NumPad4,
            Key.D5, Key.NumPad5, Key.D6, Key.NumPad6, Key.D7, Key.NumPad7, Key.D8, Key.NumPad8, Key.D9, Key.NumPad9,
            Key.Delete, Key.Return };

            if (!teclas.Contains(e.Key))
            {
                e.Handled = true;
                return;
            }

            TextBox control = (TextBox)sender;
            if (!string.IsNullOrEmpty((string)control.Tag) && control.Text.Length == 2)
            {
                control.Text += ":";
                control.Select(control.Text.Length + 1, control.Text.Length + 1);
            }

            if (control.Text.Length == 5)
            {
                e.Handled = true;
            }
        }

        private void txtHora_LostFocus(object sender, RoutedEventArgs e)
        {
            string hora = txtHora.Text;
            if (hora.Length < 5 || Convert.ToInt32(hora.Substring(0, 2)) > 23 || Convert.ToInt32(hora.Substring(3, 2)) > 59)
            {
                validarHora = false;
                return;
            }
            validarHora = true;
        }

        //----- Métodos auxiliares -----
        private bool ValidarDatos()
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("El nombre no debe estar vacío.", "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning);
                txtNombre.Focus();
                return false;
            }
            DateTime fecha;
            if (!DateTime.TryParse(dtpFecha.Text, out fecha))
            {
                MessageBox.Show("Valor de la fecha no válido.", "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning);
                dtpFecha.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtAforo.Text))
            {
                MessageBox.Show("El aforo no debe estar vacío.", "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning);
                txtAforo.Focus();
                return false;
            }
            if (!validarHora)
            {
                MessageBox.Show("Formato de hora inválido.", "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning);
                txtHora.Focus();
                return false;
            }
            return true;
        }


        /*
        private void cmbPromotor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //NO lo realiza bien 
            //promotor = cmbPromotor.Text;
        }
        */
    }
}
