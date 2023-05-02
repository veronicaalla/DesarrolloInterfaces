using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniCine_Veronica
{
    public partial class ListadoSesionesFrm : Form
    {
        private Negocio negocio;
        public Sesion sesion;
        public ListadoSesionesFrm()
        {
            InitializeComponent();
            negocio = new Negocio();
            sesion = new Sesion();
            RefrescarLista();

        }


        // MENÚ INICIAL
        private void tsmiNuevaSesion_Click(object sender, EventArgs e)
        {
            NuevaSesion();
        }


        // MENÚ CONTEXTUAL DEL LISTADO
        private void cmsSesiones_Opening(object sender, CancelEventArgs e)
        {
            this.cmsCrear.Enabled = true;
            this.cmsVer.Enabled = false;
            this.cmsBorrar.Enabled = false;
            if (lvSesiones.SelectedItems.Count == 1)
            {
                this.cmsVer.Enabled = true;
                this.cmsBorrar.Enabled = true;
            }
        }

        private void cmsCrear_Click(object sender, EventArgs e)
        {
            NuevaSesion();
        }

        private void cmsVer_Click(object sender, EventArgs e)
        {
            VerSesion();
        }

        private void cmsBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea eliminar el elemento?", "IMPORTANTE",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int idSesion = (int)this.lvSesiones.SelectedItems[0].Tag;
                this.negocio.BorrarSesion(idSesion);
            }
            this.RefrescarLista();
        }

        private void lvSesiones_DoubleClick(object sender, EventArgs e)
        {
            if (lvSesiones.SelectedItems.Count == 1)
            {
                VerSesion();
            }
        }

        // MÉTODOS AUXILIARES
        private void RefrescarLista()
        {
            //Primero limpiamos el ListView
            lvSesiones.Items.Clear();
            this.negocio.obtenerSesiones().ToList();

            //Recorremos el array y lo mostramos
            foreach (Sesion sesion in this.negocio.obtenerSesiones())
            {
                ListViewItem item = new ListViewItem(
                new string[]
                {
                        sesion.Sala,
                        sesion.DiaSemana,
                        sesion.Comienzo.ToShortTimeString(),
                        sesion.FinMax.ToShortTimeString(),
                        sesion.Precio + " €",
                        sesion.Aforo.ToString(),
                }
                );
                item.Tag = sesion.SesionId;
                this.lvSesiones.Items.Add(item);
            }
        }

        private void NuevaSesion()
        {
            Sesion nuevo = new Sesion();
            SesionFrm ventanaSesion = new SesionFrm(nuevo);
            //ventanaCuidador.Show();
            if (ventanaSesion.ShowDialog() == DialogResult.OK)
            {
                negocio.CrearSesion(nuevo);
                RefrescarLista();
            }
        }

        private void VerSesion()
        {
            //En el opening nos hemos asegurado de que solo haya un elemento seleccionado
            //Por lo tanto no nos hace falta hacer un foreach

            //Parsear no es lo mismo que castear, ahora estamos casteando
            int idSesion = (int)this.lvSesiones.SelectedItems[0].Tag;
            Sesion sesionSeleccionada = negocio.BuscarSesion(idSesion);
            SesionFrm infoPelicula = new SesionFrm(sesionSeleccionada);

            if (infoPelicula.ShowDialog() == DialogResult.OK)
            {
                negocio.ModificarSesion(sesionSeleccionada);
                RefrescarLista();
            }
        }

        private void tsmiCuadricula_Click(object sender, EventArgs e)
        {
            Reports.Generador.InformeCuadriculaSesiones();
        }
    }
}
