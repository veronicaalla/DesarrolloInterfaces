using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Diagnostics;
using System.Reflection.Emit;
using System.Security.Policy;
using Moq;
using System.Linq;
using UniCine_Veronica;
using System.Data.Entity;
using System.Security.Principal;
using static System.Collections.Specialized.BitVector32;

namespace UniCineTesting
{
    [TestClass]
    public class UniTest
    {
        /// <summary>
        /// Descripción resumida de UnitTestAnimales
        /// </summary>

        public UniTest()
        {

        }

        //Variables
        //private TestContext testContextInstance;
        private Mock<UniCineContext> _mockCineBD;
        private Negocio _negocio;

        [TestInitialize]
        public void Initialize()
        {
            //falseo el contesto
            _mockCineBD = new Mock<UniCineContext>();

            #region falseamos tabla Peliculas
            //Falseamos las tablas
            //1- Datos como consulta de Peliculas
            var datosPeliculas = new List<Pelicula>
            {
                //PeliculaId  Nombre  Duracion    Anno    Categoria   Genero  Sinopsis
                new Pelicula { PeliculaId = 1, Nombre = "Renfield", Duracion = 93, Anno = 2023, Categoria = ">18", Genero = "Terror", Sinopsis = "Vuelve el conde Dracula" },
                new Pelicula { PeliculaId = 2, Nombre = "Algo pasa con Mary", Duracion = 119, Anno = 1998, Categoria = " >12", Genero = "Comedia", Sinopsis = "Todo un peliculon a la altura de zoolander" },
                new Pelicula { PeliculaId = 3, Nombre = "Espíritu libre ", Duracion = 110, Anno = 2023, Categoria = ">18", Genero = "Aventura  ", Sinopsis = "La caratula es muy bonita, la pelicula ni idea" },
                new Pelicula { PeliculaId = 4, Nombre = "Amsterdam", Duracion = 125, Anno = 2022, Categoria = "Todos", Genero = "Romance", Sinopsis = "Algo de besos supongo que en los alrededores de Amsterdan" },
                new Pelicula { PeliculaId = 5, Nombre = "Sin novedad en el frente", Duracion = 162, Anno = 2022, Categoria = ">18", Genero = "Acción", Sinopsis = "Pelicula de la primera guerra mundial basada en el libro homonimo" },
                new Pelicula { PeliculaId = 6, Nombre = "Uncharted", Duracion = 113, Anno = 2022, Categoria = " >16", Genero = "Aventura", Sinopsis = "Ni idea, pero le gusta a los frikis" },
                new Pelicula { PeliculaId = 7, Nombre = "Bullet Train", Duracion = 95, Anno = 2022, Categoria = " >16", Genero = "Acción", Sinopsis = "Really Brad, no es tu mejor papel" },
                new Pelicula { PeliculaId = 8, Nombre = "Sonic ", Duracion = 108, Anno = 2023, Categoria = " Todos", Genero = "Aventura", Sinopsis = "Un erizo dando vueltas contra cosas" },
                new Pelicula { PeliculaId = 9, Nombre = "Luther", Duracion = 105, Anno = 2023, Categoria = " >18", Genero = "Acción", Sinopsis = "Detective cañero contra psicopata" },
                new Pelicula { PeliculaId = 10, Nombre = "fsfds", Duracion = 105, Anno = 2023, Categoria = " >18", Genero = "Acción", Sinopsis = "Detective cañero contra psicopata" }
            }.AsQueryable();

            //falseo la tabla Peliculas
            var mockTablaPeliculas = new Mock<DbSet<Pelicula>>();
            mockTablaPeliculas.As<IQueryable<Pelicula>>().Setup(x => x.Provider).Returns(datosPeliculas.Provider);
            mockTablaPeliculas.As<IQueryable<Pelicula>>().Setup(x => x.Expression).Returns(datosPeliculas.Expression);
            mockTablaPeliculas.As<IQueryable<Pelicula>>().Setup(x => x.ElementType).Returns(datosPeliculas.ElementType);
            mockTablaPeliculas.As<IQueryable<Pelicula>>().Setup(x => x.GetEnumerator()).Returns(datosPeliculas.GetEnumerator());
            //3-cuando se solicite la tabla cliente se devolvera un objeto falseado
            _mockCineBD.Setup(x => x.Peliculas).Returns(mockTablaPeliculas.Object);
            //falseamos la base de datos.
            _negocio = new Negocio(_mockCineBD.Object);
            Debug.WriteLine("TestInitialize Pelicula");
            #endregion

            #region falseamos tabla Sesiones
            //2. Datos como consulta de Sesiones
            var datosSesiones = new List<Sesion>
            {
                //SesionId	Sala	DiaSemana	Comienzo	FinMax	Precio	Aforo
                new Sesion { SesionId = 1, Sala = "SALA 1", DiaSemana = "Domingo", Comienzo = DateTime.Parse("1753-01-01 20:45:00.000"), FinMax = DateTime.Parse("1753 - 01 - 01 23:30:00.000"), Precio = 7.2f, Aforo = 200 },
                new Sesion { SesionId = 2, Sala = "SALA 2", DiaSemana = "Domingo", Comienzo = DateTime.Parse("1753-01-01 18:15:00.000"), FinMax = DateTime.Parse("1753-01-01 20:15:00.000"), Precio = 7.2f, Aforo = 174 },
                new Sesion { SesionId = 3, Sala = "SALA 3", DiaSemana = "Domingo", Comienzo = DateTime.Parse("1753-01-01 10:30:00.000"), FinMax = DateTime.Parse("1753-01-01 13:00:00.000"), Precio = 5.5f, Aforo = 122 },
                new Sesion { SesionId = 4, Sala = "SALA 1", DiaSemana = "Sábado", Comienzo = DateTime.Parse("1753-01-01 20:45:00.000"), FinMax = DateTime.Parse("1753-01-01 23:30:00.000"), Precio = 7.2f, Aforo = 200 },
                new Sesion { SesionId = 5, Sala = "SALA 2", DiaSemana = "Sábado", Comienzo = DateTime.Parse("1753-01-01 18:15:00.000"), FinMax = DateTime.Parse("1753-01-01 20:15:00.000"), Precio = 7.2f, Aforo = 174 },
                new Sesion { SesionId = 6, Sala = "SALA 3", DiaSemana = "Sábado", Comienzo = DateTime.Parse("1753-01-01 10:30:00.000"), FinMax = DateTime.Parse("1753-01-01 13:00:00.000"), Precio = 5.5f, Aforo = 122 },
                new Sesion { SesionId = 7, Sala = "SALA 4", DiaSemana = "Martes", Comienzo = DateTime.Parse("1753-01-02 10:30:00.000"), FinMax = DateTime.Parse("1753-01-02 10:40:00.000"), Precio = 5.5f, Aforo = 200 }
            }.AsQueryable();

            //Falseamos la tabla Sesiones
            var mockTablaSesiones = new Mock<DbSet<Sesion>>();
            mockTablaSesiones.As<IQueryable<Sesion>>().Setup(x => x.Provider).Returns(datosSesiones.Provider);
            mockTablaSesiones.As<IQueryable<Sesion>>().Setup(x => x.Expression).Returns(datosSesiones.Expression);
            mockTablaSesiones.As<IQueryable<Sesion>>().Setup(x => x.ElementType).Returns(datosSesiones.ElementType);
            mockTablaSesiones.As<IQueryable<Sesion>>().Setup(x => x.GetEnumerator()).Returns(datosSesiones.GetEnumerator());
            //3-cuando se solicite la tabla cliente se devolvera un objeto falseado
            _mockCineBD.Setup(x => x.Sesiones).Returns(mockTablaSesiones.Object);
            //falseamos la base de datos.
            _negocio = new Negocio(_mockCineBD.Object);
            Debug.WriteLine("TestInitialize Sesion");
            #endregion


            #region falseamos tabla Proyecciones
            //3. Datos como consulta de Proyecciones
            var datosProyecciones = new List<Proyeccion>
            {
                //PeliculaId	SesionId	Inicio	Fin  16 RESULTADOS
                new Proyeccion { PeliculaId =1, SesionId= 2, Inicio= DateTime.Parse("2023-02-13 00:00:00.000"), Fin= null},
                new Proyeccion { PeliculaId =1, SesionId= 5, Inicio= DateTime.Parse("2023-02-13 00:00:00.000"), Fin= null},
                new Proyeccion { PeliculaId =2, SesionId= 3, Inicio= DateTime.Parse("2023-02-06 00:00:00.000"), Fin= null},
                new Proyeccion { PeliculaId =2, SesionId= 6, Inicio= DateTime.Parse("2023-02-06 00:00:00.000"), Fin= null},
                new Proyeccion { PeliculaId =3, SesionId= 4, Inicio= DateTime.Parse("2023-01-30 00:00:00.000"), Fin= DateTime.Parse("2023-02-19 00:00:00.000")},
                new Proyeccion { PeliculaId =4, SesionId= 2, Inicio= DateTime.Parse("2023-01-23 00:00:00.000"), Fin= DateTime.Parse("2023-02-12 00:00:00.000")},
                new Proyeccion { PeliculaId =4, SesionId= 5, Inicio= DateTime.Parse("2023-01-23 00:00:00.000"), Fin= DateTime.Parse("2023-02-12 00:00:00.000")},
                new Proyeccion { PeliculaId =5, SesionId= 3, Inicio= DateTime.Parse("2023-01-16 00:00:00.000"), Fin= DateTime.Parse("2023-02-05 00:00:00.000")},
                new Proyeccion { PeliculaId =5, SesionId= 6, Inicio= DateTime.Parse("2023-01-16 00:00:00.000"), Fin= DateTime.Parse("2023-02-05 00:00:00.000")},
                new Proyeccion { PeliculaId =6, SesionId= 4, Inicio= DateTime.Parse("2023-01-09 00:00:00.000"), Fin= DateTime.Parse("2023-01-29 00:00:00.000")},
                new Proyeccion { PeliculaId =7, SesionId= 2, Inicio= DateTime.Parse("2023-01-02 00:00:00.000"), Fin= DateTime.Parse("2023-01-22 00:00:00.000")},
                new Proyeccion { PeliculaId =7, SesionId= 5, Inicio= DateTime.Parse("2023-01-02 00:00:00.000"), Fin= DateTime.Parse("2023-01-22 00:00:00.000")},
                new Proyeccion { PeliculaId =8, SesionId= 3, Inicio= DateTime.Parse("2023-01-02 00:00:00.000"), Fin= DateTime.Parse("2023-01-15 00:00:00.000")},
                new Proyeccion { PeliculaId =8, SesionId= 6, Inicio= DateTime.Parse("2023-01-02 00:00:00.000"), Fin= DateTime.Parse("2023-01-15 00:00:00.000")},
                new Proyeccion { PeliculaId =9, SesionId= 4, Inicio= DateTime.Parse("2023-01-02 00:00:00.000"), Fin= DateTime.Parse("2023-01-08 00:00:00.000")},
                new Proyeccion { PeliculaId =9, SesionId= 4, Inicio= DateTime.Parse("2023-02-20 00:00:00.000"), Fin= null},
            }.AsQueryable();

            //Falseamos la tabla Proyecciones
            var mockTablaProyecciones = new Mock<DbSet<Proyeccion>>();
            mockTablaProyecciones.As<IQueryable<Proyeccion>>().Setup(x => x.Provider).Returns(datosProyecciones.Provider);
            mockTablaProyecciones.As<IQueryable<Proyeccion>>().Setup(x => x.Expression).Returns(datosProyecciones.Expression);
            mockTablaProyecciones.As<IQueryable<Proyeccion>>().Setup(x => x.ElementType).Returns(datosProyecciones.ElementType);
            mockTablaProyecciones.As<IQueryable<Proyeccion>>().Setup(x => x.GetEnumerator()).Returns(datosProyecciones.GetEnumerator());
            //3-cuando se solicite la tabla cliente se devolvera un objeto falseado
            _mockCineBD.Setup(x => x.Proyecciones).Returns(mockTablaProyecciones.Object);

            //falseamos la base de datos.
            _negocio = new Negocio(_mockCineBD.Object);
            Debug.WriteLine("TestInitialize Proyeccion");
            #endregion

        }




