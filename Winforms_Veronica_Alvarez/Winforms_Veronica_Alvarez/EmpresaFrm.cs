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
    public partial class EmpresaFrm : Form
    {
        Empresa empresa;
        private EmpresaFrm()
        {
            InitializeComponent();
        }
        public EmpresaFrm(Empresa empresa) : this()
        {
            this.empresa = empresa;
            if (empresa.EmpresaId == 0)
            {
                return;
            }
        }

        //CONTROLAMOS EL FORMATO
        private void txtNIF_KeyPress(object sender, KeyPressEventArgs e)
        {
            int pos = txtNIF.SelectionStart;

            if (pos == 0)
            {
                if (char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }

            if (pos > 0)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private bool ValidaDatos()
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                txtNombre.Focus();
                MessageBox.Show("El campo nombre es obligadorio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(txtNIF.Text))
            {
                txtNIF.Focus();
                MessageBox.Show("El campo NIF es obligadorio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                txtTelefono.Focus();
                MessageBox.Show("El campo telefono es obligadorio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidaDatos())
            {
                this.empresa.Nombre = txtNombre.Text;
                this.empresa.NIF = txtNIF.Text;
                this.empresa.Telefono = txtTelefono.Text;
                this.empresa.PersonaContacto = txtPersonaContacto.Text;
                this.empresa.Convenio = dtpConvenio.Value;
                this.empresa.Direccion = txtDireccion.Text;

                DialogResult = DialogResult.OK;
            }
        }
    }
}
