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
    public partial class ListaPeliculasFrm : Form
    {
        private Negocio negocio;
        public ListaPeliculasFrm()
        {
            InitializeComponent();
            negocio = new Negocio();
            RefrescarLista();
        }


        //MENU PELICULA
        private void tsmiCrearPelicula_Click(object sender, EventArgs e)
        {
            crearPelicula();
        }


        // METODOS DEL MENÚ CONTEXTUAL
        private void cmsPeliculas_Opening(object sender, CancelEventArgs e)
        {
            this.cmsCrearPelicula.Enabled = true;
            this.cmsVerPelicula.Enabled = false;
            this.cmsEliminarPelicula.Enabled = false;
            if (lvPeliculas.SelectedItems.Count == 1)
            {
                this.cmsVerPelicula.Enabled = true;
                this.cmsEliminarPelicula.Enabled = true;
            }
        }

        private void cmsCrearPelicula_Click(object sender, EventArgs e)
        {
            crearPelicula();
        }

        private void cmsVerPelicula_Click(object sender, EventArgs e)
        {
            verPelicula();
        }

        private void cmsEliminarPelicula_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea eliminar el elemento?", "IMPORTANTE",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.negocio.BorrarPelicula((int)this.lvPeliculas.SelectedItems[0].Tag);
            }
            this.RefrescarLista();
        }

        private void lvPeliculas_DoubleClick(object sender, EventArgs e)
        {
            if (lvPeliculas.SelectedItems.Count == 1)
            {
                verPelicula();
            }
        }

        //MÉTODOS AUXILIARES
        public void RefrescarLista()
        {
            //Primero limpiamos el ListView
            lvPeliculas.Items.Clear();
            this.negocio.obtenerPeliculas().ToList();

            //Recorremos el array y lo mostramos
            foreach (Pelicula pelicula in this.negocio.obtenerPeliculas())
            {

                ListViewItem item = new ListViewItem(
                    new string[]
                    {
                         //Titulo, año y genero
                         pelicula.Titulo,
                         pelicula.Anno.ToString(),
                         pelicula.Genero
                    }
                );
                item.Tag = pelicula.PeliculaId;
                this.lvPeliculas.Items.Add(item);
            }
        }

        private void crearPelicula()
        {

            Pelicula pelicula = new Pelicula();
            PeliculaFrm nuevaPelicula = new PeliculaFrm(pelicula);
            if (nuevaPelicula.ShowDialog() == DialogResult.OK)
            {
                negocio.CrearPelicula(pelicula);
                RefrescarLista();
            }

        }

        private void verPelicula()
        {
            //En el opening nos hemos asegurado de que solo haya un elemento seleccionado
            //Por lo tanto no nos hace falta hacer un foreach

            //Parsear no es lo mismo que castear, ahora estamos casteando
            int idPelicula = (int)this.lvPeliculas.SelectedItems[0].Tag;
            Pelicula peliculaSeleccionada = negocio.BuscarPelicula(idPelicula);
            PeliculaFrm infoPelicula = new PeliculaFrm(peliculaSeleccionada);

            if (infoPelicula.ShowDialog() == DialogResult.OK)
            {
                negocio.ModificarPelicula(peliculaSeleccionada);
                RefrescarLista();
            }
        }
       
    }
}
