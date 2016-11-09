using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego_Preguntas.Model.Interface
{
    public interface IAdministracion
    {
        //administracion de preguntas        
        void agregarPregunta(EstructuraPregunta pregunta);
        void editarPregunta(int idPregunta, EstructuraPregunta pregunta);
        void eliminarPregunta(EstructuraPregunta PreguntaAEliminar); // try catch si pregunta es invalida
        bool verificarPreguntaExiste(EstructuraPregunta pregunta);
    }
}
