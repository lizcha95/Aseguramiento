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

        public void leerArchivo(string nombreArchivo)
        {
            Preguntas PreguntasLeidas = new Preguntas();

            if (nombreArchivo.EndsWith(".csv"))
            {
                try
                { 
                    var reader = new StreamReader(File.OpenRead(nombreArchivo));
                    while (!reader.EndOfStream)
                    {
                        var linea = reader.ReadLine();
                        var valor = linea.Split(',');
                        int idPregunta = Int32.Parse(valor[0]);
                        int dificultad = Int32.Parse(valor[6]);
                        if (dificultad > 10)
                            throw new ArgumentException("Formato de archivo invalido, la dificultad no puede sobrepasar a 10");
                        EstructuraRespuesta RespuestasLeidas = new EstructuraRespuesta(valor[2], valor[3], valor[4], valor[5]);
                        EstructuraPregunta Pregunta = new EstructuraPregunta(idPregunta, valor[1], dificultad, RespuestasLeidas);
                        PreguntasLeidas.PreguntasCargadas.Add(Pregunta);
                    }
                }
                catch (Exception e)
                {
                    throw new ArgumentException("Formato de archivo invalido");
                }
            }
            else
            {
                throw new ArgumentException("Extensión del archivo no válida");
            }

            PreguntasJuego = PreguntasLeidas;
        }

        public void asignarPreguntasRandom(int cantidadPreguntas)
        {
            if ((cantidadPreguntas <= 0) || (PreguntasJuego.PreguntasCargadas.Count < cantidadPreguntas))
                throw new Exception("El jugador debe asignar un numero de preguntas valido");
            else
            {
                Random rnd = new Random();
                List<int> random = new List<int>();
                foreach(EstructuraPregunta preg in PreguntasJuego.PreguntasCargadas)
                {
                    random.Add(preg.IdPregunta);
                }
                var shuffledpregs = random.OrderBy(a => rnd.Next());
                int index = 0;
                List<EstructuraPregunta> preguntasFinales = new List<EstructuraPregunta>();
                while (index != cantidadPreguntas)
                {
                    foreach (EstructuraPregunta preg in PreguntasJuego.PreguntasCargadas)
                    {
                        if (preg.IdPregunta == shuffledpregs.ElementAt(index))
                        {
                            preguntasFinales.Add(preg);
                            ++index;
                        }
                    }
                }
                var pregsByDif = preguntasFinales.OrderBy(p => p.Dificultad);
                PreguntasJuego.PreguntasAMostrar = pregsByDif.ToList();
            }
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

        public void cambiarPuntaje(int idPregunta, int respuesta)
        {
            if (verificarRespuesta(idPregunta, respuesta))
            {
                PUNTUACION_FINAL += 1;
            }
            else
            {
                if (PUNTUACION_FINAL != 0)
                    PUNTUACION_FINAL -= 1;
            }
        }

        public void incrementarDificultad(int idPregunta, int respuesta)
        {
            if (verificarRespuesta(idPregunta, respuesta))
            {
                DIFFICULTY += 1;
            }
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
                    respuestas.Add(preg.Respuesta.Respuesta);
                    respuestas.Add(preg.Respuesta.Distractor1);
                    respuestas.Add(preg.Respuesta.Distractor2);
                    respuestas.Add(preg.Respuesta.Distractor3);

                    Random rnd = new Random();
                    var shuffledResp = respuestas.OrderBy(a => rnd.Next());
                    respuestas = shuffledResp.ToList();
                }
            }
            if (respuestas.Count <= 0)
                throw new ArgumentException("La pregunta no tiene respuestas que mostrar");

            return respuestas;
        }
    }
}
