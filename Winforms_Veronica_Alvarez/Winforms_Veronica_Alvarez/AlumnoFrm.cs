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
    public partial class AlumnoFrm : Form
    {
        Alumno alumno;
        //La usamos para controlar cuando debemos añadir la fecha nula
        static string FechaNula = "31/12/9998";
        private AlumnoFrm()
        {
            InitializeComponent();
        }

        public AlumnoFrm(Alumno alumno) : this()
        {
            this.alumno = alumno;

            if (alumno.AlumnoId == 0)
            {
                cmbEstudios.SelectedItem = 0;
                dtpComienzo.Value = DateTime.Parse(FechaNula);
                return;
            }

            this.txtNombre.Text = alumno.Nombre;
            this.txtDNI.Text = alumno.DNI;
            this.txtTelefono.Text = alumno.Telefono;
            this.cmbEstudios.SelectedIndex = cmbEstudios.FindString(alumno.Estudios);
            //Empresa


            this.dtpComienzo.Value = alumno.ComienzoPracticas.HasValue ? alumno.ComienzoPracticas.Value: DateTime.Parse(FechaNula);
            if (alumno.SuperaPracticas)
            {
                chkSuperadas.Checked = true;
            }
        }


        //------------- FORMATEAMOS LOS TEXT BOX -------------------
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)

        {
            int pos = txtDNI.SelectionStart;


            // 8 numeros y 1 letra
            if (pos <7 )
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
          
            if (pos == 8)
            {
                if (char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            
        }

        //------------- BOTONES FINALES ------------------
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidaDatos())
            {
                this.alumno.Nombre = txtNombre.Text;
                this.alumno.DNI = txtDNI.Text.ToUpperInvariant();
                this.alumno.Telefono = txtTelefono.Text;
                this.alumno.Estudios = cmbEstudios.Text;
                if (string.IsNullOrEmpty(txtNIFEmpresa.Text))
                {
                    this.alumno.EmpresaId = null;
                }

                if (dtpComienzo.Value == DateTime.Parse(FechaNula))
                {
                    this.alumno.ComienzoPracticas = null;
                }
                else
                {
                    this.alumno.ComienzoPracticas = dtpComienzo.Value;
                }
                if (chkSuperadas.Checked )
                {
                    this.alumno.SuperaPracticas = true;
                }

                DialogResult = DialogResult.OK;
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // METODOS AUXILIARES
        private bool ValidaDatos()
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                txtNombre.Focus();
                MessageBox.Show("El campo nombre es obligadorio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(txtDNI.Text))
            {
                txtDNI.Focus();
                MessageBox.Show("El campo DNI es obligadorio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            Negocio negocio = new Negocio();
            List<Empresa> listadoEmpresas = negocio.BuscarEmpresas().ToList();
            BuscadorEmpresaFrm buscador = new BuscadorEmpresaFrm(listadoEmpresas);

            if (buscador.ShowDialog() == DialogResult.OK)
            {
                Empresa empresa = buscador.empresaSeleccionada;
                txtNIFEmpresa.Text = empresa.NIF;
                txtNombreEmpresa.Text = empresa.Nombre;
            }
            
        }

        private void txtNIFEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            int pos = txtNIFEmpresa.SelectionStart;

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
    }
}
