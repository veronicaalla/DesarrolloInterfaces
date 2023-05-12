using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniCine_Veronica
{
    static class Herramientas
    {
       
        static Negocio negocio = new Negocio();

        public static string[] ObtenerSalas()
        {
            UniCineContext db = new UniCineContext();
            var query = from s in db.Sesiones
                        orderby s.Sala
                        select s.Sala;

            return query.Distinct().ToArray();
        }

        public static List<Sesion> SesionesAsociadasAPelicula(Pelicula pelicula)
        {
            UniCineContext db = new UniCineContext();

            List<Proyeccion> proyeccionesAsociadas = db.Proyecciones.Where(p => p.PeliculaId == pelicula.PeliculaId).ToList();

            List<Sesion> sesionesAsociadas = new List<Sesion>();
            proyeccionesAsociadas.ForEach(p => { sesionesAsociadas.Add(negocio.BuscarSesion(p.SesionId)); });

            return sesionesAsociadas;
        }

        public static List<Pelicula> PeliculasAsociadasASesion(Sesion sesion)
        {
            UniCineContext db = new UniCineContext();
            List<Proyeccion> proyeccionesAsociadas = db.Proyecciones.Where(p => p.SesionId == sesion.SesionId).ToList();

            List<Pelicula> peliculasAsociadas = new List<Pelicula>();
            proyeccionesAsociadas.ForEach(p => peliculasAsociadas.Add(negocio.BuscarPelicula(p.PeliculaId)));

            return peliculasAsociadas;
        }

        public static List<Sesion> ObtenerSesionesFiltrado(string filtroDia, string filtroSala)
        {
            UniCineContext db = new UniCineContext();
            if (filtroDia.Equals("TODOS") && filtroSala.Equals("TODAS"))
            {
                return db.Sesiones.ToList();
            }
            if (filtroDia.Equals("TODOS") && !filtroSala.Equals("TODAS"))
            {
                return db.Sesiones.Where(s => s.Sala == filtroSala).ToList();
            }
            if (!filtroDia.Equals("TODOS") && filtroSala.Equals("TODAS"))
            {
                return db.Sesiones.Where(s => s.DiaSemana == filtroDia).ToList();
            }
            if (!filtroDia.Equals("TODOS") && !filtroSala.Equals("TODAS"))
            {
                return db.Sesiones.Where(s => s.DiaSemana == filtroDia && s.Sala == filtroSala).ToList();
            }
            return null;
        }

        internal static List<Pelicula> ObtenerPeliculasFiltradas(string genero, string categoria)
        {
            UniCineContext db = new UniCineContext();
            if (genero.Equals("Todos") && categoria.Equals("Todas"))
            {
                return db.Peliculas.ToList();
            }
            if (genero.Equals("Todos") && !categoria.Equals("Todas"))
            {
                return db.Peliculas.Where(p => p.Categoria == categoria).ToList();
            }
            if (!genero.Equals("Todos") && categoria.Equals("Todas"))
            {
                return db.Peliculas.Where(p => p.Genero == genero).ToList();
            }
            if (!genero.Equals("Todos") && !categoria.Equals("Todas"))
            {
                return db.Peliculas.Where(p => p.Genero == genero && p.Categoria == categoria).ToList();
            }
            return null;
        }

    }
}

