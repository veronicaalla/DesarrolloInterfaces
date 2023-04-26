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
    public partial class LupaPeliculaFrm : Form
    {
        Negocio negocio;
        public string nombrePelicula;

        public LupaPeliculaFrm()
        {
            InitializeComponent();
            negocio = new Negocio();
            rellenarComboPeliculas();

            cmbPeliculas.SelectedIndex = 0;
        }

        private void rellenarComboPeliculas()
        {
            List <Pelicula> listaPeliculas = negocio.obtenerPeliculas().ToList();
            foreach(Pelicula p in listaPeliculas)
            {
                cmbPeliculas.Items.Add(p.Nombre);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            nombrePelicula = cmbPeliculas.SelectedItem.ToString();
            DialogResult = DialogResult.OK;
        }
    }
}