        #region TESTING DE PELICULAS
        [TestMethod]
        public void BuscarPeliculaPorId()
        {
            //Invocamos a la logica del negocio del programa 
            Pelicula peliculaTest = _negocio.BuscarPelicula(1);

            //revisamos los resultados
            //Comprobamos que el cliente no es nulo (sabemos que existe)
            Assert.IsNotNull(peliculaTest);

            //Comprobamos que los datos de la pelicula son los correctos 
            Assert.AreEqual(1, peliculaTest.PeliculaId);
            Assert.AreEqual("Renfield", peliculaTest.Nombre);
            Assert.AreEqual(93, peliculaTest.Duracion);
            Assert.AreEqual(2023, peliculaTest.Anno);
            Assert.AreEqual(">18", peliculaTest.Categoria);
            Assert.AreEqual("Terror", peliculaTest.Genero);
            Assert.AreEqual("Vuelve el conde Dracula", peliculaTest.Sinopsis);
        }

        [TestMethod]
        public void BuscarPeliculaPorIdObtenerNulo()
        {
            //Invocamos a la logica del negocio del programa 
            Pelicula peliculaTest = _negocio.BuscarPelicula(11);

            //revisamos los resultados
            //Comprobamos que el cliente no es nulo (sabemos que existe)
            Assert.IsNull(peliculaTest);
        }

