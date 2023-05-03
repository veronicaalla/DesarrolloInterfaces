using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniCine_Veronica
{
    public partial class PeliculaFrm : Form
    {
        Pelicula pelicula;
        Negocio negocio;
        private PeliculaFrm()
        {
            InitializeComponent();
            pelicula = new Pelicula();
            negocio = new Negocio();
        }

        public PeliculaFrm(Pelicula peliculaB) : this()
        {
            this.pelicula = peliculaB;
            if (pelicula.PeliculaId == 0)
            {
                //Le damos un valor por defecto
                cmbCategoria.SelectedIndex = 0;
                cmbGenero.SelectedIndex = 0;
                return;
            }

            txtNombre.Text = pelicula.Nombre;
            txtDuracion.Text = pelicula.Duracion.ToString();
            txtAnno.Text = pelicula.Anno.ToString();
            cmbCategoria.SelectedIndex = cmbCategoria.FindString(pelicula.Categoria);
            cmbGenero.SelectedIndex = cmbGenero.FindString(pelicula.Genero);
            txtSinopsis.Text = pelicula.Sinopsis;
        }

        //Para que en los campos numericos solo admita numeros
        private void txtDuracion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtAnno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidadDatos())
            {
                //Igualamos los datos actuales a los de la sesion inicial
                pelicula.Nombre = txtNombre.Text;
                pelicula.Duracion = Int32.Parse(txtDuracion.Text);
                pelicula.Anno = Int32.Parse(txtAnno.Text);
                pelicula.Categoria = cmbCategoria.Text;
                pelicula.Genero = cmbGenero.Text;
                pelicula.Sinopsis = txtSinopsis.Text;

                DialogResult = DialogResult.OK;
            }
        }

        private void brnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool ValidadDatos()
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                txtNombre.Focus();
                MessageBox.Show("El campo nombre no puede estar vacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(txtDuracion.Text))
            {
                txtDuracion.Focus();
                MessageBox.Show("El campo duracion no puede estar vacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            int duracion = Int32.Parse(txtDuracion.Text);
            if (duracion <= 0 || duracion > 300)
            {
                txtDuracion.Focus();
                MessageBox.Show("La duracion es erronea", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(txtAnno.Text))
            {
                txtAnno.Focus();
                MessageBox.Show("El campo año no puede estar vacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(txtSinopsis.Text))
            {
                txtSinopsis.Focus();
                MessageBox.Show("La sipnopsis de la pelicula no puede estar vacia", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}


