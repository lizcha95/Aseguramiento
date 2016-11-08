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
        int MAX_DIFFICULTY = 1;
        int PUNTUACION_FINAL = 0;
        int SIG_PREGUNTA = 0;
        public List<Preguntas> PreguntasJuego = new List<Preguntas>();

       
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

        public void eliminarPregunta(Preguntas PreguntaAEliminar) 
        {
            if (PreguntasJuego.Count == 0)
                throw new NullReferenceException();
            if (!PreguntasJuego.Contains(PreguntaAEliminar))
                throw new KeyNotFoundException();
            //TODO implementar la función eliminar Pregunta        
        }

        public void editarPregunta(Preguntas PreguntaAEditar)
        {
            if (PreguntasJuego.Count == 0)
                throw new NullReferenceException();
            if (!PreguntasJuego.Contains(PreguntaAEditar))
                throw new KeyNotFoundException();
            //TODO implementar la función editar Pregunta               
        }

        public void agregarPregunta(Preguntas PreguntaAAgregar)
        {
            if (PreguntasJuego.Contains(PreguntaAAgregar))
                throw new ArgumentException();
            //TODO implementar la función agregar Pregunta  
        }

        public void sumarPuntaje()
        {
            PUNTUACION_FINAL += 1;
        }

        public void restarPuntaje()
        {
            PUNTUACION_FINAL -= 1;
        }

        public bool verificarRespuesta(int idPregunta, int respuesta)
        {
            for (int i = 0; i < PreguntasJuego.Count; i++)
            {
                for (int j = 0; j < PreguntasJuego[i].PreguntasCargadas.Count; j++)
                {
                    if (PreguntasJuego[i].PreguntasCargadas[j].IdPregunta == idPregunta)
                        return true;
                    //TODO implementar la función verificar respuesta
                }
            }
            return false;
        }
        public void incrementarDificultad()
        {
            MAX_DIFFICULTY += 1;
        }

        public void editarPregunta(int idPregunta, EstructuraPregunta pregunta)
        {
            for (int i = 0; i < PreguntasJuego.Count; i++)
            {
                for (int j = 0; j < PreguntasJuego[i].PreguntasCargadas.Count; j++)
                {
                    throw new ArgumentException();
                    //TODO implementar la función editar Pregunta
                }
            }
        }

        public void agregarPregunta(EstructuraPregunta pregunta)
        {
            if (!PreguntasJuego[0].PreguntasCargadas.Contains(pregunta))
                throw new ArgumentException();
            //TODO implementar la función agregar Pregunta  
        }

        public bool verificarPreguntaExiste(EstructuraPregunta pregunta)
        {
            for(int i = 0; i < PreguntasJuego.Count; i++)
            {
                if (PreguntasJuego[i].PreguntasCargadas.Contains(pregunta))
                    return true;
            }
            return false;
        }

        public string mostrarSiguientePregunta()
        {
            int PreguntasActuales = 0;
            return PreguntasJuego[PreguntasActuales].PreguntasCargadas[SIG_PREGUNTA].Pregunta;
        }

        public List<string> mostrarRespuestas()
        {
            List<string> respuestas = new List<string>();
            for (int i = 0; i < PreguntasJuego.Count; i++)
            {
                //TODO implementar la función mostrar respuestas
            }
            return respuestas;
        }

        public int mostrarPuntuacionFinal()
        {
            return PUNTUACION_FINAL;
        }
    }
}