        [TestMethod]
        public void BuscarPeliculaPorNombre()
        {
            Pelicula pelicula = _negocio.buscarPeliculaPorNombre("Renfield");
            Assert.IsNotNull(pelicula);
            Assert.AreEqual(1, pelicula.PeliculaId);
        }

        [TestMethod]
        public void BuscarPeliculaPorNombreObtenerNulo()
        {
            Pelicula pelicula = _negocio.buscarPeliculaPorNombre("Holaaa");
            //Comprobamos que nos devuelve null debido a que no existe ninguna pelicula con dicho nombre
            Assert.IsNull(pelicula);
        }

        [TestMethod]
        public void ObtenerPeliculas()
        {
            //Llamamos a la logica del negocio
            List<Pelicula> listadoPeliculas = _negocio.obtenerPeliculas().ToList();

            //Comprobamos que la lista no sea nula
            Assert.IsNotNull(listadoPeliculas);
            //Comprobamos que la longitud de la lista sea la correcta
            Assert.AreEqual(10, listadoPeliculas.Count);
        }


        [TestMethod]
        public void ObtenerPeliculasDatosCorrectos()
        {
            //Llamamos a la logica del negocio
            List<Pelicula> listadoPeliculas = _negocio.obtenerPeliculas().ToList();

            //Comprobamos que la lista no sea nula
            Assert.IsNotNull(listadoPeliculas);

            //Comprobamos que lea los datos bien 

            //Comprobamos que nos lea TODAS las peliculas
            Assert.AreEqual(10, listadoPeliculas.Count);
            //Comprobamos que nos lea los id bien
            Assert.AreEqual(1, listadoPeliculas[0].PeliculaId);
            //Comprobamos que nos lea bien los nombres de cada uno
            Assert.AreEqual("Algo pasa con Mary", listadoPeliculas[1].Nombre);
            Assert.AreEqual(110, listadoPeliculas[2].Duracion);
            Assert.AreEqual(2022, listadoPeliculas[3].Anno);
            Assert.AreEqual(">18", listadoPeliculas[4].Categoria);
            Assert.AreEqual("Aventura", listadoPeliculas[5].Genero);
            Assert.AreEqual("Really Brad, no es tu mejor papel", listadoPeliculas[6].Sinopsis);

        }

