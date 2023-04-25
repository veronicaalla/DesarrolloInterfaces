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
    public partial class SesionFrm : Form
    {

        Sesion sesion;
        private SesionFrm()
        {
            InitializeComponent();
            sesion = new Sesion();
        }

        public SesionFrm(Sesion sesionB) : this()
        {
            this.sesion = sesionB;
            if (sesion.SesionId == 0)
            {
                //Damos valores por defecto a los cmb
                cmbSala.SelectedIndex = 0;
                cmbDiaSemana.SelectedIndex = 0;
                return;
            }
            this.cmbSala.SelectedIndex = this.cmbSala.FindString(sesion.Sala);
            this.cmbDiaSemana.SelectedIndex = this.cmbDiaSemana.FindString(sesion.DiaSemana);
            this.dtpComienzo.Value = sesion.Comienzo;
            this.dtpFin.Value = sesion.FinMax;
            this.txtPrecio.Text = sesion.Precio.ToString();
            this.txtAforo.Text = sesion.Aforo.ToString();
        }

        //Determinamos el formato de Precio y Aforo
        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // Permitimos solamente una coma
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }

        }

        private void txtAforo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidadDatos())
            {
                this.sesion.Sala = cmbSala.Text;
                this.sesion.DiaSemana = cmbDiaSemana.Text;
                this.sesion.Comienzo = dtpComienzo.Value;
                this.sesion.FinMax = dtpFin.Value;
                this.sesion.Precio = float.Parse(txtPrecio.Text);
                this.sesion.Aforo = int.Parse(txtAforo.Text);

                DialogResult = DialogResult.OK;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool ValidadDatos()
        {
            if (string.IsNullOrEmpty(txtPrecio.Text))
            {
                txtPrecio.Focus();
                MessageBox.Show("El campo precio no puede estar vacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(txtAforo.Text))
            {
                txtAforo.Focus();
                MessageBox.Show("El campo aforo no puede estar vacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
            return true;
        }


    }
}
