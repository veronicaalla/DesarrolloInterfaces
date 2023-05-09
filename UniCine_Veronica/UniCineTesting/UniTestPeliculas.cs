using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Diagnostics;
using System.Reflection.Emit;
using System.Security.Policy;
using Moq;
using System.Linq;

namespace UniCineTesting
{
    [TestClass]
    public class UniTestPeliculas
    {
        /// <summary>
        /// Descripción resumida de UnitTestAnimales
        /// </summary>

        public UniTestPeliculas()
        {

        }


        //Variables
        private TestContext testContextInstance;
        private Mock<UniCineContext> _mockCineBD;
        private Herramientas _herramientas;
        private Pelicula _pelicula;

        [TestInitialize]
        public void Initialize()
        {
            //falseo el contesto
            _mockCineBD = new Mock<UniCineContext>();

            //Falseamos las tablas
            //1- Datos como consulta
            var datosPeliculas = new List<Pelicula>
            {
                //PeliculaId  Nombre  Duracion    Anno    Categoria   Genero  Sinopsis
                new Pelicula { PeliculaId = 1, Nombre = "Renfield", Duracion = 93, Anno = 2023, Categoria = ">18", Genero = "Terror", Sinopsis = "Vuelve el conde Dracula" },
                new Pelicula { PeliculaId = 2, Nombre = "Algo pasa con Mary", Duracion = 119, Anno = 1998, Categoria = " >12", Genero = "Comedia", Sinopsis = Todo un peliculon a la altura de zoolander },
                new Pelicula { PeliculaId = 3, Nombre = "Espíritu libre ", Duracion = 110, Anno = 2023, Categoria = ">18", Genero = "Aventura  ", Sinopsis = "La caratula es muy bonita, la pelicula ni idea" },
                new Pelicula { PeliculaId = 4, Nombre = "Amsterdam", Duracion = 125, Anno = 2022, Categoria = "Todos", Genero = "Romance", Sinopsis = "Algo de besos supongo que en los alrededores de Amsterdan" },
                new Pelicula { PeliculaId = 5, Nombre = "Sin novedad en el frente", Duracion = 162, Anno = 2022, Categoria = ">18", Genero = "Acción", Sinopsis = "Pelicula de la primera guerra mundial basada en el libro homonimo" },
                new Pelicula { PeliculaId = 6, Nombre = "Uncharted", Duracion = 113, Anno = 2022, Categoria = " >16", Genero = "Aventura", Sinopsis = "Ni idea, pero le gusta a los frikis" },
                new Pelicula { PeliculaId = 7, Nombre = "Bullet Train", Duracion = 95, Anno = 2022, Categoria = " >16", Genero = "Acción", Sinopsis = "Really Brad, no es tu mejor papel" },
                new Pelicula { PeliculaId = 8, Nombre = "Sonic ", Duracion = 108, Anno = 2023, Categoria = " Todos", Genero = "Aventura", Sinopsis = "Un erizo dando vueltas contra cosas" },
                new Pelicula { PeliculaId = 9, Nombre = "Luther", Duracion = 105, Anno = 2023, Categoria = " >18", Genero = "Acción", Sinopsis = "Detective cañero contra psicopata" }
            }.AsQueryable();

            //2-falseo la tabla
            var mockTablaPeliculas = new Mock<DbSet<Pelicula>>();
            mockTablaPeliculas.As<IQueryable<Pelicula>>().Setup(x => x.Provider).Returns(datosPeliculas.Provider);
            mockTablaPeliculas.As<IQueryable<Pelicula>>().Setup(x =>x.Expression).Returns(datosPeliculas.Expression);
            mockTablaPeliculas.As<IQueryable<Pelicula>>().Setup(x => x.ElementType).Returns(datosPeliculas.ElementType);
            mockTablaPeliculas.As<IQueryable<Pelicula>>().Setup(x => x.GetEnumerator()).Returns(datosPeliculas.GetEnumerator());
            //3-cuando se solicite la tabla cliente se devolvera un objeto falseado
            _mockCineBD.Setup(x => x.Pelicula).Returns(mockTablaPeliculas.Object);
            //falseamos la base de datos.
            _negocio = new Negocio(_mockCineBD.Object);
            Debug.WriteLine("TestInitialize");
        }


        //Install-Package Moq

        /*'Moq 4.18.4' se instaló correctamente en UniCineTesting
        No se pudieron actualizar las redirecciones de enlace de UniCineTesting\UniCineTesting.csproj : Se produjo una excepción en el destino de la invocación.
        */


    }
}