        [TestMethod]
        public void ObtenerPeliculasDatosIncorrectos()
        {
            //Llamamos a la logica del negocio
            List<Pelicula> listadoPeliculas = _negocio.obtenerPeliculas().ToList();

            //Comprobamos que la lista no sea nula
            Assert.IsNotNull(listadoPeliculas);

            //Comprobamos que no nos lea todos los datos 
            Assert.AreNotEqual(2, listadoPeliculas.Count);
            //Comprobamos que no nos lea los datos bien
            Assert.AreNotEqual(8, listadoPeliculas[0].PeliculaId);
            Assert.AreNotEqual("Renfield", listadoPeliculas[1].Nombre);
            Assert.AreNotEqual(120, listadoPeliculas[2].Duracion);
            Assert.AreNotEqual(2027, listadoPeliculas[3].Anno);
            Assert.AreNotEqual("Todos", listadoPeliculas[4].Categoria);
            Assert.AreNotEqual("Romance", listadoPeliculas[5].Genero);
            Assert.AreNotEqual("Ni idea, pero le gusta a los frikis", listadoPeliculas[6].Sinopsis);
        }

        [TestMethod]
        public void CrearPeliculaSinErrores()
        {
            Pelicula pelicula = new Pelicula();
            pelicula.PeliculaId = 11;
            pelicula.Nombre = "A mi venatana";
            pelicula.Duracion = 113;
            pelicula.Anno = 2022;
            pelicula.Categoria = ">16";
            pelicula.Genero = "Romance";
            pelicula.Sinopsis = "La atracción de Raquel por su vecino se convierte en algo más cuando él empieza a enamorarse de ella, a pesar de la oposición de su familia";

            _negocio.CrearPelicula(pelicula);
            //Comprobamos que se ha añadido y que se ha llamado a SaveChange
            _mockCineBD.Verify(m => m.Peliculas.Add(pelicula), Times.Once());
            _mockCineBD.Verify(m => m.SaveChanges(), Times.Once());
        }

