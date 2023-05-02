using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniCine_Veronica.Reports
{
    internal class Generador
    {
        Negocio negocio = new Negocio();
        static string ruta = "UniCine_Veronica.Reports.";

        public static void InformeFichaPelicula(int idPelicula)
        {
            //Instanciamos el formulario de visor 
            VisorInforme visor = new VisorInforme();
            //Al informe, le asignamos una plantilla
            visor.rpvVisorInforme.LocalReport.ReportEmbeddedResource = ruta + "rptInformeFichaPelicula.rdlc";

            UniCineContext db = new UniCineContext();

            string consultaSql1 = $"SELECT p.* FROM Peliculas as p Where p.PeliculaId={idPelicula};";
            List<Pelicula> resultado1 = db.Database.SqlQuery<Pelicula>(consultaSql1, new object[0]).ToList();

            ReportDataSource fuenteDatosInf1Pelicula = new ReportDataSource("DataSetInformeFichaPelicula_PeliculaWr", resultado1);
            visor.rpvVisorInforme.LocalReport.DataSources.Add(fuenteDatosInf1Pelicula);

            string consultaSql2 = "SELECT pr.Inicio,pr.Fin , s.DiaSemana,s.Comienzo,s.Sala,s.Precio" +
                " FROM Proyecciones as pr, Peliculas as p, Sesiones as s" +
                " Where pr.PeliculaId=p.PeliculaId " +
                "AND pr.SesionId=s.SesionId " +
                $"AND p.PeliculaId={idPelicula};";

            List<InformeFichaPeliculaWr> resultado2 = db.Database.SqlQuery<InformeFichaPeliculaWr>(consultaSql2, new object[0]).ToList();

            ReportDataSource fuenteDatosInf1Wr = new ReportDataSource("DataSetInformeFichaPelicula_SesionWr", resultado2);
            visor.rpvVisorInforme.LocalReport.DataSources.Add(fuenteDatosInf1Wr);


            visor.rpvVisorInforme.SetDisplayMode(DisplayMode.PrintLayout);
            visor.rpvVisorInforme.RefreshReport();
            //mostramos visor
            visor.Show();
        }


        public static void InformeCuadriculaSesiones()
        {
            //Instanciamos el formulario de visor 
            VisorInforme visor = new VisorInforme();
            visor.rpvVisorInforme.LocalReport.ReportEmbeddedResource = ruta + "rptInformeCuadriculaSesiones.rdlc";

            UniCineContext db = new UniCineContext();

            string consultaSql = "SELECT [DiaSemana], [Sala], [Comienzo], [FinMax] " +
                "FROM [UniCine].[dbo].[Sesiones] ORDER BY CASE [DiaSemana] " +
                "WHEN 'Lunes' THEN 1 WHEN 'Martes' THEN 2 WHEN 'Miércoles' THEN 3 WHEN 'Jueves' THEN 4 WHEN 'Viernes' " +
                "THEN 5 WHEN 'Sábado' THEN 6 WHEN 'Domingo' THEN 7 END, " +
                "[Comienzo]";
            List<InformeCuadriculaSesionesWr> resultado1 = db.Database.SqlQuery<InformeCuadriculaSesionesWr>(consultaSql, new object[0]).ToList();

            ReportDataSource fuenteDatosInf2 = new ReportDataSource("DataSetInformeCuadriculaSesionesWr", resultado1);
            visor.rpvVisorInforme.LocalReport.DataSources.Add(fuenteDatosInf2);

            visor.rpvVisorInforme.SetDisplayMode(DisplayMode.PrintLayout);
            visor.rpvVisorInforme.RefreshReport();
            visor.Show();
        }

        public static void InformeCartelera(DateTime fecha)
        {
            //Instanciamos el formulario de visor 
            VisorInforme visor = new VisorInforme();
            visor.rpvVisorInforme.LocalReport.ReportEmbeddedResource = ruta + "rptInformeCartelera.rdlc";

            UniCineContext db = new UniCineContext();
            string consultaSql = "";

            List<InformeCarteleraWr> resultado = db.Database.SqlQuery<InformeCarteleraWr>(consultaSql, new object[0]).ToList();

            ReportDataSource fuenteDatos = new ReportDataSource("DataSetInformeCarteleraWr", resultado);
            visor.rpvVisorInforme.LocalReport.DataSources.Add(fuenteDatos);

            visor.rpvVisorInforme.SetDisplayMode(DisplayMode.PrintLayout);
            visor.rpvVisorInforme.RefreshReport();
            visor.Show();


        }

        public static void InformeCatalogoPeliculas(string genero) {
            //Instanciamos el formulario de visor 
            VisorInforme visor = new VisorInforme();
            visor.rpvVisorInforme.LocalReport.ReportEmbeddedResource = ruta + "rptInformeCatalogoPeliculas.rdlc";

            UniCineContext db = new UniCineContext();

            string consultaSql = "Select p.Nombre, p.Anno, p.Duracion, p.Categoria, p.Sinopsis " +
                "FROM Peliculas as p " +
                $"WHERE p.Genero='{genero}' " +
                $"ORDER BY p.Anno;";
            List<InformeCatalogoPeliculasWr> resultado1 = db.Database.SqlQuery<InformeCatalogoPeliculasWr>(consultaSql, new object[0]).ToList();

            ReportDataSource fuenteDatos = new ReportDataSource("DataSetInformeCatalogoPeliculasWr", resultado1);
            visor.rpvVisorInforme.LocalReport.DataSources.Add(fuenteDatos);

            visor.rpvVisorInforme.SetDisplayMode(DisplayMode.PrintLayout);
            visor.rpvVisorInforme.RefreshReport();
            visor.Show();
        }
    }
}
