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
    public partial class Resumen : Form
    {
        private Resumen()
        {
            InitializeComponent();
        }
        public Resumen (Socio socio) : this()
        {
            lblNombre.Text = socio.Nombre;
            lblNacimiento.Text = socio.FechaNacimiento.ToString();
            lblSexo.Text = socio.Sexo;
            lblAficiones.Text = socio.Aficiones;
            txtOtrasAficiones.Text = socio.OtrasAficiones;
            lblSituación.Text = socio.Situación;
        }
    }
}
