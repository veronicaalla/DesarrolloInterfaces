using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
            //Lanzamos la excepcion de negocio
            ExcepcionPeliculaProyeccionAsociadas(id);

            db.Peliculas.Remove(BuscarPelicula(id));
            db.SaveChanges();
        }

        public void ModificarPelicula(Pelicula pelicula)
        {
            ExcepcionDuracionNecesaria(pelicula);
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
            ExcepcionSesionProyeccionesAsociadas(id);
            db.Sesiones.Remove(BuscarSesion(id));
            db.SaveChanges();
        }

        public void ModificarSesion(Sesion sesionModificado)
        {
            //Lanzamos excepcion de negocio
            ExcepcionTiempoSesionMayorPeli(sesionModificado);
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
        public void ExcepcionPeliculaProyeccionAsociadas(int peliculaId)
        {
            UniCineContext db = new UniCineContext();
            //Si devuelve true, significa que la pelicula tiene proyecciones asociadas
            if (db.Proyecciones.Any(p => p.PeliculaId == peliculaId))
            {
                throw new VeronicaException("No se puede eliminar la pelicula debido a que tiene proyecciones asociadas");
            }
        }

        public void ExcepcionDuracionNecesaria(Pelicula pelicula)
        {
            List<Sesion> listaSesionesAsociadas = Herramientas.SesionesAsociadasAPelicula(pelicula);
           // List<string> salas = new List<string>();
            int num = 0;
            listaSesionesAsociadas.ForEach(s =>
            {
                TimeSpan diferencia = s.FinMax - s.Comienzo;
                //La duracion de la pelicula esta almacenada en minutos 
                if (pelicula.Duracion > diferencia.TotalMinutes)
                {
                    //salas.Add(s.Sala);
                    num++;
                }
            });

            /*if (salas.Count > 0)
            {
                throw new VeronicaException($"La duracion excede el tiempo en las salas" );
                + "\n\t ");
            }*/

            if (num != 0)
            {
                throw new VeronicaException($"La duracion excede el tiempo en: {num} salas");
            }
        }



        //Reglas negocio Sesiones

        public void ExcepcionSesionProyeccionesAsociadas(int sesionId)
        {
            UniCineContext db = new UniCineContext();
            //Si devuelve true, significa que la pelicula tiene proyecciones asociadas
            if (db.Proyecciones.Any(p => p.SesionId == sesionId))
            {
                throw new VeronicaException("No se puede eliminar la sesión debido a que tiene proyecciones asociadas");
            }
        }
        public void ExcepcionTiempoSesionMayorPeli(Sesion sesion)
        {
            List<Pelicula> listaPeliculasAsociadas = Herramientas.PeliculasAsociadasASesion(sesion);
            int num = 0;
            listaPeliculasAsociadas.ForEach(p =>
            {
                if (p.Duracion > sesion.FinMax.Subtract(sesion.Comienzo).TotalMinutes)
                {
                    num++;
                }
            });
            if (num != 0)
            {
                throw new VeronicaException($"La duracion total de la sesion es menor a la duracion de {num} peliculas");
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
