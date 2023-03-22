using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TorreCine
{
    public partial class DatosDesarrolladorFrm : Form
    {
        public DatosDesarrolladorFrm()
        {
            InitializeComponent();
            txtNombre.Text = "Veronica";
            txtApellidos.Text = "Álvarez Lavin";
            txtTelefono.Text = string.Empty;
            txtEmail.Text = "veronica.alvarezlavin@iesmiguelherrero.es";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
