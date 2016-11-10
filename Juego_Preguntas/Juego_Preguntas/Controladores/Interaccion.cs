using Juego_Preguntas.Model.Interface;
using Juego_Preguntas.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego_Preguntas.Controller
{
    public class Interaccion : IInteraccion
    {
        public int DIFFICULTY = 1;
        public int PUNTUACION_FINAL = 0;
        public int SIG_PREGUNTA = 0;

        Preguntas PreguntasJuego = Run.Instance;

        public Preguntas leerArchivo(string nombreArchivo)
        {
            Preguntas PreguntasLeidas = new Preguntas();

            if (nombreArchivo.EndsWith(".cvs"))
            {
                var reader = new StreamReader(File.OpenRead(@"C:\test.csv"));
                while (!reader.EndOfStream)
                {
                    var linea = reader.ReadLine();
                    var valor = linea.Split(',');
                    int idPregunta = Int32.Parse(valor[0]);
                    int dificultad = Int32.Parse(valor[6]);
                    EstructuraRespuesta RespuestasLeidas = new EstructuraRespuesta(valor[2], valor[3], valor[4], valor[5]);
                    EstructuraPregunta Pregunta = new EstructuraPregunta(idPregunta, valor[1], dificultad, RespuestasLeidas);
                    PreguntasLeidas.PreguntasCargadas.Add(Pregunta);
                }                
            }
            else
            {
                throw new ArgumentException("Extensión del archivo no válida");
            }

            return PreguntasLeidas;
        }

        public void asignarPreguntasRandom(int cantidadPreguntas)
        {
            if ((cantidadPreguntas <= 0) || (PreguntasJuego.PreguntasCargadas.Count < cantidadPreguntas))
                throw new Exception("El jugador debe asignar un numero de preguntas valido");
            else
            {
                Random rnd = new Random();
                List<int> random = new List<int>();
                while (cantidadPreguntas++ != 0)
                {
                    random.Add(PreguntasJuego.PreguntasCargadas.Count);
                }
            }
            //TODO asignar preguntas al jugador
        }

        public string mostrarSiguientePregunta()
        {
            if (PreguntasJuego.PreguntasAMostrar.Count < SIG_PREGUNTA)
            { 
                string preg = PreguntasJuego.PreguntasAMostrar[SIG_PREGUNTA].Pregunta;
                ++SIG_PREGUNTA;

                return preg;
            }
            throw new NullReferenceException("No hay mas preguntas a mostrar, fin de la lista.");
        }

        public bool verificarRespuesta(int idPregunta, string respuesta)
        {
            bool encontrada = false;
            foreach (EstructuraPregunta preg in PreguntasJuego.PreguntasAMostrar)
            {
                if (preg.IdPregunta.Equals(idPregunta))
                {
                    encontrada = true;
                    if (preg.Respuesta.Respuesta.Equals(respuesta))
                        return true;
                    else
                        return false;
                }
            }
            if (!encontrada)
                throw new IndexOutOfRangeException("No existe la pregunta en las mostradas al usuario");

            return false;
        }

        public void sumarPuntaje()
        {
            PUNTUACION_FINAL += 1;
        }

        public void restarPuntaje()
        {
            PUNTUACION_FINAL -= 1;
        }


        public void incrementarDificultad()
        {
            DIFFICULTY += 1;
        }

        public int mostrarPuntuacionFinal()
        {
            return PUNTUACION_FINAL;
        }

        public List<string> mostrarRespuestas(int idPregunta)
        {
            List<string> respuestas = new List<string>();
            foreach (EstructuraPregunta preg in PreguntasJuego.PreguntasAMostrar)
            {
                if (preg.IdPregunta.Equals(idPregunta))
                {
                    foreach (EstructuraRespuesta res in preg.Respuestas)
                        respuestas.Add(res.Respuesta);
                }
            }
            if (respuestas.Count <= 0)
                throw new ArgumentException("La pregunta no tiene respuestas que mostrar");

            return respuestas;
        }
    }
}
