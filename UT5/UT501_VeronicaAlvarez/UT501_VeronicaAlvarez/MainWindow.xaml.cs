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

namespace UT501_VeronicaAlvarez
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

        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double primerValor, segundoValor;
                primerValor = double.Parse(txtPrimerValor.Text.Replace(".", ","));
                segundoValor = double.Parse(txtSegundorValor.Text.Replace(".", ","));

                double resultado = 0;
                string valorEntrada = string.Empty;
                //mirar como hacerlo usando Tag
                switch (cmbOperacion.SelectedIndex)
                {
                    case 0:
                        resultado = primerValor + segundoValor;
                        valorEntrada = primerValor + " + " + segundoValor;
                        break;
                    case 1:
                        resultado = primerValor - segundoValor;
                        valorEntrada = primerValor + " - " + segundoValor;
                        break;
                    case 2:
                        resultado = primerValor * segundoValor;
                        valorEntrada = primerValor + " * " + segundoValor;
                        break;
                    case 3:
                        resultado = primerValor / segundoValor;
                        valorEntrada = primerValor + " / " + segundoValor;
                        break;


                }

                Span formatoSalida = new Span();
                //Parrafo con el contenido en negrita
                formatoSalida.FontWeight = FontWeights.Bold;
                //Añadimos texto -> 1º Linea
                Run infoEntrada = new Run(valorEntrada);
                formatoSalida.Inlines.Add(infoEntrada);
                //Añadimos el salto de linea
                formatoSalida.Inlines.Add(new LineBreak());
                //Creamos la Segunda linea con su fondo en color Aqua
                Run infoSalida = new Run("Resultado igual a " + resultado);
                infoSalida.Background = new SolidColorBrush(Colors.Aqua);
                //La añadimos al Span inicial
                formatoSalida.Inlines.Add(infoSalida);
                //Añadimos el salto de linea
                formatoSalida.Inlines.Add(new LineBreak());

                //Añadimos todo el texto al -> textBlock
                this.tbResultados.Inlines.Add(formatoSalida);
            }
            catch (FormatException )
            {
                MessageBox.Show("Se deben introducir numeros", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }


    }
}
