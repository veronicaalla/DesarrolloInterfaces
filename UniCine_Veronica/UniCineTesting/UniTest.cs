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
        private TestContext testContextInstance;
        private Mock<UniCineContext> _mockCineBD;
        private Negocio _negocio;

        [TestInitialize]
        public void Initialize()
        {
            //falseo el contesto
            _mockCineBD = new Mock<UniCineContext>();

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
                new Pelicula { PeliculaId = 9, Nombre = "Luther", Duracion = 105, Anno = 2023, Categoria = " >18", Genero = "Acción", Sinopsis = "Detective cañero contra psicopata" }
            }.AsQueryable();

            //2-falseo la tabla Peliculas
            var mockTablaPeliculas = new Mock<DbSet<Pelicula>>();
            mockTablaPeliculas.As<IQueryable<Pelicula>>().Setup(x => x.Provider).Returns(datosPeliculas.Provider);
            mockTablaPeliculas.As<IQueryable<Pelicula>>().Setup(x => x.Expression).Returns(datosPeliculas.Expression);
            mockTablaPeliculas.As<IQueryable<Pelicula>>().Setup(x => x.ElementType).Returns(datosPeliculas.ElementType);
            mockTablaPeliculas.As<IQueryable<Pelicula>>().Setup(x => x.GetEnumerator()).Returns(datosPeliculas.GetEnumerator());
            //3-cuando se solicite la tabla cliente se devolvera un objeto falseado
            _mockCineBD.Setup(x => x.Peliculas).Returns(mockTablaPeliculas.Object);
            //falseamos la base de datos.
            _negocio = new Negocio(_mockCineBD.Object);



            //2. Datos como consulta de Sesiones
            var datosSesiones = new List<Sesion>
            {
               
                //SesionId	Sala	DiaSemana	Comienzo	FinMax	Precio	Aforo
                new Sesion { SesionId= 1 , Sala=" SALA 1", DiaSemana="Domingo", Comienzo= DateTime.Parse("1753-01-01 20:45:00.000") ,FinMax = DateTime.Parse("1753 - 01 - 01 23:30:00.000" ), Precio = 7 , Aforo = 200},
                new Sesion { SesionId= 1 , Sala=" SALA 1", DiaSemana="Domingo", Comienzo= 1753-01-01 20:45:00.000 ,FinMax = 1753 - 01 - 01 23:30:00.000  , Precio = 7 , Aforo = 200}
            }.AsQueryable();
            

            Debug.WriteLine("TestInitialize");
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
    Pelicula peliculaTest = _negocio.BuscarPelicula(10);

    //revisamos los resultados
    //Comprobamos que el cliente no es nulo (sabemos que existe)
    Assert.IsNull(peliculaTest);
}


[TestMethod]
public void ObtenerPeliculas()
{
    //Llamamos a la logica del negocio
    List<Pelicula> listadoPeliculas = _negocio.obtenerPeliculas().ToList();

    //Comprobamos que la lista no sea nula
    Assert.IsNotNull(listadoPeliculas);
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
    Assert.AreEqual(9, listadoPeliculas.Count);
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
    Pelicula pelicula = new Pelicula
    {
        PeliculaId = 10,
        Nombre = "A traves de mi ventana",
        Duracion = 113,
        Anno = 2022,
        Categoria = ">16",
        Genero = "Romance",
        Sinopsis = "La atracción de Raquel por su vecino se convierte en algo más cuando él empieza a " +
                    "enamorarse de ella, a pesar de la oposición de su familia."
    };

    _negocio.CrearPelicula(pelicula);
    //Comprobamos que se ha añadido y llamamos al SaveChange
    _mockCineBD.Verify(m => m.SaveChanges(), Times.Once());

}


[TestMethod]
public void CrearPeliculaNombreCampoVacio()
{
    Pelicula pelicula = new Pelicula
    {
        PeliculaId = 10,
        Duracion = 113,
        Anno = 2022,
        Categoria = ">16",
        Genero = "Romance",
        Sinopsis = "La atracción de Raquel por su vecino se convierte en algo más cuando él empieza a " +
                    "enamorarse de ella, a pesar de la oposición de su familia."
    };

    _negocio.CrearPelicula(pelicula);

    //Nos tiene que dar error por que el Nombre es vacio

}

[TestMethod]
public void EliminarPelicula()
{

}


[TestMethod]
public void EliminarPeliculaLanzaExcepcionSesionesAsociadas()
{

}

[TestMethod]
public void ModificarPelicula()
{

}

[TestMethod]
public void ModificarPeliculaLanzaExcepcionDuracionInecesaria()
{

}
        #endregion


        #region TESTING DE PELICULAS

        #endregion
    }
}
