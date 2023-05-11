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

namespace Winforms_Veronica_Alvarez
{
    public partial class ListadoAlumnosFrm : Form
    {
        private Negocio negocio;
        public ListadoAlumnosFrm()
        {
            InitializeComponent();
            negocio = new Negocio();
            RefrescarLista();
        }

       
        //MENU INICIAL
        private void tsmiCrear_Click(object sender, EventArgs e)
        {
            NuevoAlumno();
        }
        // MENU CONTEXTUAL DEL LISTVIEW ALUMNOS
        private void cmsAlumnos_Opening(object sender, CancelEventArgs e)
        {
            this.cmsCrear.Enabled = true;
            this.cmsVer.Enabled = false;
            this.cmsEliminar.Enabled = false;
            if (lvAlumnos.SelectedItems.Count == 1)
            {
                this.cmsVer.Enabled = true;
                this.cmsEliminar.Enabled = true;
            }
        }

        private void cmsCrear_Click(object sender, EventArgs e)
        {
            NuevoAlumno();
        }


        private void cmsVer_Click(object sender, EventArgs e)
        {
            VerAlumno();
        }

        private void cmsEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Seguro que desea eliminar el elemento?", "IMPORTANTE",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Alumno alumno = (Alumno)this.lvAlumnos.SelectedItems[0].Tag;
                    this.negocio.Borrar(alumno);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.RefrescarLista();
        }
        private void lvAlumnos_DoubleClick(object sender, EventArgs e)
        {

            if (lvAlumnos.SelectedItems.Count == 1)
            {
                VerAlumno();
            }
        }

        //------------ METODOS AUXILIARES -----------------
        private void RefrescarLista()
        {
            //Primero limpiamos el ListView
            lvAlumnos.Items.Clear();
            this.negocio.BuscarAlumnos().ToList();

            //Recorremos el array y lo mostramos
            foreach (Alumno alumno in this.negocio.BuscarAlumnos())
            {
                ListViewItem item = new ListViewItem(
                    new string[]
                    {
                         alumno.DNI,
                         alumno.Nombre,
                         alumno.EmpresaId.HasValue?Herramientas.ObtenerEmpresa(alumno.EmpresaId).Nombre:" ",
                         //Controlamos que la fecha pueda ser nula
                         alumno.ComienzoPracticas.HasValue?alumno.ComienzoPracticas.Value.ToShortDateString(): " ",

                    }
                );

                item.Tag = alumno;
                this.lvAlumnos.Items.Add(item);
            }
        }


        private void NuevoAlumno()
        {
            Alumno nuevo = new Alumno();
            AlumnoFrm ventanaAlumno = new AlumnoFrm(nuevo);
            //ventanaCuidador.Show();
            if (ventanaAlumno.ShowDialog() == DialogResult.OK)
            {
                negocio.Crear(nuevo);
                RefrescarLista();
            }
        }


        private void VerAlumno()
        {
            Alumno alumnoSelecionado = (Alumno)this.lvAlumnos.SelectedItems[0].Tag;
            
            AlumnoFrm infoAlumno = new AlumnoFrm(alumnoSelecionado);

                if (infoAlumno.ShowDialog() == DialogResult.OK)
                {
                    negocio.Actualizar(alumnoSelecionado);
                    RefrescarLista();
                }
            
        }

       
    }
}
