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
    /// Lógica de interacción para FrmTareaWindow.xaml
    /// </summary>
    public partial class FrmTareaWindow : Window
    {
        private Tarea tarea;
        private int estimado;
        private FrmTareaWindow()
        {
            InitializeComponent();
        }

        public FrmTareaWindow(Tarea tarea) : this()
        {
            this.tarea = tarea;
            if (tarea != null)
            {
                txtCodigoDesarrollador.Text = tarea.DesarrolladorId.ToString();
                //Buscamos el nombre del desarrollador 
                /*
                * Retorna null, observar porque
                * txtNombreDesarrollador.Text = ((Desarrollador)Herramientas.ObtenerDesarrolladorPorCodigo(txtCodigoDesarrollador.Text)).Nombre;
                */
                txtProyecto.Text = tarea.Proyecto;
                txtEstimado.Text = tarea.Estimado.ToString();
                cmbPrioriedad.Text = tarea.Prioridad;
                txtObservaciones.Text = tarea.Descripcion;
            }
        }

        private void btnAceptar_Click(object sender, RoutedEventArgs e)
        {
            if (ValidarDatos())
            {
                tarea.Proyecto = txtProyecto.Text;
                tarea.Estimado = estimado;
                tarea.Prioridad = ConseguirPrioridad();
                //CheckBox

                tarea.Descripcion = txtObservaciones.Text;
                DialogResult = true;
            }
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //----- Metodos auuxiliares----
        private bool ValidarDatos()
        {
            if (string.IsNullOrEmpty(txtProyecto.Text))
            {
                MessageBox.Show("El nombre no puede estar vacío.", "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning);
                txtProyecto.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtEstimado.Text))
            {
                MessageBox.Show("El nombre no puede estar vacío.", "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning);
                txtEstimado.Focus();
                return false;
            }
            /*
            if (!(Int32.TryParse(txtEstimado.Text, out estimado)))
            {
                MessageBox.Show("Estimado a de ser un numero ", "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning);
                txtEstimado.Focus();
                return false;
            }*/

            return true;
        }

        private string ConseguirPrioridad()
        {
            string[] aux = ((ComboBoxItem)(cmbPrioriedad.SelectedItem)).ToString().Split(' ');
            return aux[1];
        }

        private void txtEstimado_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(e.Key >= Key.D0 && e.Key <= Key.D9)
               && !(e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9)
              )
            {
                e.Handled = true;
            }
        }
    }
}
