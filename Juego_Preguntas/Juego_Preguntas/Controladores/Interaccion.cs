using Juego_Preguntas.Model.Interface;
using Juego_Preguntas.UI;
using System;
using System.Collections.Generic;
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

        List<Preguntas> PreguntasJuego = Run.Instance;

        public string mostrarSiguientePregunta()
        {
            int PreguntasActuales = 0;
            return PreguntasJuego[PreguntasActuales].PreguntasCargadas[SIG_PREGUNTA].Pregunta;
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

        public List<string> mostrarRespuestas()
        {
            List<string> respuestas = new List<string>();
            for (int i = 0; i < PreguntasJuego.Count; i++)
            {
                throw new ArgumentException();
                //TODO implementar la función mostrar respuestas
            }
            return respuestas;
        }

        
    }
}
