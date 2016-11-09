using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego_Preguntas.Model.Interface
{
    interface IInteraccion
    {
        //interaccion de usuario
        string mostrarSiguientePregunta();
        List<string> mostrarRespuestas();
        bool verificarRespuesta(int idPregunta, int respuesta);

        void sumarPuntaje();
        void restarPuntaje();
        void incrementarDificultad();
        int mostrarPuntuacionFinal();
    }
}
