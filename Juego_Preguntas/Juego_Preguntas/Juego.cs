using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Juego_Preguntas;

namespace JuegoPreguntas
{
    public class Juego : IJuego
    {
        private readonly int MAX_SIZE = (5 * 1024 * 1024);

        // Funciones que revisan el archivo y su consistencia

        // Revisa si el archivo existe en la directorio
        public bool verificarArchivoExiste(string archivo)  
        {
            if (string.IsNullOrEmpty(archivo))
                throw new ArgumentNullException();
            //TODO implementar funcion de buscar archivo
            return true;
        }

        public bool verificarExtension(string archivo)
        {
            if (!archivo.EndsWith(".txt"))
                return false;

            //TODO verificar
            return true;
        }

        public Preguntas leerArchivo(string nombreArchivo)
        {
            //TODO implementar funcion de leer archivo
            return new Preguntas();
        }

        public bool verificarTamanoNombreArchivo(string nombreArchivo)
        {
            //TODO implementar funcion de verificar tamano del nombre del archivo
            if (nombreArchivo.Length > 50)
                return false;

            return true;
        }

        /// <summary>
        /// Verifica tamano de archivo, no puede ser mayor a 5 Mb
        /// </summary>
        public bool verificarTamanoArchivo(int tamano)
        {
            if (tamano > MAX_SIZE)
                return false;
            //TODO implementar funcion de verificar tamano del archivo
            return true;
        }

        // Funciones que verifican que la estructura de las preguntas esté correcta
        public bool verificarEstructuraPreguntas(string archivo)
        {
            throw new NotImplementedException();
        }
        public int cantidadPreguntas()
        {
            throw new NotImplementedException();
        }

        // Funciones de interacción del usuario con 
        public bool verificarNumIngresado(int num)
        {
            throw new NotImplementedException();
        }
        public void eliminarPregunta(int idPregunta) 
        {
            throw new NotImplementedException();
        }
        public void editarPregunta(int idPregunta, Juego pregunta)
        {
            throw new NotImplementedException();
        }
        public void agregarPregunta(Juego pregunta)
        {
            throw new NotImplementedException();
        }
        public bool verificarPreguntaExiste(int idPregunta)
        {
            throw new NotImplementedException();
        }
        public int sumarPuntaje()
        {
            throw new NotImplementedException();
        }
        public int restarPuntaje()
        {
            throw new NotImplementedException();
        }
        public bool verificarRespuesta(int idPregunta, int respuesta)
        {
            throw new NotImplementedException();
        }
        public int incrementarDificultad()
        {
            throw new NotImplementedException();
        }

        public void editarPregunta(int idPregunta, EstructuraPregunta pregunta)
        {
            throw new NotImplementedException();
        }

        public void agregarPregunta(EstructuraPregunta pregunta)
        {
            throw new NotImplementedException();
        }

        public bool verificarPreguntaExiste(EstructuraPregunta pregunta)
        {
            throw new NotImplementedException();
        }

        public string mostrarSiguientePregunta()
        {
            throw new NotImplementedException();
        }

        public List<string> mostrarRespuestas()
        {
            throw new NotImplementedException();
        }

        public string mostrarPuntuacionFinal()
        {
            throw new NotImplementedException();
        }
    }
}
