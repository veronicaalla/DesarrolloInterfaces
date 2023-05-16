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
    public partial class ListaLibrosFrm : Form
    {
        private Negocio negocio;
        public ListaLibrosFrm()
        {
            InitializeComponent();
            negocio = new Negocio();
            RefrescarLista();
        }

        // MENÚ LIBRO
        private void tsmiCrearLibro_Click(object sender, EventArgs e)
        {
            crearLibro();
        }

        // MÉTODOS DEL MENÚ CONTEXTUAL 
        private void cmsLibros_Opening(object sender, CancelEventArgs e)
        {
            this.cmsVerLibro.Enabled = false;
            this.cmsBorrarLibro.Enabled = false;
            if (lvLibro.SelectedItems.Count == 1)
            {
                this.cmsVerLibro.Enabled = true;
                this.cmsBorrarLibro.Enabled = true;
            }
        }

        private void cmsCrearLibro_Click(object sender, EventArgs e)
        {
            crearLibro();
        }

        private void cmsVerLibro_Click(object sender, EventArgs e)
        {
            verLibro();
        }



        private void cmsBorrarLibro_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea eliminar el elemento?", "IMPORTANTE",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int idLibro = (int)this.lvLibro.SelectedItems[0].Tag;
                this.negocio.BorrarLibro(idLibro);
            }
            this.RefrescarLista();
        }

        private void lvLibro_DoubleClick(object sender, EventArgs e)
        {
            if (lvLibro.SelectedItems.Count == 1)
            {
                verLibro();
            }
        }
        // MÉTODOS AUXILIARES
        public void RefrescarLista()
        {
            //Primero limpiamos el ListView
            lvLibro.Items.Clear();
            this.negocio.obtenerPeliculas().ToList();

            //Recorremos el array y lo mostramos
            foreach (Libro libro in this.negocio.obtenerLibros())
            {

                ListViewItem item = new ListViewItem(
                    new string[]
                    {
                         //Titulo, año y genero
                         libro.Titulo,
                         libro.Anno.ToString(),
                         libro.Autor
                    }
                );
                item.Tag = libro.LibroId;
                this.lvLibro.Items.Add(item);
            }
        }

        private void crearLibro()
        {

            Libro libro= new Libro();
            LibroFrm nuevoLibro = new LibroFrm(libro);
            if (nuevoLibro.ShowDialog() == DialogResult.OK)
            {
                negocio.CrearLibro(libro);
                RefrescarLista();
            }

        }

        private void verLibro()
        {
            //En el opening nos hemos asegurado de que solo haya un elemento seleccionado
            //Por lo tanto no nos hace falta hacer un foreach

            //Parsear no es lo mismo que castear, ahora estamos casteando
            int idLibro = (int)this.lvLibro.SelectedItems[0].Tag;
            Libro libroSeleccionado = negocio.BuscarLibro(idLibro);
            LibroFrm infoPelicula = new LibroFrm(libroSeleccionado);

            if (infoPelicula.ShowDialog() == DialogResult.OK)
            {
                negocio.ModificarLibro(libroSeleccionado);
                RefrescarLista();
            }
        }

        
    }
}
