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
    public partial class LupaListadoPeliculaFrm : Form
    {
        Negocio negocio;
        public Pelicula pelicula;

        public LupaListadoPeliculaFrm()
        {
            InitializeComponent();
            negocio = new Negocio();
            RefrescarLista(negocio.obtenerPeliculas().ToList<Pelicula>());

            //Le damos valores iniciales a los combox
            cmbCategoria.SelectedIndex = 0;
            cmbGenero.SelectedIndex = 0;

        }


        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string genero = cmbGenero.GetItemText(cmbGenero.SelectedItem);
            string categoria = cmbCategoria.GetItemText(cmbCategoria.SelectedItem);
            List<Pelicula> listaSesiones = Herramientas.ObtenerPeliculasFiltradas(genero, categoria);
            RefrescarLista(listaSesiones);
        }

        private void lvPeliculas_DoubleClick(object sender, EventArgs e)
        {
            int idPelicula = (int)this.lvPeliculas.SelectedItems[0].Tag;
            Pelicula peliculaSeleccionada = negocio.BuscarPelicula(idPelicula);
            this.pelicula = peliculaSeleccionada;

            DialogResult = DialogResult.OK;
        }


        //MÉTODOS AUXILIARES
        private void RefrescarLista(List<Pelicula> listaPeliculas)
        {
            //Primero limpiamos el ListView
            lvPeliculas.Items.Clear();


            //Recorremos la lista y mostramos
            foreach (Pelicula pelicula in listaPeliculas)
            {
                ListViewItem item = new ListViewItem(
                new string[]
                {
                        pelicula.Nombre,
                        pelicula.Duracion+ " min",
                        pelicula.Anno.ToString(),
                        pelicula.Categoria,
                        pelicula.Genero

                }
                );
                item.Tag = pelicula.PeliculaId;
                this.lvPeliculas.Items.Add(item);
            }
        }
    }
}
