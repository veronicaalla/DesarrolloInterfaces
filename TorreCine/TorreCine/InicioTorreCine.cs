using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TorreCine
{
    public partial class InicioTorreCine : Form
    {
        public InicioTorreCine()
        {
            InitializeComponent();
        }

        //------------- MENU ARCHIVO -----------------
        private void tsmiDatosDesarrollador_Click(object sender, EventArgs e)
        {
            DatosDesarrolladorFrm infoDesarrollador = new DatosDesarrolladorFrm();
            infoDesarrollador.MdiParent = this;
            infoDesarrollador.Show();
        }

        private void tsmiSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //------------ MENU MANTENIMIENTO ----------------
        private void tsmiPeliculas_Click(object sender, EventArgs e)
        {
            ListaPeliculasFrm listaPeliculas = new ListaPeliculasFrm();
            listaPeliculas.MdiParent = this;
            listaPeliculas.Show();
        }

        private void tsmiSesiones_Click(object sender, EventArgs e)
        {
            ListaSesionesFrm listaSesiones = new ListaSesionesFrm();
            listaSesiones.MdiParent = this;
            listaSesiones.Show();
        }


        //----------------- MENU VENTANAS------------------
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
