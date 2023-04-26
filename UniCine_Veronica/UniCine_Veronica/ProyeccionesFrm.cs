using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
                #region fecha con TextBox
                //---fecha inicio----
                txtInicio.Text = "dd/mm/yyyy";
                txtInicio.ForeColor = Color.Gray;
                //---fecha fin----
                txtFin.Text = "dd/mm/yyyy";
                txtFin.ForeColor = Color.Gray;
                #endregion

        
                return;

            }

            txtPelicula.Text = ((Pelicula)negocio.BuscarPelicula(this.proyeccion.PeliculaId)).Nombre;
            //string sala = ((Sesion)negocio.BuscarSesion(this.proyeccion.SesionId)).Sala;
            //cmbSala.SelectedIndex = cmbSala.FindString(((Sesion)negocio.BuscarSesion(this.proyeccion.SesionId)).Sala);
            Sesion sesion = negocio.BuscarSesion(this.proyeccion.SesionId);
            txtSesion.Text = sesion.Sala + "\t" + sesion.DiaSemana + 
                "\r\nInicio:" + sesion.Comienzo.ToShortTimeString() + "\tFin" + sesion.FinMax.ToShortTimeString();
            txtInicio.Text = this.proyeccion.Inicio.ToShortDateString();
            //dtpFin.Value = (DateTime)(proyeccion.Fin.HasValue?this.proyeccion.Fin:null);
            txtFin.Text = this.proyeccion.Fin.HasValue?this.proyeccion.Fin.Value.ToShortDateString(): "dd/mm/yyyy";
            if (txtFin.Text== "dd/mm/yyyy")
            {
                txtFin.ForeColor = Color.Gray;
            }

            
        }

        #region FechaInicio en TextBox
        #region pijada -> Fechas en TextBox
        //------Fecha inicio-----
        //Método para cuandoe el TextBox está seleccionado
        private void txtInicio_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (txtInicio.Text.Equals("dd/mm/yyyy"))
            {
                txtInicio.Text = string.Empty;
                txtInicio.ForeColor = Color.Black;
            }
        }
        //Método para cuando el textBox se acaba de desseleccionar
        private void txtInicio_Leave(object sender, EventArgs e)
        {
            if (txtInicio.Text == string.Empty)
            {
                txtInicio.Text = "dd/mm/yyyy";
                txtInicio.ForeColor = Color.Gray;
            }
        }

        //-----Fecha Fin -----
        private void txtFin_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (txtFin.Text.Equals("dd/mm/yyyy"))
            {
                txtFin.Text = string.Empty;
                txtFin.ForeColor = Color.Black;
            }
        }

        private void txtFin_Leave(object sender, EventArgs e)
        {
            if (txtFin.Text == string.Empty)
            {
                txtFin.Text = "dd/mm/yyyy";
                txtFin.ForeColor = Color.Gray;
            }
        }
        #endregion

        //¿COMO FORMATEAR TEXTBOX PARA QUE SALGA CON FORMATO DE FECHA?
        private void txtInicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '/'))
            {
                e.Handled = true;
            }
            // Si el carácter presionado es una barra, verificamos la posición actual del cursor en el TextBox
            else if (e.KeyChar != '/')
            {
                // Obtenemos la posición actual del cursor en el TextBox
                int pos = txtInicio.SelectionStart;

                // Verificamos si la posición actual del cursor es la adecuada para agregar una barra
                if (pos == 2 || pos == 5)
                {
                    // Agregamos la barra al texto del TextBox y movemos el cursor a la posición siguiente
                    txtInicio.Text = txtInicio.Text.Insert(pos, "/");
                    txtInicio.SelectionStart = pos + 1;
                }
            }


        }

        private void txtFin_KeyPress(object sender, KeyPressEventArgs e)
        {
         

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '/'))
            {
                e.Handled = true;
            }
            // Si el carácter presionado es una barra, verificamos la posición actual del cursor en el TextBox
            else if (e.KeyChar != '/')
            {
                // Obtenemos la posición actual del cursor en el TextBox
                int pos = txtFin.SelectionStart;

                // Verificamos si la posición actual del cursor es la adecuada para agregar una barra
                if (pos == 2 || pos == 5)
                {
                    // Agregamos la barra al texto del TextBox y movemos el cursor a la posición siguiente
                    txtFin.Text = txtFin.Text.Insert(pos, "/");
                    txtFin.SelectionStart = pos + 1;
                }
            }
           
            
            
        }
        #endregion


        private void btnAcpetar_Click(object sender, EventArgs e)
        {
            if (ValidaDatos())
            {
                this.proyeccion.PeliculaId = negocio.buscarPeliculaPorNombre(txtPelicula.Text).PeliculaId;
                //Como hago lo de sala?

                this.proyeccion.Inicio = DateTime.Parse(txtInicio.Text);
                if (txtFin.Text != "dd/mm/yyyy")
                {
                    this.proyeccion.Fin = DateTime.Parse(txtFin.Text) ;
                }
                

                DialogResult = DialogResult.OK;
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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

            #region Si Inicio seria TextBox
            
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
            #endregion

            return true;
        }

        private void lupa_Click(object sender, EventArgs e)
        {
            LupaPeliculaFrm buscarPelicula = new LupaPeliculaFrm();
            
            if (buscarPelicula.ShowDialog() ==DialogResult.OK)
            {
                txtPelicula.Text = buscarPelicula.nombrePelicula;
            }
        }

        private void lupaSala_Click(object sender, EventArgs e)
        {
            ListadoSesionesFrm listadoSesiones = new ListadoSesionesFrm();
            if (listadoSesiones.ShowDialog() == DialogResult.OK)
            {
                Sesion sesionElegida = listadoSesiones.sesion;
                txtSesion.Text = sesionElegida.Sala + "\t" + sesionElegida.DiaSemana +
                    "\r\nInicio:" + sesionElegida.Comienzo.ToShortTimeString() + "\tFin" + sesionElegida.FinMax.ToShortTimeString();
            }
        }
    }
}
