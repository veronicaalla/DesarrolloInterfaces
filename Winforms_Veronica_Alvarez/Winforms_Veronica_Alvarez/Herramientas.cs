using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winforms_Veronica_Alvarez
{
    static class Herramientas
    {
        public static Empresa ObtenerEmpresa (int? empresaId)
        {
            PracticasContext bd = new PracticasContext();
            if (empresaId == null)
            {
                return null;
            }
            return bd.Empresas.FirstOrDefault(x => x.EmpresaId == empresaId);


        }

        public static Empresa ObtenerEmpresa (string nif)
        {
            PracticasContext bd = new PracticasContext();
            return bd.Empresas.FirstOrDefault(x => x.NIF == nif);
        }

        public static Empresa[] ObtenerEmpresa(string[] filtro)
        {
            PracticasContext bd = new PracticasContext();

            Empresa[] listadoEmpresas = new Empresa[filtro.Length];
            

            // bd.Empresas.Where(e=> e.Nombre.Contains(filtro[0]));

            return null;
        }

        public static string ObtenerNombreEmpresa(int? empresaId)
        {
            PracticasContext bd = new PracticasContext();
            if (empresaId == null)
            {
                return " ";
            }
           return bd.Empresas.FirstOrDefault(x => x.EmpresaId == empresaId).Nombre;
        }

    }
}
