﻿using Juego_Preguntas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoPreguntas
{
    interface IJuego
    {
        //archivo
        bool verificarArchivoExiste(string archivo); // Revisa si el archivo existe en la directorio
        bool verificarExtension(string archivo);
        Preguntas leerArchivo(string nombreArchivo);
        bool verificarTamanoNombreArchivo(string nombreArchivo);
        bool verificarTamanoArchivo(int tamano);

        //verificar estructura preguntas
        bool verificarEstructuraPreguntas(object archivo);
        int cantidadPreguntas(int cantidadPreguntas);

        //administracion de preguntas
        void agregarPregunta(EstructuraPregunta pregunta);
        void editarPregunta(int idPregunta, EstructuraPregunta pregunta);
        void eliminarPregunta(int idPregunta); // try catch si pregunta es invalida

        //interaccion de usuario
        bool verificarPreguntaExiste(int idPregunta);
        bool verificarPreguntaExiste(EstructuraPregunta pregunta);

        string mostrarSiguientePregunta();
        List<string> mostrarRespuestas();
        bool verificarNumIngresado(int num);
        bool verificarRespuesta(int idPregunta, int respuesta);

        int sumarPuntaje();
        int restarPuntaje();
        int incrementarDificultad();
        string mostrarPuntuacionFinal();
    }
}
