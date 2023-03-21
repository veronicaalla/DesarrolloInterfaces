using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UT2E2_Veronica
{
    public partial class FichaSocio : Form
    {
        private Socio socio;
        private string aficiones;
        private string otrasAficiones;
        private string sexo;

        public FichaSocio()
        {
            InitializeComponent();
            socio = new Socio();
        }

        //Vaciamos todos los campos
        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = string.Empty;
            dtpNacimiento.Text = string.Empty; //Vuelve a la fecha por defecto
            cmbSituacion.Text = string.Empty;
            txtAficciones.Text = string.Empty;

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validaciones())
            {
                socio.Nombre = txtNombre.Text;
                socio.FechaNacimiento = dtpNacimiento.Value;
                socio.Sexo = sexo;
                socio.Aficiones = aficiones;
                socio.OtrasAficiones = otrasAficiones;
                socio.Situación = txtAficciones.Text;

                Resumen resumen = new Resumen(socio);
                resumen.ShowDialog();
            }
        }

        private bool Validaciones()
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("El nombre no puede estar vacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(cmbSituacion.Text))
            {
                MessageBox.Show("La situacion no puede estar vacia", "ERROR" ,MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbSituacion.Focus();
                return false;
            }
            return true;
        }

        private void rbSexo_CheckedChanged(object sender, EventArgs e)
        {
           RadioButton rb = (RadioButton)sender;
            sexo = rb.Text;
        }
    }
}
