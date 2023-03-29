using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UT2E9_Veronica
{
    public partial class PeliculaFrm : Form
    {
        private PeliculaFrm()
        {
            InitializeComponent();
        }

        public PeliculaFrm(Pelicula pelicula):this()
        {
            if (pelicula.PeliculaId == 0)
            {
                //Le tenemos que asignar id o al guardarse se le asigna solo?
                return;
            }
            this.txtTitulo.Text = pelicula.Titulo;
            this.txtAño.Text = pelicula.Anno.ToString();
            this.txtGenero.Text = pelicula.Genero;
        }
    }
}