        /*
                [TestMethod]
                public void CrearPeliculaNombreCampoVacio()
                {
                    Pelicula pelicula = new Pelicula
                    {
                        PeliculaId = 11,
                        Nombre = null,
                        Duracion = 113,
                        Anno = 2022,
                        Categoria = ">16",
                        Genero = "Romance",
                        Sinopsis = "La atracción de Raquel por su vecino se convierte en algo más cuando él empieza a " +
                                    "enamorarse de ella, a pesar de la oposición de su familia."
                    };

                    _negocio.CrearPelicula(pelicula);

                    //Nos tiene que dar error por que el Nombre es vacio
                    _mockCineBD.Verify(m => m.SaveChanges(), Times.Once());

                }*/

        [TestMethod]
        public void BorrarPelicula()
        {
            //Eliminamos la pelicula que hemos creado manualmente
            //No tiene proyecciones asociadas -> No excepcion
            Pelicula pelicula = _negocio.BuscarPelicula(10);
            _negocio.BorrarPelicula(pelicula.PeliculaId);
            //Comprobamos que se ha borrado y ha llamado al SaveChange
            _mockCineBD.Verify(m => m.Peliculas.Remove(pelicula), Times.Once());
            _mockCineBD.Verify(m => m.SaveChanges(), Times.Once());

        }


        [TestMethod]
        public void BorrarPeliculaLanzaExcepcionProyeccionesAsociadas()
        {

            //Assert.ThrowsException<VeronicaException>(() => _negocio.BorrarPelicula(9);
            //Comprobar que lanza la excepcion correcta
            try
            {
                _negocio.BorrarPelicula(9);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("No se puede eliminar la pelicula debido a que tiene proyecciones asociadas", ex.Message);
            }
        }

        [TestMethod]
        public void ModificarPelicula()
        {
            Pelicula pelicula = _negocio.BuscarPelicula(9);
            pelicula.Nombre = "Cambio de nombre";
            _negocio.ModificarPelicula(pelicula);
            //Assert.AreEqual("Cambio de nombre", pelicula.Nombre);
            _mockCineBD.Verify(m => m.SaveChanges(), Times.Once());
        }

        [TestMethod]
        public void ModificarPeliculaLanzaExcepcionDuracionPeliculaSuperiorSesion()
        {
            Pelicula pelicula = _negocio.BuscarPelicula(9);
            pelicula.Duracion = 200;
            //Assert.ThrowsException<VeronicaException>(() => _negocio.ModificarPelicula(pelicula));
            //Comprobar que se lanza la excepcion correcta
            try
            {
                _negocio.ModificarPelicula(pelicula);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("La duracion excede el tiempo en: 7 salas", ex.Message);
                //Assert.AreEqual("error", ex.Message);
            }
        }
        #endregion


        #region TESTING DE SESIONES
        [TestMethod]
        public void BuscarSesionPorId()
        {
            //Invocamos a la logica del negocio del programa 
            Sesion sesion = _negocio.BuscarSesion(1);

            //revisamos los resultados
            //Comprobamos que el cliente no es nulo (sabemos que existe)
            Assert.IsNotNull(sesion);

            //Comprobamos que los datos de la pelicula son los correctos 
            Assert.AreEqual(1, sesion.SesionId);
            Assert.AreEqual("SALA 1", sesion.Sala);
            Assert.AreEqual(DateTime.Parse("1753-01-01 20:45:00.000"), sesion.Comienzo);
            Assert.AreEqual(DateTime.Parse("1753-01-01 23:30:00.000"), sesion.FinMax);
            Assert.AreEqual(7.2f, sesion.Precio);
            Assert.AreEqual(200, sesion.Aforo);
        }


        [TestMethod]
        public void BuscarSesionPorIdObtenerNull()
        {
            Sesion sesion = _negocio.BuscarSesion(10);
            //No existe ninguna sesion con dicho id -> debemos comprobar que sea null
            Assert.IsNull(sesion);
        }


