using JuegoPreguntas;
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
        [TestCase("cualquierArchivo.txt")]
        [TestCase("cualquierArchivo.sql")]
        [TestCase("cualquierArchivo.exe")]

        public void PruebaVerificarArchivoExiste(string nombreArchivo)
        {
            Juego Juego1 = new Juego();
            bool resultado = Juego1.verificarArchivoExiste(nombreArchivo);
            Assert.IsTrue(resultado);
        }

        [TestCase("cualquierArchivo.txt")]
        [TestCase("cualquierArchivo.sql")]
        [TestCase("cualquierArchivo.exe")]

        public void PruebaVerificarExtensionValida(string nombreArchivo)
        {
            Juego Juego1 = new Juego();
            bool resultado = Juego1.verificarExtension(nombreArchivo);
            Assert.IsTrue(resultado);
        }

        [TestCase("cualquierArchivoConUnTamanoMuyMuyGrandeGrandeGrandeGrandeGrande.txt")]
        [TestCase("cualquierArchivo.sql")]
        [TestCase("cualquierArchivo.exe")]

        public void NombreValido(string nombreArchivo)
        {
            /*Pruebas_Juego Juego1 = new Pruebas_Juego();
            bool resultado = Juego1.tamanoNombre(nombreArchivo);
            Assert.IsTrue(resultado);*/
        }

    }
}
