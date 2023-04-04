using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UT2E9_Veronica
{
    public partial class PeliculaFrm : Form
    {
        Pelicula pelicula;
        private PeliculaFrm()
        {
            InitializeComponent();
            pelicula = new Pelicula();
        }

        public PeliculaFrm(Pelicula peliculaNueva) : this()
        {
            this.pelicula = peliculaNueva;
            if (pelicula.PeliculaId == 0)
            {
                //Le tenemos que asignar id o al guardarse se le asigna solo?
                return;
            }
            this.txtTitulo.Text = pelicula.Titulo;
            this.txtAño.Text = pelicula.Anno.ToString();
            this.txtGenero.Text = pelicula.Genero;

            DialogResult = DialogResult.Cancel;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                this.pelicula.Titulo = txtTitulo.Text;
                this.pelicula.Anno = Int32.Parse(txtAño.Text);
                this.pelicula.Genero = txtGenero.Text;

                DialogResult = DialogResult.OK;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        //Métodos necesarios para datos correctos

        private void txtAño_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
        private bool ValidarDatos()
        {

            if (string.IsNullOrEmpty(txtTitulo.Text))
            {
                //mostrarMessageBox("El campo titulo no puede estar vacio");
                MessageBox.Show("El campo titulo no puede estar vacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTitulo.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtAño.Text))
            {
                MessageBox.Show("El campo fecha no puede estar vacia", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAño.Focus();
                return false;
            }

            if (!annoMayor())
            {
                MessageBox.Show("El año de publicacion no puede ser mayor al año actual", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAño.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtGenero.Text))
            {
                MessageBox.Show("El campo genero no puede estar vacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGenero.Focus();
                return false;
            }

            return true;
        }

        private bool annoMayor()
        {

            //Parseamos el valor
            int anno = Int32.Parse(txtAño.Text);
            //Obtenemos el año actual, para comprobar que no sea mayor
            int annoActual = DateTime.Now.Year;
            if (anno > annoActual)
            {
                return false;
            }

            return true;
        }


        /*private MessageBox mostrarMessageBox(string message)
        {
            return MessageBox.Show(message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }*/

    }
}
