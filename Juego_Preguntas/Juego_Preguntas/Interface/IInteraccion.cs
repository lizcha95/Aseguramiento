using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego_Preguntas.Model.Interface
{
    public interface IInteraccion
    {
        //interaccion de usuario
        void asignarPreguntasRandom(int cantidadPreguntas); 

        string mostrarSiguientePregunta();
        List<string> mostrarRespuestas(int idPregunta);
        bool verificarRespuesta(int idPregunta, int respuesta);

        void sumarPuntaje();
        void restarPuntaje();
        void incrementarDificultad();
        int mostrarPuntuacionFinal();
    }
}
