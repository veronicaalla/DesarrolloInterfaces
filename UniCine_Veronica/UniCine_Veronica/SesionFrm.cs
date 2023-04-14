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

        public SesionFrm(Sesion sesionB):this()
        {
            this.sesion = sesionB;
            if (sesion.SesionId == 0)
            {
                return;
            }
            txtSala.Text = this.sesion.Sala;
            this.txtDiaSemana.Text = sesion.DiaSemana;
            this.txtComienzo.Text = sesion.Comienzo.Hour + ":" + sesion.Comienzo.Minute;
            this.txtFin.Text= sesion.FinMax.Hour + ":" + sesion.FinMax.Minute;
            this.txtPrecio.Text = sesion.Precio + " €";
            this.txtAforo.Text = sesion.Aforo.ToString();
        }
    }
}
