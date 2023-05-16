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

namespace UT5E3_Veronica
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

        private void txtHora_KeyDown(object sender, KeyEventArgs e)
        {
            //Almacenamos en un array todas las teclas que puede introducir el usuario (numeros)
            Key[] teclasPosibles = { Key.D0, Key.D1, Key.D2, Key.D3, Key.D4, Key.D5, Key.D6, Key.D7, Key.D8, Key.D9 };

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

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
