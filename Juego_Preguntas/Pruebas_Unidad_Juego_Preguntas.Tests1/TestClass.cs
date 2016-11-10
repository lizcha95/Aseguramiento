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
        [TestCase("C:\\Temp\\preguntas.csv")]
        public void PruebaVerificarleerArchivo(string nombreArchivo)
        {
            var Interaccion1 = Substitute.For<Interaccion>();
            Interaccion1.leerArchivo(nombreArchivo);
            Assert.IsNotNull(Run.Instance);
        }

        [TestCase(6)]
        [TestCase(2)]
        [TestCase(9)]
        public void PruebaVerificarAsignarPreguntasRandom(int cantidadPreguntas)
        {
            var Interaccion1 = Substitute.For<Interaccion>();
            Interaccion1.leerArchivo("C:\\Temp\\preguntas.csv");
            Interaccion1.asignarPreguntasRandom(cantidadPreguntas);
            Assert.IsNotNull(Run.Instance.PreguntasAMostrar);

        }

        [Test]
        public void PruebaVerificarMostrarSiguientePregunta()
        {
            Interaccion Interaccion1 = new Interaccion();
            Assert.Throws<NullReferenceException>(() => Interaccion1.mostrarSiguientePregunta());
        }

        [TestCase(1, "Cortázar")]
        public void PruebaVerificarRespuesta(int idPregunta, string respuesta)
        {
            Interaccion Interaccion1 = new Interaccion();
            Assert.Throws<IndexOutOfRangeException>(() => Interaccion1.verificarRespuesta(idPregunta, respuesta));
        }

        [TestCase("preguntasSobreCiencia.cvs")]
        public void PruebaVerificarExtensionArchivo(string nombreArchivo)
        {
            Interaccion Interaccion1 = new Interaccion();
            StringAssert.EndsWith(".cvs", nombreArchivo);
        }


        [Test]
        public void PruebaVerificarEliminarPregunta_ListaPreguntasVacia_RetornaExcepcion()
        {
            Administracion Admin = new Administracion();
            EstructuraRespuesta RespuestaAEliminar = new EstructuraRespuesta("Respuesta1", "Distractor1", "Distractor2", "Distractor3");
            EstructuraPregunta PreguntaAEliminar = new EstructuraPregunta(1, "Pregunta 1", 1, RespuestaAEliminar);
            Assert.Throws<KeyNotFoundException>(() => Admin.eliminarPregunta(PreguntaAEliminar));
        }

        [Test]
        public void PruebaVerificarEliminarPregunta_PreguntaNoExisteEnLista_RetornaExcepcion()
        {
            Administracion Admin = new Administracion();
            EstructuraRespuesta RespuestaAEliminar = new EstructuraRespuesta("Respuesta1", "Distractor1", "Distractor2", "Distractor3");
            EstructuraRespuesta RespuestaPrueba = new EstructuraRespuesta("Respuesta1", "Distractor1", "Distractor2", "Distractor3");
            EstructuraPregunta PreguntaAEliminar = new EstructuraPregunta(1, "Pregunta 1", 1, RespuestaAEliminar);
            EstructuraPregunta PreguntaPrueba = new EstructuraPregunta(2, "Pregunta 2", 2, RespuestaPrueba);
            Run.Instance.PreguntasCargadas.Add(PreguntaPrueba);
            Assert.Throws<KeyNotFoundException>(() => Admin.eliminarPregunta(PreguntaAEliminar));
        }

        [Test]
        public void PruebaVerificarEditarPregunta_ListaPreguntasVacia_RetornaExcepcion()
        {
            Administracion Admin = new Administracion();
            EstructuraRespuesta RespuestaAEditar = new EstructuraRespuesta("Respuesta1", "Distractor1", "Distractor2", "Distractor3");
            EstructuraPregunta PreguntaAEditar = new EstructuraPregunta(2, "Pregunta1", 2, RespuestaAEditar);
            Assert.Throws<KeyNotFoundException>(() => Admin.eliminarPregunta(PreguntaAEditar));
        }

        [Test]
        public void PruebaVerificarEditarPregunta_PreguntaNoExisteEnLista_RetornaExcepcion()
        {
            var Admin = Substitute.For<Administracion>();
            EstructuraRespuesta RespuestaAEditar = new EstructuraRespuesta("Respuesta1", "Distractor1", "Distractor2", "Distractor3");
            EstructuraRespuesta RespuestaPrueba = new EstructuraRespuesta("Respuesta1", "Distractor1", "Distractor2", "Distractor3");
            EstructuraPregunta PreguntaAEditar = new EstructuraPregunta(1, "Pregunta 1", 1, RespuestaAEditar);
            EstructuraPregunta PreguntaPrueba = new EstructuraPregunta(2, "Pregunta 2", 1, RespuestaPrueba);
            Run.Instance.PreguntasCargadas.Add(PreguntaPrueba);
            Assert.Throws<NullReferenceException>(() => Admin.editarPregunta(PreguntaAEditar.IdPregunta, PreguntaAEditar));
        }

        [Test]
        public void PruebaVerificarAgregarPregunta_PreguntaYaExisteEnLista_RetornaExcepcion()
        {
            var admin = Substitute.For<Administracion>();
            var preguntas = Substitute.For<Preguntas>();
            EstructuraRespuesta RespuestaACargar = new EstructuraRespuesta("Respuesta1", "Distractor1", "Distractor2", "Distractor3");
            preguntas.PreguntasCargadas = new List<EstructuraPregunta> { new EstructuraPregunta(1, "Pregunta 1", 1, RespuestaACargar) };
            Run.Instance.PreguntasCargadas = preguntas.PreguntasCargadas;

            EstructuraRespuesta RespuestaAAgregar = new EstructuraRespuesta("Respuesta1", "Distractor1", "Distractor2", "Distractor3");
            EstructuraPregunta PreguntaAAgregar = new EstructuraPregunta(1, "Pregunta 1", 1, RespuestaAAgregar);
            Assert.Throws<ArgumentException>(() => admin.agregarPregunta(PreguntaAAgregar));
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
            EstructuraRespuesta RespuestaAEditar = new EstructuraRespuesta("Respuesta1", "Distractor1", "Distractor2", "Distractor3");
            EstructuraPregunta preguntaAEditar = new EstructuraPregunta(1, "Pregunta 1", 1, RespuestaAEditar);
            Assert.Throws<NullReferenceException>(() => admin.editarPregunta(1, preguntaAEditar));
        }

        [Test]
        public void PruebaAgregarPregunta_Exitosamente()
        {
            var admin = Substitute.For<Administracion>();
            var preguntas = Substitute.For<Preguntas>();
            EstructuraRespuesta RespuestaAAgregar = new EstructuraRespuesta("Respuesta1", "Distractor1", "Distractor2", "Distractor3");
            EstructuraPregunta PreguntaAAgregar = new EstructuraPregunta(1, "Pregunta 1", 1, RespuestaAAgregar);
            Run.Instance.PreguntasCargadas = preguntas.PreguntasCargadas;
            Assert.DoesNotThrow(() => admin.agregarPregunta(PreguntaAAgregar));
            Assert.IsTrue(admin.Received().existePregunta(PreguntaAAgregar));
        }

        [Test]
        public void PruebaVerificarPreguntaExiste_ListaExiste_RetornaTrue()
        {
            Administracion admin = new Administracion();
            EstructuraRespuesta RespuestaAAgregar = new EstructuraRespuesta("Respuesta1", "Distractor1", "Distractor2", "Distractor3");
            EstructuraPregunta PreguntaAAgregar = new EstructuraPregunta(1, "Pregunta 1", 1, RespuestaAAgregar);
            Run.Instance.PreguntasCargadas.Add(PreguntaAAgregar);
            Assert.IsTrue(admin.verificarPreguntaExiste(PreguntaAAgregar));
        }

        [Test]
        public void PruebaVerificarPreguntaExiste_ListaExiste_RetornaFalse()
        {
            Administracion admin = new Administracion();
            EstructuraRespuesta RespuestaAAgregar = new EstructuraRespuesta("Respuesta1", "Distractor1", "Distractor2", "Distractor3");
            EstructuraPregunta PreguntaAAgregar = new EstructuraPregunta(1, "Pregunta 1", 1, RespuestaAAgregar);
            Assert.IsTrue(admin.verificarPreguntaExiste(PreguntaAAgregar));
        }

        [TestCase(1)]
        public void PruebaMostrarRespuesta_RetornaExcepcion(int numeroPregunta)
        {
            Interaccion interaccion = new Interaccion();
            Assert.Throws<ArgumentException>(() => interaccion.mostrarRespuestas(numeroPregunta));
        }

        [Test]
        public void PruebaVerificarIncrementoPuntaje()
        {
            Interaccion Interaccion = new Interaccion();
            EstructuraRespuesta respuesta = new EstructuraRespuesta("respuesta", "distractor", "distractor", "distractor");
            EstructuraPregunta pregunta = new EstructuraPregunta(1, "Pregunta 1", 1, respuesta);
            Run.Instance.PreguntasCargadas.Add(pregunta);
            Interaccion.cambiarPuntaje(1, "respuesta");
            Assert.Equals(Interaccion.PUNTUACION_FINAL, 1);
        }

        [Test]
        public void PruebaVerificarDecrementoPuntaje()
        {
            Interaccion Interaccion = new Interaccion();
            EstructuraRespuesta respuesta = new EstructuraRespuesta("respuesta", "distractor", "distractor", "distractor");
            EstructuraPregunta pregunta = new EstructuraPregunta(1, "Pregunta 1", 1, respuesta);
            Run.Instance.PreguntasCargadas.Add(pregunta);
            Interaccion.cambiarPuntaje(1, "distractor");
            Assert.Equals(Interaccion.PUNTUACION_FINAL, 0);
        }
    }
}