        [TestMethod]
        public void ObtenerSesiones()
        {
            //Llamamos a la logica del negocio
            List<Sesion> listadoSesiones = _negocio.obtenerSesiones().ToList();

            //Comprobamos que la lista no sea nula
            Assert.IsNotNull(listadoSesiones);
            //Comprobamos que recoja todas las sesiones existentes
            Assert.AreEqual(7, listadoSesiones.Count);
        }



        [TestMethod]
        public void ObtenerSesionesDatosCorrectos()
        {
            //Llamamos a la logica del negocio
            List<Sesion> listadoSesiones = _negocio.obtenerSesiones().ToList();

            //Comprobamos que no sea nulo
            Assert.IsNotNull(listadoSesiones);
            //Comprobamos que los datos recogidos sean los correctos
            Assert.IsTrue(listadoSesiones.Count() == 7);
            Assert.AreEqual(1, listadoSesiones[0].SesionId);
            Assert.AreEqual("SALA 2", listadoSesiones[1].Sala);
            Assert.AreEqual("Domingo", listadoSesiones[2].DiaSemana);
            Assert.AreEqual(DateTime.Parse("1753-01-01 20:45:00.000"), listadoSesiones[3].Comienzo);
            Assert.AreEqual(DateTime.Parse("1753-01-01 20:15:00.000"), listadoSesiones[4].FinMax);
            Assert.AreEqual(5.5f, listadoSesiones[5].Precio);
            Assert.AreEqual(200, listadoSesiones[6].Aforo);
        }


        [TestMethod]
        public void ObtenerSesionesDatosIncorrectos()
        {
            //Llamamos a la logica del negocio
            List<Sesion> listadoSesiones = _negocio.obtenerSesiones().ToList();

            //Comprobamos que no sea nulo
            Assert.IsNotNull(listadoSesiones);
            //Comprobamos que los datos recogidos sean los correctos
            Assert.IsTrue(listadoSesiones.Count() == 7);
            Assert.AreNotEqual(5, listadoSesiones[0].SesionId);
            Assert.AreNotEqual("SALA 6", listadoSesiones[1].Sala);
            Assert.AreNotEqual("Lunes", listadoSesiones[2].DiaSemana);
            Assert.AreNotEqual(DateTime.Parse("1753-01-05 20:45:00.000"), listadoSesiones[3].Comienzo);
            Assert.AreNotEqual(DateTime.Parse("1753-01-03 20:15:00.000"), listadoSesiones[4].FinMax);
            Assert.AreNotEqual(5.7f, listadoSesiones[5].Precio);
            Assert.AreNotEqual(100, listadoSesiones[6].Aforo);
        }


        [TestMethod]
        public void CrearSesionSinErrores()
        {
            Sesion sesion = new Sesion
            {
                SesionId = 10,
                Sala = "SALA 5",
                DiaSemana = "Lunes",
                Comienzo = DateTime.Parse("1753-01-05 20:45:00.000"),
                FinMax = DateTime.Parse("1753-01-03 20:15:00.000"),
                Precio = 5.5f,
                Aforo = 50
            };

            _negocio.CrearSesion(sesion);
            //Comprobamos que se ha añadido y que se ha llamado a SaveChange
            _mockCineBD.Verify(m => m.Sesiones.Add(sesion), Times.Once());
            _mockCineBD.Verify(m => m.SaveChanges(), Times.Once());
        }


        [TestMethod]
        public void BorrarSesion()
        {
            //Creamos una sesion para que nos permita borrarla
            //Debido a que no tiene proyecciones asociadas, por lo tanto, no lanzará una excepcion
            Sesion sesion = _negocio.BuscarSesion(7);
            _negocio.BorrarSesion(sesion.SesionId);

            //Comprobamos que se ha borrado y ha llamado al SaveChange
            _mockCineBD.Verify(m => m.Sesiones.Remove(sesion), Times.Once());
            _mockCineBD.Verify(m => m.SaveChanges(), Times.Once());
        }


        [TestMethod]
        public void BorrarSesionExcepcionProyeccionesAsociadas()
        {
            try
            {
                _negocio.BorrarSesion(6);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("No se puede eliminar la sesión debido a que tiene proyecciones asociadas", ex.Message);
            }
        }


