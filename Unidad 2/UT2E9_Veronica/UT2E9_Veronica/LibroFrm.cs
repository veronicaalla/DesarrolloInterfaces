using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace UT2E9_Veronica
{
    public partial class LibroFrm : Form
    {
        Libro libro;
        private LibroFrm()
        {
            InitializeComponent();
        }

        public LibroFrm(Libro libroNuevo) : this()
        {
            this.libro = libroNuevo;
            if (libroNuevo.LibroId == 0)
            {
                return;
            }

            txtTitulo.Text = libro.Titulo;
            txtAnno.Text = libro.Anno.ToString();
            txtAutor.Text = libro.Autor;

            DialogResult = DialogResult.Cancel;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                this.libro.Titulo = txtTitulo.Text;
                this.libro.Anno = Int32.Parse(txtAnno.Text);
                this.libro.Autor = txtAutor.Text;

                DialogResult = DialogResult.OK;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }


        //Métodos necesarios para datos correctos
        private void txtAnno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private bool ValidarDatos()
        {

            if (string.IsNullOrEmpty(txtTitulo.Text))
            {
                //mostrarMessageBox("El campo titulo no puede estar vacio");
                MessageBox.Show("El campo titulo no puede estar vacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTitulo.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtAnno.Text))
            {
                MessageBox.Show("El campo fecha no puede estar vacia", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAnno.Focus();
                return false;
            }

            if (!annoMayor())
            {
                MessageBox.Show("El año de publicacion no puede ser mayor al año actual", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAnno.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtAutor.Text))
            {
                MessageBox.Show("El campo autor no puede estar vacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAutor.Focus();
                return false;
            }

            return true;
        }

        private bool annoMayor()
        {

            //Parseamos el valor
            int anno = Int32.Parse(txtAnno.Text);
            //Obtenemos el año actual, para comprobar que no sea mayor
            int annoActual = DateTime.Now.Year;
            if (anno > annoActual)
            {
                return false;
            }

            return true;
        }
    }
}
