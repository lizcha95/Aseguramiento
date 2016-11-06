using Juego_Preguntas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoPreguntas
{
    interface IPreguntas
    {
        //archivo
        bool verificarArchivoExiste(string archivo); // Revisa si el archivo existe en la directorio
        bool verificarExtension(string archivo);
        void leerArchivo(string nombreArchivo);
        bool verificarTamanoNombreArchivo();
        bool verificarTamanoArchivo(string archivo);

        //verificar estructura preguntas
        bool verificarEstructuraPreguntas(string archivo);
        int cantidadPreguntas();

        //interaccion de usuario
        bool verificarNumIngresado(int num);
        void eliminarPregunta(int idPregunta); // try catch si pregunta es invalida
        void editarPregunta(int idPregunta, EstructuraPregunta pregunta); 
        void agregarPregunta(EstructuraPregunta pregunta);
        bool verificarPreguntaExiste(int idPregunta);
        bool verificarPreguntaExiste(EstructuraPregunta pregunta);
        int sumarPuntaje();
        int restarPuntaje();
        bool verificarRespuesta(int idPregunta, int respuesta);
        int incrementarDificultad();
    }
}