        [TestMethod]
        public void ModificarSesion()
        {
            Sesion sesion = _negocio.BuscarSesion(6);
            sesion.DiaSemana = "Lunes";
            _negocio.ModificarSesion(sesion);
            _mockCineBD.Verify(m => m.SaveChanges(), Times.Once());

        }


        [TestMethod]
        public void ModificarSesionExcepcionTiempoSesionInsuficiente()
        {
            Sesion sesion = _negocio.BuscarSesion(6);
            try
            {
                sesion.FinMax = DateTime.Parse("1753-01-01 10:40:00.000");
                _negocio.ModificarSesion(sesion);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("La duracion total de la sesion es menor a la duracion de 6 peliculas", ex.Message);
            }
        }
        #endregion



        #region TESTING DE PROYECCIONES

        [TestMethod]
        public void BuscarProyeccion()
        {
            //Llamamos a la logica de la aplicacion
            Proyeccion proyeccion = _negocio.BuscarProyeccion(1, 2, DateTime.Parse("2023-02-13 00:00:00.000"));
            //Comprobamos que la proyeccion no sea nula
            Assert.IsNotNull(proyeccion);

            //Comprobamos que los datos que ha recogido de dicha proyeccion sean correctos
            Assert.AreEqual(1, proyeccion.PeliculaId);
            Assert.AreEqual(2, proyeccion.SesionId);
            Assert.AreEqual(DateTime.Parse("2023-02-13 00:00:00.000"), proyeccion.Inicio);
            Assert.AreEqual(null, proyeccion.Fin);
        }


        [TestMethod]
        public void BuscarProyeccionObtenerNull()
        {
            //Llamamos a la logica de la aplicacion
            Proyeccion proyeccion = _negocio.BuscarProyeccion(1, 50, DateTime.Parse("2023-02-13 00:00:00.000"));
            //Comprobamos que la proyeccion no sea nula
            Assert.IsNull(proyeccion);
        }


        [TestMethod]
        public void ObtenerProyecciones()
        {
            List<Proyeccion> listadoProyecciones = _negocio.obtenerProyecciones().ToList();
            //Comprobamos que el listado no sea nulo
            Assert.IsNotNull(listadoProyecciones);

            //Comprobamos que la longitud del listado sea el correspondiente
            Assert.IsTrue(listadoProyecciones.Count == 16);
        }


        [TestMethod]
        public void ObtenerProyeccionesDatosCorrectos()
        {
            List<Proyeccion> listadoProyecciones = _negocio.obtenerProyecciones().ToList();
            //Comprobamos que el listado no sea nulo
            Assert.IsNotNull(listadoProyecciones);

            //Comprobamos que la longitud del listado sea el correspondiente
            Assert.IsTrue(listadoProyecciones.Count == 16);

            Assert.AreEqual(1, listadoProyecciones[0].PeliculaId);
            Assert.AreEqual(5, listadoProyecciones[1].SesionId);
            Assert.AreEqual(DateTime.Parse("2023-02-06 00:00:00.000"), listadoProyecciones[2].Inicio);
            Assert.AreEqual(null, listadoProyecciones[3].Fin);
            Assert.AreEqual(DateTime.Parse("2023-01-08 00:00:00.000"), listadoProyecciones[14].Fin);
        }


        [TestMethod]
        public void ObtenerProyeccionesDatosIncorrectos()
        {
            List<Proyeccion> listadoProyecciones = _negocio.obtenerProyecciones().ToList();
            //Comprobamos que el listado no sea nulo
            Assert.IsNotNull(listadoProyecciones);

            //Comprobamos que la longitud del listado sea el correspondiente
            Assert.IsTrue(listadoProyecciones.Count != 10);

            Assert.AreNotEqual(2, listadoProyecciones[0].PeliculaId);
            Assert.AreNotEqual(3, listadoProyecciones[1].SesionId);
            Assert.AreNotEqual(DateTime.Parse("2023-02-16 00:00:00.000"), listadoProyecciones[2].Inicio);
            Assert.AreNotEqual(null, listadoProyecciones[10].Fin);
            Assert.AreNotEqual(DateTime.Parse("2023-01-13 00:00:00.000"), listadoProyecciones[14].Fin);
        }


