using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego_Preguntas.Model.Interface
{
    public interface IInteraccion
    {
        Preguntas leerArchivo(string nombreArchivo);

        //interaccion de usuario
        void asignarPreguntasRandom(int cantidadPreguntas); 

        string mostrarSiguientePregunta();
        List<string> mostrarRespuestas(int idPregunta);
        bool verificarRespuesta(int idPregunta, string respuesta);

        void cambiarPuntaje(int idPregunta, int respuesta);
        void incrementarDificultad();
        int mostrarPuntuacionFinal();
    }
}
