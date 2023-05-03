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
    public partial class ListadoPeliculasFrm : Form
    {
        private Negocio negocio;

        public ListadoPeliculasFrm()
        {
            InitializeComponent();
            negocio = new Negocio();
            RefrescarLista();
        }

        //MENU INICIAL
        private void tsmiNuevaPelicula_Click(object sender, EventArgs e)
        {
            NuevaPelicula();
        }

        //MENU CONTEXTUAL DEL LISTVIEW
        private void cmsPeliculas_Opening(object sender, CancelEventArgs e)
        {
            this.cmsNuevo.Enabled = true;
            this.cmsVer.Enabled = false;
            this.cmsBorrar.Enabled = false;
            if (lvPeliculas.SelectedItems.Count == 1)
            {
                this.cmsVer.Enabled = true;
                this.cmsBorrar.Enabled = true;
            }
        }

        private void cmsNuevo_Click(object sender, EventArgs e)
        {
            NuevaPelicula();
        }

        private void cmsVer_Click(object sender, EventArgs e)
        {
            VerPelicula();
        }

        private void cmsBorrar_Click(object sender, EventArgs e)
        {
            //Para controlar la posible excepcion de negocio
            try
            {
                if (MessageBox.Show("¿Seguro que desea eliminar el elemento?", "IMPORTANTE",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int idPelicula = (int)this.lvPeliculas.SelectedItems[0].Tag;
                    //Lazamos excepción de negocio desde Negocio en el metodo BorrarPelicula
                    this.negocio.BorrarPelicula(idPelicula);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.RefrescarLista();
        }



        private void lvPeliculas_DoubleClick(object sender, EventArgs e)
        {
            if (lvPeliculas.SelectedItems.Count == 1)
            {
                VerPelicula();
            }

        }

        //MÉTODOS AUXILIARES
        private void RefrescarLista()
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

        public void NuevaPelicula()
        {
            Pelicula nuevo = new Pelicula();
            PeliculaFrm ventanaPelicula = new PeliculaFrm(nuevo);
            //ventanaCuidador.Show();
            if (ventanaPelicula.ShowDialog() == DialogResult.OK)
            {
                negocio.CrearPelicula(nuevo);
                RefrescarLista();
            }
        }
        public void VerPelicula()
        {
            //En el opening nos hemos asegurado de que solo haya un elemento seleccionado
            //Por lo tanto no nos hace falta hacer un foreach

            //Parsear no es lo mismo que castear, ahora estamos casteando
            int idPelicula = (int)this.lvPeliculas.SelectedItems[0].Tag;
            Pelicula peliculaSeleccionada = negocio.BuscarPelicula(idPelicula);
            PeliculaFrm infoPelicula = new PeliculaFrm(peliculaSeleccionada);

            try
            {
                if (infoPelicula.ShowDialog() == DialogResult.OK)
                {
                    negocio.ModificarPelicula(peliculaSeleccionada);
                    RefrescarLista();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmsFicha_Click(object sender, EventArgs e)
        {
            if (lvPeliculas.SelectedItems.Count == 1)
            {
                int idPelicula = (int)this.lvPeliculas.SelectedItems[0].Tag;
                Reports.Generador.InformeFichaPelicula(idPelicula);
            }


        }

        private void tsmiCartelera_Click(object sender, EventArgs e)
        {
            FechaFrm fecha = new FechaFrm();

            if (fecha.ShowDialog() == DialogResult.OK)
            {
                Reports.Generador.InformeCartelera(fecha.fecha);
                this.Close();
            }

        }

        private void tsmiCatalogo_Click(object sender, EventArgs e)
        {
            ComboGeneroFrm seleccinador = new ComboGeneroFrm();
            if (seleccinador.ShowDialog() == DialogResult.OK)
            {
                Reports.Generador.InformeCatalogoPeliculas(seleccinador.genero);
                this.Close();
            }
        }
    }
}
