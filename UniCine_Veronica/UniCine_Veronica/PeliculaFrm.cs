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
        private PeliculaFrm()
        {
            InitializeComponent();
            pelicula = new Pelicula();
        }

        public PeliculaFrm(Pelicula peliculaB) : this()
        {
            this.pelicula = peliculaB;
            if (pelicula.PeliculaId == 0)
            {
                return;
            }

            txtNombre.Text = pelicula.Nombre;
            txtDuracion.Text = pelicula.Duracion.ToString();
            txtAnno.Text = pelicula.Anno.ToString();
            cmbCategoria.Text = pelicula.Categoria;
            cmbGenero.Text = pelicula.Genero;
            txtSinopsis.Text = pelicula.Sinopsis;
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
            return true;
        }
    }
}
