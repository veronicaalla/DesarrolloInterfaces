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
    public partial class Contenedor : Form
    {
        public Contenedor()
        {
            InitializeComponent();
        }

        // MENU ARCHIVO
        private void tsmiSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // MENU MANTENIMIENTO
        private void tsmiPeliculas_Click(object sender, EventArgs e)
        {
            ListaPeliculasFrm listaPeliculas = new ListaPeliculasFrm();
            listaPeliculas.MdiParent = this;
            listaPeliculas.Show();
        }

        private void tsmiLibros_Click(object sender, EventArgs e)
        {
            ListaLibrosFrm listaLibros = new ListaLibrosFrm();
            listaLibros.MdiParent = this;
            listaLibros.Show();
        }

        private void tsmiCascada_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void tsmiHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tsmiVertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
    }
}
