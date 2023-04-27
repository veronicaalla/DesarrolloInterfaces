﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniCine_Veronica
{
    internal class Herramientas
    {
        static UniCineContext db = new UniCineContext();

        public static string[] ObtenerSalas()
        {
            var query = from s in db.Sesiones
                        orderby s.Sala
                        select s.Sala;

            return query.Distinct().ToArray();
        }
        

        public static List<Sesion> ObtenerSesionesFiltrado(string filtroDia, string filtroSala)
        {
            
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
                return db.Peliculas.Where(p => p.Genero== genero && p.Categoria == categoria).ToList();
            }
            return null;
        }

    }
}

