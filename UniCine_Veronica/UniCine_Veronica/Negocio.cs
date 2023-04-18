using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniCine_Veronica
{
    internal class Negocio
    {//Instanciamos la clase con la conexion para tener acceso a la bbdd

        //private static UniCineContext db = new UniCineContext();
         static UniCineContext db = new UniCineContext();

        public Negocio() {
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
            // db.Entry(db.Peliculas.FirstOrDefault(x => x.PeliculaId == pelicula.PeliculaId)).CurrentValues.SetValues(pelicula);
            Pelicula peliculaBD = db.Peliculas.FirstOrDefault(x => x.PeliculaId == pelicula.PeliculaId);
            if (peliculaBD != null)
            {
                db.Entry(peliculaBD).CurrentValues.SetValues(pelicula);
                db.SaveChanges();
            }
        }


        // METODOS PARA LAS SESIONES
        public Sesion[] obtenerSesiones()
        {
            return db.Sesiones.ToArray();
        }

        public void CrearSesion(Sesion sesion)
        {
            db.Sesiones.Add(sesion);
            db.SaveChanges();
        }

        public Sesion BuscarSesion(int id)
        {
            return db.Sesiones.FirstOrDefault(x => x.SesionId == id);
        }

        public void BorrarSesion(int id)
        {
            db.Sesiones.Remove(BuscarSesion(id));
            db.SaveChanges();
        }

        public void ModificarSesion(Sesion sesionModificado)
        {
            //db.Entry(db.Libros.FirstOrDefault(x => x.LibroId == libroModificado.LibroId)).CurrentValues.SetValues(libroModificado);

             Sesion libroBD = db.Sesiones.FirstOrDefault(x => x.SesionId == sesionModificado.SesionId);
            if (libroBD != null)
            {
                db.Entry(libroBD).CurrentValues.SetValues(sesionModificado);
                db.SaveChanges();
            }

        }

        // METODOS PARA LAS PROYECCIONES
       public Proyeccion[] obtenerProyecciones()
        {
            return db.Proyecciones.ToArray();
        }

        public void CrearProyeccion(Proyeccion proyeccion)
        {
            db.Proyecciones.Add(proyeccion);
            db.SaveChanges();
        }
        
        public Proyeccion BuscarProyeccion(int idPelicula, int idSesion, DateTime fecha)
        {
            return db.Proyecciones.FirstOrDefault(x => x.PeliculaId ==idPelicula && x.SesionId==idSesion && x.Inicio == fecha );
        }

        /*
        public void BorrarProyeccion(int id)
        {
            db.Sesiones.Remove(BuscarSesion(id));
            db.SaveChanges();
        }

        public void ModificarProyeccion(Sesion sesionModificado)
        {
            //db.Entry(db.Libros.FirstOrDefault(x => x.LibroId == libroModificado.LibroId)).CurrentValues.SetValues(libroModificado);

            Sesion libroBD = db.Sesiones.FirstOrDefault(x => x.SesionId == sesionModificado.SesionId);
            if (libroBD != null)
            {
                db.Entry(libroBD).CurrentValues.SetValues(sesionModificado);
                db.SaveChanges();
            }

        }*/



    }
}
