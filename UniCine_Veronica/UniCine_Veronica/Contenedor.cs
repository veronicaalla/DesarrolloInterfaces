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
    public partial class Contenedor : Form
    {
        public Contenedor()
        {
            InitializeComponent();
        }

        // MENÚ ARCHIVOS
        private void tsmiDatosDesarrollador_Click(object sender, EventArgs e)
        {

            
                DatosDesarrolladorFrm infoDesarrollador = new DatosDesarrolladorFrm();
                infoDesarrollador.MdiParent = this;
                infoDesarrollador.Show();
            


        }

        private void tsmiSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // MENÚ MANTENIMIENTO
        private void tsmiPeliculas_Click(object sender, EventArgs e)
        {
            
                ListadoPeliculasFrm listadoPeliculas = new ListadoPeliculasFrm();
                listadoPeliculas.MdiParent = this;
                listadoPeliculas.Show();
            
        }

        private void tsmiSesiones_Click(object sender, EventArgs e)
        {
            
                ListadoSesionesFrm listadoSesiones = new ListadoSesionesFrm();
                listadoSesiones.MdiParent = this;
                listadoSesiones.Show();
            
        }

        private void tsmiProyecciones_Click(object sender, EventArgs e)
        {
            
                ListadoProyeccionesFrm listadoProyecciones = new ListadoProyeccionesFrm();
                listadoProyecciones.MdiParent = this;
                listadoProyecciones.Show();
            
        }

        // MENÚ VENTANAS
        private void tsmiCascada_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void tsmiHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tsmiVertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        //Método auxiliar
        public bool mostrar()
        {
            foreach (Form form in Application.OpenForms)
            {
                if (typeof(DatosDesarrolladorFrm) == form.GetType())
                {
                    form.Activate(); //Nos muestra por formulario 
                    return false;
                }
            }
            return true;
        }
    }
}
