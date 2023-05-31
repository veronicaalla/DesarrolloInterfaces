using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// Lógica de interacción para FrmDesarrolladorWindow.xaml
    /// </summary>
    public partial class FrmDesarrolladorWindow : Window
    {
        Desarrollador desarrollador;
        private FrmDesarrolladorWindow()
        {
            InitializeComponent();
            dtpFecha.SelectedDate = DateTime.Now;
        }

        public FrmDesarrolladorWindow(Desarrollador desarollador) : this()
        {
            this.desarrollador = desarrollador;
            txtNombre.Text = desarrollador.Nombre;
            //fecha
            txtTelefono.Text = desarrollador.Telefono;
            cmbCategoria.Text = desarrollador.Categoria;
            txtCodigo.Text = desarrollador.Codigo;
        }

        private void btnAceptar_Click(object sender, RoutedEventArgs e)
        {
            if (ValidarDatos())
            {
                desarrollador.Nombre = txtNombre.Text;
                desarrollador.Nacimiento = dtpFecha.SelectedDate.Value;
                desarrollador.Telefono = txtTelefono.Text;
                desarrollador.Categoria = ObtenerCategoria();
                desarrollador.Codigo = txtCodigo.Text;

                DialogResult = true;
            }
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
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
                MessageBox.Show("El nombre no puede estar vacío.", "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning);
                txtNombre.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                MessageBox.Show("El teléfono no puede estar vacío.", "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning);
                txtTelefono.Focus();
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

        private string ObtenerCategoria()
        {
            string[] aux = ((ComboBoxItem)(cmbCategoria.SelectedItem)).ToString().Split(' ');
            return aux[1];
        }
    }
}
