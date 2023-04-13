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
    public partial class ListadoSesionesFrm : Form
    {
        private Negocio negocio;
        public ListadoSesionesFrm()
        {
            InitializeComponent();
            RefrescarLista();
            negocio = new Negocio();
        }


        // MENÚ INICIAL
        private void tsmiNuevaSesion_Click(object sender, EventArgs e)
        {
            NuevaSesion();
        }


        // MENÚ CONTEXTUAL DEL LISTADO
        private void tsmiCrear_Click(object sender, EventArgs e)
        {
            NuevaSesion();
        }

        private void tsmiVer_Click(object sender, EventArgs e)
        {
            VerSesion();
        }

        private void tsmiBorrar_Click(object sender, EventArgs e)
        {

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
                //String esCuidador = "No";
                //if (sesion.Responsable) { esCuidador = "Si"; };

                ListViewItem item = new ListViewItem(
                    new string[]
                    {
                        sesion.Sala,
                        sesion.DiaSemana,
                        sesion.Comienzo.ToString(),
                        sesion.FinMax.ToString(),
                        sesion.Precio.ToString(),
                        sesion.Aforo.ToString(),

                    }
                );
                item.Tag = sesion.SesionId; ;
                this.lvSesiones.Items.Add(item);
            }
        }

        private void NuevaSesion()
        {
            Sesion nuevo = new Sesion();
            SesionesFrm ventanaSesion = new SesionesFrm(nuevo);
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
            SesionesFrm infoPelicula = new SesionesFrm(sesionSeleccionada);

            if (infoPelicula.ShowDialog() == DialogResult.OK)
            {
                negocio.ModificarSesion(sesionSeleccionada);
                RefrescarLista();
            }
        }

       
    }
}
