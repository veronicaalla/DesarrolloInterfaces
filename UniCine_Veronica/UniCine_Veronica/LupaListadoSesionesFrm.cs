using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniCine_Veronica
{
    public partial class LupaListadoSesionesFrm : Form
    {
        private Negocio negocio;
        public Sesion sesion;
        public LupaListadoSesionesFrm()
        {
            InitializeComponent();
            negocio = new Negocio();
            sesion = new Sesion();

            //DAmos valores por defecto a los comboBox
            cmbDia.SelectedIndex = 0;
            cmbSala .SelectedIndex = 0;

            //Cargamos los valores iniciales en el lv
            RefrescarLista(negocio.obtenerSesiones().ToList<Sesion>());
        }

        private void lvSesiones_DoubleClick(object sender, EventArgs e)
        {
            int idSesion = (int)this.lvSesiones.SelectedItems[0].Tag;
            Sesion sesionSeleccionada = negocio.BuscarSesion(idSesion);
            this.sesion = sesionSeleccionada;
            DialogResult = DialogResult.OK;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string filtroDia = cmbDia.GetItemText(cmbDia.SelectedItem);
            string filtroSala = cmbSala.GetItemText(cmbSala.SelectedItem);
           List<Sesion> listaSesiones = Herramientas.ObtenerSesionesFiltrado(filtroDia, filtroSala);
            RefrescarLista(listaSesiones);
          
        }

        //Métodos auxiliares
        private void RefrescarLista(List<Sesion> listaSesiones)
        {
            //Primero limpiamos el ListView
            lvSesiones.Items.Clear();

            //Recorremos la lista y  mostramos
            foreach (Sesion sesion in listaSesiones)
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
    }
}
