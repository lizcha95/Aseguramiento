using JuegoPreguntas;
using Juego_Preguntas;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Juego_Preguntas.Controller;
using Juego_Preguntas.UI;
using Juego_Preguntas.Model.Interface;
using NSubstitute;

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
            Administracion Admin = new Administracion();
            EstructuraPregunta PreguntaAEliminar = new EstructuraPregunta(1, "Pregunta 1", 1, new List<EstructuraRespuesta>());
            Assert.Throws<KeyNotFoundException>(() => Admin.eliminarPregunta(PreguntaAEliminar));
        }

        [Test]
        public void PruebaVerificarEliminarPregunta_PreguntaNoExisteEnLista_RetornaExcepcion()
        {
            Administracion Admin = new Administracion();
            EstructuraPregunta PreguntaAEliminar = new EstructuraPregunta(1, "Pregunta 1", 1, new List<EstructuraRespuesta>());
            EstructuraPregunta PreguntaPrueba = new EstructuraPregunta(2, "Pregunta 2", 2, new List<EstructuraRespuesta>());
            Run.Instance.PreguntasCargadas.Add(PreguntaPrueba);
            Assert.Throws<KeyNotFoundException>(() => Admin.eliminarPregunta(PreguntaAEliminar));
        }

        [Test]
        public void PruebaVerificarEditarPregunta_ListaPreguntasVacia_RetornaExcepcion()
        {
            Administracion Admin = new Administracion();
            EstructuraPregunta PreguntaAEditar = new EstructuraPregunta();
            Assert.Throws<KeyNotFoundException>(() => Admin.eliminarPregunta(PreguntaAEditar));
        }

        [Test]
        public void PruebaVerificarEditarPregunta_PreguntaNoExisteEnLista_RetornaExcepcion()
        {
            Administracion Admin = new Administracion();
            EstructuraPregunta PreguntaAEditar = new EstructuraPregunta(1, "Pregunta 1", 1, new List<EstructuraRespuesta>());
            EstructuraPregunta PreguntaPrueba = new EstructuraPregunta(2, "Pregunta 2", 1, new List<EstructuraRespuesta>());
            Run.Instance.PreguntasCargadas.Add(PreguntaPrueba);
            Assert.Throws<KeyNotFoundException>(() => Admin.eliminarPregunta(PreguntaAEditar));
        }

        [Test]
        public void PruebaVerificarAgregarPregunta_PreguntaYaExisteEnLista_RetornaExcepcion()
        {
            var admin = Substitute.For<Administracion>();
            var preguntas = Substitute.For<Preguntas>();
            preguntas.PreguntasCargadas = new List<EstructuraPregunta> { new EstructuraPregunta(1, "Pregunta 1", 1, new List<EstructuraRespuesta>()) };
            Run.Instance.PreguntasCargadas = preguntas.PreguntasCargadas;

            EstructuraPregunta PreguntaAAgregar = new EstructuraPregunta(1, "Pregunta 1", 1, new List<EstructuraRespuesta>());
            Assert.Throws<ArgumentException>(() => admin.agregarPregunta(PreguntaAAgregar));
        }

        [Test]
        public void PruebaIncrementarDificultad_Retorna1()
        {
            Interaccion interaccion = new Interaccion();
            interaccion.incrementarDificultad();
            Assert.AreEqual(interaccion.DIFFICULTY, 2);
        }

        [Test]
        public void PruebaPuntajeFinalInicial_Retorna0()
        {
            Interaccion interaccion = new Interaccion();
            Assert.AreEqual(interaccion.PUNTUACION_FINAL, 0);
        }

        [Test]
        public void PruebaPuntajeFinal_Mas4_Retorna4()
        {
            Interaccion interaccion = new Interaccion();
            interaccion.PUNTUACION_FINAL += 4;
            Assert.AreEqual(interaccion.PUNTUACION_FINAL, 4);
        }

        [Test]
        public void PruebaEditarPregunta_RetornaExcepcion()
        {
            Administracion admin = new Administracion();
            EstructuraPregunta preguntaAEditar = new EstructuraPregunta(1, "Pregunta 1", 1, new List<EstructuraRespuesta>());
            Assert.Throws<NullReferenceException>(() => admin.editarPregunta(1, preguntaAEditar));
        }

        [Test]
        public void PruebaAgregarPregunta_Exitosamente()
        {
            var admin = Substitute.For<Administracion>();
            var preguntas = Substitute.For<Preguntas>();
            EstructuraPregunta PreguntaAAgregar = new EstructuraPregunta(1, "Pregunta 1", 1, new List<EstructuraRespuesta>());
            Run.Instance.PreguntasCargadas = preguntas.PreguntasCargadas;
            Assert.DoesNotThrow(() => admin.agregarPregunta(PreguntaAAgregar));
            Assert.IsTrue(admin.Received().existePregunta(PreguntaAAgregar));
        }

        [Test]
        public void PruebaVerificarPreguntaExiste_ListaExiste_RetornaTrue()
        {
            Administracion admin = new Administracion();
            EstructuraPregunta PreguntaAAgregar = new EstructuraPregunta(1, "Pregunta 1", 1, new List<EstructuraRespuesta>());
            admin.agregarPregunta(PreguntaAAgregar);
            Assert.IsTrue(admin.verificarPreguntaExiste(PreguntaAAgregar));
        }

        [Test]
        public void PruebaVerificarPreguntaExiste_ListaExiste_RetornaFalse()
        {
            Administracion admin = new Administracion();
            EstructuraPregunta PreguntaAAgregar = new EstructuraPregunta(1, "Pregunta 1", 1, new List<EstructuraRespuesta>());
            Assert.IsTrue(admin.verificarPreguntaExiste(PreguntaAAgregar));
        }

        [TestCase(1)]
        public void PruebaMostrarRespuesta_RetornaExcepcion(int numeroPregunta)
        {
            Interaccion interaccion = new Interaccion();
            Assert.Throws<ArgumentException>(() => interaccion.mostrarRespuestas(numeroPregunta));
        }
    }
}
