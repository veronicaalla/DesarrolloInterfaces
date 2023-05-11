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
    public partial class ListadoEmpresasFrm : Form
    {
        Negocio negocio;
        public ListadoEmpresasFrm()
        {
            InitializeComponent();
            negocio = new Negocio();
            RefrescarLista();
        }

       

        //MENU PRINCIPAL
        private void tsmiCrear_Click(object sender, EventArgs e)
        {
            CrearEmpresa();
        }

        // MENU CONTEXTUAL DEL LISTVIEW 
        private void cmsEmpresas_Opening(object sender, CancelEventArgs e)
        {
            this.cmsCrear.Enabled = true;
            this.cmsVer.Enabled = false;
            this.cmsEliminar.Enabled = false;
            if (lvEmpresas.SelectedItems.Count == 1)
            {
                this.cmsVer.Enabled = true;
                this.cmsEliminar.Enabled = true;
            }
        }
        private void cmsCrear_Click(object sender, EventArgs e)
        {
            CrearEmpresa();
        }

        private void cmsVer_Click(object sender, EventArgs e)
        {
            VerEmpresa();
        }

        private void cmsEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Seguro que desea eliminar el elemento?", "IMPORTANTE",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Empresa empresa = (Empresa)this.lvEmpresas.SelectedItems[0].Tag;
                    this.negocio.Borrar(empresa);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.RefrescarLista();
        }

        private void lvEmpresas_DoubleClick(object sender, EventArgs e)
        {
            if (lvEmpresas.SelectedItems.Count == 1)
            {
                VerEmpresa();
            }
        }

        //METODOS AUXILIARES
        private void RefrescarLista()
        {
            //Primero limpiamos el ListView
            lvEmpresas.Items.Clear();
            this.negocio.BuscarEmpresas().ToList();

            //Recorremos el array y lo mostramos
            foreach (Empresa empresa in this.negocio.BuscarEmpresas())
            {

                ListViewItem item = new ListViewItem(
                    new string[]
                    {
                         empresa.Nombre,
                         empresa.Telefono,
                         empresa.PersonaContacto
                    }
                ) ;

                item.Tag = empresa;
                this.lvEmpresas.Items.Add(item);
            }
        }
        private void CrearEmpresa()
        {
            Empresa nueva = new Empresa();
            EmpresaFrm ventanaEmpresa = new EmpresaFrm(nueva);
            //ventanaCuidador.Show();
            if (ventanaEmpresa.ShowDialog() == DialogResult.OK)
            {
                negocio.Crear(nueva);
                RefrescarLista();
            }
        }
        private void VerEmpresa()
        {
            Empresa empresaSeleccionada = (Empresa)this.lvEmpresas.SelectedItems[0].Tag;

            EmpresaFrm infoEmpresa = new EmpresaFrm(empresaSeleccionada);

            if (infoEmpresa.ShowDialog() == DialogResult.OK)
            {
                negocio.Actualizar(empresaSeleccionada);
                RefrescarLista();
            }
        }
    }
}
