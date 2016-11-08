using JuegoPreguntas;
using Juego_Preguntas;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas_Unidad_Juego_Preguntas.Tests1
{
    [TestFixture]
    public class TestClass
    {
        [TestCase("preguntasSobreCiencia.txt")]
        [TestCase("preguntasSobreHistoria.txt")]

        public void PruebaVerificarArchivo_ArchivoExiste_RetornaTrue(string nombreArchivo)
        {
            Juego Juego1 = new Juego();
            bool resultado = Juego1.verificarArchivoExiste(nombreArchivo);
            Assert.IsTrue(resultado);
        }

        [TestCase("")]

        public void PruebaVerificarArchivo_ArchivoNoExiste_RetornaException(string nombreArchivo)
        {
            Juego Juego1 = new Juego();
            Assert.Throws<ArgumentNullException>(() => Juego1.verificarArchivoExiste(nombreArchivo));
        }

        [TestCase("preguntasSobreCulturaGeneral.txt")]

        public void PruebaVerificarExtension_ExtensionBuena_RetornaTrue(string nombreArchivo)
        {
            Juego Juego1 = new Juego();
            bool resultado = Juego1.verificarExtension(nombreArchivo);
            Assert.IsTrue(resultado);
        }

        [TestCase("preguntasSobreHumanidad.sql")]

        public void PruebaVerificarExtension_ExtensionMala_RetornaFalse(string nombreArchivo)
        {
            Juego Juego1 = new Juego();
            bool resultado = Juego1.verificarExtension(nombreArchivo);
            Assert.IsFalse(resultado);
        }

        [TestCase("preguntasSobreAnimales.txt")]

        public void PruebaVerificarLeerArchivo_RetornaObjetoPreguntas(string nombreArchivo)
        {
            Juego Juego1 = new Juego();
            Assert.IsInstanceOf<Juego_Preguntas.Preguntas>(Juego1.leerArchivo(nombreArchivo));
        }

        [TestCase("preguntasSobreEraPaleosóica2ParaNiñosDeTercerGrado.txt")]

        public void PruebaVerificarTamanoNombreArchivo_TamanoNombreMalo_RetornaFalse(string nombreArchivo)
        {
            Juego Juego1 = new Juego();
            bool resultado = Juego1.verificarTamanoNombreArchivo(nombreArchivo);
            Assert.IsFalse(resultado);
        }

        [TestCase(1024)]

        public void PruebaVerificarTamanoArchivo_TamanoBueno_RetornaTrue(int tamano)
        {
            Juego Juego1 = new Juego();
            bool resultado = Juego1.verificarTamanoArchivo(tamano);
            Assert.IsTrue(resultado);
        }

        [TestCase(5242890)]

        public void PruebaVerificarTamanoArchivo_TamanoMalo_RetornaFalse(int tamano)
        {
            Juego Juego1 = new Juego();
            bool resultado = Juego1.verificarTamanoArchivo(tamano);
            Assert.IsFalse(resultado);
        }

        [Test]

        public void PruebaVerificarEstructuraPreguntas_EstructuraBuena_RetornaTrue()
        {
            Preguntas PreguntaPruebas = new Preguntas();
            Juego Juego1 = new Juego();
            bool resultado = Juego1.verificarEstructuraPreguntas(PreguntaPruebas);
            Assert.IsTrue(resultado);
        }

        [Test]

        public void PruebaVerificarEstructuraPreguntas_EstructuraMala_RetornaFalse()
        {
            string PreguntaPruebas = "Este es un string de prueba";
            Juego Juego1 = new Juego();
            bool resultado = Juego1.verificarEstructuraPreguntas(PreguntaPruebas);
            Assert.IsFalse(resultado);
        }

        [TestCase(0, 10)]

        public void PruebaVerificarCantidadPreguntasIngresadas_CantidadCero_RetornaExcepcion(int num, int cantidadPreguntas)
        {
            Juego Juego1 = new Juego();
            Assert.Throws<ArgumentException>(() => Juego1.cantidadPreguntas(num, cantidadPreguntas));
        }

        [TestCase(10, 5)]

        public void PruebaVerificarCantidadPreguntasIngresadas_CantidadMala_RetornaExcepcion(int num, int cantidadPreguntas)
        {
            Juego Juego1 = new Juego();
            Assert.Throws<IndexOutOfRangeException>(() => Juego1.cantidadPreguntas(num, cantidadPreguntas));
        }

        [Test]

        public void PruebaVerificarEliminarPregunta_ListaPreguntasVacia_RetornaExcepcion()
        {
            Juego Juego1 = new Juego();
            Preguntas PreguntaAEliminar = new Preguntas();
            Assert.Throws<NullReferenceException>(() => Juego1.eliminarPregunta(PreguntaAEliminar));
        }

        [Test]

        public void PruebaVerificarEliminarPregunta_PreguntaNoExisteEnLista_RetornaExcepcion()
        {
            Juego Juego1 = new Juego();
            Preguntas PreguntaAEliminar = new Preguntas();
            Preguntas PreguntaPrueba = new Preguntas();
            Juego1.PreguntasJuego.Add(PreguntaPrueba);
            Assert.Throws<KeyNotFoundException>(() => Juego1.eliminarPregunta(PreguntaAEliminar));
        }

        [Test]

        public void PruebaVerificarEditarPregunta_ListaPreguntasVacia_RetornaExcepcion()
        {
            Juego Juego1 = new Juego();
            Preguntas PreguntaAEditar = new Preguntas();
            Assert.Throws<NullReferenceException>(() => Juego1.eliminarPregunta(PreguntaAEditar));
        }

        [Test]

        public void PruebaVerificarEditarPregunta_PreguntaNoExisteEnLista_RetornaExcepcion()
        {
            Juego Juego1 = new Juego();
            Preguntas PreguntaAEditar = new Preguntas();
            Preguntas PreguntaPrueba = new Preguntas();
            Juego1.PreguntasJuego.Add(PreguntaPrueba);
            Assert.Throws<KeyNotFoundException>(() => Juego1.eliminarPregunta(PreguntaAEditar));
        }

        [Test]

        public void PruebaVerificarAgregarPregunta_PreguntaYaExisteEnLista_RetornaExcepcion()
        {
            Juego Juego1 = new Juego();
            Preguntas PreguntaAAgregar = new Preguntas();
            Juego1.PreguntasJuego.Add(PreguntaAAgregar);
            Assert.Throws<ArgumentException>(() => Juego1.agregarPregunta(PreguntaAAgregar));
        }
    }
}
