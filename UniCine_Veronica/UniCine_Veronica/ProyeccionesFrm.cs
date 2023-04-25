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
        DateTime fechaInicio;
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
                txtInicio.Text = "dd/mm/yyyy";
                txtInicio.ForeColor = Color.Gray;
                return;

            }

            txtPelicula.Text = ((Pelicula)negocio.BuscarPelicula(this.proyeccion.PeliculaId)).Nombre;
            txtSala.Text = ((Sesion)negocio.BuscarSesion(this.proyeccion.SesionId)).Sala;
            txtInicio.Text = this.proyeccion.Inicio.ToShortDateString();
            txtFin.Text = this.proyeccion.Fin.HasValue?this.proyeccion.Fin.Value.ToShortDateString():" ";

            
        }

        #region pijada
        private void txtInicio_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (txtInicio.Text.Equals("dd/mm/yyyy"))
            {
                txtInicio.Text = string.Empty;
                txtInicio.ForeColor = Color.Black;
            }
        }
        #endregion

        private void txtInicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '/'))
            {
                e.Handled = true;
            }
        }

        public bool ValidaDatos()
        {
            if (string.IsNullOrEmpty(txtPelicula.Text))
            {
                txtPelicula.Focus();
                MessageBox.Show("La pelicula no puede estar vacia", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
            Pelicula pelicula= negocio.buscarPeliculaPorNombre(txtPelicula.Text);

            if (pelicula ==null)
            {
                txtPelicula.Focus();
                MessageBox.Show("La pelicula indicada, no existe", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(txtSala.Text))
            {
                txtSala.Focus();
                MessageBox.Show("La sala no puede estar vacia", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
            /*foreach (Sesion s in negocio.obtenerSesiones())
            {
                if (s.Sala == txtSala.Text)
                {
                    break; 
                }

                MessageBox.Show("La sala indicada no existe", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }*/

            if (string.IsNullOrEmpty(txtInicio.Text))
            {
                txtInicio.Focus();
                MessageBox.Show("La fecha de inicio no puede estar vacia", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            
            if (!DateTime.TryParse(txtInicio.Text, out fechaInicio))
            {
                txtInicio.Focus();
                MessageBox.Show("El formato de la fecha es incorrecto \"dd/mm/yyyy\"", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }


    }
}
