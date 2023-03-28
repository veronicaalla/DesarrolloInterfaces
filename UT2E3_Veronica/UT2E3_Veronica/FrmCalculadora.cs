using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace UT2E3_Veronica
{
    public partial class FrmCalculadora : Form
    {
        //Instanciamos la clase calculadora para poder obtener los metodos de dicha clase

        public Calculadora _calculadora;
        public FrmCalculadora()
        {
            InitializeComponent();
            _calculadora = new Calculadora();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            _calculadora.Borrar();
            txtVisor.Text = string.Empty;
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            if (!txtVisor.Text.Contains(","))
            {
                txtVisor.Text += ",";
            }
        }

        private void BtnNumeros_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text == "0")
            {
                txtVisor.Text = string.Empty;
                txtVisor.Text = ((Button)sender).Tag.ToString();
                _calculadora.Visor = float.Parse(txtVisor.Text);
                return;
            }

            txtVisor.Text += ((Button)sender).Tag.ToString();
            _calculadora.Visor = float.Parse(txtVisor.Text);
        }

        private void btnOperaciones_Click(object sender, EventArgs e)
        {
            string operacion = ((Button)sender).Tag.ToString();
            Operaciones(operacion);
            txtVisor.Text = string.Empty;
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            _calculadora.Calcular();
            _calculadora.Operacion = OperacionesEnun.SinOperacion;
            txtVisor.Text = _calculadora.Visor.ToString();
        }

        //Memory Recovery -> Boton recuperar
        private void btnMR_Click(object sender, EventArgs e)
        {
            txtVisor.Text = _calculadora.Memoria.ToString();
        }

        //Memory Storage
        private void btnMS_Click(object sender, EventArgs e)
        {
            _calculadora.Memoria = float.Parse(txtVisor.Text);
        }

        private void FrmCalculadora_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtVisor.Text += e.KeyChar.ToString();

            //Cuando pulsemos una tecla nos realice el codigo del boton correspondiente
            if (txtVisor.Text == "0")
            {
                txtVisor.Text = string.Empty;
                _calculadora.Visor = float.Parse(txtVisor.Text);
                return;
            }

            _calculadora.Visor = float.Parse(txtVisor.Text);

            /*if ((e.KeyChar == '/') || (e.KeyChar == '*')|| (e.KeyChar == '+')|| (e.KeyChar == '-'))
            {
                Operaciones(txtVisor.Text);
                txtVisor.Text = string.Empty;
            }*/
        }

        private void Operaciones(string operacion)
        {
            switch (operacion)
            {
                case "+":
                    _calculadora.Operacion = OperacionesEnun.Suma;
                    break;
                case "-":
                    _calculadora.Operacion = OperacionesEnun.Resta;
                    break;
                case "*":
                    _calculadora.Operacion = OperacionesEnun.Multiplicacion;
                    break;
                case "/":
                    _calculadora.Operacion = OperacionesEnun.Disvision;
                    break;
            }
        }
    }
}
