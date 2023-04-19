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
    public partial class ProyeccionesFrm : Form
    {
        Proyeccion proyeccion;
        Negocio negocio;
        private ProyeccionesFrm()
        {
            InitializeComponent();
            proyeccion= new Proyeccion();
            negocio = new Negocio();    
        }

        public ProyeccionesFrm (Proyeccion proyeccionB) : this()
        {
            this.proyeccion= proyeccionB;
            //Da igual cual de los valores de la primaryKey sea vacio
            //Con que uno de ellos lo sea, nos sirve
            if (proyeccion.PeliculaId == 0)
            {
                return;
            }

            txtPelicula.Text = ((Pelicula)negocio.BuscarPelicula(proyeccion.PeliculaId)).Nombre;
            txtSala.Text = ((Sesion)negocio.BuscarSesion(proyeccion.SesionId)).Sala;
            txtInicio.Text = proyeccion.Inicio.ToShortDateString();
            txtFin.Text = proyeccion.Fin.Value.ToShortDateString()??" ";
        }

    }
}
