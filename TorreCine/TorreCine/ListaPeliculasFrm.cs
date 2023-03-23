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
    public partial class ListaPeliculasFrm : Form
    {
        private Cliente cliente;
        public ListaPeliculasFrm()
        {
            InitializeComponent();
            cliente = new Cliente();
            RefrescarLista();
        }

        private void tsmiNuevaPelicula_Click(object sender, EventArgs e)
        {
           
           crearPelicula();
           
        }

        public void RefrescarLista()
        {
            //Primero limpiamos el ListView
            /* lvPeliculas.Items.Clear();
             this.cliente.obtenerPeliculas().ToList();

             //Recorremos el array y lo mostramos
             foreach (Pelicula pelicula in this.cliente.obtenerPeliculas())
             {

                 ListViewItem item = new ListViewItem(
                     new string[]
                     {
                         
                     }
                 );
                 item.Tag = pelicula.PeliculaId;
                 this.lvPeliculas.Items.Add(item);
             }*/
        }

        private void crearPelicula()
        {
            /*
            Pelicula pelicula = new Pelicula();
            PeliculasFrm nuevaPelicula = new PeliculasFrm(pelicula);
            if (nuevaPelicula.ShowDialog() == DialogResult.OK)
            {
                cliente.crearPelicula(pelicula);
                RefrescarLista();
            }
            */
            PeliculasFrm nuevaPelicula = new PeliculasFrm();
            nuevaPelicula.ShowDialog();
        }

        //------------------- MENU CONTEXTUAL -----------------

        private void cmsPeliculas_Opening(object sender, CancelEventArgs e)
        {
            this.cmsVer.Enabled = false;
            this.cmsEliminar.Enabled = false;
            if (lvPeliculas.SelectedItems.Count == 1)
            {
                this.cmsVer.Enabled = true;
                this.cmsEliminar.Enabled = true;
            }
        }

        private void cmsNuevo_Click(object sender, EventArgs e)
        {
            crearPelicula();
        }

        private void cmsVer_Click(object sender, EventArgs e)
        {
           /* foreach (ListViewItem item in lvPeliculas.SelectedItems)
            {
                int idItem = (int)item.Tag;
                Pelicula peliculaSeleccionada = cliente.obtenerPelicula(idItem);
                PeliculasFrm infoPelicula = new PeliculasFrm(peliculaSeleccionada);
                if (infoPelicula.ShowDialog() == DialogResult.OK)
                {
                    cliente.actualizarPelicula(peliculaSeleccionada);
                    RefrescarLista();
                }

            }
           */
        }

        private void cmsEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea eliminar el elemento?", "IMPORTANTE",
           MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                //this.cliente.eliminarPelicula((int)this.lvPeliculas.SelectedItems[0].Tag);
            }

            this.RefrescarLista();
        }
    }
}