        [TestMethod]
        public void CrearProyeccionSinErrores()
        {
            Proyeccion proyeccion = new Proyeccion
            {
                PeliculaId = 1,
                SesionId = 2,
                Inicio = DateTime.Parse("2023-06-20 00:00:00.000"),
                Fin = null
            };

            _negocio.CrearProyeccion(proyeccion);
            //Comprobamos que se ha añadido y que se ha llamado a SaveChange
            _mockCineBD.Verify(m => m.Proyecciones.Add(proyeccion), Times.Once());
            _mockCineBD.Verify(m => m.SaveChanges(), Times.Once());

        }


        [TestMethod]
        public void CrearProyeccionExcepcionDuracionPeliculaMayorSesion()
        {

            try
            {
                Proyeccion proyeccion = new Proyeccion
                {
                    PeliculaId = 1, //Dura 93 minutos
                    SesionId = 7, //La hemos creado con una duraccion de 10 minutos
                    Inicio = DateTime.Parse("2023-06-22 00:00:00.000"),
                    Fin = DateTime.Parse("2023-07-22 00:00:00.000")
                };

                _negocio.CrearProyeccion(proyeccion);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("La duracion de la pelicula es mayor a la duracion de la sala", ex.Message);
                Assert.AreNotEqual("error", ex.Message);
            }
        }


        [TestMethod]
        public void CrearProyeccionExcepcionProyeccionSolapada()
        {
            try
            {
                Proyeccion proyeccion = new Proyeccion
                {
                    PeliculaId = 3, //Dura 93 minutos
                    SesionId = 2, //La hemos creado con una duraccion de 10 minutos
                    Inicio = DateTime.Parse("2023-02-13 00:00:00.000"),
                    Fin = DateTime.Parse("2023-07-22 00:00:00.000")
                };

                _negocio.CrearProyeccion(proyeccion);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Ya existe una proyeccion con la misma sesion y fecha", ex.Message);
            }
        }

        
        [TestMethod]
        public void CrearProyeccionExcepcionFechasIncorrectas()
        {
            try
            {
                Proyeccion proyeccion = new Proyeccion
                {
                    PeliculaId = 3, 
                    SesionId = 2, 
                    Inicio = DateTime.Parse("2023-03-13 00:00:00.000"),
                    Fin = DateTime.Parse("2023-04-22 00:00:00.000")
                };

                _negocio.CrearProyeccion(proyeccion);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("La fecha de fin debe ser posterior a la fecha de inicio", ex.Message);
            }
        }

        
        [TestMethod]
        public void ModificarProyeccion()
        {
            Proyeccion proyeccion = _negocio.BuscarProyeccion(9, 4, DateTime.Parse("2023-02-20 00:00:00.000"));

            //Comprobamos que la proyeccion no sea nula 
            Assert.IsNotNull(proyeccion);

            //Modificamos la proyeccion
            proyeccion.Fin = DateTime.Parse("2023-10-20 00:00:00.000");
            _negocio.ModificarProyeccion(proyeccion);

            //Verificamos que se han realizado los cambios
            _mockCineBD.Verify(m => m.SaveChanges(), Times.Once());


        }

        
        [TestMethod]
        public void ModificarProyeccionExcepcionDuracionPeliculaMayorSesion()
        {
            Proyeccion proyeccion = _negocio.BuscarProyeccion(9, 4, DateTime.Parse("2023-02-20 00:00:00.000"));

            //Comprobamos que la proyeccion no sea nula 
            Assert.IsNotNull(proyeccion);
            try
            {
                //Modificamos la proyeccion
                proyeccion.SesionId = 7;
                _negocio.ModificarProyeccion(proyeccion);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("La duracion de la pelicula es mayor a la duracion de la sala", ex.Message);
            }

        }

        
        [TestMethod]
        public void ModificarProyeccionExcepcionFechasIncorectas()
        {
        Proyeccion proyeccion = _negocio.BuscarProyeccion(9, 4, DateTime.Parse("2023-02-20 00:00:00.000"));

            //Comprobamos que la proyeccion no sea nula 
            Assert.IsNotNull(proyeccion);
            try
            {
                //Modificamos la proyeccion
                proyeccion.Fin = DateTime.Parse("2023-01-20 00:00:00.000");
                _negocio.ModificarProyeccion(proyeccion);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("La fecha de fin debe ser posterior a la fecha de inicio", ex.Message);
            }
        }
        #endregion

        
    }
}

/* CONTROL DE EXCEPCIONES
 * 
 * Act and assert
    Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => account.Debit(debitAmount));
*/