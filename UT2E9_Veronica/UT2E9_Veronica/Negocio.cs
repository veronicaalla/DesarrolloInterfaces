using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UT2E9_Veronica
{
    internal class Negocio
    {
        //Instanciamos la clase con la conexion para tener acceso a la bbdd

        private static ModeloBd db = new ModeloBd();

        public Negocio() { }


        // METODOS PARA LOS LIBROS
        public Libro[] obtenerLibros()
        {
            return db.Libros.ToArray();
        }

        public void CrearLibro(Libro libro)
        {
            db.Libros.Add(libro);
            db.SaveChanges();
        }

        public Libro BuscarLibro(int id)
        {
            return db.Libros.FirstOrDefault(x => x.LibroId == id);
        }

        public void BorrarLibro(int id)
        {
            db.Libros.Remove(BuscarLibro(id));
            db.SaveChanges();
        }

        public void ModificarLibro(Libro libroModificado)
        {
            db.Entry(db.Libros.FirstOrDefault(x => x.LibroId == libroModificado.LibroId)).CurrentValues.SetValues(libroModificado);

            #region Paso a paso (anterior)
            /*
             Paso a paso (de lo anterior)
             Libro libroBD = db.Libros.FirstOrDefault(x => x.LibroId == libroModificado.LibroId);
            if (libroBD != null)
            {
                db.Entry(libroBD).CurrentValues.SetValues(libroModificado);
                db.SaveChanges();
            }*/
            #endregion

        }


        // MÉTODOS PARA LAS PELICULAS
        public Pelicula[] obtenerPeliculas()
        {
            return db.Peliculas.ToArray();
        }


        public void CrearPelicula(Pelicula pelicula)
        {
            db.Peliculas.Add(pelicula);
            db.SaveChanges();
        }

        public Pelicula BuscarPelicula(int id)
        {
            return db.Peliculas.FirstOrDefault(x => x.PeliculaId == id);
        }

        public void BorrarPelicula(int id)
        {
            db.Peliculas.Remove(BuscarPelicula(id));
            db.SaveChanges();
        }

        public void ModificarPelicula(Pelicula pelicula)
        {
            db.Entry(db.Peliculas.FirstOrDefault(x => x.PeliculaId == pelicula.PeliculaId)).CurrentValues.SetValues(pelicula);

        }


    }
}
