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

namespace UT5E04_VeronicaAlvarez
{
    /// <summary>
    /// Lógica de interacción para ReservaWindow.xaml
    /// </summary>
    public partial class ReservaWindow : Window
    {
        private Reserva reserva;
        private ReservaWindow()
        {
            InitializeComponent();
            dtpFecha.SelectedDate = DateTime.Now;
        }

        public ReservaWindow(Reserva reserva) : this()
        {
            this.reserva = reserva;
            if (reserva != null)
            {
                txtNombre.Text = reserva.Nombre;
                txtComensales.Text = reserva.Comensales.ToString();
                txtObservaciones.Text = reserva.Observaciones;
                txtTelefono.Text = reserva.Telefono;
                dtpFecha.SelectedDate = reserva.Fecha.Equals(DateTime.MinValue) ? dtpFecha.SelectedDate : DateTime.Parse(reserva.Fecha.ToShortDateString());
                cbAsiste.IsChecked = reserva.Asiste;
            }
        }

        private void Numerico_KeyDown(object sender, KeyEventArgs e)
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
                MessageBox.Show("El nombre no puede estar vacío.", "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning);
                txtNombre.Focus();
                return false;
            }
            if (!dtpFecha.SelectedDate.HasValue)
            {
                MessageBox.Show("Valor de la fecha incorrecto.", "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning);
                dtpFecha.Focus();
                return false;
            }
            return true;
        }

        private void BtnAceptar_Click(object sender, RoutedEventArgs e)
        {
            if (ValidarDatos())
            {
                reserva.Nombre = txtNombre.Text;
                reserva.Asiste = cbAsiste.IsChecked.Value;
                reserva.Observaciones = txtObservaciones.Text;
                reserva.Telefono = txtTelefono.Text;
                reserva.Fecha = dtpFecha.SelectedDate.Value;
                reserva.Comensales = Convert.ToInt32(txtComensales.Text);

                DialogResult = true;
            }
        }
    }
}