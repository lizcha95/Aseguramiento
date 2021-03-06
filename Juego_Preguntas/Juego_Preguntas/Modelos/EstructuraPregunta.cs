﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego_Preguntas
{
    public class EstructuraPregunta
    {
        public readonly int VALOR = 1; //todas las preguntas valen 1

        public int IdPregunta { get; set; }
        public string Pregunta { get; set; }
        public int Dificultad { get; set; }
        public EstructuraRespuesta Respuesta { get; set; }

        public EstructuraPregunta(int id, string preg, int dif, EstructuraRespuesta dist)
        {
            IdPregunta = id;
            Pregunta = preg;
            Dificultad = dif;
            Respuesta = dist;
        }
    }
}
