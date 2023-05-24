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

        }

        private void btnAceptar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void txtComensales_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtTelefono_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private bool ValidarDatos()
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                txtNombre.Focus();
                MessageBox.Show("El campo nombre no puede estar vacio ", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (string.IsNullOrEmpty(dtpFecha.Text))
            {
                dtpFecha.Focus();
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
    }
}
