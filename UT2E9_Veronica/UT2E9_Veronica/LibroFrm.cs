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
            this.libro.Titulo = txtTitulo.Text;
            this.libro.Anno = Int32.Parse(txtAnno.Text);
            this.libro.Autor = txtAutor.Text;

            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
