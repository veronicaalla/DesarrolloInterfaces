using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniCine_Veronica
{
    internal class Negocio
    {//Instanciamos la clase con la conexion para tener acceso a la bbdd

        static UniCineContext db = new UniCineContext();

        public Negocio()
        {
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


        public Pelicula buscarPeliculaPorNombre(string nombre)
        {
            return db.Peliculas.FirstOrDefault(x => x.Nombre.Equals(nombre));
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
            return db.Proyecciones.FirstOrDefault(x => x.PeliculaId == idPelicula && x.SesionId == idSesion && x.Inicio == fecha);
        }


        public void BorrarProyeccion(int idPelicula, int idSesion, DateTime fecha)
        {
            db.Proyecciones.Remove(BuscarProyeccion(idPelicula, idSesion, fecha));
            db.SaveChanges();
        }



        public void ModificarProyeccion(Proyeccion proyeccionModificada)
        {
            //db.Entry(db.Libros.FirstOrDefault(x => x.LibroId == libroModificado.LibroId)).CurrentValues.SetValues(libroModificado);

            Proyeccion proyeccionDB = db.Proyecciones.FirstOrDefault(x => x.PeliculaId == proyeccionModificada.SesionId
                                                        && x.SesionId == proyeccionModificada.SesionId
                                                        && x.Inicio == proyeccionModificada.Inicio);

            if (proyeccionDB != null)
            {
                db.Entry(proyeccionDB).CurrentValues.SetValues(proyeccionModificada);
                db.SaveChanges();
            }
        }



        //-------------------------EXCEPCIONES DE NEGOCIO------------------

        //Reglas negocio Peliculas
        public void ExcepcionPeliculasAsociadas(int peliculaId)
        {
            UniCineContext db = new UniCineContext();
            //Si devuelve true, significa que la pelicula tiene proyecciones asociadas
            if (db.Proyecciones.Any(p => p.PeliculaId == peliculaId))
            {
                throw new VeronicaException ("No se puede eliminar la pelicula debido a que tiene proyecciones asociadas")
            }
        }

        public void ExcepcionDuracionNecesaria()
        {

        }

        public void ExcepcionRangoTiempo()
        {

        }

        //Reglas negocio Sesiones
        public void ExcepcionTiempoSesionMayorPeli()
        {

        }

        public void ExcepcionAforo(int aforo)
        {
            if (aforo < 0)
            {
                throw new VeronicaException("El aforo de una sala debe de ser superior a 0");
            }
        }

        public void ExcepcionPrecio(float precio)
        {
            if (precio <= 0)
            {
                throw new VeronicaException("El precio debe ser superior a 0");
            }
        }

        //Reglas negocio Proyecciones
        public void ExcepcionDuracionPeliMenorSesion()
        {

        }

        public void ExcepcionNoProyeccionSolapada()
        {

        }

        public void ExcepcionFechasCorrectas()
        {

        }
    }
}
