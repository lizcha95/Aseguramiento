using Juego_Preguntas.Model.Interface;
using Juego_Preguntas.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego_Preguntas.Controller
{
    public class Administracion : IAdministracion
    {
        List<Preguntas> PreguntasJuego = Run.Instance;

        public EstructuraPregunta crearPregunta()
        {
            return new EstructuraPregunta();
        }

        public void agregarPregunta(EstructuraPregunta pregunta)
        {
            if (!PreguntasJuego[0].PreguntasCargadas.Contains(pregunta))
                throw new ArgumentException();
            //TODO implementar la función agregar Pregunta  
        }

        public void agregarPregunta(Preguntas PreguntaAAgregar)
        {
            if (PreguntasJuego.Contains(PreguntaAAgregar))
                throw new ArgumentException();
            //TODO implementar la función agregar Pregunta  
        }

        public void editarPregunta(int idPregunta, EstructuraPregunta pregunta)
        {
            for (int i = 0; i < PreguntasJuego.Count; i++)
            {
                for (int j = 0; j < PreguntasJuego[i].PreguntasCargadas.Count; j++)
                {
                    throw new ArgumentException();
                    //TODO implementar la función editar Pregunta
                }
            }
        }

        public void editarPregunta(Preguntas PreguntaAEditar)
        {
            if (PreguntasJuego.Count == 0)
                throw new NullReferenceException();
            if (!PreguntasJuego.Contains(PreguntaAEditar))
                throw new KeyNotFoundException();
            //TODO implementar la función editar Pregunta               
        }

        public void eliminarPregunta(Preguntas PreguntaAEliminar)
        {
            if (PreguntasJuego.Count == 0)
                throw new NullReferenceException();
            if (!PreguntasJuego.Contains(PreguntaAEliminar))
                throw new KeyNotFoundException();
            //TODO implementar la función eliminar Pregunta        
        }

        public bool verificarPreguntaExiste(EstructuraPregunta pregunta)
        {
            for (int i = 0; i < PreguntasJuego.Count; i++)
            {
                if (PreguntasJuego[i].PreguntasCargadas.Contains(pregunta))
                    return true;
            }
            return false;
        }
    }
}
