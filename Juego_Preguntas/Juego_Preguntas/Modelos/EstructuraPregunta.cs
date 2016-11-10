using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego_Preguntas
{
    public class EstructuraPregunta
    {
        public readonly int MIN_DIFICULTAD = 1;
        public readonly int MAX_DIFICULTAD = 10;
        public readonly int VALOR = 1; //todas las preguntas valen 1

        public int IdPregunta { get; set; }
        public string Pregunta { get; set; }
        public int Dificultad { get; set; }
        public List<EstructuraRespuesta> Respuestas;

        public EstructuraPregunta()
        {
            Respuestas = new List<EstructuraRespuesta>();
        }

        public EstructuraPregunta(int id, string preg, int dif, List<EstructuraRespuesta> dist)
        {
            IdPregunta = id;
            Pregunta = preg;
            Dificultad = dif;
            Respuestas = dist;
        }
    }
}
