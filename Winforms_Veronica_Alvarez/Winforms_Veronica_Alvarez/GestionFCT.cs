using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winforms_Veronica_Alvarez
{
    public partial class GestionFCT : Form
    {
        public GestionFCT()
        {
            InitializeComponent();
        }

        //---- MENU ARCHIVO -----
        private void tsmiSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //---- MENU MANTENIMIENTOS -----
        private void tsmiEmpresas_Click(object sender, EventArgs e)
        {
             foreach (Form form in Application.OpenForms)
            {
                if (typeof(ListadoEmpresasFrm) == form.GetType())
                {
                    form.Activate(); //Nos muestra por formulario 
                    return;
                }
            }

            ListadoEmpresasFrm listadoEmpresas = new ListadoEmpresasFrm();
            listadoEmpresas.MdiParent = this;
            listadoEmpresas.Show();
            
        }

        private void tsmiAlumnos_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (typeof(ListadoAlumnosFrm) == form.GetType())
                {
                    form.Activate(); //Nos muestra por formulario 
                    return;
                }
            }

            ListadoAlumnosFrm listadoAlumnos = new ListadoAlumnosFrm();
            listadoAlumnos.MdiParent = this;
            listadoAlumnos.Show();
        }
    }
}
