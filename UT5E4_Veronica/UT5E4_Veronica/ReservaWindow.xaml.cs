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

namespace UT5E4_Veronica
{
    /// <summary>
    /// Lógica de interacción para ReservaWindow.xaml
    /// </summary>
    public partial class ReservaWindow : Window
    {

        Reserva reserva;
        private ReservaWindow()
        {
            InitializeComponent();
        }


        public ReservaWindow(Reserva reserva) : this()
        {
            this.reserva = reserva;
            if (reserva.ReservaId == 0)
            {
                return;
            }

            //Le asignamos los datos 
            txtNombre.Text = reserva.Nombre;
            //Fecha
            dpFecha.Text = reserva.Fecha.ToShortDateString();

            txtTelefono.Text = reserva.Telefono;
            txtComensales.Text = reserva.Comensales.ToString();
            if (reserva.Asiste == true)
            {
                chkAsiste.IsChecked = true;
            }

            txtObservaciones.Text = reserva.Observaciones;
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, RoutedEventArgs e)
        {
            if (ValidarDatos())
            {
                this.reserva.Nombre = txtNombre.Text;
                this.reserva.Fecha = dpFecha.SelectedDate.Value;
                this.reserva.Telefono = txtTelefono.Text;
                this.reserva.Comensales = Int32.Parse(txtComensales.Text);
                this.reserva.Asiste = chkAsiste.IsChecked.Value;
                this.reserva.Observaciones = txtObservaciones.Text;

                DialogResult = true;
            }
        }

        private void txtComensales_KeyDown(object sender, KeyEventArgs e)
        {
            Key[] teclas = { Key.Tab, Key.Back, Key.Delete };

            if (!(e.Key >= Key.D0 && e.Key <= Key.D9)
                && !(e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9)
                && !teclas.Contains(e.Key))
            {
                e.Handled = true;
            }
        }

        private void txtTelefono_KeyDown(object sender, KeyEventArgs e)
        {
            Key[] teclas = { Key.Tab, Key.Back, Key.Delete };

            if (!(e.Key >= Key.D0 && e.Key <= Key.D9)
                && !(e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9)
                && !teclas.Contains(e.Key))
            {
                e.Handled = true;
            }
        }

        private bool ValidarDatos()
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                txtNombre.Focus();
                MessageBox.Show("El campo nombre no puede estar vacio ", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (string.IsNullOrEmpty(dpFecha.Text))
            {
                dpFecha.Focus();
                MessageBox.Show("El campo fecha no puede estar vacio ", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                txtTelefono.Focus();
                MessageBox.Show("El campo telefono no puede estar vacio ", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (string.IsNullOrEmpty(txtComensales.Text))
            {
                txtComensales.Focus();
                MessageBox.Show("El campo comensales no puede estar vacio ", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            return true;
        }

        //Lo usamos para definir que la menor fecha a introducir es la actual
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dpFecha.DisplayDateStart = DateTime.Now;
        }

        private void txtObservaciones_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtDni_KeyDown(object sender, KeyEventArgs e)
        {

           /* // Obtener el texto actual y el carácter que se está ingresando
            string currentText = txtDni.Text;
            char newChar = (char)KeyInterop.VirtualKeyFromKey(e.Key);

            // Validar que el carácter ingresado sea un número o una letra
            if (!char.IsDigit(newChar) && !char.IsLetter(newChar))
            {
                e.Handled = true; // Ignorar el carácter no válido
                return;
            }

            // Validar que los primeros 8 caracteres sean números y el noveno sea una letra
            if (currentText.Length < 8 && !char.IsDigit(newChar))
            {
                e.Handled = true; // Ignorar si aún no se ingresaron los 8 primeros dígitos
                return;
            }

            if (currentText.Length == 8 && !char.IsLetter(newChar))
            {
                e.Handled = true; // Ignorar si no se ingresó una letra como noveno carácter
                return;
            }

            // Concatenar el nuevo carácter al texto actual
            string newText = currentText + newChar;

            // Actualizar el texto del TextBox
            txtDni.Text = newText;

            e.Handled = true; // Marcar el evento como manejado
           */

            
            if (txtDni.)

        }
    }
}
