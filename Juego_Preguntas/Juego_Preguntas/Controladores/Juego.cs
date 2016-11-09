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
                throw new ArgumentNullException("El archivo no existe");
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
        public bool verificarEstructuraPreguntas(object archivo)
        {
            if (archivo.GetType() == typeof(Preguntas))
                return true;
            //TODO implementar función que verifica estructura preguntas
            return false;
        }

        public int cantidadPreguntas(int cantidadPreguntasSolicitadas, int cantidadPreguntas)
        {
            if (cantidadPreguntasSolicitadas == 0)
                throw new ArgumentException();
            if (cantidadPreguntasSolicitadas >= cantidadPreguntas)
                throw new IndexOutOfRangeException();
            return cantidadPreguntasSolicitadas;
        }
    }

    
}
