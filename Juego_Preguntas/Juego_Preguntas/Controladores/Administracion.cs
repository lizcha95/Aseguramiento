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
        Preguntas PreguntasJuego = Run.Instance;

        public bool existePregunta(EstructuraPregunta pregunta)
        {
            bool encontrada = false;
            if (PreguntasJuego.PreguntasCargadas.Count <= 0)
                return false;

            foreach (EstructuraPregunta preg in PreguntasJuego.PreguntasCargadas)
            {
                if (preg.Pregunta.Equals(pregunta.Pregunta))
                {
                    encontrada = true;
                }
            }
            return encontrada;
        }

        public void agregarPregunta(EstructuraPregunta pregunta)
        {
            if (existePregunta(pregunta))
                throw new ArgumentException();

            int index = 0;
            EstructuraPregunta preg = PreguntasJuego.PreguntasCargadas.LastOrDefault<EstructuraPregunta>();
            if (preg != null)
                index = preg.IdPregunta;

            //TODO implementar la función agregar Pregunta  
            pregunta.IdPregunta = index;
            PreguntasJuego.PreguntasCargadas.Add(pregunta);
        }

        public void editarPregunta(int idPregunta, EstructuraPregunta pregunta)
        {
            bool encontrada = false;
            foreach (EstructuraPregunta preg in PreguntasJuego.PreguntasCargadas)
            {
                if (preg.IdPregunta.Equals(idPregunta))
                {
                    encontrada = true;
                    //TODO implementar edit
                }
            }
            if (!encontrada)
                throw new NullReferenceException("No existe la pregunta");
            
        }

        public void eliminarPregunta(EstructuraPregunta PreguntaAEliminar)
        {
            if (existePregunta(PreguntaAEliminar))
            {
                int index = 0;
                foreach (EstructuraPregunta preg in PreguntasJuego.PreguntasCargadas)
                {
                    if (preg.IdPregunta.Equals(PreguntaAEliminar.IdPregunta))
                    {
                        PreguntasJuego.PreguntasCargadas.RemoveAt(index);
                        return;
                    }
                    ++index;
                }
            }
            else
                throw new KeyNotFoundException("No existe la pregunta");
        }

        public bool verificarPreguntaExiste(EstructuraPregunta pregunta)
        {
            bool encontrada = false;
            foreach (EstructuraPregunta preg in PreguntasJuego.PreguntasCargadas)
            {
                if (preg.IdPregunta.Equals(pregunta.IdPregunta))
                    encontrada = true;
            }
            return encontrada;
        }
    }
}
