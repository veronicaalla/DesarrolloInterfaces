using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace UniCine_Veronica
{
    public partial class ListadoProyeccionesFrm : Form
    {
        private Negocio negocio;
        //Dictionary<string, string> clavesProyecciones;
        public ListadoProyeccionesFrm()
        {
            InitializeComponent();
            negocio = new Negocio();
            //clavesProyecciones = new Dictionary<string, string>();
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
                //clavesProyecciones = new  Dictionary<string, string>();
                ListViewItem item = new ListViewItem(

                new string[]
                {
                    ((Pelicula)negocio.BuscarPelicula(proyeccion.PeliculaId)).Nombre ,
                    ((Sesion)negocio.BuscarSesion(proyeccion.SesionId)).Sala ,
                    ((Sesion)negocio.BuscarSesion(proyeccion.SesionId)).DiaSemana,
                    proyeccion.Inicio.ToShortDateString(),
                    ((Sesion)negocio.BuscarSesion(proyeccion.SesionId)).Comienzo.ToShortTimeString(),
                    //para controlar si la fecha es nula
                    proyeccion.Fin.HasValue?proyeccion.Fin.Value.ToShortDateString() :" ",
                    ((Sesion)negocio.BuscarSesion(proyeccion.SesionId)).FinMax.ToShortTimeString(),

                }
                );
                #region Prueba dictionary
                /*
                Dictionary<string, string> clavesProyecciones;
                item.Tag = (clavesProyecciones = new Dictionary<string, string>());
                clavesProyecciones.Add("Pelicula", proyeccion.PeliculaId.ToString());
                clavesProyecciones.Add("Sesion", proyeccion.SesionId.ToString());
                clavesProyecciones.Add("Fecha", proyeccion.Inicio.ToString());
                */
                #endregion

                item.Tag = proyeccion.PeliculaId + " " + proyeccion.SesionId + " " + proyeccion.Inicio;
                this.lvProyecciones.Items.Add(item);
            }
        }


        private void NuevaProyeccion()
        {
            try { 
            Proyeccion nuevo = new Proyeccion();
            ProyeccionesFrm ventanaProyeccion = new ProyeccionesFrm(nuevo);
            if (ventanaProyeccion.ShowDialog() == DialogResult.OK)
            {
                negocio.CrearProyeccion(nuevo);
                RefrescarLista();
            }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VerProyeccion()
        {
            try
            {
                //En el opening nos hemos asegurado de que solo haya un elemento seleccionado
                //Por lo tanto no nos hace falta hacer un foreach;

                string[] claves = ((string)this.lvProyecciones.SelectedItems[0].Tag).Split(' ');

                Proyeccion proyeccionSeleccionada = negocio.BuscarProyeccion(Int32.Parse(claves[0]), Int32.Parse(claves[1]), DateTime.Parse(claves[2]));

                #region prueba de dictionary
                //Proyeccion proyeccionSeleccionada = negocio.BuscarProyeccion(Int32.Parse(clavesProyecciones["Pelicula"]), Int32.Parse(clavesProyecciones["Sesion"]), DateTime.Parse(clavesProyecciones["Fecha"]));
                //Proyeccion proyeccionSeleccionada = negocio.BuscarProyeccion(Tag.)
                #endregion
                ProyeccionesFrm infoProyeccion = new ProyeccionesFrm(proyeccionSeleccionada);

                if (infoProyeccion.ShowDialog() == DialogResult.OK)
                {
                    negocio.ModificarProyeccion(proyeccionSeleccionada);
                    RefrescarLista();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #region Dictionary
            /*Probar hacerlo mediante Dictionary
             * //inicialización y crear a valores
              Dictionary<string, string> comunidadesCapitales = new Dictionary<string, string>()
              {
                    {"Aragon", "Zaragoza"},
                    {"Navarra", "Pamplona"}
                };
            comunidadesCapitales.Add("Castilla la mancha", "Toledo");
            Console.WriteLine(comunidadesCapitales["Aragon"]); //devuelve Zaragoza
            */
            #endregion
        }
    }
}
