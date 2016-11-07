using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego_Preguntas
{
    public class Preguntas
    {
        public List<EstructuraPregunta> PreguntasCargadas;
        public int CantidadPreguntas { get; set; }

        public Preguntas()
        {
            PreguntasCargadas = new List<EstructuraPregunta>();
        }
    }
}
