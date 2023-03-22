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
            txtAficciones.Enabled = false;
        }

        //Vaciamos todos los campos
        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = string.Empty;
            dtpNacimiento.Text = string.Empty; //Vuelve a la fecha por defecto
            txtAficciones.Text = string.Empty;
            VaciarAficines();
            ReiniciarSexo();
            //Como hago para el comboBox
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validaciones())
            {
                socio.Nombre = txtNombre.Text;
                socio.FechaNacimiento = dtpNacimiento.Value;
                socio.Sexo = sexo;
                socio.Aficiones = aficiones;
                socio.OtrasAficiones = txtAficciones.Text;
                socio.Situación = cmbSituacion.Text;

                Resumen resumen = new Resumen(socio);
                if (resumen.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Se han confirmado los datos", "", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("No se han confirmado los datos", "", MessageBoxButtons.OK);
                }
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

        private void chkOtros_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOtros.Checked)
            {
                txtAficciones.Enabled = true;
            }
            else
            {
                txtAficciones.Text = string.Empty;
                txtAficciones.Enabled = false;
            }
        }

        private void VaciarAficines()
        {
            chkDeportes.Checked = false;
            chkMusica.Checked = false;
            chkLectura.Checked = false;
            chkOtros.Checked = false;
        }
        private void ReiniciarSexo()
        {
            rbHombre.Checked = true;
            rbMujer.Checked = false;
            rbOtros.Checked = false;
        }

    }
}
