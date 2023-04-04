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

        public PeliculaFrm(Pelicula peliculaNueva):this()
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
            this.pelicula.Titulo = txtTitulo.Text;
            this.pelicula.Anno = Int32.Parse(txtAño.Text);
            this.pelicula.Genero = txtGenero.Text;

            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
