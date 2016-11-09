using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego_Preguntas.Model.Interface
{
    interface IAdministracion
    {
        //administracion de preguntas
        EstructuraPregunta crearPregunta();
        
        void agregarPregunta(EstructuraPregunta pregunta);
        void agregarPregunta(Preguntas PreguntaAAgregar);

        void editarPregunta(Preguntas PreguntaAEditar);
        void editarPregunta(int idPregunta, EstructuraPregunta pregunta);

        void eliminarPregunta(Preguntas PreguntaAEliminar); // try catch si pregunta es invalida

        bool verificarPreguntaExiste(EstructuraPregunta pregunta);
    }
}
