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
    public partial class BuscadorEmpresaFrm : Form
    {
        List<Empresa> listadoEmpresas = new List<Empresa>();
        public Empresa empresaSeleccionada;
        private BuscadorEmpresaFrm()
        {
            InitializeComponent();

        }
        public BuscadorEmpresaFrm(List<Empresa> listEmpresas) : this()
        {
            this.listadoEmpresas = listEmpresas;

            RefrescarLista(listadoEmpresas);
        }



        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            //Separamos cada opc de filtrado por comas ','
            string[] listaFiltrado = txtFiltrado.Text.Split(',');
            List<Empresa> listadoFiltrado = Herramientas.ObtenerEmpresa(listaFiltrado).ToList();
            RefrescarLista(listadoEmpresas);
        }


        //Pasamos por parametro el listado para poder reutilizar codigo
        private void RefrescarLista(List<Empresa> listadoEmpresas)
        {
            //Primero limpiamos el ListView
            lvEmpresas.Items.Clear();


            //Recorremos el array y lo mostramos
            foreach (Empresa empresa in listadoEmpresas)
            {

                ListViewItem item = new ListViewItem(
                    new string[]
                    {
                         empresa.Nombre
                    }
                );

                item.Tag = empresa;
                this.lvEmpresas.Items.Add(item);
            }
        }
    }
}
