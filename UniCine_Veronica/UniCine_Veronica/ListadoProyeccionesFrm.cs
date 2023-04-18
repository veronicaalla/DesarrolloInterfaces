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
    public partial class ListadoProyeccionesFrm : Form
    {
        private Negocio negocio;
        public ListadoProyeccionesFrm()
        {
            InitializeComponent();
            negocio = new Negocio();
            RefrescarLista();
        }



        //MENU INICIAL
        private void tsmiNueva_Click(object sender, EventArgs e)
        {
            NuevaProyeccion();
        }


        // MENU ASOCIADO AL LIST VIEW
        private void cmsProyecciones_Opening(object sender, CancelEventArgs e)
        {
            this.cmsNueva.Enabled = true;
            this.cmsVer.Enabled = false;
            this.cmsBorrar.Enabled = false;
            if (lvProyecciones.SelectedItems.Count == 1)
            {
                this.cmsVer.Enabled = true;
                this.cmsBorrar.Enabled = true;
            }
        }

        private void cmsNueva_Click(object sender, EventArgs e)
        {
            NuevaProyeccion();
        }

        private void cmsVer_Click(object sender, EventArgs e)
        {
            VerProyeccion();
        }

        private void cmsBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea eliminar el elemento?", "IMPORTANTE",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                //int idProyeccion = (int)this.lvProyecciones.SelectedItems[0].Tag;
                // this.negocio.BorrarProyeccion(    );
            }
            this.RefrescarLista();
        }

        private void lvProyecciones_DoubleClick(object sender, EventArgs e)
        {
            if (lvProyecciones.SelectedItems.Count == 1)
            {
                VerProyeccion();
            }
        }

        // MÉTODOS AUXILIARES

        private void RefrescarLista()
        {
            //Primero limpiamos el ListView
            lvProyecciones.Items.Clear();
            this.negocio.obtenerProyecciones().ToList();

            //Recorremos el array y lo mostramos
            foreach (Proyeccion proyeccion in this.negocio.obtenerProyecciones())
            {
                ListViewItem item = new ListViewItem(
                new string[]
                {
                        ((Pelicula)negocio.BuscarPelicula(proyeccion.PeliculaId)).Nombre,
                        ((Sesion)negocio.BuscarSesion(proyeccion.SesionId)).Sala,
                        proyeccion.Inicio.ToShortDateString(),
                        proyeccion.Fin.Value.ToShortDateString() ?? "  "
                }                                                   
                ) ;
                item.Tag = proyeccion.PeliculaId+ " " +proyeccion.SesionId + " "+ proyeccion.Inicio;
                this.lvProyecciones.Items.Add(item);
            }
        }


        private void NuevaProyeccion()
        {/*
            Proyeccion nuevo = new Proyeccion();
            ProyeccionesFrm ventanaProyeccion = new ProyeccionesFrm(nuevo);
            if (ventanaProyeccion.ShowDialog() == DialogResult.OK)
            {
                negocio.CrearProyeccion(nuevo);
                RefrescarLista();
            }*/
        }

        private void VerProyeccion()
        {/*
            //En el opening nos hemos asegurado de que solo haya un elemento seleccionado
            //Por lo tanto no nos hace falta hacer un foreach

            //Parsear no es lo mismo que castear, ahora estamos casteando
            int idPelicula = (int)this.lvProyecciones.SelectedItems[0].Tag;
            Proyeccion proyeccionSeleccionada = negocio.BuscarProyeccion(idPelicula, idSesion, fecha);
            ProyeccionesFrm infoProyeccion = new ProyeccionesFrm(proyeccionSeleccionada);

            if (infoProyeccion.ShowDialog() == DialogResult.OK)
            {
                //negocio.ModificarProyeccion(proyeccionSeleccionada);
                RefrescarLista();
            }*/
        }
    }
}
